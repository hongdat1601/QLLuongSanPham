using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmCongDoan : Form
    {
        private SanPhamDAO sanPhamDAO;
        private CongDoanDAO congDoanDAO;
        private SanPham sanPham;
        private CongDoan congDoan;

        public frmCongDoan()
        {
            InitializeComponent();
            sanPhamDAO = new SanPhamDAO();
            congDoanDAO = new CongDoanDAO();
        }

        #region Methods

        private void CreateList()
        {
            lstvSanPham.GridLines = true;
            lstvSanPham.FullRowSelect = true;
            lstvSanPham.View = View.Details;

            lstvCongDoan.GridLines = true;
            lstvCongDoan.FullRowSelect = true;
            lstvCongDoan.View = View.Details;

            lstvSanPham.Columns.Add("STT", 70);
            lstvSanPham.Columns.Add("Tên sản phẩm", lstvSanPham.Width - 75);

            lstvCongDoan.Columns.Add("STT", 70);
            lstvCongDoan.Columns.Add("Tên công đoạn", 210);
            lstvCongDoan.Columns.Add("Đơn giá", 170);

        }

        private void LoadListSanPham(IEnumerable<SanPham> list)
        {
            int stt = 1;

            lstvSanPham.Items.Clear();
            foreach (var sp in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = stt.ToString();
                item.SubItems.Add(sp.TenSP);
                item.Tag = sp;

                lstvSanPham.Items.Add(item);
                stt++;
            }
        }

        private void LoadListCongDoan(IEnumerable<CongDoan> list)
        {
            int stt = 1;

            lstvCongDoan.Items.Clear();
            foreach (var cd in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = stt.ToString();
                item.SubItems.Add(cd.TenCongDoan);
                item.SubItems.Add(String.Format("{0:#,###}", cd.DonGia.Value) + " VND");
                item.Tag = cd;

                lstvCongDoan.Items.Add(item);
                stt++;
            }
        }

        private bool KiemTraThongTin()
        {
            if (string.IsNullOrEmpty(txtCongDoanCapNhat.Text.Trim()))
            {
                MessageBox.Show("Tên công đoạn bỏ trống!", "Lỗi");
                return false;
            }

            return true;
        }

        #endregion

        #region Events

        private void frmCongDoan_Load(object sender, EventArgs e)
        {
            CreateList();
            LoadListSanPham(sanPhamDAO.GetSanPhams());
        }

        private void lstvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvSanPham.SelectedItems.Count > 0)
            {
                sanPham = (SanPham)lstvSanPham.SelectedItems[0].Tag;
                txtTenSPCapNhat.Text = sanPham.TenSP;

                var listCongDoan = congDoanDAO.GetCongDoansByIdSanPham(sanPham.ID);
                LoadListCongDoan(congDoanDAO.GetCongDoansByIdSanPham(sanPham.ID));

                if (lstvCongDoan.Items.Count > 0)
                {
                    lstvCongDoan.SelectedIndices.Add(0);
                }
            }
        }

        private void lstvCongDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvCongDoan.SelectedItems.Count > 0)
            {
                congDoan = (CongDoan)lstvCongDoan.SelectedItems[0].Tag;
                txtCongDoanCapNhat.Text = congDoan.TenCongDoan;
                nudDonGiaCapNhat.Value = congDoan.DonGia.Value;
                lstvCongDoan.Focus();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (congDoan == null)
            {
                MessageBox.Show("Chưa chọn công đoạn!", "Thông báo");
                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (KiemTraThongTin())
                {
                    congDoan.TenCongDoan = txtCongDoanCapNhat.Text.Trim();
                    congDoan.DonGia = nudDonGiaCapNhat.Value;
                    congDoanDAO.Update(congDoan);

                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;

                    txtCongDoanCapNhat.Enabled = false;
                    nudDonGiaCapNhat.Enabled = false;
                    btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
                    btnSua.IconColor = Color.Orange;
                    btnSua.Text = "Sửa";

                    LoadListCongDoan(congDoanDAO.GetCongDoansByIdSanPham(sanPham.ID));
                }

            }
            else
            {
                txtCongDoanCapNhat.Enabled = true;
                nudDonGiaCapNhat.Enabled = true;
                btnSua.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnSua.IconColor = Color.Blue;
                btnSua.Text = "Lưu";

                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (sanPham == null)
            {
                MessageBox.Show("Chưa chọn Sản phẩm!", "Thông báo");
                return;
            }

            if (btnThem.Text == "Lưu")
            {

                if (KiemTraThongTin())
                {
                    CongDoan cd = new CongDoan
                    {
                        IDSanPham = sanPham.ID,
                        TenCongDoan = txtCongDoanCapNhat.Text.Trim(),
                        DonGia = nudDonGiaCapNhat.Value
                    };

                    congDoanDAO.Add(cd);

                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    txtCongDoanCapNhat.Enabled = false;
                    nudDonGiaCapNhat.Enabled = false;
                    btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
                    btnThem.IconColor = Color.Green;
                    btnThem.Text = "Thêm";

                    LoadListCongDoan(congDoanDAO.GetCongDoansByIdSanPham(sanPham.ID));
                    lstvCongDoan.SelectedIndices.Add(lstvCongDoan.Items.Count - 1);
                }
            }
            else
            {
                txtCongDoanCapNhat.Enabled = true;
                nudDonGiaCapNhat.Enabled = true;
                nudDonGiaCapNhat.Value = 0;
                txtCongDoanCapNhat.Text = "";
                btnThem.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnThem.IconColor = Color.Blue;
                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (congDoan == null)
            {
                MessageBox.Show("Chưa chọn công đoạn!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                congDoanDAO.Delete(congDoan);
                LoadListCongDoan(congDoanDAO.GetCongDoansByIdSanPham(sanPham.ID));
                if (lstvCongDoan.Items.Count > 0)
                {
                    lstvCongDoan.SelectedIndices.Add(lstvCongDoan.Items.Count - 1);
                }
            }
        }

        private void btnTimKimSP_Click(object sender, EventArgs e)
        {
            LoadListSanPham(sanPhamDAO.GetSPByChar(txtTenSearch.Text));
        }

        #endregion

    }
}
