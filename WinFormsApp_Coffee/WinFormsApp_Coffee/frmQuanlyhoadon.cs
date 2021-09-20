using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_Coffee
{
    public partial class frmQuanlyhoadon : Form
    {
        public frmQuanlyhoadon()
        {
            InitializeComponent();
        }

        private void btnXemhd_Click(object sender, EventArgs e)
        {
            frmXemhoadon f = new frmXemhoadon();
            f.ShowDialog();
        }
    }
}
