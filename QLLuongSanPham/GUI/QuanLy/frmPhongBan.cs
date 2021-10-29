using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLLuongSanPham.BLL;
using QLLuongSanPham.DAL;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmPhongBan : Form
    {
        private PhongBanBLL _phongBan = new PhongBanBLL();
        private NhanVienBLL _nhanVien = new NhanVienBLL();

        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void CreateList(ListView lvw)
        {
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.View = View.Details;

            lvwPhongBan.Columns.Add("STT", 70);
            lvwPhongBan.Columns.Add("Tên phòng", 210);
            lvwPhongBan.Columns.Add("Ngày thành lập", 140);
            lvwPhongBan.Columns.Add("Số lượng nhân viên", 140);
            lvwPhongBan.Columns.Add("Tên quản lý", 210);
        }

        private void LoadListPhongBan(IEnumerable<PhongBan> list)
        {
            lvwPhongBan.Items.Clear();

            int i = 1;
            foreach (PhongBan pb in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString();
                item.SubItems.Add(pb.TenPhongBan);
                item.SubItems.Add(pb.NgayThanhLap.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(pb.SoLuongNhanVien.ToString());
                if (pb.IDQuanLy != null)
                    item.SubItems.Add(_nhanVien.GetById(pb.IDQuanLy.Value).HoTen);
                else
                    item.SubItems.Add("");
                item.Tag = pb;


                lvwPhongBan.Items.Add(item);

                i++;
            }

            if (lvwPhongBan.Items.Count > 0)
                lvwPhongBan.SelectedIndices.Add(0);


            lvwPhongBan.Focus();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            CreateList(lvwPhongBan);
            LoadListPhongBan(_phongBan.GetPhongBans());

            if (lvwPhongBan.Items.Count > 0)
                lvwPhongBan.SelectedIndices.Add(0);
        }

        private void lvwPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPhongBan.SelectedItems.Count > 0)
            {
                PhongBan pb = (PhongBan)lvwPhongBan.SelectedItems[0].Tag;
                txtTenPhongBan.Text = pb.TenPhongBan;
                txtNgayThanhLap.Text = pb.NgayThanhLap.Value.ToString("dd/MM/yyyy");
                txtSLNV.Text = pb.SoLuongNhanVien.ToString();

                if (pb.IDQuanLy != null)
                    txtTenQL.Text = _nhanVien.GetById(pb.IDQuanLy.Value).HoTen;
                else
                    txtTenQL.Text = "";

                
                txtPos.Text = (lvwPhongBan.SelectedIndices[0] + 1).ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lvwPhongBan.Items.Count > 0)
            {
                lvwPhongBan.SelectedIndices.Clear();
                lvwPhongBan.SelectedIndices.Add((Convert.ToInt32(txtPos.Text)) % lvwPhongBan.Items.Count);
            }
            lvwPhongBan.Focus();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (lvwPhongBan.Items.Count > 0)
            {
                lvwPhongBan.SelectedIndices.Clear();
                lvwPhongBan.SelectedIndices.Add((Convert.ToInt32(txtPos.Text) - 2 
                    + lvwPhongBan.Items.Count) 
                    % lvwPhongBan.Items.Count);
            }
            lvwPhongBan.Focus();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (lvwPhongBan.Items.Count > 0)
            {
                lvwPhongBan.SelectedIndices.Clear();
                lvwPhongBan.SelectedIndices.Add(0);
            }
            lvwPhongBan.Focus();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (lvwPhongBan.Items.Count > 0)
            {
                lvwPhongBan.SelectedIndices.Clear();
                lvwPhongBan.SelectedIndices.Add(lvwPhongBan.Items.Count-1);
            }
            lvwPhongBan.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan();
            pb.NgayThanhLap = DateTime.Now;
            pb.TenPhongBan = txtTenPhongBan.Text;

            _phongBan.AddPhongBan(pb);
            LoadListPhongBan(_phongBan.GetPhongBans());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lvwPhongBan.SelectedItems.Count > 0)
            {
                int id = ((PhongBan)lvwPhongBan.SelectedItems[0].Tag).ID;
                _phongBan.DeletePhongBan(id);
                LoadListPhongBan(_phongBan.GetPhongBans());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvwPhongBan.SelectedItems.Count > 0)
            {
                PhongBan pb = (PhongBan)lvwPhongBan.SelectedItems[0].Tag;
                pb.TenPhongBan = txtTenPhongBan.Text;
                _phongBan.UpdatePhongBan(pb);

                LoadListPhongBan(_phongBan.GetPhongBans());
            }
        }
    }
}
