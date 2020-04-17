using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrate
{
    public partial class MainPage : Form
    {
        public MainPage(string str)
        {
            InitializeComponent();
            lblUserDisp.Text = str;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            lblDateandTimeDisp.Text = System.DateTime.Now.ToString();
        }

        #region Menu click operations
        private void companyDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            companyDetail ccd = new companyDetail();
            ccd.MdiParent = this;
            //ccd.BringToFront();
            ccd.WindowState = FormWindowState.Minimized;
            ccd.Show();
            ccd.WindowState = FormWindowState.Maximized;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientDetail cd = new frmClientDetail();
            cd.MdiParent = this;
            cd.WindowState = FormWindowState.Minimized;
            cd.Show();
            cd.WindowState = FormWindowState.Maximized;
        }
        #endregion

    }
}
