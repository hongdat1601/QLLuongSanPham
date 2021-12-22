using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmChamCongHC : Form
    {
        PhongBanDAO phongBanDAO = new PhongBanDAO();
        LoaiPhepDAO loaiPhepDAO = new LoaiPhepDAO();
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        ChucVuDAO chucVuDAO = new ChucVuDAO();
        BangCongHCDAO bangCongDAO = new BangCongHCDAO();

        NhanVien nhanVienCurrent = null;
        LoaiPhep loaiPhep = null;
        BangCongHC bangCong = null;

        string tenNVTimKiem = "";
        int idPhongBan = -1;

        public frmChamCongHC()
        {
            InitializeComponent();

        }

        #region Method

        private void LoadCombobox()
        {
            // Load danh sach phong ban
            var phongBanList = phongBanDAO.GetPhongBans();

            foreach (var i in phongBanList)
            {
                cboPhongBan.Items.Add(i.TenPhongBan);
            }

            // Load danh sach loai phep
            var loaiPhepList = loaiPhepDAO.GetLoaiPheps();
            foreach (var i in loaiPhepList)
            {
                cboPhep.Items.Add(i.TenPhep);
            }
        }

        private void CreateList()
        {
            // Tao list nhan vien
            lstvNhanVien.GridLines = true;
            lstvNhanVien.FullRowSelect = true;
            lstvNhanVien.View = View.Details;

            lstvNhanVien.Columns.Add("CMND", 120);
            lstvNhanVien.Columns.Add("Tên nhân viên", 220);
            lstvNhanVien.Columns.Add("Phòng ban", 220);
            lstvNhanVien.Columns.Add("Chức vụ", 220);

            // Tao list ngay nghi
            lstvNgayNghi.GridLines = true;
            lstvNgayNghi.FullRowSelect = true;
            lstvNgayNghi.View = View.Details;

            lstvNgayNghi.Columns.Add("Ngày nghỉ", 120);
            lstvNgayNghi.Columns.Add("Loại phép", 220);
            lstvNgayNghi.Columns.Add("Phụ cấp", 220);

        }

        private void LoadDataNhanVien(string tenNhanVien, int idPhongBan)
        {
            var data = nhanVienDAO.GetNhanViensByNameAndIDPhongBan(tenNhanVien, idPhongBan);
            data = data.Where(x => x.IDChucVu.Value != 7);
            if (data == null) return;

            lstvNhanVien.Items.Clear();
            foreach (var nv in data)
            {
                ListViewItem item = new ListViewItem();

                item.Text = nv.CMND;
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(phongBanDAO.GetNameByID(nv.IDPhongBan.Value));
                item.SubItems.Add(chucVuDAO.GetNameByID(nv.IDChucVu.Value));

                item.Tag = nv;
                lstvNhanVien.Items.Add(item);
            }
        }

        private void LoadDataNgayNghi(int idNhanVien)
        {
            var data = bangCongDAO.GetBangCongHCsByIDNhanVien(idNhanVien);
            if (data == null) return;

            lstvNgayNghi.Items.Clear();
            foreach (var bc in data)
            {
                ListViewItem item = new ListViewItem();

                item.Text = bc.NgayCham.Value.ToString("dd/MM/yyyy");
                item.SubItems.Add(loaiPhepDAO.GetByID(bc.IDLoaiPhep.Value).TenPhep);
                item.SubItems.Add(String.Format("{0:0,###}", loaiPhepDAO.GetByID(bc.IDLoaiPhep.Value).PhuCap) + " VND");

                item.Tag = bc;
                lstvNgayNghi.Items.Add(item);
            }
        }

        #endregion

        #region Event

        private void frmChamCongHC_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            CreateList();
            LoadDataNhanVien(tenNVTimKiem, idPhongBan);
        }

        private void cboPhep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cboPhep.Text;
            loaiPhep = loaiPhepDAO.GetByName(name);

            if (loaiPhep != null)
            {
                nudPhuCap.Value = loaiPhep.PhuCap.Value;
            }
            else
            {
                nudPhuCap.Value = 0;
            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            tenNVTimKiem = txtNameSearch.Text;
            LoadDataNhanVien(tenNVTimKiem, idPhongBan);
        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPhongBan = phongBanDAO.GetIDByName(cboPhongBan.Text);
            LoadDataNhanVien(tenNVTimKiem, idPhongBan);
        }

        private void lstvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvNhanVien.SelectedItems.Count > 0)
            {
                nhanVienCurrent = lstvNhanVien.SelectedItems[0].Tag as NhanVien;

                txtCMND.Text = nhanVienCurrent.CMND;
                txtTenNV.Text = nhanVienCurrent.HoTen;

                LoadDataNgayNghi(nhanVienCurrent.ID);
            }
        }

        private void lstvNgayNghi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvNgayNghi.SelectedItems.Count > 0)
            {
                bangCong = lstvNgayNghi.SelectedItems[0].Tag as BangCongHC;
                loaiPhep = loaiPhepDAO.GetByID(bangCong.IDLoaiPhep.Value);
                cboPhep.Text = loaiPhep.TenPhep;
                nudPhuCap.Value = loaiPhep.PhuCap.Value;
                dtmDate.Value = bangCong.NgayCham.Value;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (bangCong == null)
            {
                MessageBox.Show("Chưa chọn ngày nghỉ!", "Lỗi");
                return;
            }

            if (bangCongDAO.CheckExist(nhanVienCurrent.ID, dtmDate.Value) == null
                || bangCongDAO.CheckExist(nhanVienCurrent.ID, dtmDate.Value).ID == bangCong.ID)
            {
                bangCong.NgayCham = dtmDate.Value;
                bangCong.IDLoaiPhep = loaiPhep.ID;

                if (bangCongDAO.Update(bangCong))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    LoadDataNgayNghi(nhanVienCurrent.ID);
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bị trùng ngày nghỉ!", "Lỗi");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nhanVienCurrent == null)
            {
                MessageBox.Show("Chưa chọn nhân viên!", "Thông báo");
                return;
            }

            if (loaiPhep == null)
            {
                MessageBox.Show("Chưa chọn loại phép!", "Thông báo");
                return;
            }


            BangCongHC bc = new BangCongHC();

            bc.IDNhanVien = nhanVienCurrent.ID;
            bc.IDLoaiPhep = loaiPhep.ID;
            bc.NgayCham = dtmDate.Value;

            if (bangCongDAO.CheckExist(nhanVienCurrent.ID, dtmDate.Value) == null)
            {
                if (bangCongDAO.Add(bc))
                {
                    LoadDataNgayNghi(nhanVienCurrent.ID);
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show($"Công ngày {dtmDate.Value.ToString("dd/MM/yyyy")} đã tồn tại!", "Lỗi");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bangCong == null)
            {
                MessageBox.Show("Chưa chọn ngày nghỉ!", "Lỗi");
                return;
            }

            if (MessageBox.Show("Xác nhận xóa ngày nghỉ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bangCongDAO.Remove(bangCong);
                bangCong = null;
                LoadDataNgayNghi(nhanVienCurrent.ID);
            }
        }

        #endregion

    }
}
