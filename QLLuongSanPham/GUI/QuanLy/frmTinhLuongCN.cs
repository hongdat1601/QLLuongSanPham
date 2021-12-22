using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmTinhLuongCN : Form
    {
        NhanVienDAO nhanVienDao;
        PhongBanDAO phongBanDAO;
        BangCongCNDAO bangCongDAO;
        BangLuongDAO bangLuongDAO;
        CaLamDAO caLamDAO;
        CongDoanDAO congDoanDAO;
        NhanVien nhanVien;
        IEnumerable<BangCongSP> bangCongSPs;
        ChucVuDAO chucVuDAO;

        public frmTinhLuongCN()
        {
            InitializeComponent();
            bangCongDAO = new BangCongCNDAO();
            bangLuongDAO = new BangLuongDAO();
            nhanVienDao = new NhanVienDAO(); ;
            phongBanDAO = new PhongBanDAO();
            congDoanDAO = new CongDoanDAO();
            caLamDAO = new CaLamDAO();
            chucVuDAO = new ChucVuDAO();
        }

        #region Method

        private void LoadDataNhanVien(IEnumerable<NhanVien> data)
        {
            data = data.Where(x => x.IDChucVu.Value == 7);

            lstvNhanVien.Items.Clear();
            foreach (var nv in data)
            {
                ListViewItem item = new ListViewItem();
                item.Text = nv.CMND;
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(phongBanDAO.GetById(nv.IDPhongBan.Value).TenPhongBan);
                item.SubItems.Add(chucVuDAO.GetChucByID(nv.IDChucVu.Value).TenChucVu);

                int count = bangCongDAO.GetBangCongSPsByIDNhanVien(nv.ID).Count();

                item.SubItems.Add(count > 0 ? "Còn" : "Không");

                item.Tag = nv;

                lstvNhanVien.Items.Add(item);
            }

        }

        private void LoadDataLich(IEnumerable<BangCongSP> data)
        {
            lstvLich.Items.Clear();
            if (data == null)
            {
                return;
            }

            foreach (var bc in data)
            {
                ListViewItem item = new ListViewItem();
                item.Text = bc.NgayDiLam.Value.ToString("dd/MM/yyyy");
                item.SubItems.Add(caLamDAO.GetByID(bc.IDCaLam.Value).TenCa);
                item.SubItems.Add(congDoanDAO.GetById(bc.IDCongDoan.Value).TenCongDoan);

                if (bc.TrangThai == null)
                {
                    item.SubItems.Add("Chưa chấm");
                }
                else
                {
                    item.SubItems.Add(bc.TrangThai.Value ? "Có" : "Không");
                }

                item.SubItems.Add(bc.SoLuongSP.ToString());

                item.Tag = bc;

                lstvLich.Items.Add(item);
            }
        }

        private void LoadDataLuong(IEnumerable<BangLuong> data)
        {
            data = data.Where(x => nhanVienDao.GetById(x.IDNhanVien).IDChucVu.Value == 7);

            lstvLuong.Items.Clear();
            foreach (var bl in data)
            {
                ListViewItem item = new ListViewItem();
                item.Text = nhanVienDao.GetById(bl.IDNhanVien).CMND;
                item.SubItems.Add(nhanVienDao.GetById(bl.IDNhanVien).HoTen);
                item.SubItems.Add(phongBanDAO.GetById(nhanVienDao.GetById(bl.IDNhanVien).IDPhongBan.Value).TenPhongBan);
                item.SubItems.Add(chucVuDAO.GetChucByID(nhanVienDao.GetById(bl.IDNhanVien).IDChucVu.Value).TenChucVu);
                item.SubItems.Add(bl.NgayLap.Value.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(String.Format("{0:0,###}", bl.TienLuong) + " VND");

                item.Tag = bl;

                lstvLuong.Items.Add(item);
            }
        }

        private void CreateTitleNV(ListView lvw)
        {
            lvw.Columns.Add("CMND", 120);
            lvw.Columns.Add("Tên nhân viên", 170);
            lvw.Columns.Add("Phòng ban", 120);
            lvw.Columns.Add("Chức vụ", 120);
            lvw.Columns.Add("Còn công", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitleCV(ListView lvw)
        {
            lvw.Columns.Add("Ngày làm", 120);
            lvw.Columns.Add("Ca làm việc", 120);
            lvw.Columns.Add("Công đoạn", 120);
            lvw.Columns.Add("Có mặt", 120);
            lvw.Columns.Add("Số lượng sản phẩm", 150);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitleLuong(ListView lvw)
        {
            lvw.Columns.Add("CMND", 120);
            lvw.Columns.Add("Tên nhân viên", 120);
            lvw.Columns.Add("Phòng Ban", 120);
            lvw.Columns.Add("Chức vụ", 120);
            lvw.Columns.Add("Ngày lập", 120);
            lvw.Columns.Add("Tiền lương", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        #endregion

        #region Event

        private void frmTinhLuongCN_Load(object sender, EventArgs e)
        {
            CreateTitleNV(lstvNhanVien);
            CreateTitleCV(lstvLich);
            CreateTitleLuong(lstvLuong);

            LoadDataNhanVien(nhanVienDao.GetNhanViens());
            LoadDataLuong(bangLuongDAO.GetBangLuongs());
        }

        private void lstvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvNhanVien.SelectedItems[0];
                nhanVien = (NhanVien)item.Tag;

                bangCongSPs = bangCongDAO.GetBangCongSPsByIDNhanVien(nhanVien.ID);

                LoadDataLich(bangCongSPs);
            }
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            if (nhanVien == null)
            {
                MessageBox.Show("Chưa chọn nhân viên!", "Thông báo");
                return;
            }

            if (bangCongSPs.Count() <= 0)
            {
                MessageBox.Show("Không có bảng công!", "Thông báo");
                return;
            }

            decimal tienLuong = nudTP.Value;

            List<int> ids = new List<int>();
            foreach (var bc in bangCongSPs)
            {
                tienLuong += congDoanDAO.GetById(bc.IDCongDoan.Value).DonGia.Value * bc.SoLuongSP.Value;
                ids.Add(bc.ID);
            }

            BangLuong bangLuong = new BangLuong
            {
                IDNhanVien = nhanVien.ID,
                NgayLap = DateTime.Now,
                TienLuong = tienLuong
            };

            bangLuongDAO.Add(bangLuong);
            LoadDataLuong(bangLuongDAO.GetBangLuongs());

            ids.ForEach(x => bangCongDAO.RemoveBCCN(bangCongDAO.GetByID(x)));
            bangCongSPs = bangCongDAO.GetBangCongSPsByIDNhanVien(nhanVien.ID);
            LoadDataLich(bangCongSPs);
            lstvNhanVien.SelectedItems[0].SubItems[lstvNhanVien.SelectedItems[0].SubItems.Count - 1].Text = "Không";

            nudTP.Value = 0;
        }

        private void btnTiemKiem_Click(object sender, EventArgs e)
        {
            LoadDataNhanVien(nhanVienDao.GetNhanViens().Where(x => x.HoTen.Contains(txtTen.Text)));
        }

        #endregion

    }
}
