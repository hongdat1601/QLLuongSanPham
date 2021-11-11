using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmPhongBan : Form
    {
        private PhongBanDAO phongBanDAO;
        private PhongBan phongBan = null;

        public frmPhongBan()
        {
            InitializeComponent();
            phongBanDAO = new PhongBanDAO();
        }

        private void CreateList(ListView lvw)
        {
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.View = View.Details;

            lstvPhongBan.Columns.Add("STT", 70);
            lstvPhongBan.Columns.Add("Tên phòng", 210);
            lstvPhongBan.Columns.Add("Ngày thành lập", 140);
            lstvPhongBan.Columns.Add("Số lượng nhân viên", 140);
            lstvPhongBan.Columns.Add("Tên quản lý", 210);
        }

        private void LoadListPhongBan(IEnumerable<PhongBan> list)
        {
            lstvPhongBan.Items.Clear();

            int i = 1;
            foreach (PhongBan pb in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(pb.TenPhongBan);
                item.SubItems.Add(pb.NgayThanhLap.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(pb.SoLuongNhanVien.ToString());
                item.SubItems.Add(pb.TenQuanLy);
                item.Tag = pb;


                lstvPhongBan.Items.Add(item);

                i++;
            }

            lstvPhongBan.Focus();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            CreateList(lstvPhongBan);
            LoadListPhongBan(phongBanDAO.GetPhongBans());

            if (lstvPhongBan.Items.Count > 0)
                lstvPhongBan.SelectedIndices.Add(0);
        }

        private void lvwPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvPhongBan.SelectedItems.Count > 0)
            {
                phongBan = (PhongBan)lstvPhongBan.SelectedItems[0].Tag;
                txtTenPhongBan.Text = phongBan.TenPhongBan;
                txtSLNV.Text = phongBan.SoLuongNhanVien.ToString();
                txtTenQL.Text = phongBan.TenQuanLy;
                dtmNgayThanhLap.Value = phongBan.NgayThanhLap.Value;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (phongBan == null)
            {
                MessageBox.Show("Chưa chọn phòng ban!", "Thông báo");
                return;
            }

            if (btnSua.Text == "Lưu")
            {
                phongBan.TenPhongBan = txtTenPhongBan.Text;
                phongBan.TenQuanLy = txtSLNV.Text;
                phongBan.NgayThanhLap = dtmNgayThanhLap.Value;
                phongBan.TenQuanLy = txtTenQL.Text;
                phongBanDAO.Update(phongBan);

                txtTenPhongBan.Enabled = false;
                dtmNgayThanhLap.Enabled = false;
                txtTenQL.Enabled = false;
                btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
                btnSua.IconColor = Color.Orange;
                btnSua.Text = "Sửa";

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                LoadListPhongBan(phongBanDAO.GetPhongBans());
            }
            else
            {
                txtTenPhongBan.Enabled = true;
                dtmNgayThanhLap.Enabled = true;
                txtTenQL.Enabled = true;
                btnSua.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnSua.IconColor = Color.Blue;
                btnSua.Text = "Lưu";
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (phongBan == null)
            {
                MessageBox.Show("Chưa chọn phòng ban!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                phongBanDAO.Delete(phongBan);
                LoadListPhongBan(phongBanDAO.GetPhongBans());
                if (lstvPhongBan.Items.Count > 0)
                {
                    lstvPhongBan.SelectedIndices.Add(lstvPhongBan.Items.Count - 1);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Lưu")
            {
                PhongBan pb = new PhongBan
                {
                    TenPhongBan = txtTenPhongBan.Text,
                    NgayThanhLap = dtmNgayThanhLap.Value,
                    TenQuanLy = txtTenQL.Text
                };
                phongBanDAO.Add(pb);

                txtTenPhongBan.Enabled = false;
                dtmNgayThanhLap.Enabled = false;
                txtTenQL.Enabled = false;


                btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
                btnThem.IconColor = Color.Green;
                btnThem.Text = "Thêm";

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                LoadListPhongBan(phongBanDAO.GetPhongBans());
                lstvPhongBan.SelectedIndices.Add(lstvPhongBan.Items.Count - 1);
            }
            else
            {
                txtTenPhongBan.Enabled = true;
                dtmNgayThanhLap.Enabled = true;
                txtTenQL.Enabled = true;
                txtTenPhongBan.Text = "";
                txtTenQL.Text = "";
                dtmNgayThanhLap.Value = DateTime.Now;

                btnThem.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnThem.IconColor = Color.Blue;
                btnThem.Text = "Lưu";

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadListPhongBan(phongBanDAO.GetListPBByName(txtTenSearch.Text));
        }
    }
}
