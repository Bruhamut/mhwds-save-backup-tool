using System.Runtime.CompilerServices;

namespace mhwds_save_backup_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.CreateZipBackup(Program.zipPath, Program.savePath);
        }
        
        private void chooseBackupFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string filePath = fbd.SelectedPath;
                Program.zipPath = @$"{filePath}\{Program.formattedDT}.zip";
            }
        }
    }
}
