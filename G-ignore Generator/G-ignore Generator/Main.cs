using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            OpenFileDialog opnFile = new OpenFileDialog();
            FolderBrowserDialog fbdFolder = new FolderBrowserDialog();

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
            fbdFolder.RootFolder = Environment.SpecialFolder.UserProfile;
            fbdFolder.Description = "                                        >>>  Select your Repository (Path Folder)    <<<";
            fbdFolder.ShowNewFolderButton = true;

            if (fbdFolder.ShowDialog() == DialogResult.OK)
            {
                string thePath = fbdFolder.SelectedPath;
                this.txtPath.Text = thePath;
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtPath.Text))
            {
                chkListItems.Enabled = false;//TRUE-NULL
            }
            else
            {
                chkListItems.Enabled = true;//FALSE-NOT-NULL
                browseFiles.Url = new Uri(fbdFolder.SelectedPath);
                chkListItems.BackColor = Color.FromArgb(241, 248, 255);

                if (!File.Exists(pathStartupFile))
                {
                    File.Create(pathStartupFile);
                }
            }
        }

        private void chkListItems_DoubleClick(object sender, EventArgs e)
        {
            opnFile.InitialDirectory = txtPath.Text;
            opnFile.Filter = "All files (*.*)|*.*";
            opnFile.Multiselect = true;
            opnFile.Title = "       >>>      Select your Files to Import to .GITIGNORE      <<<";


            if (opnFile.ShowDialog() == DialogResult.OK)
            {
                string fullPath = opnFile.FileName;
                string fileSelect = opnFile.SafeFileName;
                string[] fileSelectMulti = opnFile.SafeFileNames;

                string jump = "================================";

                this.chkListItems.Items.Add(jump);

                foreach (String file in opnFile.FileNames)
                {
                    this.chkListItems.Items.Add(file);
                    
                }

            }
        }

        private void browseFiles_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                if(browseFiles.CanGoBack)
                {
                    browseFiles.GoBack();
                }
            }
        }

        private void chkListItems_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27) || e.KeyCode == Keys.Delete) //DEL OR ESC
            {
                foreach (var item in chkListItems.CheckedItems.OfType<string>().ToList())
                {
                    chkListItems.Items.Remove(item);
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
