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
            createComboxSp();
            CreateTitleLuong(lstvLuong);
            LoadDataLuong(bangLuongDAO.GetBangLuongs());
        }
        private void createComboxSp()
        {
            int range = 50;
            int year = DateTime.Now.Year;
            while (range > 0)
            {
                cboNam.Items.Add(year--);
                range--;
            }
        }

        private void LoadDataLuong(IEnumerable<BangLuong> data)
        {
            if (data == null) return;
            data = data.Where(x => nhanVienDAO.GetById(x.IDNhanVien).IDChucVu.Value == 7);
            chartThongKe.Series["BangLuong"].Points.Clear();

            lstvLuong.Items.Clear();
            foreach (var bl in data)
            {
                ListViewItem item = new ListViewItem();
                item.Text = bl.ID.ToString();
                item.SubItems.Add(nhanVienDAO.GetById(bl.IDNhanVien).HoTen);
                item.SubItems.Add(nhanVienDAO.GetById(bl.IDNhanVien).CMND);
                item.SubItems.Add(phongBanDAO.GetById(nhanVienDAO.GetById(bl.IDNhanVien).IDPhongBan.Value).TenPhongBan);
                item.SubItems.Add(chucVuDAO.GetChucByID(nhanVienDAO.GetById(bl.IDNhanVien).IDChucVu.Value).TenChucVu);
                item.SubItems.Add(bl.NgayLap.Value.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(bl.TienLuong.ToString() + " VND");

                item.Tag = bl;

                lstvLuong.Items.Add(item);

                DataPoint point = new DataPoint();
                point.SetValueXY(bl.ID.ToString(), bl.TienLuong);
                point.Label = bl.TienLuong.ToString();

                chartThongKe.Series["BangLuong"].Points.Add(point);
            }
            //Ìnorma
            Infomation(data);
        }
        private void Infomation(IEnumerable<BangLuong> data)
        {
            if (data == null) return;

            decimal tong = 0;
            decimal tb = 0;
            decimal max = 0;
            decimal min = 0;
            decimal std = 0;

            int n = 0;

            foreach (var i in data)
            {
                tong += i.TienLuong;

                if (n == 0)
                {
                    max = i.TienLuong;
                    min = i.TienLuong;
                }
                else
                {
                    if (max < i.TienLuong)
                        max = i.TienLuong;

                    if (min > i.TienLuong)
                        min = i.TienLuong;
                }

                n++;
            }
            if (tong == 0)
            {
                tb = 0;
            }
            else
            {
                tb = tong / n;
            }

            foreach (var i in data)
            {
                std += (i.TienLuong / 1000 - tb / 1000) * (i.TienLuong / 1000 - tb / 1000);
            }

            double tmp = 0;
            if (n > 1)
            {
                tmp = Math.Round(Math.Sqrt(Convert.ToDouble(std / (n - 1))) * 1000, 3);
            }
            lblTong.Text = tong.ToString();
            lblTrungBinh.Text =Math.Round(tb,3).ToString();
            lblMin.Text = min.ToString();
            lblMax.Text = max.ToString();
            lblChenhLech.Text = tmp.ToString();


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
        private void LoadDatawithDate()
        {
            int month, year;

            if (cboThang.Text.Equals("Tất cả")) month = -1;
            else
            {
                month = Convert.ToInt32(cboThang.Text.Split(' ')[1]);
            }

            if (cboNam.Text.Equals("Tất cả")) year = -1;
            else
            {
                year = Convert.ToInt32(cboNam.Text);
            }
            IEnumerable<BangLuong> data = bangLuongDAO.GetBangLuongsByDate(month, year);
            LoadDataLuong(data);
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDatawithDate();
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDatawithDate();
        }
        
    }
}
