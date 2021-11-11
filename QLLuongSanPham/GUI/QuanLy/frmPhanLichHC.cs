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
using System.Globalization;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmPhanLichHC : Form
    {
        NhanVienDAO nvDAO;
        ChucVuDAO cvDAO;
        BangCongHCDAO bcDAO;
        NhanVien nv;

        private string[] thu = { "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy" };
        private string[] thuEng = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public frmPhanLichHC()
        {
            InitializeComponent();
            nvDAO = new NhanVienDAO();
            cvDAO = new ChucVuDAO();
            bcDAO = new BangCongHCDAO();
        }

        private void frmPhanCongHC_Load(object sender, EventArgs e)
        {

            CreateTiltileNV(lvwDSNV);
            LoadListEmployee(nvDAO.GetNhanViens());

            CreateTitileLich(lvwDSLich);

        }

        //Methods
        private void CreateTiltileNV(ListView lvw)
        {
            lvw.Columns.Add("STT", 80);
            lvw.Columns.Add("Tên nhân viên", 120);
            lvw.Columns.Add("Chức vụ", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitileLich(ListView lvw)
        {
            lvw.Columns.Add("Tên nhân viên", 200);
            lvw.Columns.Add("Ngày đi làm", 200);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void LoadListEmployee(IEnumerable<NhanVien> nhanViens)
        {
            lvwDSNV.Items.Clear();
            int i = 1;

            foreach (NhanVien nv in nhanViens)
            {
                ListViewItem item = new ListViewItem();
                string chucVu = cvDAO.GetChucByID((int)nv.IDChucVu).TenChucVu;

                if (chucVu.StartsWith("Nhân") || chucVu.StartsWith("Trưởng"))
                {
                    item.Text = i.ToString();
                    item.SubItems.Add(nv.HoTen);
                    item.SubItems.Add(cvDAO.GetChucByID((int)nv.IDChucVu).TenChucVu);
                    item.Tag = nv;

                    lvwDSNV.Items.Add(item);
                    i++;
                }
            }
        }

        private void LoadListLich(IEnumerable<BangCongHC> bangCongs)
        {
            lvwDSLich.Items.Clear();

            foreach (BangCongHC bc in bangCongs)
            {
                ListViewItem item = new ListViewItem();
                nv = (NhanVien)lvwDSNV.SelectedItems[0].Tag;
                if (nv.ID == bc.IDNhanVien)
                {
                    item.Text = nv.HoTen;
                    item.SubItems.Add(bc.NgayCham.Value.Date.ToString("dd/MM/yyyy"));
                    item.Tag = bc;

                    lvwDSLich.Items.Add(item);
                }
            }

            if (lvwDSLich.Items.Count > 0)
            {
                lvwDSLich.SelectedIndices.Add(0);
            }
            lvwDSLich.Focus();
        }

        private void CreateNgayDiLam(TableLayoutPanel tbl)
        {
            tbl.Controls.Clear();
            string layThu = dtmNgay.Value.DayOfWeek.ToString();
            DateTime date = dtmNgay.Value.Date;

            int k = 0;
            if (layThu.Equals("Sunday"))
            {
                MessageBox.Show("Không phân lịch vào ngày chủ nhật", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                for (int i = 0; i < thuEng.Length; i++)
                {
                    if (layThu.Equals(thuEng[i]))
                    {
                        for (int j = i; j < thuEng.Length; j++)
                        {
                            Label lbl = new Label();
                            lbl.Name = "lbl" + j;
                            lbl.Text = thu[j] + " " + date.AddDays(k).ToString("dd/MM/yyyy");
                            lbl.Dock = DockStyle.Fill;
                            lbl.Font = new Font("Microsoft Sans Serif", 10);
                            lbl.TextAlign = ContentAlignment.MiddleCenter;

                            CheckBox check = new CheckBox();
                            check.Name = "cbo" + j;
                            check.Dock = DockStyle.Fill;
                            check.CheckAlign = ContentAlignment.MiddleCenter;

                            tbl.Controls.Add(lbl, j - i, 0);
                            tbl.Controls.Add(check, j - i, 1);
                            k++;
                        }
                        break;
                    }
                }
            }
        }

        private void LoadNgayDiLam()
        {
            tblThu.Controls.Clear();
            string[] mang;
            int i = 0;
            int j = 0;
            nv = (NhanVien)lvwDSNV.SelectedItems[0].Tag;

            if (lvwDSLich.Items.Count > 0)
            {
                BangCongHC bc = (BangCongHC)lvwDSLich.Items[0].Tag;

                if (nv.ID == bc.IDNhanVien)
                {
                    if (dtmNgay.Value.Date.ToString("dd/MM/yyyy").Equals(bc.NgayCham.Value.Date.ToString("dd/MM/yyyy")))
                    {
                        CreateNgayDiLam(tblThu);
                    }
                    else
                    {
                        dtmNgay.Value = bc.NgayCham.Value;
                    }

                    foreach (Control item in tblThu.Controls)
                    {
                        CheckBox check = item as CheckBox;
                        mang = tblThu.GetControlFromPosition(i, 0).Text.Split(new char[] { ' ' });

                        if (check != null)
                        {
                            if (j < lvwDSLich.Items.Count)
                            {
                                bc = (BangCongHC)lvwDSLich.Items[j].Tag;
                                if (bc.NgayCham.Value.ToString("dd/MM/yyyy").Equals(mang[2]))
                                {
                                    check.Checked = true;
                                    j++;
                                }
                            }
                            i++;
                        }
                    }
                }
            }
            //else
            //{
            //    MessageBox.Show("Nhân viên này chưa có lịch làm việc", "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}
        }

        private void PhanLich()
        {
            if (lvwDSNV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                nv = (NhanVien)lvwDSNV.SelectedItems[0].Tag;
                BangCongHC bc = null;
                string[] mang;
                int i = 0;

                if (dtmNgay.Value.Date == DateTime.Today.Date)
                {
                    MessageBox.Show("Bạn chưa chọn ngày bắt đầu đi làm cho nhân viên", "Thông báo", MessageBoxButtons.OK);
                }
                foreach (Control item in tblThu.Controls)
                {
                    CheckBox check = item as CheckBox;
                    if (check != null)
                    {
                        mang = tblThu.GetControlFromPosition(i, 0).Text.Split(new char[] { ' ' });
                        DateTime ngay = DateTime.ParseExact(mang[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        if (check.Checked == true)
                        {
                            bc = new BangCongHC();
                            bc.IDNhanVien = nv.ID;
                            bc.NgayCham = ngay;
                            bcDAO.AddLich(bc);
                        }
                        i++;
                    }
                }
            }
        }

        private void SuaBangCong()
        {
            if (lvwDSNV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                BangCongHC bc = (BangCongHC)lvwDSLich.Items[0].Tag;
                nv = (NhanVien)lvwDSNV.SelectedItems[0].Tag;

                string[] mang;
                int i = 0, j = 0;

                if (bc.IDNhanVien == nv.ID)
                {
                    foreach (Control item in tblThu.Controls)
                    {
                        CheckBox check = item as CheckBox;
                        if (check != null)
                        {
                            mang = tblThu.GetControlFromPosition(i, 0).Text.Split(new char[] { ' ' });
                            DateTime ngay = DateTime.ParseExact(mang[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            if (j < lvwDSLich.Items.Count)
                            {
                                bc = (BangCongHC)lvwDSLich.Items[j].Tag;
                                if (check.Checked == true)
                                {
                                    bc.NgayCham = ngay;
                                    bcDAO.UpdateBangCong(bc);
                                    j++;
                                }
                            }
                            else
                            {
                                if (ngay != bc.NgayCham && check.Checked == true)
                                {
                                    bc = new BangCongHC();
                                    bc.IDNhanVien = nv.ID;
                                    bc.NgayCham = ngay;
                                    bcDAO.AddLich(bc);
                                }
                            }
                            i++;
                        }
                    }

                    if (lvwDSLich.Items.Count - j > 0)
                    {
                        for (; j < lvwDSLich.Items.Count; j++)
                        {
                            if (j < lvwDSLich.Items.Count)
                            {
                                bc = (BangCongHC)lvwDSLich.Items[j].Tag;
                                bcDAO.RemoveBangCong(bc);
                            }
                        }
                    }
                }

            }
        }

        private void XoaBC()
        {
            if (lvwDSLich.Items.Count > 0)
            {
                BangCongHC bc = (BangCongHC)lvwDSLich.SelectedItems[0].Tag;
                bcDAO.RemoveBangCong(bc);
            }
        }

        // Events
        private void dtmNgay_ValueChanged(object sender, EventArgs e)
        {
            CreateNgayDiLam(tblThu);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            PhanLich();
            LoadListLich(bcDAO.GetBangCongHCs());
            LoadNgayDiLam();
        }

        private void lvwDSNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDSNV.SelectedItems.Count > 0)
            {
                LoadListLich(bcDAO.GetBangCongHCs());
                LoadNgayDiLam();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaBangCong();
            if (lvwDSNV.SelectedItems.Count > 0)
            {
                LoadListLich(bcDAO.GetBangCongHCs());
                LoadNgayDiLam();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaBC();
            if (lvwDSNV.SelectedItems.Count > 0)
            {
                LoadListLich(bcDAO.GetBangCongHCs());
                LoadNgayDiLam();
            }
        }

        private void btnSearchNV_Click(object sender, EventArgs e)
        {
            LoadListEmployee(nvDAO.GetListNVByName(txtTenNV.Text));
        }
    }
}
