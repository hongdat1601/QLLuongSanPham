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
    public partial class frmHopDong : Form
    {
        HopDongDAO hopDongDAO;
        SanPhamDAO sanPhamDAO;
        CTHopDongDAO ctHopDongDAO;
        HopDong hopDong;
        ChiTietHopDong chiTietHopDong;
        SanPham sanPham;

        public frmHopDong()
        {
            InitializeComponent();
            hopDongDAO = new HopDongDAO();
            sanPhamDAO = new SanPhamDAO();
            ctHopDongDAO = new CTHopDongDAO();
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            hopDongDAO.UpdateTrangThai();
            CreateList();
            LoadListHopDong(hopDongDAO.GetHopDongs());
        }

        private void CreateList()
        {
            lstvHopDong.GridLines = true;
            lstvHopDong.FullRowSelect = true;
            lstvHopDong.View = View.Details;

            lstvCTHopDong.GridLines = true;
            lstvCTHopDong.FullRowSelect = true;
            lstvCTHopDong.View = View.Details;

            lstvSanPham.GridLines = true;
            lstvSanPham.FullRowSelect = true;
            lstvSanPham.View = View.Details;

            lstvHopDong.Columns.Add("STT", 70);
            lstvHopDong.Columns.Add("Tên hợp đồng", 210);
            lstvHopDong.Columns.Add("Tên khách hàng", 210);
            lstvHopDong.Columns.Add("Ngày bắt đầu", 100);
            lstvHopDong.Columns.Add("Ngày kết thúc", 100);
            lstvHopDong.Columns.Add("Điều khoản", 210);
            lstvHopDong.Columns.Add("Trạng thái", 150);

            lstvSanPham.Columns.Add("STT", 70);
            lstvSanPham.Columns.Add("Tên sản phẩm", 210);

            lstvCTHopDong.Columns.Add("Tên sản phẩm", 210);
            lstvCTHopDong.Columns.Add("Số lượng", 100);
        }

        private void LoadListHopDong(IEnumerable<HopDong> list)
        {
            int stt = 1;

            lstvHopDong.Items.Clear();
            foreach (var hd in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = stt.ToString();
                item.SubItems.Add(hd.TenHopDong);
                item.SubItems.Add(hd.TenKhachHang);
                item.SubItems.Add(hd.NgayBatDau.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(hd.NgayKetThuc.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(hd.DieuKhoan);
                
                if(hd.TrangThai.Value)
                {
                    item.SubItems.Add("Còn thời hạn");
                }
                else
                {
                    item.SubItems.Add("Đã hết hạn");
                }

                item.Tag = hd;

                lstvHopDong.Items.Add(item);
                stt++;
            }
        }

        private void LoadListCTHopDong(IEnumerable<ChiTietHopDong> list)
        {

            lstvCTHopDong.Items.Clear();
            foreach (var ct in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (sanPhamDAO.GetById(ct.IDSanPham).TenSP);
                item.SubItems.Add(ct.SoLuong.ToString());
                item.Tag = ct;

                lstvCTHopDong.Items.Add(item);
            }
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

        private void lstvHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvHopDong.SelectedItems.Count > 0 && btnLapHopDong.Text != "Lưu")
            {
                hopDong = (HopDong)lstvHopDong.SelectedItems[0].Tag;
                txtTenHopDong.Text = hopDong.TenHopDong;
                txtTenKhachHang.Text = hopDong.TenKhachHang;
                dtmNgayBatDau.Value = hopDong.NgayBatDau.Value;
                dtmNgayKetThuc.Value = hopDong.NgayKetThuc.Value;
                txtDieuKhoan.Text = hopDong.DieuKhoan;

                if (hopDong.TrangThai.Value)
                {
                    txtTrangThai.Text = "Còn thời hạn";
                }
                else
                {
                    txtTrangThai.Text = "Đã hết hạn";
                }

                LoadListCTHopDong(ctHopDongDAO.GetCTHDsByIdHopDong(hopDong.ID));
            }
        }

        private void lstvCTHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvCTHopDong.SelectedItems.Count > 0 && btnLapHopDong.Text != "Lưu")
            {
                chiTietHopDong = (ChiTietHopDong)lstvCTHopDong.SelectedItems[0].Tag;
                txtTenSanPham.Text = sanPhamDAO.GetById(chiTietHopDong.IDSanPham).TenSP;
                nudSoLuong.Text = chiTietHopDong.SoLuong.ToString();                
            }
            else if (lstvCTHopDong.SelectedItems.Count > 0 && btnLapHopDong.Text == "Lưu")
            {
                txtTenSanPham.Text = lstvCTHopDong.SelectedItems[0].SubItems[0].Text;
                nudSoLuong.Text = lstvCTHopDong.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnLapHopDong_Click(object sender, EventArgs e)
        {
            if (btnLapHopDong.Text == "Lưu")
            {

                txtTenHopDong.Enabled = false;
                dtmNgayBatDau.Enabled = false;
                dtmNgayKetThuc.Enabled = false;
                txtTenKhachHang.Enabled = false;
                txtDieuKhoan.Enabled = false;
                txtTenSanPham.Enabled = false;
                nudSoLuong.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;

                btnLapHopDong.IconChar = FontAwesome.Sharp.IconChar.Plus;
                btnLapHopDong.IconColor = Color.Green;
                btnLapHopDong.Text = "Thêm";

                LoadListHopDong(hopDongDAO.GetHopDongs());
                lstvHopDong.SelectedIndices.Add(lstvHopDong.Items.Count - 1);
            }
            else
            {
                txtTenHopDong.Enabled = true;
                dtmNgayBatDau.Enabled = true;
                dtmNgayKetThuc.Enabled = true;
                txtTenKhachHang.Enabled = true;
                txtDieuKhoan.Enabled = true;
                nudSoLuong.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;

                txtTenHopDong.Text = "";
                txtTenKhachHang.Text = "";
                txtDieuKhoan.Text = "";
                txtTenSanPham.Text = "";
                nudSoLuong.Text = "";
                txtTrangThai.Text = "";
                dtmNgayBatDau.Value = DateTime.Now;
                dtmNgayKetThuc.Value = DateTime.Now;

                btnLapHopDong.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnLapHopDong.IconColor = Color.Blue;
                btnLapHopDong.Text = "Lưu";

                lstvCTHopDong.Items.Clear();
                LoadListSanPham(sanPhamDAO.GetSanPhams());
            }
        }

        private void lstvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvSanPham.SelectedItems.Count > 0)
            {
                sanPham = (SanPham)lstvSanPham.SelectedItems[0].Tag;
                txtTenSanPham.Text = sanPham.TenSP;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int stt = lstvCTHopDong.Items.Count + 1;
            ListViewItem item = new ListViewItem();
            item.Text = (sanPham.TenSP);
            item.SubItems.Add(nudSoLuong.Text);

            lstvCTHopDong.Items.Add(item);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstvCTHopDong.SelectedItems.Count > 0)
            {
                lstvCTHopDong.Items.Remove(lstvCTHopDong.SelectedItems[0]);
            }
        }

    }
}
