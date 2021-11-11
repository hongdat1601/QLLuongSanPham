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

namespace QLLuongSanPham.GUI.NhanVienGUI
{
    public partial class frmLuongNhanVien : Form
    {
        //BangLuongDAO blDAO;
        //BangCongCNDAO bcDAO;
        //ChiTiet_BCSPDAO ctDAO;
        //CaLamDAO caDAO;
        //CongDoanDAO cdDAO;
        BangCongHCDAO hcDAO;
        LoaiPhepDAO phepDAO;
        private NhanVien _nhanVien;

        public frmLuongNhanVien(NhanVien nhanVien)
        {
            InitializeComponent();
            //blDAO = new BangLuongDAO();
            //bcDAO = new BangCongCNDAO();
            //ctDAO = new ChiTiet_BCSPDAO();
            //caDAO = new CaLamDAO();
            //cdDAO = new CongDoanDAO();
            hcDAO = new BangCongHCDAO();
            phepDAO = new LoaiPhepDAO();

            this._nhanVien = nhanVien;
        }

        private void frmLuongNhanVien_Load(object sender, EventArgs e)
        {
        //    if(_nhanVien.IDChucVu == 7)
        //    {
        //        CreateTitleCN(lvwSalary);
        //        LoadLuongCN();
        //    }
        //    else
        //    {
        //        CreateTitleNV(lvwSalary);
        //        LoadLuongHC();
        //    }
           
        }

        //Methods
        private void CreateTitleCN(ListView lvwListSalary)
        {
            lvwListSalary.Columns.Add("Ngày đi làm", 140);
            lvwListSalary.Columns.Add("Ca làm việc", 100);
            lvwListSalary.Columns.Add("Công đoạn làm việc", 180);
            lvwListSalary.Columns.Add("Giá công đoạn", 110);
            lvwListSalary.Columns.Add("Phụ cấp", 100);
            lvwListSalary.Columns.Add("Thưởng/phạt", 120);
            lvwListSalary.Columns.Add("Ghi chú", 430);

            lvwListSalary.View = View.Details;
            lvwListSalary.GridLines = true;
            lvwListSalary.FullRowSelect = true;
        }

        private void CreateTitleNV(ListView lvw)
        {
            lvw.Columns.Add("Ngày đi làm", 140);
            lvw.Columns.Add("Phụ cấp", 130);
            lvw.Columns.Add("Ghi chú", 430);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        //private void LoadLuongCN()
        //{
        //    lvwSalary.Items.Clear();

        //    foreach (CT_BangCongSP ct in ctDAO.GetChiTiets())
        //    {
        //        foreach (BangCongSP bc in bcDAO.GetBangCongSPs())
        //        {
        //            if (ct.ID_BCSP == bc.ID && ct.ID_NV == _nhanVien.ID)
        //            {
        //                ListViewItem item = new ListViewItem();
        //                item.Text = bcDAO.GetByID(bc.ID).NgayDiLam.Value.Date.ToString("dd/MM/yyyy");
        //                item.SubItems.Add(caDAO.GetByID(bcDAO.GetByID(bc.ID).IDCaLam.Value).TenCa);
        //                item.SubItems.Add(cdDAO.GetById(bcDAO.GetByID(bc.ID).IDCongDoan.Value).TenCongDoan);
        //                item.SubItems.Add(Convert.ToDecimal(cdDAO.GetById(bcDAO.GetByID(bc.ID).IDCongDoan.Value).DonGia).ToString());
        //                item.SubItems.Add(0.ToString());

        //                lvwSalary.Items.Add(item);
        //            }
        //        }
        //    }
        //}

        private void LoadLuongHC()
        {
            lvwSalary.Items.Clear();

            foreach (BangCongHC hc in hcDAO.GetBangCongHCs())
            {
                if(hc.IDNhanVien == _nhanVien.ID)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = hc.NgayCham.Value.Date.ToString("dd/MM/yyyy");
                    if(hc.IDLoaiPhep != null)
                    {
                        item.SubItems.Add(Convert.ToDecimal(phepDAO.GetByID(hc.IDLoaiPhep.Value).PhuCap).ToString());
                    }

                    lvwSalary.Items.Add(item);
                }
            }
        }

        private void Search()
        {
            
        }
    }
}
