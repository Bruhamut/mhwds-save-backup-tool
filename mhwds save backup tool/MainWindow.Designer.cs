namespace mhwds_save_backup_tool
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            chooseBackupFolderToolStripMenuItem = new ToolStripMenuItem();
            chooseSaveFolderToolStripMenuItem = new ToolStripMenuItem();
            listview1 = new ListView();
            columnHeader1 = new ColumnHeader();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(653, 36);
            button1.Name = "button1";
            button1.Size = new Size(125, 28);
            button1.TabIndex = 0;
            button1.Text = "Backup save data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += SaveBackup;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseBackupFolderToolStripMenuItem, chooseSaveFolderToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // chooseBackupFolderToolStripMenuItem
            // 
            chooseBackupFolderToolStripMenuItem.Name = "chooseBackupFolderToolStripMenuItem";
            chooseBackupFolderToolStripMenuItem.Size = new Size(201, 22);
            chooseBackupFolderToolStripMenuItem.Text = "Choose Backup Folder...";
            chooseBackupFolderToolStripMenuItem.Click += ChooseBackupFolder;
            // 
            // chooseSaveFolderToolStripMenuItem
            // 
            chooseSaveFolderToolStripMenuItem.Name = "chooseSaveFolderToolStripMenuItem";
            chooseSaveFolderToolStripMenuItem.Size = new Size(201, 22);
            chooseSaveFolderToolStripMenuItem.Text = "Choose Save Folder...";
            chooseSaveFolderToolStripMenuItem.Click += ChooseSaveFolder;
            // 
            // listview1
            // 
            listview1.AllowColumnReorder = true;
            listview1.BackColor = SystemColors.ControlLightLight;
            listview1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listview1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listview1.ForeColor = SystemColors.WindowText;
            listview1.GridLines = true;
            listview1.Location = new Point(30, 70);
            listview1.Name = "listview1";
            listview1.Size = new Size(748, 288);
            listview1.TabIndex = 2;
            listview1.UseCompatibleStateImageBehavior = false;
            listview1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 200;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(30, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += RefreshList;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listview1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MHWDS Save Backup";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem chooseBackupFolderToolStripMenuItem;
        private ListView listview1;
        private Button button2;
        private ColumnHeader columnHeader1;
        private ToolStripMenuItem chooseSaveFolderToolStripMenuItem;
    }
}
