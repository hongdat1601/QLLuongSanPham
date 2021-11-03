using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmPhongBan : Form
    {
        private PhongBanDAO phongBanDAO;
        private NhanVienDAO nhanVienDAO;

        public frmPhongBan()
        {
            InitializeComponent();
            phongBanDAO = new PhongBanDAO();
            nhanVienDAO = new NhanVienDAO();
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
                    item.SubItems.Add(nhanVienDAO.GetById(pb.IDQuanLy.Value).HoTen);
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
            LoadListPhongBan(phongBanDAO.GetPhongBans());

            if (lvwPhongBan.Items.Count > 0)
                lvwPhongBan.SelectedIndices.Add(0);
        }

        private void lvwPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPhongBan.SelectedItems.Count > 0)
            {
                PhongBan pb = (PhongBan)lvwPhongBan.SelectedItems[0].Tag;
                txtTenPhongBan.Text = pb.TenPhongBan;
                txtSLNV.Text = pb.SoLuongNhanVien.ToString();

                if (pb.IDQuanLy != null)
                    txtTenQL.Text = nhanVienDAO.GetById(pb.IDQuanLy.Value).HoTen;
                else
                    txtTenQL.Text = "";
            }
        }
    }
}
