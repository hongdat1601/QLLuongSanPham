using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QLLuongSanPham.DAO;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.QuanLy
{
    public partial class frmPhanLichCN : Form
    {
        SanPhamDAO spDAO;
        NhanVienDAO nvDAO;
        BangCongCNDAO bcDAO;
        ChucVuDAO cvDAO;
        CongDoanDAO cdDAO;
        CaLamDAO caDAO;

        public frmPhanLichCN()
        {
            InitializeComponent();
            spDAO = new SanPhamDAO();
            nvDAO = new NhanVienDAO();
            bcDAO = new BangCongCNDAO();
            cvDAO = new ChucVuDAO();
            caDAO = new CaLamDAO();
            cdDAO = new CongDoanDAO();
        }

        #region Methods
        //Tạo tiêu đề
        private void CreateTitileSP(ListView lvw)
        {
            lvw.Columns.Add("Tên sản phẩm", 150);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitilePC(ListView lvw)
        {
            lvw.Columns.Add("Tên nhân viên", 120);
            lvw.Columns.Add("Chức vụ", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitileCN(ListView lvw)
        {
            lvw.Columns.Add("Tên nhân viên", 120);
            lvw.Columns.Add("Chức vụ", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void CreateTitileLich(ListView lvw)
        {
            lvw.Columns.Add("Tên nhân viên", 120);
            lvw.Columns.Add("Ngày làm việc", 120);
            lvw.Columns.Add("Tên công đoạn", 120);
            lvw.Columns.Add("Tên ca làm việc", 120);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        //Load data
        private void LoadListSanPham(IEnumerable<SanPham> sanPhams)
        {
            lvwDSSP.Items.Clear();
            ListViewItem item;

            foreach (SanPham sp in sanPhams)
            {
                item = new ListViewItem();
                item.Text = sp.TenSP;
                item.Tag = sp;

                lvwDSSP.Items.Add(item);
            }
            if (lvwDSSP.Items.Count > 0)
            {
                lvwDSSP.SelectedIndices.Add(0);
            }
            lvwDSSP.Focus();
        }

        private int GetIDNVByCD(int id, IEnumerable<BangCongSP> bangCongSPs)
        {
            foreach (BangCongSP bc in bangCongSPs)
            {
                if (bc.IDCongDoan == id)
                {
                    id = bc.ID_NhanVien.Value;
                    return id;
                }
            }
            return 0;
        }

        private ListViewItem CreateItems(NhanVien nv)
        {
            string chucVu = cvDAO.GetChucByID(nv.IDChucVu.Value).TenChucVu;
            if (chucVu.StartsWith("Công"))
            {
                ListViewItem item = new ListViewItem();
                item.Text = nv.HoTen;
                item.SubItems.Add(chucVu);
                item.Tag = nv;

                return item;
            }
            return null;

        }

        private void LoadListCN(IEnumerable<NhanVien> nhanViens)
        {
            lvwDSNV.Items.Clear();

            foreach (NhanVien nv in nhanViens)
            {
                if (CreateItems(nv) != null)
                {
                    if (lvwDSPC.Items.Count == 0)
                    {
                        lvwDSNV.Items.Add(CreateItems(nv));
                    }
                    else if (nv.ID != GetIDNVByCD(cdDAO.GetByName(cboTenCD.Text).ID, bcDAO.GetBangCongSPs()) && CheckName(lvwDSPC, nv) == false)
                    {
                        lvwDSNV.Items.Add(CreateItems(nv));
                    }
                }
            }
        }

        private void LoadListPC(IEnumerable<NhanVien> nhanViens)
        {
            lvwDSPC.Items.Clear();

            foreach (NhanVien nv in nhanViens)
            {
                if (CreateItems(nv) != null)
                {
                    if (CheckName(lvwDSNV, nv) == false)
                    {
                        foreach (BangCongSP bc in bcDAO.GetByIDCd(cdDAO.GetByName(cboTenCD.Text).ID))
                        {
                            if (bc.ID_NhanVien == nv.ID)
                            {
                                lvwDSPC.Items.Add(CreateItems(nv));
                            }
                        }
                    }
                }
            }
        }

        private void LoadCa(IEnumerable<CaLam> caLams)
        {
            cboCa.Items.Clear();

            foreach (CaLam ca in caLams)
            {
                cboCa.Items.Add(ca.TenCa);
            }
            cboCa.SelectedIndex = 0;
        }

        private void LoadCD(IEnumerable<CongDoan> congDoans)
        {
            cboTenCD.Items.Clear();

            foreach (CongDoan cd in congDoans)
            {
                cboTenCD.Items.Add(cd.TenCongDoan);
            }
            cboTenCD.SelectedIndex = 0;
        }

        private int GetIDCaByCD(int id, IEnumerable<BangCongSP> bangCongSPs)
        {
            foreach (BangCongSP item in bangCongSPs)
            {
                if (item.IDCongDoan == id)
                    return item.IDCaLam.Value;
            }
            return 0;
        }

        private bool CheckName(ListView lvw1, NhanVien nv)
        {
            for (int i = lvw1.Items.Count - 1; i >= 0; i--)
            {
                if (lvw1.Items[i].Text == nv.HoTen)
                {
                    return true;
                }
            }

            return false;
        }
        private void EnableTxt()
        {
            dtmNgay.Enabled = true;
            cboTenCD.Enabled = true;
            cboCa.Enabled = true;
        }

        private void DisableTxt()
        {
            dtmNgay.Enabled = false;
            txtTenSpInput.Enabled = false;
            cboTenCD.Enabled = false;
            cboCa.Enabled = false;
        }

        private void ClearTxt()
        {
            dtmNgay.Value = DateTime.Today;
            cboTenCD.SelectedIndex = 0;
            cboCa.SelectedIndex = 0;
        }

        private void AddLich()
        {
            int count = lvwDSPC.Items.Count;

            for (int i = 0; i < count; i++)
            {
                NhanVien nv = (NhanVien)lvwDSPC.Items[i].Tag;
                BangCongSP bc = new BangCongSP()
                {
                    IDCongDoan = cdDAO.GetByName(cboTenCD.Text).ID,
                    IDCaLam = caDAO.GetIDByName(cboCa.Text),
                    NgayDiLam = dtmNgay.Value.Date,
                    ID_NhanVien = nv.ID,
                    SoLuongSP = 0
                };
                bcDAO.AddBCCN(bc);
            }
        }

        private void LoadListLich(int idCD, IEnumerable<BangCongSP> bangCongSPs)
        {
            lvwDSLich.Items.Clear();

            foreach (BangCongSP bc in bangCongSPs)
            {
                if (idCD == bc.IDCongDoan)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = nvDAO.GetById(bc.ID_NhanVien.Value).HoTen;
                    item.SubItems.Add(bc.NgayDiLam.Value.Date.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(cdDAO.GetById(bc.IDCongDoan.Value).TenCongDoan);
                    item.SubItems.Add(caDAO.GetByID(bc.IDCaLam.Value).TenCa);
                    lvwDSLich.Items.Add(item);
                }
            }
        }
        #endregion

        #region Events

        private void frmPhanLichCN_Load(object sender, EventArgs e)
        {
            // Tạo tiêu đề cột
            CreateTitileSP(lvwDSSP);
            CreateTitilePC(lvwDSPC);
            CreateTitileCN(lvwDSNV);
            CreateTitileLich(lvwDSLich);

            // Load data
            LoadListSanPham(spDAO.GetSanPhams());
            LoadCa(caDAO.GetCaLams());
        }

        private void lvwDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDSSP.SelectedItems.Count > 0)
            {
                lvwDSNV.Items.Clear();
                SanPham sp = (SanPham)lvwDSSP.SelectedItems[0].Tag;
                IEnumerable<CongDoan> listCD = cdDAO.GetCongDoansByIdSanPham(sp.ID);
                LoadCa(caDAO.GetCaLams());
                LoadCD(cdDAO.GetCongDoansByIdSanPham(sp.ID));

                txtTenSpInput.Text = sp.TenSP;
                if (cboTenCD.Items.Count == 0)
                {
                    cboTenCD.Items.Clear();
                    foreach (CongDoan cd in listCD)
                    {
                        cboTenCD.Items.Add(cd.TenCongDoan);
                    }
                    cboTenCD.SelectedIndex = 0;
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int dem = lvwDSNV.SelectedItems.Count;
            while (dem >= 0)
            {
                if (lvwDSNV.SelectedItems.Count > 0)
                {
                    NhanVien nv = (NhanVien)lvwDSNV.SelectedItems[0].Tag;

                    if (lvwDSPC.Items.Count == 0)
                    {
                        lvwDSPC.Items.Add(CreateItems(nv));
                        lvwDSNV.Items.Remove(lvwDSNV.SelectedItems[0]);
                    }
                    else
                    {
                        if (CheckName(lvwDSPC, nv) == false)
                        {
                            lvwDSPC.Items.Add(CreateItems(nv));
                            lvwDSNV.Items.Remove(lvwDSNV.SelectedItems[0]);
                        }
                    }
                }
                dem--;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int dem = lvwDSPC.SelectedItems.Count;
            while (dem >= 0)
            {
                if (lvwDSPC.SelectedItems.Count > 0)
                {
                    NhanVien nv = (NhanVien)lvwDSPC.SelectedItems[0].Tag;

                    if (lvwDSNV.Items.Count == 0)
                    {
                        lvwDSNV.Items.Add(CreateItems(nv));
                        lvwDSPC.Items.Remove(lvwDSPC.SelectedItems[0]);
                    }
                    else
                    {
                        if (CheckName(lvwDSNV, nv) == false)
                        {
                            lvwDSNV.Items.Add(CreateItems(nv));
                            lvwDSPC.Items.Remove(lvwDSPC.SelectedItems[0]);
                        }
                    }
                }
                dem--;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lvwDSSP.SelectedItems.Count > 0)
            {
                if (btnThem.Text.Equals("Phân lịch"))
                {
                    ClearTxt();
                    EnableTxt();

                    btnThem.Text = "Lưu";
                    btnThem.IconChar = FontAwesome.Sharp.IconChar.Save;
                    btnThem.IconColor = Color.Blue;
                }
                else
                {
                    DisableTxt();

                    btnThem.Text = "Phân lịch";
                    btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
                    btnThem.IconColor = Color.FromArgb(128, 255, 128);

                    AddLich();
                    LoadListLich(cdDAO.GetByName(cboTenCD.Text).ID, bcDAO.GetBangCongSPs());
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnTimDSSP_Click(object sender, EventArgs e)
        {
            LoadListSanPham(spDAO.GetSPByChar(txtSpSearch.Text));
        }

        #endregion

        private void cboTenCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCD = cdDAO.GetByName(cboTenCD.Text).ID;
            if (GetIDCaByCD(idCD, bcDAO.GetBangCongSPs()) != 0)
            {
                lvwDSNV.Items.Clear();
                cboCa.Text = caDAO.GetByID(GetIDCaByCD(idCD, bcDAO.GetBangCongSPs())).TenCa;
                LoadListPC(nvDAO.GetNhanViens());
                LoadListLich(idCD, bcDAO.GetBangCongSPs());
                LoadListCN(nvDAO.GetNhanViens());
            }
            else
            {
                lvwDSPC.Items.Clear();
                cboCa.Items.Clear();
                foreach (CaLam ca in caDAO.GetCaLams())
                {
                    cboCa.Items.Add(ca.TenCa);
                }
                cboCa.SelectedIndex = 0;
                LoadListCN(nvDAO.GetNhanViens());
                LoadListLich(idCD, bcDAO.GetBangCongSPs());
            }
        }
    }
}
