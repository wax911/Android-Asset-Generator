namespace Resource_Generator
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.prgConversion = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lstImages = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRename = new System.Windows.Forms.TextBox();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.btnBegin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWorkspace = new System.Windows.Forms.TextBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.rdbMul = new System.Windows.Forms.RadioButton();
            this.rdbSin = new System.Windows.Forms.RadioButton();
            this.lblCharRename = new System.Windows.Forms.Label();
            this.lblWorkspace = new System.Windows.Forms.Label();
            this.prgLoadingimgs = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // prgConversion
            // 
            this.prgConversion.Location = new System.Drawing.Point(132, 419);
            this.prgConversion.Name = "prgConversion";
            this.prgConversion.Size = new System.Drawing.Size(137, 23);
            this.prgConversion.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgConversion.TabIndex = 0;
            this.prgConversion.Click += new System.EventHandler(this.prgConversion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coversion Progress:";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.ShowItemToolTips = true;
            this.menu.Size = new System.Drawing.Size(692, 24);
            this.menu.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Directory:";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(132, 56);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(299, 20);
            this.txtDirectory.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(437, 54);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lstImages
            // 
            this.lstImages.Location = new System.Drawing.Point(16, 123);
            this.lstImages.MultiSelect = false;
            this.lstImages.Name = "lstImages";
            this.lstImages.ShowGroups = false;
            this.lstImages.Size = new System.Drawing.Size(496, 211);
            this.lstImages.TabIndex = 6;
            this.lstImages.UseCompatibleStateImageBehavior = false;
            this.lstImages.SelectedIndexChanged += new System.EventHandler(this.lstImages_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Images:";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Enabled = false;
            this.btnOpenFolder.Location = new System.Drawing.Point(518, 419);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(149, 23);
            this.btnOpenFolder.TabIndex = 8;
            this.btnOpenFolder.Text = "Open Destination Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rename Selected Image:";
            // 
            // txtRename
            // 
            this.txtRename.Location = new System.Drawing.Point(166, 340);
            this.txtRename.MaxLength = 15;
            this.txtRename.Name = "txtRename";
            this.txtRename.ReadOnly = true;
            this.txtRename.Size = new System.Drawing.Size(161, 20);
            this.txtRename.TabIndex = 10;
            this.txtRename.TextChanged += new System.EventHandler(this.txtRename_TextChanged);
            this.txtRename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRename_KeyPress);
            // 
            // Worker
            // 
            this.Worker.WorkerReportsProgress = true;
            this.Worker.WorkerSupportsCancellation = true;
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_ProgressChanged);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // btnBegin
            // 
            this.btnBegin.Enabled = false;
            this.btnBegin.Location = new System.Drawing.Point(437, 419);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 11;
            this.btnBegin.Text = "Convert Images";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Work Space Name:";
            // 
            // txtWorkspace
            // 
            this.txtWorkspace.Location = new System.Drawing.Point(166, 366);
            this.txtWorkspace.MaxLength = 15;
            this.txtWorkspace.Name = "txtWorkspace";
            this.txtWorkspace.Size = new System.Drawing.Size(161, 20);
            this.txtWorkspace.TabIndex = 13;
            this.txtWorkspace.TextChanged += new System.EventHandler(this.txtWorkspace_TextChanged);
            this.txtWorkspace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWorkspace_KeyPress);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.rdbMul);
            this.grpOptions.Controls.Add(this.rdbSin);
            this.grpOptions.Location = new System.Drawing.Point(518, 39);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(159, 78);
            this.grpOptions.TabIndex = 14;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "File Options";
            // 
            // rdbMul
            // 
            this.rdbMul.AutoSize = true;
            this.rdbMul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbMul.Location = new System.Drawing.Point(13, 44);
            this.rdbMul.Name = "rdbMul";
            this.rdbMul.Size = new System.Drawing.Size(104, 18);
            this.rdbMul.TabIndex = 7;
            this.rdbMul.TabStop = true;
            this.rdbMul.Text = "Multiple Images";
            this.rdbMul.UseVisualStyleBackColor = true;
            this.rdbMul.CheckedChanged += new System.EventHandler(this.rdbMul_CheckedChanged);
            // 
            // rdbSin
            // 
            this.rdbSin.AutoSize = true;
            this.rdbSin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbSin.Location = new System.Drawing.Point(13, 21);
            this.rdbSin.Name = "rdbSin";
            this.rdbSin.Size = new System.Drawing.Size(92, 18);
            this.rdbSin.TabIndex = 6;
            this.rdbSin.TabStop = true;
            this.rdbSin.Text = "Single Image";
            this.rdbSin.UseVisualStyleBackColor = true;
            this.rdbSin.CheckedChanged += new System.EventHandler(this.rdbSin_CheckedChanged);
            // 
            // lblCharRename
            // 
            this.lblCharRename.AutoSize = true;
            this.lblCharRename.Location = new System.Drawing.Point(385, 343);
            this.lblCharRename.Name = "lblCharRename";
            this.lblCharRename.Size = new System.Drawing.Size(30, 13);
            this.lblCharRename.TabIndex = 15;
            this.lblCharRename.Text = "0/15";
            // 
            // lblWorkspace
            // 
            this.lblWorkspace.AutoSize = true;
            this.lblWorkspace.Location = new System.Drawing.Point(385, 369);
            this.lblWorkspace.Name = "lblWorkspace";
            this.lblWorkspace.Size = new System.Drawing.Size(30, 13);
            this.lblWorkspace.TabIndex = 16;
            this.lblWorkspace.Text = "0/15";
            // 
            // prgLoadingimgs
            // 
            this.prgLoadingimgs.Location = new System.Drawing.Point(518, 173);
            this.prgLoadingimgs.Name = "prgLoadingimgs";
            this.prgLoadingimgs.Size = new System.Drawing.Size(162, 23);
            this.prgLoadingimgs.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgLoadingimgs.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Loading Images:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(63, 104);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(275, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel Operation";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 462);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prgLoadingimgs);
            this.Controls.Add(this.lblWorkspace);
            this.Controls.Add(this.lblCharRename);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.txtWorkspace);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.txtRename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstImages);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgConversion);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximumSize = new System.Drawing.Size(708, 515);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Android Resource Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgConversion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListView lstImages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRename;
        private System.ComponentModel.BackgroundWorker Worker;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWorkspace;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton rdbMul;
        private System.Windows.Forms.RadioButton rdbSin;
        private System.Windows.Forms.Label lblCharRename;
        private System.Windows.Forms.Label lblWorkspace;
        private System.Windows.Forms.ProgressBar prgLoadingimgs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnCancel;
    }
}

