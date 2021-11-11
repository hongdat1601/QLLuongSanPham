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
    public partial class frmTinhLuongHC : Form
    {
        PhongBanDAO phongBanDAO;
        ChucVuDAO chucVuDAO;
        NhanVienDAO nhanVienDAO;
        BangCongHCDAO bangCongDAO;
        LoaiPhepDAO loaiPhepDAO;
        BangLuongDAO bangLuongDAO;

        NhanVien nhanVien;
        IEnumerable<BangCongHC> bangCongHCs;

        public frmTinhLuongHC()
        {
            InitializeComponent();

            phongBanDAO = new PhongBanDAO();
            chucVuDAO = new ChucVuDAO();
            nhanVienDAO = new NhanVienDAO();
            bangCongDAO = new BangCongHCDAO();
            loaiPhepDAO = new LoaiPhepDAO();
            bangLuongDAO = new BangLuongDAO();
        }

        private void frmTinhLuongHC_Load(object sender, EventArgs e)
        {
            CreateTitleDSNV(lstvNhanVien);
            CreateTitleCV(lstvCongViec);
            CreateTitleLuong(lstvLuong);

            LoadDataNhanVien(nhanVienDAO.GetNhanViens());
            LoadDataLuong(bangLuongDAO.GetBangLuongs());
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add($"Tháng {i}");
            }
            cboThang.SelectedIndex = DateTime.Now.Month - 1;

            cboNam.Items.Add((DateTime.Now.Year - 1).ToString());
            cboNam.Items.Add((DateTime.Now.Year).ToString());
            cboNam.Items.Add((DateTime.Now.Year + 1).ToString());
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
                item.SubItems.Add(chucVuDAO.GetChucByID(nv.IDChucVu.Value).PhuCap.ToString() + " VND");


                item.Tag = nv;

                lstvNhanVien.Items.Add(item);
            }
        }

        private void LoadDataCongViec(IEnumerable<BangCongHC> data)
        {
            lstvCongViec.Items.Clear();
            if (data == null)
            {
                return;
            }

            foreach (var bc in data)
            {
                ListViewItem item = new ListViewItem();

                item.Text = bc.NgayCham.Value.ToString("dd/MM/yyyy");

                if (bc.TrangThai == null)
                    item.SubItems.Add("Không");
                else
                    item.SubItems.Add((bc.TrangThai.Value ? "Có" : "Không"));

                if (bc.IDLoaiPhep == null)
                {
                    item.SubItems.Add("Không");
                    item.SubItems.Add("0 VND");
                }
                else
                {
                    item.SubItems.Add(loaiPhepDAO.GetByID(bc.IDLoaiPhep.Value).TenPhep);
                    item.SubItems.Add(loaiPhepDAO.GetByID(bc.IDLoaiPhep.Value).PhuCap.ToString() + " VND");
                } 

                item.Tag = bc;

                lstvCongViec.Items.Add(item);
            }
        }

        private void LoadDataLuong(IEnumerable<BangLuong> data)
        {
            data = data.Where(x => nhanVienDAO.GetById(x.IDNhanVien.Value).IDChucVu.Value != 7);

            lstvLuong.Items.Clear();
            int stt = 1;
            foreach (var bl in data)
            {
                ListViewItem item = new ListViewItem();
                item.Text = stt.ToString();
                item.SubItems.Add(nhanVienDAO.GetById(bl.IDNhanVien.Value).HoTen);
                item.SubItems.Add(bl.NgayLap.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(bl.TienLuong.Value.ToString() + " VND");

                item.Tag = bl;

                lstvLuong.Items.Add(item);
                stt++;
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

        private void CreateTitleCV(ListView lvw)
        {
            lvw.Columns.Add("Ngày đi làm", 120);
            lvw.Columns.Add("Có mặt", 120);
            lvw.Columns.Add("Phép", 170);
            lvw.Columns.Add("Phụ cấp", 170);

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

        private void lstvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvNhanVien.SelectedItems[0];
                nhanVien = (NhanVien)item.Tag;

                bangCongHCs = bangCongDAO.GetBangCongHCsByIDNVAndDate(nhanVien.ID, 
                    cboThang.SelectedIndex+1, 
                    Convert.ToInt32(cboNam.Text));

                LoadDataCongViec(bangCongHCs);
            }
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhanVien == null)
                return;

            bangCongHCs = bangCongDAO.GetBangCongHCsByIDNVAndDate(nhanVien.ID,
                    cboThang.SelectedIndex + 1,
                    Convert.ToInt32(cboNam.Text));

            LoadDataCongViec(bangCongHCs);
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhanVien == null)
                return;

            bangCongHCs = bangCongDAO.GetBangCongHCsByIDNVAndDate(nhanVien.ID,
                    cboThang.SelectedIndex + 1,
                    Convert.ToInt32(cboNam.Text));



            LoadDataCongViec(bangCongHCs);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (nhanVien == null)
            {
                MessageBox.Show("Chưa chọn nhân viên!", "Thông báo");
                return;
            }

            if (bangCongHCs.Count() <= 0)
            {
                MessageBox.Show("Nhân viên không có lịch để tính", "Thông báo");
                return;
            }

            List<int> ids = new List<int>();

            int soNgayLam = bangCongHCs.Count();
            int soNgayLamThucTe = 0;
            decimal phuCap = chucVuDAO.GetChucByID(nhanVien.IDChucVu.Value).PhuCap.Value;
            phuCap += Convert.ToDecimal(txtThuongPhat.Text);

            foreach (var bc in bangCongHCs)
            {
                if (bc.TrangThai != null)
                {
                    if (bc.TrangThai.Value)
                    {
                        soNgayLamThucTe++;
                    }
                }

                if (bc.IDLoaiPhep != null)
                {
                    phuCap += loaiPhepDAO.GetByID(bc.IDLoaiPhep.Value).PhuCap.Value;
                }

                ids.Add(bc.ID);
            }

            decimal tongTien = phuCap
                + (Convert.ToDecimal((soNgayLamThucTe * 1.0 / soNgayLam)) * nhanVien.LuongCanBan.Value)
                + (Convert.ToInt32(nudSoBuoiLamThem.Text) * 100000);

            BangLuong bl = new BangLuong
            {
                IDNhanVien = nhanVien.ID,
                NgayLap = DateTime.Now,
                SoBuoiLamThem = Convert.ToInt32(nudSoBuoiLamThem.Text),
                TienLuong = Math.Round(tongTien, 0)
            };

            bangLuongDAO.Add(bl);
            LoadDataLuong(bangLuongDAO.GetBangLuongs());

            foreach (int id in ids)
            {
                bangCongDAO.RemoveBangCong(bangCongDAO.GetByID(id));
            }

            bangCongHCs = bangCongDAO.GetBangCongHCsByIDNVAndDate(nhanVien.ID,
                    cboThang.SelectedIndex + 1,
                    Convert.ToInt32(cboNam.Text));

            LoadDataCongViec(bangCongHCs);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDataNhanVien(nhanVienDAO.GetNhanViens().Where(x => x.HoTen.Contains(txtTen.Text)));
        }
    }
}
