using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmCaLamViec : Form
    {
        CaLamDAO caLamDAO = new CaLamDAO();

        public frmCaLamViec()
        {
            InitializeComponent();
        }

        //Methods
        private void CreateTitile(ListView lvw)
        {
            lvw.Columns.Add("STT");
            lvw.Columns.Add("Tên ca", 120);
            lvw.Columns.Add("Thời gian làm việc", 150);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void LoadListPB(IEnumerable<CaLam> caLams)
        {
            lvwDSCA.Items.Clear();

            int i = 1;

            foreach (CaLam caLam in caLams)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(caLam.TenCa);
                item.SubItems.Add(caLam.ThoiGianLam);
                item.Tag = caLam;

                lvwDSCA.Items.Add(item);
                i++;
            }
        }

        private void ClearTexbox()
        {
            txtCalam.Clear();
            txtTime.Clear();
        }

        //Envent
        private void frmCaLamViec_Load(object sender, EventArgs e)
        {
            CreateTitile(lvwDSCA);
            LoadListPB(caLamDAO.GetCaLams());
        }

        private void lvwDSCA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDSCA.SelectedItems.Count > 0)
            {
                CaLam ca = (CaLam)lvwDSCA.SelectedItems[0].Tag;
                txtCalam.Text = ca.TenCa;
                txtTime.Text = ca.ThoiGianLam;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("Thêm"))
            {
                ClearTexbox();

                btnAdd.Text = "Lưu";
                btnAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnAdd.IconColor = Color.Blue;

                txtCalam.Enabled = true;
                txtTime.Enabled = true;

                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnAdd.Text = "Thêm";
                btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
                btnAdd.IconColor = Color.FromArgb(128, 255, 128);

                txtCalam.Enabled = false;
                txtTime.Enabled = false;

                CaLam ca = new CaLam();
                ca.TenCa = txtCalam.Text;
                ca.ThoiGianLam = txtTime.Text;
                caLamDAO.AddCaLam(ca);

                LoadListPB(caLamDAO.GetCaLams());
                ClearTexbox();

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CaLam ca = (CaLam)lvwDSCA.SelectedItems[0].Tag;

            caLamDAO.RemoveCaLam(ca);
            LoadListPB(caLamDAO.GetCaLams());
            ClearTexbox();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Equals("Sửa"))
            {
                btnEdit.Text = "Lưu";
                btnEdit.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnEdit.IconColor = Color.Blue;

                txtCalam.Enabled = true;
                txtTime.Enabled = true;

                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Text = "Sửa";
                btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
                btnEdit.IconColor = Color.FromArgb(255, 128, 0);

                txtCalam.Enabled = false;
                txtTime.Enabled = false;

                CaLam ca = (CaLam)lvwDSCA.SelectedItems[0].Tag;
                ca.TenCa = txtCalam.Text;
                ca.ThoiGianLam = txtTime.Text;

                caLamDAO.EditCaLam(ca);
                LoadListPB(caLamDAO.GetCaLams());
                ClearTexbox();

                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
            }

        }
    }
}
