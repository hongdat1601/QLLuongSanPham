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
    public partial class frmTinhLuongCN : Form
    {
        public frmTinhLuongCN()
        {
            InitializeComponent();
        }

        private void frmTinhLuongCN_Load(object sender, EventArgs e)
        {
            CreateTitleNV(lvwDSNV);
            CreateTitleCV(lvwChiTiet);
            CreateTitleLuong(lvwDSLuong);
        }

        private void CreateTitleNV(ListView lvw)
        {
            lvw.Columns.Add("STT", 120);
            lvw.Columns.Add("Tên nhân viên", 230);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitleCV(ListView lvw)
        {
            lvw.Columns.Add("Ngày làm", 120);
            lvw.Columns.Add("Ca làm việc", 120);
            lvw.Columns.Add("Công đoạn", 120);
            lvw.Columns.Add("Số lượng sản phẩm", 150);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitleLuong(ListView lvw)
        {
            lvw.Columns.Add("STT", 120);
            lvw.Columns.Add("Tên nhân viên", 120);
            lvw.Columns.Add("Tiền lương", 120);
            lvw.Columns.Add("Ngày lập", 120);
            lvw.Columns.Add("Ghi chú", 450);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }
    }
}
