using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileMonitor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        //エクスプローラーで開く
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].Index >= 0)
            {
                //フォルダ取得
                string FilePath = listView1.SelectedItems[0].SubItems[3].Text;
                FileInfo fileInfo = new FileInfo(FilePath);
                System.Diagnostics.Process.Start(fileInfo.DirectoryName);
            }
        }

        //階層確認
        private void CheckDirectButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fileSystemWatcher1.Path.ToString());
        }

        //階層指定
        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            using (var directory_ = new FolderBrowserDialog())
            {
                directory_.Description = "監視ディレクトリ選択";
                directory_.SelectedPath = @"C:";
                directory_.ShowNewFolderButton = true;
                if (directory_.ShowDialog() == DialogResult.OK)
                {
                    fileSystemWatcher1.Path = directory_.SelectedPath;
                }
            }
        }

        //フォルダリスト書き込み
        private void FileListAdd(System.IO.FileSystemEventArgs e)
        {
            //保存数制限
            if (saveNun.Value <= listView1.Items.Count)
            {
                for (; saveNun.Value <= listView1.Items.Count; listView1.Items[(int)saveNun.Value-1].Remove());
            } 
            //追加 Dt, tyepe, Name, FullPath
            listView1.Items.Insert(0, DateTime.Now.ToString()).SubItems.AddRange(new String[] { e.ChangeType.ToString(), e.Name.Split("\\".ToCharArray()).Last(), e.FullPath });
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (e.ChangeType.ToString() == "Created" && createCheck.Checked) { FileListAdd(e); }
            else if (e.ChangeType.ToString() == "Deleted" && deleteCheck.Checked) { FileListAdd(e); }
            else if (e.ChangeType.ToString() == "Changed" && changeCheck.Checked) { FileListAdd(e); }
            else if (e.ChangeType.ToString() == "Renamed" && renameCheck.Checked) { FileListAdd(e); }
        }
        private void logDeleteButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
        //ログファイル保存
        private void logSaveButton_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "ログを保存する";
                sfd.InitialDirectory = Environment.CurrentDirectory;
                sfd.FileName = @"FileLog.txt";
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string item = string.Empty;
                    foreach (ListViewItem anItem in listView1.Items)
                    {
                        item += $"{anItem.Text} | {anItem.SubItems[1].Text} | {anItem.SubItems[2].Text} | {anItem.SubItems[3].Text}\n";
                   }
                    File.WriteAllText(sfd.FileName, item);
                } // if end
            } // using end
        } // log save end
    }
}
