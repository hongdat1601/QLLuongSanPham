using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;
using System;
using System.Windows.Forms;

namespace QLLuongSanPham.GUI.NhanVienGUI
{
    public partial class frmLuongNhanVien : Form
    {
        BangLuongDAO blDAO;
        private NhanVien _nhanVien;

        public frmLuongNhanVien(NhanVien nhanVien)
        {
            InitializeComponent();
            blDAO = new BangLuongDAO();

            this._nhanVien = nhanVien;
        }

        private void frmLuongNhanVien_Load(object sender, EventArgs e)
        {
            if (_nhanVien.IDChucVu == 7)
            {
                CreateTitleCN(lvwSalary);
                LoadLuongCN();
            }
            else
            {
                CreateTitleNV(lvwSalary);
                LoadLuongHC();
            }

        }

        //Methods
        private void CreateTitleCN(ListView lvwListSalary)
        {
            lvwListSalary.Columns.Add("Ngày lập", 140);
            lvwListSalary.Columns.Add("Tiền lương", 140);

            lvwListSalary.View = View.Details;
            lvwListSalary.GridLines = true;
            lvwListSalary.FullRowSelect = true;
        }

        private void CreateTitleNV(ListView lvw)
        {
            lvw.Columns.Add("Ngày lập", 140);
            lvw.Columns.Add("Tiền lương", 140);
            lvw.Columns.Add("Số buổi làm thêm", 140);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void LoadLuongCN()
        {
            lvwSalary.Items.Clear();

            foreach (BangLuong hc in blDAO.GetListByIDNV(_nhanVien.ID))
            {
                ListViewItem item = new ListViewItem();
                item.Text = hc.NgayLap.Date.ToString("dd/MM/yyyy");
                item.SubItems.Add(hc.TienLuong.ToString() + " VNĐ");

                lvwSalary.Items.Add(item);
            }
        }

        private void LoadLuongHC()
        {
            lvwSalary.Items.Clear();

            foreach (BangLuong hc in blDAO.GetListByIDNV(_nhanVien.ID))
            {
                ListViewItem item = new ListViewItem();
                item.Text = hc.NgayLap.Date.ToString("dd/MM/yyyy");
                item.SubItems.Add(hc.TienLuong.ToString() + " VNĐ");
                item.SubItems.Add(hc.SoBuoiLamThem.ToString());

                lvwSalary.Items.Add(item);
            }
        }
    }
}
