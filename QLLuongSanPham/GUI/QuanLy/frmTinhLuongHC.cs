using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmTinhLuongHC : Form
    {
        PhongBanDAO phongBanDAO;
        ChucVuDAO chucVuDAO;
        NhanVienDAO nhanVienDAO;
        BangCongHCDAO bangCongDAO;
        BangLuongDAO bangLuongDAO;
        LoaiPhepDAO loaiPhepDAO;

        NhanVien nhanVien;
        IEnumerable<BangCongHC> bangCongHCs;

        public frmTinhLuongHC()
        {
            InitializeComponent();

            phongBanDAO = new PhongBanDAO();
            chucVuDAO = new ChucVuDAO();
            nhanVienDAO = new NhanVienDAO();
            bangCongDAO = new BangCongHCDAO();
            bangLuongDAO = new BangLuongDAO();
            loaiPhepDAO = new LoaiPhepDAO();
        }

        #region Method

        private void LoadCombobox()
        {
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add($"Tháng {i}");
            }
            cboThang.SelectedIndex = DateTime.Now.Month - 1;

            cboNam.Items.Add((DateTime.Now.Year - 1).ToString());
            cboNam.Items.Add((DateTime.Now.Year).ToString());
            cboNam.SelectedIndex = 1;
        }

        private void LoadDataNhanVien(IEnumerable<NhanVien> data)
        {
            data = data.Where(x => x.IDChucVu.Value != 7);
            lstvNhanVien.Items.Clear();

            if (data == null)
                return;

            foreach (var nv in data)
            {
                ListViewItem item = new ListViewItem();
                item.Text = nv.CMND;
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(phongBanDAO.GetById(nv.IDPhongBan.Value).TenPhongBan);
                item.SubItems.Add(chucVuDAO.GetChucByID(nv.IDChucVu.Value).TenChucVu);
                item.SubItems.Add(String.Format("{0:0,###}", chucVuDAO.GetChucByID(nv.IDChucVu.Value).PhuCap) + " VND");


                item.Tag = nv;

                lstvNhanVien.Items.Add(item);
            }
        }

        private void LoadDataNgayNghi(IEnumerable<BangCongHC> data)
        {
            if (data == null) return;

            nudNgayNghi.Value = data.Count();
            lstvNgayNghi.Items.Clear();
            nudTongPhuCap.Value = 0;
            foreach (var bc in data)
            {
                ListViewItem item = new ListViewItem();

                item.Text = bc.NgayCham.Value.ToString("dd/MM/yyyy");
                item.SubItems.Add(loaiPhepDAO.GetByID(bc.IDLoaiPhep.Value).TenPhep);
                item.SubItems.Add(String.Format("{0:0,###}", loaiPhepDAO.GetByID(bc.IDLoaiPhep.Value).PhuCap) + " VND");
                item.Tag = bc;

                lstvNgayNghi.Items.Add(item);
                nudTongPhuCap.Value += loaiPhepDAO.GetByID(bc.IDLoaiPhep.Value).PhuCap.Value;
            }

            nudTongPhuCap.Value += chucVuDAO.GetChucByID(nhanVien.IDChucVu.Value).PhuCap.Value;
        }

        private void LoadDataLuong(IEnumerable<BangLuong> data)
        {
            data = data.Where(x => nhanVienDAO.GetById(x.IDNhanVien).IDChucVu.Value != 7);

            lstvLuong.Items.Clear();
            foreach (var bl in data)
            {
                ListViewItem item = new ListViewItem();
                item.Text = nhanVienDAO.GetById(bl.IDNhanVien).CMND;
                item.SubItems.Add(nhanVienDAO.GetById(bl.IDNhanVien).HoTen);
                item.SubItems.Add(phongBanDAO.GetById(nhanVienDAO.GetById(bl.IDNhanVien).IDPhongBan.Value).TenPhongBan);
                item.SubItems.Add(chucVuDAO.GetChucByID(nhanVienDAO.GetById(bl.IDNhanVien).IDChucVu.Value).TenChucVu);
                item.SubItems.Add(bl.NgayLap.Value.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(String.Format("{0:0,###}", bl.TienLuong) + " VND");

                item.Tag = bl;

                lstvLuong.Items.Add(item);
            }
        }

        private void CreateTitleDSNV(ListView lvw)
        {
            lvw.Columns.Add("CMND", 120);
            lvw.Columns.Add("Tên nhân viên", 120);
            lvw.Columns.Add("Phòng Ban", 120);
            lvw.Columns.Add("Chức vụ", 170);
            lvw.Columns.Add("Phụ cấp", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitleNgayNghi(ListView lvw)
        {
            lvw.Columns.Add("Ngày nghỉ", 120);
            lvw.Columns.Add("Loại phép", 170);
            lvw.Columns.Add("Phụ cấp", 170);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitleLuong(ListView lvw)
        {
            lvw.Columns.Add("CMND", 120);
            lvw.Columns.Add("Tên nhân viên", 120);
            lvw.Columns.Add("Phòng Ban", 120);
            lvw.Columns.Add("Chức vụ", 170);
            lvw.Columns.Add("Ngày lập", 120);
            lvw.Columns.Add("Tiền lương", 170);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        #endregion

        #region Event

        private void frmTinhLuongHC_Load(object sender, EventArgs e)
        {
            CreateTitleDSNV(lstvNhanVien);
            CreateTitleNgayNghi(lstvNgayNghi);
            CreateTitleLuong(lstvLuong);

            LoadDataNhanVien(nhanVienDAO.GetNhanViens());
            LoadDataLuong(bangLuongDAO.GetBangLuongs());
            LoadCombobox();
        }

        private void lstvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvNhanVien.SelectedItems[0];
                nhanVien = (NhanVien)item.Tag;

                bangCongHCs = bangCongDAO.GetBangCongHCsByIDNVAndDate(nhanVien.ID,
                    cboThang.SelectedIndex + 1,
                    Convert.ToInt32(cboNam.Text));

                LoadDataNgayNghi(bangCongHCs);
            }
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhanVien == null)
                return;

            bangCongHCs = bangCongDAO.GetBangCongHCsByIDNVAndDate(nhanVien.ID,
                    cboThang.SelectedIndex + 1,
                    Convert.ToInt32(cboNam.Text));

            LoadDataNgayNghi(bangCongHCs);
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhanVien == null)
                return;

            bangCongHCs = bangCongDAO.GetBangCongHCsByIDNVAndDate(nhanVien.ID,
                    cboThang.SelectedIndex + 1,
                    Convert.ToInt32(cboNam.Text));



            LoadDataNgayNghi(bangCongHCs);
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDataNhanVien(nhanVienDAO.GetNhanViens().Where(x => x.HoTen.Contains(txtTen.Text)));
        }

        #endregion

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (nhanVien == null)
            {
                MessageBox.Show("Chưa chọn nhân viên!", "Thông báo");
                return;
            }

            int month = Convert.ToInt32(cboThang.SelectedIndex + 1);
            int year = Convert.ToInt32(cboNam.Text);
            if (bangLuongDAO.CheckExist(nhanVien.ID, month, year) != null)
            {
                MessageBox.Show($"Tháng này nhân viên {nhanVien.HoTen} đã có lương", "Lỗi");
                return;
            }

            BangLuong bl = new BangLuong();
            bl.IDNhanVien = nhanVien.ID;
            bl.NgayLap = DateTime.Now;

            decimal luongCanBang = nhanVien.LuongCanBan.Value * Convert.ToDecimal(nhanVien.ChiSoLuong.Value);
            bl.TienLuong = luongCanBang - (nudNgayNghi.Value / nudTongSoNgay.Value * luongCanBang)
                + (nudSoBuoiLamThem.Value * nudLuongLamThem.Value)
                + nudTongPhuCap.Value + nudThuongPhat.Value;

            bl.TienLuong = Math.Round(bl.TienLuong, 3);

            if (bangLuongDAO.Add(bl))
            {
                MessageBox.Show("Đã tính lương!", "Thông báo");
                LoadDataLuong(bangLuongDAO.GetBangLuongs());

                List<int> lst = bangCongHCs.Select(x => x.ID).ToList();
                bangCongHCs = null;
                foreach (int i in lst)
                {
                    bangCongDAO.Remove(bangCongDAO.GetByID(i));
                }

                bangCongHCs = bangCongDAO.GetBangCongHCsByIDNVAndDate(nhanVien.ID,
                cboThang.SelectedIndex + 1,
                Convert.ToInt32(cboNam.Text));

                LoadDataNgayNghi(bangCongHCs);
                nudThuongPhat.Value = 0;
                nudSoBuoiLamThem.Value = 0;
                nudNgayNghi.Value = 0;
                nudTongPhuCap.Value = 0;
            }
            else
            {
                MessageBox.Show("Lỗi tính lương!", "Thông báo");
            }

        }
    }
}
