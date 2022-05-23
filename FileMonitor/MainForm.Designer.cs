namespace FileMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.logSaveButton = new System.Windows.Forms.Button();
            this.logDeleteButton = new System.Windows.Forms.Button();
            this.saveNun = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.renameCheck = new System.Windows.Forms.CheckBox();
            this.deleteCheck = new System.Windows.Forms.CheckBox();
            this.createCheck = new System.Windows.Forms.CheckBox();
            this.changeCheck = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckDirectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.saveNun)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Location = new System.Drawing.Point(320, 30);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(90, 30);
            this.DirectoryButton.TabIndex = 9;
            this.DirectoryButton.Text = "階層指定";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // logSaveButton
            // 
            this.logSaveButton.Location = new System.Drawing.Point(230, 30);
            this.logSaveButton.Name = "logSaveButton";
            this.logSaveButton.Size = new System.Drawing.Size(90, 30);
            this.logSaveButton.TabIndex = 8;
            this.logSaveButton.Text = "ログ保存";
            this.logSaveButton.UseVisualStyleBackColor = true;
            this.logSaveButton.Click += new System.EventHandler(this.logSaveButton_Click);
            // 
            // logDeleteButton
            // 
            this.logDeleteButton.Location = new System.Drawing.Point(140, 30);
            this.logDeleteButton.Name = "logDeleteButton";
            this.logDeleteButton.Size = new System.Drawing.Size(90, 30);
            this.logDeleteButton.TabIndex = 7;
            this.logDeleteButton.Text = "ログ削除";
            this.logDeleteButton.UseVisualStyleBackColor = true;
            this.logDeleteButton.Click += new System.EventHandler(this.logDeleteButton_Click);
            // 
            // saveNun
            // 
            this.saveNun.Location = new System.Drawing.Point(60, 30);
            this.saveNun.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.saveNun.Name = "saveNun";
            this.saveNun.Size = new System.Drawing.Size(80, 30);
            this.saveNun.TabIndex = 6;
            this.saveNun.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "保存数";
            // 
            // renameCheck
            // 
            this.renameCheck.AutoSize = true;
            this.renameCheck.Checked = true;
            this.renameCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renameCheck.Location = new System.Drawing.Point(135, 30);
            this.renameCheck.Name = "renameCheck";
            this.renameCheck.Size = new System.Drawing.Size(92, 27);
            this.renameCheck.TabIndex = 4;
            this.renameCheck.Text = "名前変更";
            this.renameCheck.UseVisualStyleBackColor = true;
            // 
            // deleteCheck
            // 
            this.deleteCheck.AutoSize = true;
            this.deleteCheck.Checked = true;
            this.deleteCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteCheck.Location = new System.Drawing.Point(70, 30);
            this.deleteCheck.Name = "deleteCheck";
            this.deleteCheck.Size = new System.Drawing.Size(62, 27);
            this.deleteCheck.TabIndex = 3;
            this.deleteCheck.Text = "削除";
            this.deleteCheck.UseVisualStyleBackColor = true;
            // 
            // createCheck
            // 
            this.createCheck.AutoSize = true;
            this.createCheck.Checked = true;
            this.createCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.createCheck.Location = new System.Drawing.Point(5, 30);
            this.createCheck.Name = "createCheck";
            this.createCheck.Size = new System.Drawing.Size(62, 27);
            this.createCheck.TabIndex = 2;
            this.createCheck.Text = "作成";
            this.createCheck.UseVisualStyleBackColor = true;
            // 
            // changeCheck
            // 
            this.changeCheck.AutoSize = true;
            this.changeCheck.Location = new System.Drawing.Point(230, 30);
            this.changeCheck.Name = "changeCheck";
            this.changeCheck.Size = new System.Drawing.Size(92, 27);
            this.changeCheck.TabIndex = 1;
            this.changeCheck.Text = "内容変更";
            this.changeCheck.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnTime,
            this.columnEvent,
            this.ColumnFileName,
            this.columnFolder});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("メイリオ", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(840, 375);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnTime
            // 
            this.ColumnTime.Text = "時刻";
            this.ColumnTime.Width = 120;
            // 
            // columnEvent
            // 
            this.columnEvent.Text = "動作";
            this.columnEvent.Width = 65;
            // 
            // ColumnFileName
            // 
            this.ColumnFileName.Text = "ファイル名";
            this.ColumnFileName.Width = 230;
            // 
            // columnFolder
            // 
            this.columnFolder.Text = "フォルダ名";
            this.columnFolder.Width = 420;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 28);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.testToolStripMenuItem.Text = "エクスプローラーで開く";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createCheck);
            this.groupBox1.Controls.Add(this.deleteCheck);
            this.groupBox1.Controls.Add(this.renameCheck);
            this.groupBox1.Controls.Add(this.changeCheck);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 70);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "フィルター";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckDirectButton);
            this.groupBox2.Controls.Add(this.saveNun);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DirectoryButton);
            this.groupBox2.Controls.Add(this.logDeleteButton);
            this.groupBox2.Controls.Add(this.logSaveButton);
            this.groupBox2.Location = new System.Drawing.Point(330, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 70);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ログ";
            // 
            // CheckDirectButton
            // 
            this.CheckDirectButton.Location = new System.Drawing.Point(410, 30);
            this.CheckDirectButton.Name = "CheckDirectButton";
            this.CheckDirectButton.Size = new System.Drawing.Size(90, 30);
            this.CheckDirectButton.TabIndex = 10;
            this.CheckDirectButton.Text = "階層確認";
            this.CheckDirectButton.UseVisualStyleBackColor = true;
            this.CheckDirectButton.Click += new System.EventHandler(this.CheckDirectButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "ホーム";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saveNun)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnTime;
        private System.Windows.Forms.ColumnHeader columnEvent;
        private System.Windows.Forms.ColumnHeader ColumnFileName;
        private System.Windows.Forms.ColumnHeader columnFolder;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.CheckBox changeCheck;
        private System.Windows.Forms.CheckBox deleteCheck;
        private System.Windows.Forms.CheckBox createCheck;
        private System.Windows.Forms.CheckBox renameCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown saveNun;
        private System.Windows.Forms.Button logDeleteButton;
        private System.Windows.Forms.Button logSaveButton;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CheckDirectButton;
    }
}

