using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_Coffee
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void quảnLýDanhMụcĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDmdouong f = new frmDmdouong();
            f.ShowDialog();
        }

        private void quảnLýĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDouong f = new frmDouong();
            f.ShowDialog();
        }

        private void quảnLýBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlyban f = new frmQuanlyban();
            f.ShowDialog();
        }

        private void quảnLýThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongke f = new frmThongke();
            f.ShowDialog();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlytaikhoan f = new frmQuanlytaikhoan();
            f.ShowDialog();
        }

        private void quảnLýKhuyễnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlykhuyenmai f = new frmQuanlykhuyenmai();
            f.ShowDialog();
        }

        private void quảnLýTàiKhoảnCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlytaikhoancanhan f = new frmQuanlytaikhoancanhan();
            f.ShowDialog();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlyhoadon f = new frmQuanlyhoadon();
            f.ShowDialog();
        }
    }
}
