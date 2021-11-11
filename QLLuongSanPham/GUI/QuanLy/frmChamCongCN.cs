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
        BangCongSP bangCong;

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
            caLamDAO.GetCaLams().ToList().ForEach(x => cboTenCa.Items.Add(x.TenCa));
            cboTenCa.SelectedIndex = 0;
        }

        private void CreateColumn()
        {
            lstvLich.Columns.Add("ID NV", 70);
            lstvLich.Columns.Add("Tên nhân viên", 210);
            lstvLich.Columns.Add("Ngày làm", 120);
            lstvLich.Columns.Add("Ca làm", 120);
            lstvLich.Columns.Add("Công đoạn", 210);
            lstvLich.Columns.Add("Số lượng", 120);
        }

        private void LoadData(IEnumerable<BangCongSP> data)
        {
            lstvLich.Items.Clear();
            foreach (var bc in data)
            {
                ListViewItem item = new ListViewItem();

                item.Text = bc.ID_NhanVien.ToString();
                item.SubItems.Add(nhanVienDAO.GetById(bc.ID_NhanVien.Value).HoTen);
                item.SubItems.Add(bc.NgayDiLam.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(caLamDAO.GetByID(bc.IDCaLam.Value).TenCa);
                item.SubItems.Add(congDoanDAO.GetById(bc.IDCongDoan.Value).TenCongDoan);
                item.SubItems.Add(bc.SoLuongSP.ToString());

                item.Tag = bc;

                lstvLich.Items.Add(item);
            }
        }

        private void dtmNgayLam_ValueChanged(object sender, EventArgs e)
        {
            LoadData(bangCongDAO.GetBangCongSPsByDateAndCa(dtmNgayLam.Value.ToString("dd/MM/yyyy"), 
                caLamDAO.GetIDByName(cboTenCa.Text)));

            txtTenNV.Text = "";
            txtTenCongDoan.Text = "";
            nudSoLuong.Value = 0;
            bangCong = null;
        }

        private void cboTenCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(bangCongDAO.GetBangCongSPsByDateAndCa(dtmNgayLam.Value.ToString("dd/MM/yyyy"), 
                caLamDAO.GetIDByName(cboTenCa.Text)));

            txtTenNV.Text = "";
            txtTenCongDoan.Text = "";
            nudSoLuong.Value = 0;
            bangCong = null;
        }

        private void lstvLich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvLich.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvLich.SelectedItems[0];
                bangCong = (BangCongSP)item.Tag;

                txtTenNV.Text = nhanVienDAO.GetById(bangCong.ID_NhanVien.Value).HoTen;
                txtTenCongDoan.Text = congDoanDAO.GetById(bangCong.IDCongDoan.Value).TenCongDoan;
                nudSoLuong.Value = bangCong.SoLuongSP.Value;
            }
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (bangCong == null)
            {
                MessageBox.Show("Chưa chọn lịch", "Thông báo");
                return;
            }

            bangCong.SoLuongSP = Convert.ToInt32(nudSoLuong.Value);
            bangCongDAO.UpdateBCCN(bangCong);
            LoadData(bangCongDAO.GetBangCongSPsByDateAndCa(dtmNgayLam.Value.ToString("dd/MM/yyyy"),
                caLamDAO.GetIDByName(cboTenCa.Text)));

        }
    }
}
