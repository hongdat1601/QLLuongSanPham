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
    public partial class frmPhanLichCN : Form
    {
        SanPhamDAO spDAO;
        NhanVienDAO nvDAO;
        BangCongCNDAO bcDAO;
        ChucVuDAO cvDAO;
        CongDoanDAO cdDAO;
        CaLamDAO caDAO;
        ChiTiet_BCSPDAO ctDAO;
        BCCN_CT_NVDAO bc_ctDAO;

        public frmPhanLichCN()
        {
            InitializeComponent();
            spDAO = new SanPhamDAO();
            nvDAO = new NhanVienDAO();
            bcDAO = new BangCongCNDAO();
            cvDAO = new ChucVuDAO();
            caDAO = new CaLamDAO();
            cdDAO = new CongDoanDAO();
            ctDAO = new ChiTiet_BCSPDAO();
            bc_ctDAO = new BCCN_CT_NVDAO();
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
            lvwDSLich.Items.Clear();
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

        public bool CheckNameNV(string name, ListView list)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                if (name.Equals(list.Items[i].SubItems[0].Text))
                {
                    return true;
                }
            }
            return false;
        }

        private void LoadListCNDynamic(IEnumerable<dynamic> list)
        {
            ListViewItem item;
            lvwDSNV.Items.Clear();

            foreach (dynamic nv in list)
            {
                item = new ListViewItem();
                string tenCV = bc_ctDAO.GetNameChucVu(nv.chucvu);

                if (lvwDSPC.Items.Count == 0)
                {
                    if (tenCV.StartsWith("Công"))
                    {
                        item.Text = nv.ten;
                        item.SubItems.Add(tenCV);
                        item.Tag = nv;

                        lvwDSNV.Items.Add(item);
                    }
                }
                else if (CheckNameNV(nv.ten, lvwDSPC) == false )
                {
                    if (tenCV.StartsWith("Công"))
                    {
                        item.Text = nv.ten;
                        item.SubItems.Add(tenCV);
                        item.Tag = nv;

                        lvwDSNV.Items.Add(item);
                    }
                }
            }


        }

        private void LoadListPCDynamic(IEnumerable<dynamic> list)
        {
            ListViewItem item;
            lvwDSPC.Items.Clear();
            foreach (var nv in list)
            {
                if(CheckNameNV(nv.ten, lvwDSPC) == true)
                {
                    break;
                }
                item = new ListViewItem();
                item.Text = nv.ten;
                item.Tag = nv;

                lvwDSPC.Items.Add(item);
            }
        }


        private void LoadListLich()
        {
            lvwDSLich.Items.Clear();
            SanPham sp = (SanPham)lvwDSSP.SelectedItems[0].Tag;

            foreach (dynamic bc in bc_ctDAO.GetIDAndTenNVByIDSP(sp.ID))
            {
                ListViewItem item = new ListViewItem();
                item.Text = bc.ten;
                item.SubItems.Add(bc.ngay.ToString("dd/MM/yyyy"));
                item.SubItems.Add(cdDAO.GetById(bc.idCD).TenCongDoan);
                item.SubItems.Add(caDAO.GetByID(bc.idCa).TenCa);

                lvwDSLich.Items.Add(item);
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

        private bool CheckCDInBC(IEnumerable<CongDoan> congDoans, IEnumerable<BangCongSP> bangCongSPs)
        {
            foreach (BangCongSP item in bangCongSPs)
            {
                foreach (CongDoan cd in congDoans)
                {
                    if (item.IDCongDoan == cd.ID)
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

            if (count > 0)
            {

                BangCongSP bc = new BangCongSP();
                CT_BangCongSP ct;
                dynamic nv;

                bc.IDCaLam = caDAO.GetIDByName(cboCa.Text);
                bc.IDCongDoan = cdDAO.GetByName(cboTenCD.Text).ID;
                bc.SoLuongNguoi = count;
                bc.NgayDiLam = dtmNgay.Value;
                bcDAO.AddBCCN(bc);

                for (int i = 0; i < count; i++)
                {
                    nv = lvwDSPC.Items[i].Tag;
                    ct = new CT_BangCongSP();
                    ct.ID_NV = nv.id;
                    ct.ID_BCSP = bc.ID;

                    ctDAO.AddCTBC(ct);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa phân công nhân viên", "Thông báo", MessageBoxButtons.OK);
                return;
            }

        }

        private int GetCAbyCD()
        {
            int idCD = cdDAO.GetByName(cboTenCD.Text).ID;
            int idCA;

            foreach (BangCongSP item in bcDAO.GetBangCongSPs())
            {
                if(idCD == item.IDCongDoan)
                {
                    idCA = (int)item.IDCaLam;
                    return idCA;
                }
            }
            return 0;
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
                int idCDInBC;
                txtTenSpInput.Text = sp.TenSP;

                if (CheckCDInBC(listCD, bcDAO.GetBangCongSPs()) == true)
                {
                    foreach (BangCongSP bc in bcDAO.GetBangCongSPs())
                    {
                        foreach (CongDoan cd in listCD)
                        {
                            if (cd.ID == bc.IDCongDoan)
                            {
                                idCDInBC = (int)bc.IDCongDoan;
                                cboTenCD.Text = cdDAO.GetById(idCDInBC).TenCongDoan;
                            }
                        }
                    } 
                    cboCa.Text = caDAO.GetByID(GetCAbyCD()).TenCa;
                    LoadListPCDynamic(bc_ctDAO.GetIDAndTenNVByIDSP(sp.ID));
                    LoadListCNDynamic(bc_ctDAO.GetAllNV());
                    LoadListLich();
                }
                else
                {
                    lvwDSPC.Items.Clear();
                    lvwDSNV.Items.Clear();
                    cboTenCD.Text = "";
                    cboCa.Text = "";

                    LoadListCNDynamic(bc_ctDAO.GetAllNV());
                    LoadListLich();
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lvwDSNV.SelectedItems.Count > 0)
            {
                dynamic nv;
                int i = lvwDSNV.Items.Count - 1;
                int k = 0;
                ListViewItem item;

                while (i >= 0 && lvwDSNV.SelectedItems.Count > 0)
                {
                    nv = lvwDSNV.SelectedItems[k].Tag;
                    item = new ListViewItem();

                    if (lvwDSPC.Items.Count == 0)
                    {
                        item.Text = nv.ten;
                        item.Tag = nv;

                        lvwDSPC.Items.Add(item);
                        i--;
                    }
                    else if (CheckNameNV(nv.ten, lvwDSPC) == false)
                    {
                        item.Text = nv.ten;
                        item.Tag = nv;

                        lvwDSPC.Items.Add(item);
                        i--;
                    }

                    if (lvwDSNV.SelectedItems.Count > 0)
                    {
                        lvwDSNV.SelectedItems[k].Remove();
                    }
                }
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lvwDSPC.SelectedItems.Count > 0)
            {
                dynamic nv;
                int i = lvwDSPC.Items.Count - 1;
                int k = 0;
                ListViewItem item;

                while (i >= 0 && lvwDSPC.SelectedItems.Count > 0)
                {
                    nv = lvwDSPC.SelectedItems[k].Tag;
                    item = new ListViewItem();
                    string tenCV = bc_ctDAO.GetNameChucVu(nv.chucvu);
                    if (lvwDSNV.Items.Count == 0)
                    {
                        if (tenCV.StartsWith("Công"))
                        {
                            item.Text = nv.ten;
                            item.SubItems.Add(tenCV);
                            item.Tag = nv;

                            lvwDSNV.Items.Add(item);
                            i--;
                        }
                    }
                    if (CheckNameNV(nv.ten, lvwDSNV) == false)
                    {
                        if (tenCV.StartsWith("Công"))
                        {
                            item.Text = nv.ten;
                            item.SubItems.Add(tenCV);
                            item.Tag = nv;

                            lvwDSNV.Items.Add(item);
                            i--;
                        }
                    }

                    if (lvwDSPC.Items[k].Selected)
                    {
                        lvwDSPC.Items[k].Remove();
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lvwDSSP.SelectedItems.Count > 0)
            {
                SanPham sp = (SanPham)lvwDSSP.SelectedItems[0].Tag;
                if (btnThem.Text.Equals("Phân lịch"))
                {
                    LoadCa(caDAO.GetCaLams());
                    LoadCD(cdDAO.GetCongDoansByIdSanPham(sp.ID));

                    ClearTxt();
                    EnableTxt();
                   

                    btnThem.Text = "Lưu";
                    btnThem.IconChar = FontAwesome.Sharp.IconChar.Save;
                    btnThem.IconColor = Color.Blue;

                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    DisableTxt();

                    btnThem.Text = "Phân lịch";
                    btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
                    btnThem.IconColor = Color.FromArgb(128, 255, 128);

                    AddLich();

                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    LoadListLich();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm", "Thông báo", MessageBoxButtons.OK);
            }
        }
        #endregion


    }
}
