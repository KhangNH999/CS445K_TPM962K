using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_Coffee
{
    public partial class frmQuanlykhuyenmai : Form
    {
        public frmQuanlykhuyenmai()
        {
            InitializeComponent();
        }

        private void btnThemdotkhuyenmai_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXemdotkm_Click(object sender, EventArgs e)
        {
            frmDotkhuyenmai f = new frmDotkhuyenmai();
            f.ShowDialog();
        }
    }
}
