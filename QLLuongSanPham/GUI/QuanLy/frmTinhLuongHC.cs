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
    public partial class frmTinhLuongHC : Form
    {
        public frmTinhLuongHC()
        {
            InitializeComponent();
        }

        private void frmTinhLuongHC_Load(object sender, EventArgs e)
        {
            CreateTitleDSNV(lvwDSNV);
            CreateTitleCV(lvwCongViec);
            CreateTitleNgayNghi(lvwNgayNghi);
            CreateTitleLuong(lvwDSLuong);
        }

        private void CreateTitleDSNV(ListView lvw)
        {
            lvw.Columns.Add("Tên nhân viên", 120);
            lvw.Columns.Add("Chức vụ", 120);
            lvw.Columns.Add("Phụ cấp", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitleCV(ListView lvw)
        {
            lvw.Columns.Add("Ngày đi làm", 120);
            lvw.Columns.Add("Có mặt", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitleNgayNghi(ListView lvw)
        {
            lvw.Columns.Add("Ngày nghỉ", 120);
            lvw.Columns.Add("Lí do", 120);
            lvw.Columns.Add("Phụ cấp", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitleLuong(ListView lvw)
        {
            lvw.Columns.Add("STT", 120);
            lvw.Columns.Add("Tên nhân viên", 120);
            lvw.Columns.Add("Ngày lập", 120);
            lvw.Columns.Add("Tiền lương", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

    }
}
