using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLuongSanPham
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "demo" && txtPassword.Text == "123")
            {
                frmManagement frm = new frmManagement();
                this.Hide();

                if (frm.ShowDialog() == DialogResult.Yes)
                    this.Close();
                else
                    this.Show();
            }
        }
    }
}
