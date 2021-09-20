using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_Coffee
{
    public partial class frmQuanlytaikhoancanhan : Form
    {
        public frmQuanlytaikhoancanhan()
        {
            InitializeComponent();
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            frmDoimatkhau f = new frmDoimatkhau();
            f.ShowDialog();
        }
    }
}
