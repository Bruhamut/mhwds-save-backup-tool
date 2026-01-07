using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace mhwds_save_backup_tool
{
    public partial class Form1 : Form
    {
        string filePath = "";
        string savePath = "";
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
            fbd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fbd.UseDescriptionForTitle = true;
            fbd.Description = "Select a folder to contain your save backups";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                filePath = fbd.SelectedPath;
                Program.zipPath = @$"{filePath}\{Program.formattedDT}.zip";
            }
        }

        private void chooseSaveFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            fbd.UseDescriptionForTitle = true;
            fbd.Description = "Select the folder containing your MHWilds save data";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                savePath = fbd.SelectedPath;
                Program.savePath = savePath;
            }
        }

        private void ZipFolderList_SelectedIndexChanged(ListView lsv, string Folder)
        {
            lsv.Items.Clear();
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
