using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QLLuongSanPham.Entities;

namespace QLLuongSanPham.GUI.NhanVienGUI
{
    public partial class frmNVChinh : Form
    {
        //Fields
        private IconButton cureentButton;
        private Panel leftBorderBtn;
        private Form activeForm;
        private NhanVien nhanVien;

        //Construstor
        public frmNVChinh(NhanVien nhanVien)
        {
            InitializeComponent();
            CollapseMenu();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.nhanVien = nhanVien;
        }

        private void frmMainEmployee_Load(object sender, EventArgs e)
        {
            OpenFormChild(new frmTongQuan(nhanVien));

        }

        //Structs
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(129, 61, 191);
            public static Color color2 = Color.FromArgb(255, 203, 59);
            public static Color color3 = Color.FromArgb(241, 98, 86);
        }

        //Methods
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                cureentButton = (IconButton)senderBtn;
                cureentButton.BackColor = Color.FromArgb(22, 146, 224);
                cureentButton.ForeColor = color;
                cureentButton.TextAlign = ContentAlignment.MiddleCenter;
                cureentButton.IconColor = color;
                cureentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                cureentButton.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, cureentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (cureentButton != null)
            {
                cureentButton.BackColor = Color.FromArgb(75, 218, 161);
                cureentButton.ForeColor = Color.White;
                cureentButton.TextAlign = ContentAlignment.MiddleLeft;
                cureentButton.IconColor = Color.White;
                cureentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                cureentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenFormChild(Form formChild)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = formChild;
            formChild.TopLevel = false;
            formChild.Dock = DockStyle.Fill;

            pnlDesktop.Controls.Add(activeForm);
            activeForm.BringToFront();
            activeForm.Show();
        }

        // Events
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color1);
            OpenFormChild(new frmTongQuan(nhanVien));
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color2);
            frmThongtinNV frmTT = new frmThongtinNV(nhanVien);
            OpenFormChild(frmTT);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColor.color3);
            OpenFormChild(new frmLuongNhanVien(nhanVien));
        }

        private void btnBars_Click(object sender, EventArgs e)
        {
            CollapseMenu();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 50;
                pcbLogo.Visible = false;
                btnBars.Dock = DockStyle.Top;
                panelLogo.BorderStyle = BorderStyle.None;
                lblName.Text = "";
                btnHome.IconChar = IconChar.None;
                btnInfor.IconChar = IconChar.None;
                btnSalary.IconChar = IconChar.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                    menuButton.Enabled = false;
                }
                btnExit.Enabled = true;
            }
            else
            {
                panelMenu.Width = 250;
                pcbLogo.Visible = true;
                btnBars.Dock = DockStyle.None;
                panelLogo.BorderStyle = BorderStyle.Fixed3D;
                lblName.Text = nhanVien.HoTen;
                btnHome.IconChar = IconChar.Home;
                btnInfor.IconChar = IconChar.Info;
                btnSalary.IconChar = IconChar.MoneyCheckAlt;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "" + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 20, 0);
                    menuButton.Enabled = true;
                }
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTab_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int VM_NCCALCSIZE = 0x0083;
            if (m.Msg == VM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        //Xử lý button show
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnShow.IconChar = IconChar.Clone;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                btnShow.IconChar = IconChar.WindowRestore;
            }
        }

        // Thoát form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }
    }
}
