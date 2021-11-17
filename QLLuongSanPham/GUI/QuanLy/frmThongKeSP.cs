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
using System.Windows.Forms.DataVisualization.Charting;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmThongKeSP : Form
    {
        BangLuongDAO bangLuongDAO;
        NhanVienDAO nhanVienDAO;
        PhongBanDAO phongBanDAO;
        ChucVuDAO chucVuDAO;

        public frmThongKeSP()
        {
            InitializeComponent();

            phongBanDAO = new PhongBanDAO();
            chucVuDAO = new ChucVuDAO();
            bangLuongDAO = new BangLuongDAO();
            nhanVienDAO = new NhanVienDAO();
        }

        private void frmThongKeSP_Load(object sender, EventArgs e)
        {
            CreateTitleLuong(lstvLuong);
            LoadDataLuong(bangLuongDAO.GetBangLuongs());
        }

        private void LoadDataLuong(IEnumerable<BangLuong> data)
        {
            data = data.Where(x => nhanVienDAO.GetById(x.IDNhanVien).IDChucVu.Value == 7);

            lstvLuong.Items.Clear();
            foreach (var bl in data)
            {
                ListViewItem item = new ListViewItem();
                item.Text = bl.ID.ToString();
                item.SubItems.Add(nhanVienDAO.GetById(bl.IDNhanVien).HoTen);
                item.SubItems.Add(nhanVienDAO.GetById(bl.IDNhanVien).CMND);
                item.SubItems.Add(phongBanDAO.GetById(nhanVienDAO.GetById(bl.IDNhanVien).IDPhongBan.Value).TenPhongBan);
                item.SubItems.Add(chucVuDAO.GetChucByID(nhanVienDAO.GetById(bl.IDNhanVien).IDChucVu.Value).TenChucVu);
                item.SubItems.Add(bl.NgayLap.ToString("dd/MM/yyyy"));
                item.SubItems.Add(bl.TienLuong.ToString() + " VND");

                item.Tag = bl;

                lstvLuong.Items.Add(item);

                DataPoint point = new DataPoint();
                point.SetValueXY(bl.ID.ToString(), bl.TienLuong);
                point.Label = bl.TienLuong.ToString();

                chartThongKe.Series["BangLuong"].Points.Add(point);
            }
        }

        private void CreateTitleLuong(ListView lvw)
        {
            lvw.Columns.Add("ID Bảng Lương", 120);
            lvw.Columns.Add("Tên nhân viên", 120);
            lvw.Columns.Add("CMND", 120);
            lvw.Columns.Add("Phòng Ban", 120);
            lvw.Columns.Add("Chức vụ", 170);
            lvw.Columns.Add("Ngày lập", 120);
            lvw.Columns.Add("Tiền lương", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }
    }
}
