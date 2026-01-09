using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace mhwds_save_backup_tool
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveBackup(object sender, EventArgs e)
        {
            Program.CreateZipBackup(Program.savePath);
            RefreshList(sender, e);
        }

        private void ChooseBackupFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fbd.UseDescriptionForTitle = true;
            fbd.Description = "Select a folder to contain your save backups";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Program.backupFolderPath = fbd.SelectedPath;
                RefreshList(sender, e);
            }
        }

        private void ChooseSaveFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            fbd.UseDescriptionForTitle = true;
            fbd.Description = "Select the folder containing your MHWilds save data";
            if (fbd.ShowDialog() == DialogResult.OK)
                Program.savePath = fbd.SelectedPath;
        }

        private void ZipFolderList(ListView lsv, string Folder)
        {
            lsv.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles();
            foreach (FileInfo file in Files)
            {
                lsv.Items.Add(file.Name);
            }
        }

        private void RefreshList(object sender, EventArgs e)
        {
            ZipFolderList(listview1, Program.backupFolderPath);
        }
    }
}
