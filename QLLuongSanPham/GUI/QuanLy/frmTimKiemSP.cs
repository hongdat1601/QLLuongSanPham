using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmTimKiemSP : Form
    {
        SanPhamDAO sanPhamDAO;

        public frmTimKiemSP()
        {
            InitializeComponent();
            sanPhamDAO = new SanPhamDAO();
        }

        private void frmTimKiemSP_Load(object sender, EventArgs e)
        {
            CreateTitle(lstvDSSP);
            LoadData(sanPhamDAO.GetSanPhams());
        }

        private void CreateTitle(ListView lvw)
        {
            lvw.Columns.Add("Tên sản phẩm", 120);
            lvw.Columns.Add("Đơn giá", 80);
            lvw.Columns.Add("Đơn vị tính", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void LoadData(IEnumerable<SanPham> sanPhams)
        {
            lstvDSSP.Items.Clear();

            foreach (SanPham sp in sanPhams)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = sp.TenSP;
                listViewItem.SubItems.Add(sp.DonGia.ToString());
                listViewItem.SubItems.Add(sp.DonViTinh);
                listViewItem.Tag = sp;

                lstvDSSP.Items.Add(listViewItem);
            }

            if (lstvDSSP.Items.Count > 0)
            {
                lstvDSSP.SelectedIndices.Add(0);
            }
            lstvDSSP.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData(sanPhamDAO.FindByNameAndPrice(txtName.Text, txtDonGia.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData(sanPhamDAO.GetSanPhams());
            txtDonGia.Text = "";
            txtName.Text = "";
        }
    }
}
