using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace G_ignore_Generator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

            const string fileGignore2 = @".gitignore";
            string pathExec = Directory.GetCurrentDirectory();
            string pathStartup = Application.StartupPath;
            string pathStartupFile = Path.Combine(Application.StartupPath, fileGignore2);


        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options optform = new Options();
            optform.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.lblTitleA.Focus();
            this.ActiveControl = lblTitleA;
            this.chkListItems.CheckOnClick = true;
        }

        private void txtPath_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdPath = new FolderBrowserDialog();
            fbdPath.RootFolder = Environment.SpecialFolder.UserProfile;
            fbdPath.Description = "                                        >>>  Select your Repository (Path Folder)    <<<";


            if (fbdPath.ShowDialog() == DialogResult.OK)
            {
                string thePath = fbdPath.SelectedPath;
                this.txtPath.Text = thePath;
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtPath.Text))
            {
                chkListItems.Enabled = false;//TRUE
            }
            else
            {
                chkListItems.Enabled = true;//FALSE

                if (!File.Exists(pathStartupFile))
                {
                    File.Create(pathStartupFile);
                }
            }
        }

        private void chkListItems_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opnPath = new OpenFileDialog();
            opnPath.InitialDirectory = txtPath.Text;
            opnPath.Filter = "All files (*.*)|*.*";
            opnPath.Multiselect = true;
            opnPath.Title = "       >>>      Select your Files to Import to .GITIGNORE      <<<";


            if (opnPath.ShowDialog() == DialogResult.OK)
            {
                string fullPath = opnPath.FileName;
                string fileSelect = opnPath.SafeFileName;
                string[] fileSelectMulti = opnPath.SafeFileNames;

                string jump = "================================";

                this.chkListItems.Items.Add(jump);

                foreach (String file in opnPath.FileNames)
                {
                    this.chkListItems.Items.Add(file);
                }

            }
        }
    }
}
