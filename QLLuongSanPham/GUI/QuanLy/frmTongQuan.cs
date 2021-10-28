using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLLuongSanPham.BLL;
using QLLuongSanPham.DAL;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmTongQuan : Form
    {
        private PhongBanBLL _phongBan = new PhongBanBLL();
        private SanPhamBLL _sanPham = new SanPhamBLL();
        private HopDongBLL _hopDong = new HopDongBLL();
        private NhanVienBLL _nhanVien = new NhanVienBLL();
        private ChucVuBLL _chucVu = new ChucVuBLL();


        public frmTongQuan()
        {
            InitializeComponent();
        }

        private void CreateList(ListView lvw)
        {
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.View = View.Details;
            lvw.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        }

        private void LoadListNhanVien()
        {
            lvwNhanVien.Columns.Add("STT", 70);
            lvwNhanVien.Columns.Add("Họ Tên", 210);
            lvwNhanVien.Columns.Add("Ngày sinh", 140);
            lvwNhanVien.Columns.Add("Giới Tính", 100);
            lvwNhanVien.Columns.Add("Địa Chỉ", 210);
            lvwNhanVien.Columns.Add("SĐT", 210);
            lvwNhanVien.Columns.Add("Chức vụ", 140);
            lvwNhanVien.Columns.Add("CMND", 140);
            lvwNhanVien.Columns.Add("Phòng ban", 140);

            int i = 1;
            foreach (NhanVien nv in _nhanVien.GetNhanViens())
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.NgaySinh.Value.ToString("dd/MM/yyyy"));

                if (nv.GioiTinh.Value)
                {
                    item.SubItems.Add("Nam");
                }
                else
                {
                    item.SubItems.Add("Nữ");
                }
                
                item.SubItems.Add(nv.DiaChi);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(_chucVu.GetById(nv.IDChucVu.Value).TenChucVu);
                item.SubItems.Add(nv.CMND);
                item.SubItems.Add(_phongBan.GetById(nv.IDPhongBan.Value).TenPhongBan);

                lvwNhanVien.Items.Add(item);
                i++;
            }
        }

        private void LoadListPhongBan()
        {
            lvwPhongBan.Columns.Add("STT", 70);
            lvwPhongBan.Columns.Add("Tên phòng", 210);
            lvwPhongBan.Columns.Add("Ngày thành lập", 140);
            lvwPhongBan.Columns.Add("Số lượng nhân viên", 140);
            lvwPhongBan.Columns.Add("Tên quản lý", 210);

            int i = 1;
            foreach(PhongBan pb in _phongBan.GetPhongBans())
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(pb.TenPhongBan);
                item.SubItems.Add(pb.NgayThanhLap.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(pb.SoLuongNhanVien.ToString());
                item.SubItems.Add(pb.TenQuanLy);

                lvwPhongBan.Items.Add(item);
                i++;
            }
        }

        private void LoadListSanPham()
        {
            lvwSanPham.Columns.Add("STT", 70);
            lvwSanPham.Columns.Add("Tên sản phẩm", 210);
            lvwSanPham.Columns.Add("Đơn giá", 210);
            lvwSanPham.Columns.Add("Đơn vị tính", 140);

            int i = 1;
            foreach (SanPham sp in _sanPham.GetSanPhams())
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(sp.TenSP);
                item.SubItems.Add(sp.DonGia.ToString());
                item.SubItems.Add(sp.DonViTinh);

                lvwSanPham.Items.Add(item);
                i++;
            }
        }

        private void LoadListHopDong()
        {
            lvwHopDong.Columns.Add("STT", 70);
            lvwHopDong.Columns.Add("Tên hợp đồng", 210);
            lvwHopDong.Columns.Add("Tên khách hàng", 100);
            lvwHopDong.Columns.Add("Ngày bắt đầu", 140);
            lvwHopDong.Columns.Add("Ngày kết thúc", 140);
            lvwHopDong.Columns.Add("Trạng thái", 210);

            int i = 1;
            foreach (HopDong hd in _hopDong.GetHopDongs())
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(hd.TenHopDong);
                item.SubItems.Add(hd.TenKhachHang);
                item.SubItems.Add(hd.NgayBatDau.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(hd.NgayKetThuc.Value.ToString("dd/MM/yyyy"));

                if (hd.TrangThai == false)
                    item.SubItems.Add("Đã thanh lý");

                lvwHopDong.Items.Add(item);
                i++;
            }

        }

        private void frmTongQuan_Load(object sender, EventArgs e)
        {
            lblNgay.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy");

            // Thêm list view nhân viên
            CreateList(lvwNhanVien);
            LoadListNhanVien();

            // Thêm list view phòng ban
            CreateList(lvwPhongBan);
            LoadListPhongBan();

            // Thêm list view sản phẩm
            CreateList(lvwSanPham);
            LoadListSanPham();

            // Thêm list view hợp đồng
            CreateList(lvwHopDong);
            LoadListHopDong();

            // Đếm phòng ban, nhân viên, sản phẩmm, hợp đồng
            lblSLNhanVien.Text = _nhanVien.GetNhanViens().Count().ToString();
            lblSLPhongBan.Text = _phongBan.GetPhongBans().Count().ToString();
            lblSLSanPham.Text = _sanPham.GetSanPhams().Count().ToString();
            lblSLHopDong.Text = _hopDong.GetHopDongs().Count().ToString();
        }
    }
}
