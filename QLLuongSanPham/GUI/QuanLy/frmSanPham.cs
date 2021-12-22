using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmSanPham : Form
    {
        SanPhamDAO spDAO;
        public frmSanPham()
        {
            InitializeComponent();
            spDAO = new SanPhamDAO();
        }

        //Methods
        private void CreateCtilte(ListView lvw)
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
            lvwDSSP.Items.Clear();

            foreach (SanPham sp in sanPhams)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = sp.TenSP;
                listViewItem.SubItems.Add(sp.DonGia.ToString());
                listViewItem.SubItems.Add(sp.DonViTinh);
                listViewItem.Tag = sp;

                lvwDSSP.Items.Add(listViewItem);
            }

            if (lvwDSSP.Items.Count > 0)
            {
                lvwDSSP.SelectedIndices.Add(0);
            }
            lvwDSSP.Focus();
        }

        private SanPham CreateProduct(SanPham sp)
        {
            sp.TenSP = txtTenSP.Text;
            sp.DonViTinh = txtDVT.Text;
            sp.DonGia = Convert.ToInt32(txtDG.Text);
            sp.AnhSP = ptcAvata.ImageLocation;

            return sp;
        }

        private void EnaTxt()
        {
            txtTenSP.Enabled = true;
            txtDG.Enabled = true;
            txtDVT.Enabled = true;
            btnChonAnh.Enabled = true;
        }

        private void DisTxt()
        {
            txtTenSP.Enabled = false;
            txtDG.Enabled = false;
            txtDVT.Enabled = false;
            btnChonAnh.Enabled = false;
        }

        private void ClearTxT()
        {
            txtDG.Clear();
            txtDVT.Clear();
            txtTenSP.Clear();
            ptcAvata.ImageLocation = "";
        }

        //Envents
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            CreateCtilte(lvwDSSP);
            LoadData(spDAO.GetSanPhams());
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Chọn ảnh của bạn";
            opf.Filter = "Image File (*.jpg; *.jpeg; *.png;) | *.jpg; *.jpeg; *.png;";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(opf.FileName);
                ptcAvata.Image = image;
                ptcAvata.ImageLocation = opf.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm"))
            {
                EnaTxt();
                ClearTxT();
                btnThem.Text = "Lưu";
                btnThem.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnThem.IconColor = Color.Blue;

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                DisTxt();
                btnThem.Text = "Thêm";
                btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
                btnThem.IconColor = Color.FromArgb(128, 255, 128);

                SanPham sp = new SanPham();
                spDAO.AddProcduct(CreateProduct(sp));

                ClearTxT();
                LoadData(spDAO.GetSanPhams());

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("Sửa"))
            {
                EnaTxt();
                btnSua.Text = "Lưu";
                btnSua.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnSua.IconColor = Color.Blue;

                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                DisTxt();
                btnSua.Text = "Sửa";
                btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
                btnSua.IconColor = Color.FromArgb(255, 128, 0);

                SanPham sp = (SanPham)lvwDSSP.SelectedItems[0].Tag;
                spDAO.UpdateEmployee(CreateProduct(sp));
                LoadData(spDAO.GetSanPhams());
                ClearTxT();

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SanPham sp = (SanPham)lvwDSSP.SelectedItems[0].Tag;
            spDAO.RemoveProcduct(sp);
            LoadData(spDAO.GetSanPhams());
            ClearTxT();
        }

        private void lvwDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDSSP.SelectedItems.Count > 0)
            {
                SanPham sp = (SanPham)lvwDSSP.SelectedItems[0].Tag;
                txtDG.Text = sp.DonGia.ToString();
                txtDVT.Text = sp.DonViTinh;
                txtTenSP.Text = sp.TenSP;
                ptcAvata.ImageLocation = sp.AnhSP;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData(spDAO.GetSPByChar(txtNameSearch.Text));
        }
    }
}
