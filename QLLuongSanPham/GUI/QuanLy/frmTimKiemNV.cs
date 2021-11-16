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

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmTimKiemNV : Form
    {
        NhanVienDAO nhanVienDAO;
        PhongBanDAO phongBanDAO;
        ChucVuDAO chucVuDAO;
        TrinhDoHocVanDAO hocVanDAO;

        public frmTimKiemNV()
        {
            InitializeComponent();
            nhanVienDAO = new NhanVienDAO();
            phongBanDAO = new PhongBanDAO();
            chucVuDAO = new ChucVuDAO();
            hocVanDAO = new TrinhDoHocVanDAO();
        }

        private void CreateTitle(ListView lvw)
        {
            lvw.Columns.Add("CMND/CCCD", 120);
            lvw.Columns.Add("Họ tên", 120);
            lvw.Columns.Add("Ngày sinh", 120);
            lvw.Columns.Add("Giới tính", 60);
            lvw.Columns.Add("Số điện thoại", 100);
            lvw.Columns.Add("Địa chỉ", 180);
            lvw.Columns.Add("Phòng ban", 100);
            lvw.Columns.Add("Chức vụ", 80);
            lvw.Columns.Add("Lương căn bản", 120);
            lvw.Columns.Add("Chỉ số lương", 100);
            lvw.Columns.Add("Thâm niên công tác", 180);
            lvw.Columns.Add("Trình độ học vấn", 180);
            lvw.Columns.Add("Trình độ ngoại ngữ", 180);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void frmTimKiemNV_Load(object sender, EventArgs e)
        {
            CreateTitle(lstvNhanVien);
            LoadListEmployee(nhanVienDAO.GetNhanViens());
            LoadComboboxs();
        }

        private void LoadComboboxs()
        {
            phongBanDAO.GetPhongBans()
                .ToList()
                .ForEach(x => cboPB.Items.Add(x.TenPhongBan));

            chucVuDAO.GetChucVus()
                .ToList()
                .ForEach(x => cboCV.Items.Add(x.TenChucVu));

            hocVanDAO.GetTrinhDoHocVans()
                .ToList()
                .ForEach(x => cboHV.Items.Add(x.TenTrinhDo));
        }

        private void LoadListEmployee(IEnumerable<NhanVien> nhanViens)
        {
            lstvNhanVien.Items.Clear();

            foreach (NhanVien nv in nhanViens)
            {
                ListViewItem lvwItem = new ListViewItem();
                lvwItem.Text = nv.CMND;
                lvwItem.SubItems.Add(nv.HoTen);
                lvwItem.SubItems.Add(nv.NgaySinh.ToString("dd/MM/yyyy"));
                if (nv.GioiTinh == true)
                {
                    lvwItem.SubItems.Add("Nam");
                }
                else
                {
                    lvwItem.SubItems.Add("Nữ");
                }

                lvwItem.SubItems.Add(nv.SDT);
                lvwItem.SubItems.Add(nv.DiaChi);
                lvwItem.SubItems.Add(phongBanDAO.GetById(nv.IDPhongBan.Value).TenPhongBan);
                lvwItem.SubItems.Add(chucVuDAO.GetChucByID(nv.IDChucVu.Value).TenChucVu);
                lvwItem.SubItems.Add(nv.LuongCanBan.ToString());
                lvwItem.SubItems.Add(nv.ChiSoLuong.ToString());
                lvwItem.SubItems.Add(nv.ThamNienCongTac.ToString());
                lvwItem.SubItems.Add(hocVanDAO.GetHVByID(nv.IDTrinhDoHocVan.Value).TenTrinhDo);
                lvwItem.SubItems.Add(nv.TrinhDoNgoaiNgu.ToString());
                lvwItem.Tag = nv;

                lstvNhanVien.Items.Add(lvwItem);
            }

            if (lstvNhanVien.Items.Count > 0)
            {
                lstvNhanVien.SelectedIndices.Add(0);
            }
            lstvNhanVien.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bool? gioiTinh;

            if (cboSex.Text == "Khác")
            {
                gioiTinh = null;
            }
            else
            {
                gioiTinh = cboSex.Text == "Nam" ? true : false;
            }


            int pb = phongBanDAO.GetIDByName(cboPB.Text);
            int cv = chucVuDAO.GetIDByName(cboCV.Text);
            int hv = hocVanDAO.GetIDByName(cboHV.Text);
            int tnct = string.IsNullOrEmpty(txtThamNien.Text) ? -1 : Convert.ToInt32(txtThamNien.Text);

            var lstNV = nhanVienDAO.Find(txtName.Text,
                txtPhone.Text, 
                txtNgaySinh.Text,
                gioiTinh,
                txtID.Text,
                txtAdress.Text,
                pb,
                cv,
                hv,
                tnct
                );

            LoadListEmployee(lstNV);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadListEmployee(nhanVienDAO.GetNhanViens());
            txtName.Text = "";
            txtPhone.Text = "";
            txtID.Text = "";
            txtAdress.Text = "";
            cboPB.Text = "";
            cboHV.Text = "";
            cboCV.Text = "";
            txtThamNien.Text = "";

        }
    }
}
