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
    }
}
