using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLuongSanPham.Entities;
using QLLuongSanPham.DAO;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmChamCongHC : Form
    {

        BangCongHCDAO bangCongDAO;
        NhanVienDAO nhanVienDAO;
        LoaiPhepDAO loaiPhepDAO;
        BangCongHC bangCong;

        public frmChamCongHC()
        {
            InitializeComponent();
            bangCongDAO = new BangCongHCDAO();
            nhanVienDAO = new NhanVienDAO();
            loaiPhepDAO = new LoaiPhepDAO();
        }

        private void frmChamCongHC_Load(object sender, EventArgs e)
        {
            CreateList();
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            loaiPhepDAO.GetLoaiPheps().ToList().ForEach(x => cboPhep.Items.Add(x.TenPhep));
        }

        private void LoadData(IEnumerable<BangCongHC> data)
        {
            lstvLich.Items.Clear();

            foreach (var bc in data)
            {
                ListViewItem item = new ListViewItem();

                item.Text = bc.IDNhanVien.ToString();
                item.SubItems.Add(nhanVienDAO.GetById(bc.IDNhanVien.Value).HoTen);
                item.SubItems.Add(bc.NgayCham.Value.ToString("dd/MM/yyyy"));

                if (bc.IDLoaiPhep == null)
                    item.SubItems.Add("Không");
                else
                    item.SubItems.Add(loaiPhepDAO.GetByID(bc.IDLoaiPhep.Value).TenPhep);

                if (bc.TrangThai == null)
                {
                    item.SubItems.Add("");
                }
                else
                {
                    item.SubItems.Add((bc.TrangThai.Value ? "Có" : "Không"));
                }

                item.Tag = bc;

                lstvLich.Items.Add(item);
            }
        }

        private void CreateList()
        {
            lstvLich.GridLines = true;
            lstvLich.FullRowSelect = true;
            lstvLich.View = View.Details;

            // Create Column
            lstvLich.Columns.Add("ID NV", 100);
            lstvLich.Columns.Add("Tên nhân viên", 210);
            lstvLich.Columns.Add("Ngày làm", 120);
            lstvLich.Columns.Add("Nghỉ phép", 120);
            lstvLich.Columns.Add("Điểm danh", 120);

        }

        private void dtmDate_ValueChanged(object sender, EventArgs e)
        {
            string date = dtmDate.Value.ToString("dd/MM/yyyy");
            LoadData(bangCongDAO.GetBangCongHCsByDate(date));

            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cboPhep.Text = "Không";
            chkDiemDanh.Checked = false;
            bangCong = null;
        }

        private void lstvLich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvLich.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvLich.SelectedItems[0];
                bangCong = (BangCongHC)item.Tag;

                txtMaNV.Text = bangCong.IDNhanVien.ToString();
                txtTenNV.Text = nhanVienDAO.GetById(bangCong.IDNhanVien.Value).HoTen;

                if (bangCong.IDLoaiPhep == null)
                    cboPhep.Text = "Không";
                else
                    cboPhep.Text = loaiPhepDAO.GetByID(bangCong.IDLoaiPhep.Value).TenPhep;

                if (bangCong.TrangThai == null)
                    chkDiemDanh.Checked = false;
                else
                    chkDiemDanh.Checked = bangCong.TrangThai.Value;
            }
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (bangCong == null)
            {
                MessageBox.Show("Chưa chọn lịch!", "Thông báo");
                return;
            }

            if (cboPhep.SelectedIndex != 0)
            {
                bangCong.IDLoaiPhep = loaiPhepDAO.GetByName(cboPhep.Text).ID;
                bangCong.TrangThai = false;
            }
            else
            {
                bangCong.IDLoaiPhep = null;
                bangCong.TrangThai = chkDiemDanh.Checked;
            }

            bangCongDAO.UpdateBangCong(bangCong);
            string date = dtmDate.Value.ToString("dd/MM/yyyy");
            LoadData(bangCongDAO.GetBangCongHCsByDate(date));
        }

        private void cboPhep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhep.SelectedIndex == 0)
            {
                chkDiemDanh.Enabled = true; 
            }
            else
            {
                chkDiemDanh.Enabled = false;
            }
        }

        private void btnTimKimSP_Click(object sender, EventArgs e)
        {
            
        }
    }
}
