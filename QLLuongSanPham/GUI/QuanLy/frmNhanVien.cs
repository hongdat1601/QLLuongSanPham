using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;
namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmNhanVien : Form
    {
        private NhanVienDAO nvDAO = new NhanVienDAO();
        private PhongBanDAO pbDAO;
        private ChucVuDAO cvDAO;
        private TrinhDoHocVanDAO hvDAO;

        public frmNhanVien()
        {
            InitializeComponent();
            nvDAO = new NhanVienDAO();
            pbDAO = new PhongBanDAO();
            cvDAO = new ChucVuDAO();
            hvDAO = new TrinhDoHocVanDAO();

            CreateTitile(lvwDSNV);
            LoadListEmployee(nvDAO.GetNhanViens());
        }

        //Method
        private void CreateTitile(ListView lvw)
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

        private void LoadListEmployee(IEnumerable<NhanVien> nhanViens)
        {
            lvwDSNV.Items.Clear();

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
                lvwItem.SubItems.Add(pbDAO.GetById(nv.IDPhongBan.Value).TenPhongBan);
                lvwItem.SubItems.Add(cvDAO.GetChucByID(nv.IDChucVu.Value).TenChucVu);
                lvwItem.SubItems.Add(nv.LuongCanBan.ToString());
                lvwItem.SubItems.Add(nv.ChiSoLuong.ToString());
                lvwItem.SubItems.Add(nv.ThamNienCongTac.ToString() + " năm");
                lvwItem.SubItems.Add(hvDAO.GetHVByID(nv.IDTrinhDoHocVan.Value).TenTrinhDo);
                lvwItem.SubItems.Add("Ielts " + nv.TrinhDoNgoaiNgu.ToString());
                lvwItem.Tag = nv;

                lvwDSNV.Items.Add(lvwItem);
            }

            if (lvwDSNV.Items.Count > 0)
            {
                lvwDSNV.SelectedIndices.Add(0);
            }
            lvwDSNV.Focus();
        }

        private void LoadDeparment(IEnumerable<PhongBan> phongBans)
        {
            cboPB.Items.Clear();

            foreach (PhongBan pb in phongBans)
            {
                cboPB.Items.Add(pb.TenPhongBan);
            }
        }

        private void LoadChucVu(IEnumerable<ChucVu> chucVus)
        {
            cboCV.Items.Clear();

            foreach (ChucVu cv in chucVus)
            {
                cboCV.Items.Add(cv.TenChucVu);
            }
        }

        private void LoadHocVan(IEnumerable<TrinhDoHocVan> hocVans)
        {
            cboHV.Items.Clear();

            foreach (TrinhDoHocVan cv in hocVans)
            {
                cboHV.Items.Add(cv.TenTrinhDo);
            }
        }

        private void EnabledTxT()
        {
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            dtmDate.Enabled = true;
            txtCMND.Enabled = true;
            txtAdress.Enabled = true;
            cboSex.Enabled = true;
            cboPB.Enabled = true;
            cboCV.Enabled = true;
            cboHV.Enabled = true;
            txtSeniority.Enabled = true;
            txtBasicSalary.Enabled = true;
            txtIndexSalary.Enabled = true;
            txtNN.Enabled = true;
        }

        private void Disabled()
        {
            txtName.Enabled = false;
            txtNN.Enabled = false;
            txtPhone.Enabled = false;
            dtmDate.Enabled = false;
            txtCMND.Enabled = false;
            txtAdress.Enabled = false;
            cboSex.Enabled = false;
            cboPB.Enabled = false;
            cboCV.Enabled = false;
            cboHV.Enabled = false;
            txtSeniority.Enabled = false;
            txtBasicSalary.Enabled = false;
            txtIndexSalary.Enabled = false;
        }

        private void ClearTxt()
        {
            txtName.Clear();
            txtPhone.Clear();
            dtmDate.Value = DateTime.Today;
            txtCMND.Clear();
            txtAdress.Clear();
            cboSex.SelectedIndex = 0;
            cboPB.Items.Clear();
            cboCV.Items.Clear();
            cboHV.Items.Clear();
            txtSeniority.Clear();
            txtBasicSalary.Clear();
            txtIndexSalary.Clear();
            txtNN.Clear();
        }

        private NhanVien CreateEmployee(NhanVien nv)
        {
            nv.HoTen = txtName.Text;
            nv.SDT = txtPhone.Text;
            nv.NgaySinh = dtmDate.Value;
            nv.CMND = txtCMND.Text;
            nv.DiaChi = txtAdress.Text;

            if (cboSex.Text.Equals("Nữ"))
            {
                nv.GioiTinh = false;
            }
            else
            {
                nv.GioiTinh = true;
            }

            nv.IDPhongBan = pbDAO.GetIDByName(cboPB.Text);
            nv.IDChucVu = cvDAO.GetIDByName(cboCV.Text);
            nv.IDTrinhDoHocVan = hvDAO.GetIDByName(cboHV.Text);
            if (txtSeniority.Text != "")
            {
                nv.ThamNienCongTac = Convert.ToInt32(txtSeniority.Text.Substring(0, 2));
            }
            else
                nv.ThamNienCongTac = 0;
            if (txtBasicSalary.Text != "")
            {
                nv.LuongCanBan = Convert.ToDecimal(txtBasicSalary.Text);
            }
            else
                nv.LuongCanBan = 0;
            if (txtIndexSalary.Text != "")
            {
                nv.ChiSoLuong = Convert.ToDouble(txtIndexSalary.Text);
            }
            else
                nv.ChiSoLuong = 0;
            if (txtNN.Text != "")
            {
                nv.TrinhDoNgoaiNgu = Convert.ToDouble(txtNN.Text);
            }
            else
                nv.TrinhDoNgoaiNgu = 0;
            return nv;
        }

        //Envents
        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void lvwDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDSNV.SelectedItems.Count > 0)
            {
                NhanVien nv = (NhanVien)lvwDSNV.SelectedItems[0].Tag;
                txtName.Text = nv.HoTen;
                txtPhone.Text = nv.SDT;
                dtmDate.Value = nv.NgaySinh.Date;
                txtCMND.Text = nv.CMND;
                txtAdress.Text = nv.DiaChi;
                if (nv.GioiTinh == true)
                {
                    cboSex.Text = "Nam";
                }
                else
                {
                    cboSex.Text = "Nữ";
                }
                cboPB.Text = pbDAO.GetNameByID((int)nv.IDPhongBan);
                cboCV.Text = cvDAO.GetNameByID((int)nv.IDChucVu);
                cboHV.Text = hvDAO.GetNameByID((int)nv.IDTrinhDoHocVan);
                txtSeniority.Text = nv.ThamNienCongTac + " năm";
                txtBasicSalary.Text = nv.LuongCanBan.ToString();
                txtIndexSalary.Text = nv.ChiSoLuong.ToString();
                txtNN.Text = nv.TrinhDoNgoaiNgu.ToString();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm"))
            {
                ClearTxt();
                EnabledTxT();

                LoadDeparment(pbDAO.GetPhongBans());
                cboPB.SelectedIndex = 0;

                LoadChucVu(cvDAO.GetChucVus());
                cboCV.SelectedIndex = 0;

                LoadHocVan(hvDAO.GetTrinhDoHocVans());
                cboHV.SelectedIndex = 0;

                btnThem.Text = "Lưu";
                btnThem.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnThem.IconColor = Color.Blue;

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                Disabled();
                btnThem.Text = "Thêm";
                btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
                btnThem.IconColor = Color.FromArgb(128, 255, 128);

                NhanVien nv = new NhanVien();
                nvDAO.AddEmployee(CreateEmployee(nv));
                ClearTxt();
                LoadListEmployee(nvDAO.GetNhanViens());

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwDSNV.SelectedItems.Count > 0)
            {
                NhanVien nv = (NhanVien)lvwDSNV.SelectedItems[0].Tag;
                nvDAO.RemoveEmployee(nv);
                ClearTxt();
                LoadListEmployee(nvDAO.GetNhanViens());
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để xóa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("Sửa"))
            {
                EnabledTxT();

                LoadDeparment(pbDAO.GetPhongBans());
                LoadChucVu(cvDAO.GetChucVus());
                LoadHocVan(hvDAO.GetTrinhDoHocVans());

                btnSua.Text = "Lưu";
                btnSua.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnSua.IconColor = Color.Blue;

                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                Disabled();
                btnSua.Text = "Sửa";
                btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
                btnSua.IconColor = Color.FromArgb(255, 128, 0);

                NhanVien nvUpdate = (NhanVien)lvwDSNV.SelectedItems[0].Tag;
                nvDAO.UpdateEmployee(CreateEmployee(nvUpdate));

                ClearTxt();
                LoadListEmployee(nvDAO.GetNhanViens());

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void cboCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCV.Text.StartsWith("Công"))
            {
                txtSeniority.Enabled = false;
                txtNN.Enabled = false;
                txtBasicSalary.Enabled = false;
                txtIndexSalary.Enabled = false;

                txtSeniority.Text = 0.ToString() + " năm";
                txtNN.Text = 0.ToString();
                txtBasicSalary.Text = 0.ToString();
                txtIndexSalary.Text = 0.ToString();

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadListEmployee(nvDAO.GetListNVByName(txtNameSearch.Text));
        }
    }
}
