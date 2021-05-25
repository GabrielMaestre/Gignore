using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_ignore_Generator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options optform = new Options();
            optform.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.lblTitleA.Focus();
            this.ActiveControl = lblTitleA;
        }
    }
}
