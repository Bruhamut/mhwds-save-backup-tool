using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace mhwds_save_backup_tool
{
    public partial class Form1 : Form
    {
        string filePath = "";
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
                filePath = fbd.SelectedPath;
                Program.zipPath = @$"{filePath}\{Program.formattedDT}.zip";
            }
        }

        private void ZipFolderList_SelectedIndexChanged(ListView lsv, string Folder)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles();
            foreach (FileInfo file in Files)
            {
                lsv.Items.Add(file.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZipFolderList_SelectedIndexChanged(listview1, filePath);
        }
    }
}
