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

namespace QLLuongSanPham.GUI.NhanVienGUI
{
    public partial class frmLuongNhanVien : Form
    {
        BangLuongDAO blDAO;
        BangCongCNDAO bcDAO;
        ChiTiet_BCSPDAO ctDAO;
        CaLamDAO caDAO;
        CongDoanDAO cdDAO;
        private NhanVien _nhanVien;

        public frmLuongNhanVien(NhanVien nhanVien)
        {
            InitializeComponent();
            blDAO = new BangLuongDAO();
            bcDAO = new BangCongCNDAO();
            ctDAO = new ChiTiet_BCSPDAO();
            caDAO = new CaLamDAO();
            cdDAO = new CongDoanDAO();

            this._nhanVien = nhanVien;
        }

        private void frmLuongNhanVien_Load(object sender, EventArgs e)
        {
            CreateTitle(lvwSalary);
            LoadLuongCN();
        }

        //Methods
        private void CreateTitle(ListView lvwListSalary)
        {
            lvwListSalary.Columns.Add("Ngày đi làm", 140);
            lvwListSalary.Columns.Add("Ca làm việc", 100);
            lvwListSalary.Columns.Add("Công đoạn làm việc", 180);
            lvwListSalary.Columns.Add("Giá công đoạn", 110);
            lvwListSalary.Columns.Add("Phụ cấp", 100);
            lvwListSalary.Columns.Add("Ghi chú", 430);

            lvwListSalary.View = View.Details;
            lvwListSalary.GridLines = true;
            lvwListSalary.FullRowSelect = true;
        }

        private void LoadLuongCN()
        {
            lvwSalary.Items.Clear();

            foreach (CT_BangCongSP ct in ctDAO.GetChiTiets())
            {
                foreach (BangCongSP bc in bcDAO.GetBangCongSPs())
                {
                    if (ct.ID_BCSP == bc.ID)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = bcDAO.GetByID(bc.ID).NgayDiLam.Value.Date.ToString("dd/MM/yyyy");
                        item.SubItems.Add(caDAO.GetByID(bcDAO.GetByID(bc.ID).IDCaLam.Value).TenCa);
                        item.SubItems.Add(cdDAO.GetById(bcDAO.GetByID(bc.ID).IDCongDoan.Value).TenCongDoan);
                        item.SubItems.Add(Convert.ToDecimal(cdDAO.GetById(bcDAO.GetByID(bc.ID).IDCongDoan.Value).DonGia).ToString());
                        item.SubItems.Add(0.ToString());

                        lvwSalary.Items.Add(item);
                    }
                }
            }
        }
    }
}