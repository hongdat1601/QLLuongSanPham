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

namespace QLLuongSanPham.GUI.NhanVienGUI
{
    public partial class frmThongtinNV : Form
    {
        private NhanVien nhanVien;
        PhongBanDAO pbDAO;
        ChucVuDAO cvDAO;
        TrinhDoHocVanDAO tdDAO;
        NhanVienDAO nvDAO;

        public frmThongtinNV(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
            pbDAO = new PhongBanDAO();
            cvDAO = new ChucVuDAO();
            tdDAO = new TrinhDoHocVanDAO();
            nvDAO = new NhanVienDAO();
        }

        #region Methods

        private void LoadTT()
        {
            picImage.ImageLocation = nhanVien.Anh;
            txtName.Text = nhanVien.HoTen;
            txtPhone.Text = nhanVien.SDT;
            txtBirhDay.Text = nhanVien.NgaySinh.Value.Date.ToString("dd/MM/yyyy");
            if(nhanVien.GioiTinh == true)
            {
                cboSex.Text = "Name";
            }
            else
            {
                cboSex.Text = "Nữ";
            }
            txtID.Text = nhanVien.CMND;
            txtAdress.Text = nhanVien.DiaChi;
            txtDeparment.Text = pbDAO.GetById(nhanVien.IDPhongBan.Value).TenPhongBan;
            txtPosition.Text = cvDAO.GetChucByID(nhanVien.IDChucVu.Value).TenChucVu;
            txtStudy.Text = tdDAO.GetHVByID(nhanVien.IDTrinhDoHocVan.Value).TenTrinhDo;
            txtEnglish.Text = nhanVien.TrinhDoNgoaiNgu.ToString();
            txtSeniority.Text = nhanVien.ThamNienCongTac.ToString() + "năm";
            txtBasicSalary.Text = nhanVien.LuongCanBan.ToString();
            txtIndexSalary.Text = nhanVien.ChiSoLuong.ToString();
            lblRole.Text = cvDAO.GetChucByID(nhanVien.IDChucVu.Value).TenChucVu;
        }

        private void UpdateNV(NhanVien nv)
        {
            nv.HoTen = txtName.Text;
            nv.DiaChi = txtAdress.Text;
            nv.CMND = txtID.Text;
            nv.SDT = txtPhone.Text;
            if(cboSex.Text == "Nam")
            {
                nv.GioiTinh = true;
            }
            else
            {
                nv.GioiTinh = false;
            }
            nv.NgaySinh = Convert.ToDateTime(txtBirhDay.Text);

            nv.IDPhongBan = pbDAO.GetIDByName(txtDeparment.Text);
            nv.IDChucVu = cvDAO.GetIDByName(txtPosition.Text);
            nv.IDTrinhDoHocVan = tdDAO.GetIDByName(txtStudy.Text);
            nv.ThamNienCongTac = Convert.ToInt32(txtSeniority.Text.Substring(0, 1));
            nv.TrinhDoNgoaiNgu = Convert.ToDouble(txtEnglish.Text);
            nv.ChiSoLuong = Convert.ToDouble(txtIndexSalary.Text);
            nv.LuongCanBan = Convert.ToDecimal(txtBasicSalary.Text);

            nvDAO.UpdateEmployee(nv);
        }

        #endregion
        private void btnFixPassWord_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
        }

        private void frmThongtinNV_Load(object sender, EventArgs e)
        {
            if(nhanVien.IDChucVu == 7)
            {
                lblEnglish.Visible = false;
                txtEnglish.Visible = false;
                lblSeniority.Visible = false;
                txtSeniority.Visible = false;
                gbxInfoSlary.Visible = false;
            }
            LoadTT();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Chọn ảnh của bạn";
            opf.Filter = "Image File (*.jpg; *.jpeg; *.png;) | *.jpg; *.jpeg; *.png;";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(opf.FileName);
                picImage.Image = image;
                picImage.ImageLocation = opf.FileName;
                NhanVien nv = nvDAO.GetById(nhanVien.ID);
                nv.Anh = opf.FileName;
                UpdateNV(nv);
            }
        }

        private void btnFixInfo_Click(object sender, EventArgs e)
        {
            NhanVien nv = nvDAO.GetById(nhanVien.ID);
            UpdateNV(nv);
        }
    }
}
