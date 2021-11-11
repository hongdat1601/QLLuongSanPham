using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;
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
    public partial class frmChamCongCN : Form
    {
        BangCongCNDAO bangCongDAO;
        CaLamDAO caLamDAO;
        CongDoanDAO congDoanDAO;
        NhanVienDAO nhanVienDAO;

        public frmChamCongCN()
        {
            InitializeComponent();
            bangCongDAO = new BangCongCNDAO();
            caLamDAO = new CaLamDAO();
            congDoanDAO = new CongDoanDAO();
            nhanVienDAO = new NhanVienDAO();
        }

        private void frmChamCongCN_Load(object sender, EventArgs e)
        {
            CreateList();
        }

        private void CreateList()
        {
            lstvLich.GridLines = true;
            lstvLich.FullRowSelect = true;
            lstvLich.View = View.Details;

            CreateColumn();
            LoadCombobox();
        }

        private void LoadCombobox()
        {
        }

        private void CreateColumn()
        {
            lstvLich.Columns.Add("STT", 70);
            lstvLich.Columns.Add("Tên nhân viên", 210);
            lstvLich.Columns.Add("Công đoạn", 210);
            lstvLich.Columns.Add("Số lượng", 120);
        }

        private void LoadData(BangCongSP bangCong)
        {
            
        }

        private void dtmNgayLam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboTenCa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
