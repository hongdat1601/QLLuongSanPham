using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;

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

        #region Method

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
            lstvLich.Columns.Add("CMND", 120);
            lstvLich.Columns.Add("Tên nhân viên", 210);
            lstvLich.Columns.Add("Ngày làm", 120);
            lstvLich.Columns.Add("Ca làm", 120);
            lstvLich.Columns.Add("Công đoạn", 210);
            lstvLich.Columns.Add("Có mặt", 120);
            lstvLich.Columns.Add("Số lượng", 120);
        }

        private void LoadData(IEnumerable<BangCongSP> data)
        {
            lstvLich.Items.Clear();
            foreach (var bc in data)
            {
                ListViewItem item = new ListViewItem();

                item.Text = nhanVienDAO.GetById(bc.ID_NhanVien.Value).CMND;
                item.SubItems.Add(nhanVienDAO.GetById(bc.ID_NhanVien.Value).HoTen);
                item.SubItems.Add(bc.NgayDiLam.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(caLamDAO.GetByID(bc.IDCaLam.Value).TenCa);
                item.SubItems.Add(congDoanDAO.GetById(bc.IDCongDoan.Value).TenCongDoan);

                if (bc.TrangThai == null)
                {
                    item.SubItems.Add("Chưa chấm");
                }
                else
                {
                    item.SubItems.Add((bc.TrangThai.Value ? "Có" : "Không"));
                }

                item.SubItems.Add(bc.SoLuongSP.ToString());

                item.Tag = bc;

                lstvLich.Items.Add(item);
            }
        }

        #endregion

        #region Event

        private void frmChamCongCN_Load(object sender, EventArgs e)
        {
            CreateList();
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

                if (bangCong.TrangThai == null || bangCong.TrangThai.Value == false)
                {
                    chkCoMat.Checked = false;
                }
                else
                {
                    chkCoMat.Checked = true;
                }
            }
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (bangCong == null)
            {
                MessageBox.Show("Chưa chọn lịch", "Thông báo");
                return;
            }

            if (chkCoMat.Checked)
            {
                bangCong.TrangThai = true;
            }
            else
            {
                bangCong.TrangThai = false;
            }

            bangCong.SoLuongSP = Convert.ToInt32(nudSoLuong.Value);
            bangCongDAO.UpdateBCCN(bangCong);
            LoadData(bangCongDAO.GetBangCongSPsByDateAndCa(dtmNgayLam.Value.ToString("dd/MM/yyyy"),
                caLamDAO.GetIDByName(cboTenCa.Text)));

        }

        #endregion

        private void chkCoMat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoMat.Checked)
            {
                nudSoLuong.Enabled = true;
            }
            else
            {
                nudSoLuong.Value = 0;
                nudSoLuong.Enabled = false;
            }
        }
    }
}
