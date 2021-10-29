using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLuongSanPham.Presentation.NhanVien
{
    public partial class frmLuongNhanVien : Form
    {
        public frmLuongNhanVien()
        {
            InitializeComponent();
        }

        private void frmLuongNhanVien_Load(object sender, EventArgs e)
        {
            CreateTitle(lvwSalary);
        }

        //Methods
        private void CreateTitle(ListView lvwListSalary)
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
    }
}
