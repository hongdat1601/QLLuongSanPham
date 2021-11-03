using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmPhanLich : Form
    {
        private Form activeForm = null;

        public frmPhanLich()
        {
            InitializeComponent();
        }

        public void OpenFormChild(Form formChild)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = formChild;
            formChild.TopLevel = false;
            formChild.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(activeForm);
            activeForm.BringToFront();
            activeForm.Show();

        }

        private void btnCongNhan_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmPhanLichCN());
        }

        private void btnHC_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmPhanLichHC());
        }
    }
}
