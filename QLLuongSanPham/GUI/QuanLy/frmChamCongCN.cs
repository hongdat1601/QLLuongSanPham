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
    public partial class frmChamCongCN : Form
    {
        BangCongCNDAO bangCongDAO;
        ChiTiet_BCSPDAO bangCongCTDAO;
        CaLamDAO caLamDAO;
        CongDoanDAO congDoanDAO;
        NhanVienDAO nhanVienDAO;

        public frmChamCongCN()
        {
            InitializeComponent();
            bangCongDAO = new BangCongCNDAO();
            bangCongCTDAO = new ChiTiet_BCSPDAO();
            caLamDAO = new CaLamDAO();
            congDoanDAO = new CongDoanDAO();
            nhanVienDAO = new NhanVienDAO();
        }

        private void frmChamCongCN_Load(object sender, EventArgs e)
        {
            CreateList();
        }

        private void CreateList()
        {
            lstvLich.GridLines = true;
            lstvLich.FullRowSelect = true;
            lstvLich.View = View.Details;

            CreateColumn();
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            caLamDAO.GetCaLams().ToList().ForEach(x => cboTenCa.Items.Add(x.TenCa));
            cboTenCa.SelectedIndex = 0;
        }

        private void CreateColumn()
        {
            lstvLich.Columns.Add("STT", 70);
            lstvLich.Columns.Add("Tên nhân viên", 210);
            lstvLich.Columns.Add("Công đoạn", 210);
            lstvLich.Columns.Add("Số lượng", 120);
        }

        private void LoadData(BangCongSP bangCong)
        {
            var data = bangCongCTDAO.GetByIDBangCong(bangCong.ID);
            int stt = 1;

            foreach(CT_BangCongSP ct in data)
            {
                ListViewItem item = new ListViewItem();

                item.Text = stt.ToString();
                item.SubItems.Add(nhanVienDAO.GetById(ct.ID_NV).HoTen);


                lstvLich.Items.Add(item);
                stt++;
            }
        }

        private void dtmNgayLam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboTenCa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
