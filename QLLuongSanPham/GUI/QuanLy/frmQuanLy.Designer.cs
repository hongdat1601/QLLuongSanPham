
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmQuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.btnThongKeSP = new FontAwesome.Sharp.IconButton();
            this.btnThongKeHC = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.btnTimKiemSP = new FontAwesome.Sharp.IconButton();
            this.btnTimKiemNV = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.pnlXuLy = new System.Windows.Forms.Panel();
            this.btnCongDoan = new FontAwesome.Sharp.IconButton();
            this.btnXuLyTinhLuong = new FontAwesome.Sharp.IconButton();
            this.btnXuLyChamCong = new FontAwesome.Sharp.IconButton();
            this.btnXuLyPhanCa = new FontAwesome.Sharp.IconButton();
            this.btnXuLy = new FontAwesome.Sharp.IconButton();
            this.pnlDanhMuc = new System.Windows.Forms.Panel();
            this.btnCaLam = new FontAwesome.Sharp.IconButton();
            this.btnPhongBan = new FontAwesome.Sharp.IconButton();
            this.btnHopDong = new FontAwesome.Sharp.IconButton();
            this.btnSanPham = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnDanhMuc = new FontAwesome.Sharp.IconButton();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.pnlSeperate = new System.Windows.Forms.Panel();
            this.picAvatar = new FontAwesome.Sharp.IconPictureBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.ptcMain = new System.Windows.Forms.PictureBox();
            this.pnLeft.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlThongKe.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            this.pnlXuLy.SuspendLayout();
            this.pnlDanhMuc.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(142)))), ((int)(((byte)(227)))));
            this.pnLeft.Controls.Add(this.btnDangXuat);
            this.pnLeft.Controls.Add(this.pnlMenu);
            this.pnLeft.Controls.Add(this.pnlInfo);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(320, 1102);
            this.pnLeft.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnDangXuat.IconColor = System.Drawing.Color.White;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 1039);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(320, 63);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(142)))), ((int)(((byte)(227)))));
            this.pnlMenu.Controls.Add(this.pnlThongKe);
            this.pnlMenu.Controls.Add(this.btnThongKe);
            this.pnlMenu.Controls.Add(this.pnlTimKiem);
            this.pnlMenu.Controls.Add(this.btnTimKiem);
            this.pnlMenu.Controls.Add(this.pnlXuLy);
            this.pnlMenu.Controls.Add(this.btnXuLy);
            this.pnlMenu.Controls.Add(this.pnlDanhMuc);
            this.pnlMenu.Controls.Add(this.btnDanhMuc);
            this.pnlMenu.Location = new System.Drawing.Point(0, 324);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(317, 592);
            this.pnlMenu.TabIndex = 2;
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlThongKe.Controls.Add(this.btnThongKeSP);
            this.pnlThongKe.Controls.Add(this.btnThongKeHC);
            this.pnlThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongKe.Location = new System.Drawing.Point(0, 966);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(296, 127);
            this.pnlThongKe.TabIndex = 19;
            // 
            // btnThongKeSP
            // 
            this.btnThongKeSP.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThongKeSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKeSP.FlatAppearance.BorderSize = 0;
            this.btnThongKeSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeSP.ForeColor = System.Drawing.Color.White;
            this.btnThongKeSP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThongKeSP.IconColor = System.Drawing.Color.White;
            this.btnThongKeSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKeSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeSP.Location = new System.Drawing.Point(0, 63);
            this.btnThongKeSP.Name = "btnThongKeSP";
            this.btnThongKeSP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongKeSP.Size = new System.Drawing.Size(296, 63);
            this.btnThongKeSP.TabIndex = 10;
            this.btnThongKeSP.Text = "Lương Sản Phẩm";
            this.btnThongKeSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKeSP.UseVisualStyleBackColor = false;
            this.btnThongKeSP.Click += new System.EventHandler(this.btnThongKeSP_Click);
            // 
            // btnThongKeHC
            // 
            this.btnThongKeHC.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThongKeHC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeHC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKeHC.FlatAppearance.BorderSize = 0;
            this.btnThongKeHC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeHC.ForeColor = System.Drawing.Color.White;
            this.btnThongKeHC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThongKeHC.IconColor = System.Drawing.Color.White;
            this.btnThongKeHC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKeHC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeHC.Location = new System.Drawing.Point(0, 0);
            this.btnThongKeHC.Name = "btnThongKeHC";
            this.btnThongKeHC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongKeHC.Size = new System.Drawing.Size(296, 63);
            this.btnThongKeHC.TabIndex = 9;
            this.btnThongKeHC.Text = "Lương Hành Chánh";
            this.btnThongKeHC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeHC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKeHC.UseVisualStyleBackColor = false;
            this.btnThongKeHC.Click += new System.EventHandler(this.btnThongKeHC_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(142)))), ((int)(((byte)(227)))));
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 903);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(296, 63);
            this.btnThongKe.TabIndex = 18;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnClick);
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTimKiem.Controls.Add(this.btnTimKiemSP);
            this.pnlTimKiem.Controls.Add(this.btnTimKiemNV);
            this.pnlTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimKiem.Location = new System.Drawing.Point(0, 769);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(296, 134);
            this.pnlTimKiem.TabIndex = 17;
            // 
            // btnTimKiemSP
            // 
            this.btnTimKiemSP.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimKiemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimKiemSP.FlatAppearance.BorderSize = 0;
            this.btnTimKiemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSP.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemSP.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTimKiemSP.IconColor = System.Drawing.Color.White;
            this.btnTimKiemSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemSP.Location = new System.Drawing.Point(0, 63);
            this.btnTimKiemSP.Name = "btnTimKiemSP";
            this.btnTimKiemSP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTimKiemSP.Size = new System.Drawing.Size(296, 63);
            this.btnTimKiemSP.TabIndex = 9;
            this.btnTimKiemSP.Text = "Sản Phẩm";
            this.btnTimKiemSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiemSP.UseVisualStyleBackColor = false;
            this.btnTimKiemSP.Click += new System.EventHandler(this.btnTimKiemSP_Click);
            // 
            // btnTimKiemNV
            // 
            this.btnTimKiemNV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTimKiemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimKiemNV.FlatAppearance.BorderSize = 0;
            this.btnTimKiemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNV.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemNV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTimKiemNV.IconColor = System.Drawing.Color.White;
            this.btnTimKiemNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemNV.Location = new System.Drawing.Point(0, 0);
            this.btnTimKiemNV.Name = "btnTimKiemNV";
            this.btnTimKiemNV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTimKiemNV.Size = new System.Drawing.Size(296, 63);
            this.btnTimKiemNV.TabIndex = 8;
            this.btnTimKiemNV.Text = "Nhân Viên";
            this.btnTimKiemNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiemNV.UseVisualStyleBackColor = false;
            this.btnTimKiemNV.Click += new System.EventHandler(this.btnTimKiemNV_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(142)))), ((int)(((byte)(227)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.White;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(0, 706);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(296, 63);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnClick);
            // 
            // pnlXuLy
            // 
            this.pnlXuLy.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlXuLy.Controls.Add(this.btnCongDoan);
            this.pnlXuLy.Controls.Add(this.btnXuLyTinhLuong);
            this.pnlXuLy.Controls.Add(this.btnXuLyChamCong);
            this.pnlXuLy.Controls.Add(this.btnXuLyPhanCa);
            this.pnlXuLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlXuLy.Location = new System.Drawing.Point(0, 449);
            this.pnlXuLy.Name = "pnlXuLy";
            this.pnlXuLy.Size = new System.Drawing.Size(296, 257);
            this.pnlXuLy.TabIndex = 15;
            // 
            // btnCongDoan
            // 
            this.btnCongDoan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCongDoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCongDoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCongDoan.FlatAppearance.BorderSize = 0;
            this.btnCongDoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongDoan.ForeColor = System.Drawing.Color.White;
            this.btnCongDoan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCongDoan.IconColor = System.Drawing.Color.White;
            this.btnCongDoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCongDoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCongDoan.Location = new System.Drawing.Point(0, 189);
            this.btnCongDoan.Name = "btnCongDoan";
            this.btnCongDoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCongDoan.Size = new System.Drawing.Size(296, 63);
            this.btnCongDoan.TabIndex = 21;
            this.btnCongDoan.Text = "Công Đoạn";
            this.btnCongDoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCongDoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCongDoan.UseVisualStyleBackColor = false;
            this.btnCongDoan.Click += new System.EventHandler(this.btnCongDoan_Click);
            // 
            // btnXuLyTinhLuong
            // 
            this.btnXuLyTinhLuong.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXuLyTinhLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuLyTinhLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuLyTinhLuong.FlatAppearance.BorderSize = 0;
            this.btnXuLyTinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuLyTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLyTinhLuong.ForeColor = System.Drawing.Color.White;
            this.btnXuLyTinhLuong.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXuLyTinhLuong.IconColor = System.Drawing.Color.White;
            this.btnXuLyTinhLuong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuLyTinhLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLyTinhLuong.Location = new System.Drawing.Point(0, 126);
            this.btnXuLyTinhLuong.Name = "btnXuLyTinhLuong";
            this.btnXuLyTinhLuong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXuLyTinhLuong.Size = new System.Drawing.Size(296, 63);
            this.btnXuLyTinhLuong.TabIndex = 10;
            this.btnXuLyTinhLuong.Text = "Tính Lương";
            this.btnXuLyTinhLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLyTinhLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuLyTinhLuong.UseVisualStyleBackColor = false;
            this.btnXuLyTinhLuong.Click += new System.EventHandler(this.btnXuLyTinhLuong_Click_1);
            // 
            // btnXuLyChamCong
            // 
            this.btnXuLyChamCong.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXuLyChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuLyChamCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuLyChamCong.FlatAppearance.BorderSize = 0;
            this.btnXuLyChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuLyChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLyChamCong.ForeColor = System.Drawing.Color.White;
            this.btnXuLyChamCong.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXuLyChamCong.IconColor = System.Drawing.Color.White;
            this.btnXuLyChamCong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuLyChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLyChamCong.Location = new System.Drawing.Point(0, 63);
            this.btnXuLyChamCong.Name = "btnXuLyChamCong";
            this.btnXuLyChamCong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXuLyChamCong.Size = new System.Drawing.Size(296, 63);
            this.btnXuLyChamCong.TabIndex = 9;
            this.btnXuLyChamCong.Text = "Chấm Công";
            this.btnXuLyChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLyChamCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuLyChamCong.UseVisualStyleBackColor = false;
            this.btnXuLyChamCong.Click += new System.EventHandler(this.btnXuLyChamCong_Click_1);
            // 
            // btnXuLyPhanCa
            // 
            this.btnXuLyPhanCa.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXuLyPhanCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuLyPhanCa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuLyPhanCa.FlatAppearance.BorderSize = 0;
            this.btnXuLyPhanCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuLyPhanCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLyPhanCa.ForeColor = System.Drawing.Color.White;
            this.btnXuLyPhanCa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXuLyPhanCa.IconColor = System.Drawing.Color.White;
            this.btnXuLyPhanCa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuLyPhanCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLyPhanCa.Location = new System.Drawing.Point(0, 0);
            this.btnXuLyPhanCa.Name = "btnXuLyPhanCa";
            this.btnXuLyPhanCa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXuLyPhanCa.Size = new System.Drawing.Size(296, 63);
            this.btnXuLyPhanCa.TabIndex = 8;
            this.btnXuLyPhanCa.Text = "Phân Lịch Công Nhân";
            this.btnXuLyPhanCa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLyPhanCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuLyPhanCa.UseVisualStyleBackColor = false;
            this.btnXuLyPhanCa.Click += new System.EventHandler(this.btnXuLyPhanCa_Click);
            // 
            // btnXuLy
            // 
            this.btnXuLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(142)))), ((int)(((byte)(227)))));
            this.btnXuLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuLy.FlatAppearance.BorderSize = 0;
            this.btnXuLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuLy.ForeColor = System.Drawing.Color.White;
            this.btnXuLy.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnXuLy.IconColor = System.Drawing.Color.White;
            this.btnXuLy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLy.Location = new System.Drawing.Point(0, 386);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXuLy.Size = new System.Drawing.Size(296, 63);
            this.btnXuLy.TabIndex = 14;
            this.btnXuLy.Text = "Xử Lý";
            this.btnXuLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuLy.UseVisualStyleBackColor = false;
            this.btnXuLy.Click += new System.EventHandler(this.btnClick);
            // 
            // pnlDanhMuc
            // 
            this.pnlDanhMuc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlDanhMuc.Controls.Add(this.btnCaLam);
            this.pnlDanhMuc.Controls.Add(this.btnPhongBan);
            this.pnlDanhMuc.Controls.Add(this.btnHopDong);
            this.pnlDanhMuc.Controls.Add(this.btnSanPham);
            this.pnlDanhMuc.Controls.Add(this.btnNhanVien);
            this.pnlDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDanhMuc.Location = new System.Drawing.Point(0, 63);
            this.pnlDanhMuc.Name = "pnlDanhMuc";
            this.pnlDanhMuc.Size = new System.Drawing.Size(296, 323);
            this.pnlDanhMuc.TabIndex = 11;
            // 
            // btnCaLam
            // 
            this.btnCaLam.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCaLam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaLam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaLam.FlatAppearance.BorderSize = 0;
            this.btnCaLam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaLam.ForeColor = System.Drawing.Color.White;
            this.btnCaLam.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCaLam.IconColor = System.Drawing.Color.White;
            this.btnCaLam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCaLam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaLam.Location = new System.Drawing.Point(0, 252);
            this.btnCaLam.Name = "btnCaLam";
            this.btnCaLam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCaLam.Size = new System.Drawing.Size(296, 63);
            this.btnCaLam.TabIndex = 12;
            this.btnCaLam.Text = "Ca Làm";
            this.btnCaLam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaLam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaLam.UseVisualStyleBackColor = false;
            this.btnCaLam.Click += new System.EventHandler(this.btnCaLam_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPhongBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhongBan.FlatAppearance.BorderSize = 0;
            this.btnPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnPhongBan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPhongBan.IconColor = System.Drawing.Color.White;
            this.btnPhongBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhongBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhongBan.Location = new System.Drawing.Point(0, 189);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPhongBan.Size = new System.Drawing.Size(296, 63);
            this.btnPhongBan.TabIndex = 11;
            this.btnPhongBan.Text = "Phòng Ban";
            this.btnPhongBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhongBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhongBan.UseVisualStyleBackColor = false;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHopDong.FlatAppearance.BorderSize = 0;
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong.ForeColor = System.Drawing.Color.White;
            this.btnHopDong.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHopDong.IconColor = System.Drawing.Color.White;
            this.btnHopDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.Location = new System.Drawing.Point(0, 126);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHopDong.Size = new System.Drawing.Size(296, 63);
            this.btnHopDong.TabIndex = 10;
            this.btnHopDong.Text = "Hợp Đồng";
            this.btnHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSanPham.IconColor = System.Drawing.Color.White;
            this.btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(0, 63);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSanPham.Size = new System.Drawing.Size(296, 63);
            this.btnSanPham.TabIndex = 9;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNhanVien.IconColor = System.Drawing.Color.White;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(296, 63);
            this.btnNhanVien.TabIndex = 8;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(142)))), ((int)(((byte)(227)))));
            this.btnDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnDanhMuc.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnDanhMuc.IconColor = System.Drawing.Color.White;
            this.btnDanhMuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDanhMuc.Size = new System.Drawing.Size(296, 63);
            this.btnDanhMuc.TabIndex = 10;
            this.btnDanhMuc.Text = "Danh Mục";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnClick);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(142)))), ((int)(((byte)(227)))));
            this.pnlInfo.Controls.Add(this.txtChucVu);
            this.pnlInfo.Controls.Add(this.txtTen);
            this.pnlInfo.Controls.Add(this.pnlSeperate);
            this.pnlInfo.Controls.Add(this.picAvatar);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(320, 318);
            this.pnlInfo.TabIndex = 1;
            // 
            // txtChucVu
            // 
            this.txtChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(142)))), ((int)(((byte)(227)))));
            this.txtChucVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.ForeColor = System.Drawing.Color.White;
            this.txtChucVu.Location = new System.Drawing.Point(0, 237);
            this.txtChucVu.Multiline = true;
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(320, 31);
            this.txtChucVu.TabIndex = 3;
            this.txtChucVu.Text = "Quản Lý";
            this.txtChucVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(142)))), ((int)(((byte)(227)))));
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.White;
            this.txtTen.Location = new System.Drawing.Point(0, 200);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(320, 31);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlSeperate
            // 
            this.pnlSeperate.BackColor = System.Drawing.Color.White;
            this.pnlSeperate.Location = new System.Drawing.Point(3, 302);
            this.pnlSeperate.Name = "pnlSeperate";
            this.pnlSeperate.Size = new System.Drawing.Size(320, 1);
            this.pnlSeperate.TabIndex = 2;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.picAvatar.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.picAvatar.IconColor = System.Drawing.Color.RoyalBlue;
            this.picAvatar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picAvatar.IconSize = 139;
            this.picAvatar.Location = new System.Drawing.Point(91, 40);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(139, 139);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnMinimize);
            this.pnlControl.Controls.Add(this.btnHelp);
            this.pnlControl.Controls.Add(this.btnThoat);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(320, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1062, 50);
            this.pnlControl.TabIndex = 3;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 28;
            this.btnMinimize.Location = new System.Drawing.Point(927, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnHelp.IconColor = System.Drawing.Color.Black;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHelp.IconSize = 28;
            this.btnHelp.Location = new System.Drawing.Point(973, 7);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(40, 40);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnThoat.IconColor = System.Drawing.Color.Black;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 28;
            this.btnThoat.Location = new System.Drawing.Point(1019, 7);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 40);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.lblWelcome);
            this.pnlBody.Controls.Add(this.ptcMain);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(320, 50);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1062, 1052);
            this.pnlBody.TabIndex = 4;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(142)))), ((int)(((byte)(227)))));
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(82, 54);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(915, 90);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptcMain
            // 
            this.ptcMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptcMain.Image = ((System.Drawing.Image)(resources.GetObject("ptcMain.Image")));
            this.ptcMain.Location = new System.Drawing.Point(87, 239);
            this.ptcMain.Name = "ptcMain";
            this.ptcMain.Size = new System.Drawing.Size(915, 610);
            this.ptcMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcMain.TabIndex = 0;
            this.ptcMain.TabStop = false;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 1102);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLy";
            this.Text = "frmManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.pnLeft.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlThongKe.ResumeLayout(false);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlXuLy.ResumeLayout(false);
            this.pnlDanhMuc.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnlInfo;
        private FontAwesome.Sharp.IconPictureBox picAvatar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlSeperate;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtTen;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlBody;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnHelp;
        private FontAwesome.Sharp.IconButton btnDanhMuc;
        private System.Windows.Forms.Panel pnlDanhMuc;
        private FontAwesome.Sharp.IconButton btnPhongBan;
        private FontAwesome.Sharp.IconButton btnHopDong;
        private FontAwesome.Sharp.IconButton btnSanPham;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnXuLy;
        private System.Windows.Forms.Panel pnlThongKe;
        private FontAwesome.Sharp.IconButton btnThongKeSP;
        private FontAwesome.Sharp.IconButton btnThongKeHC;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private System.Windows.Forms.Panel pnlTimKiem;
        private FontAwesome.Sharp.IconButton btnTimKiemSP;
        private FontAwesome.Sharp.IconButton btnTimKiemNV;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.Panel pnlXuLy;
        private FontAwesome.Sharp.IconButton btnXuLyChamCong;
        private FontAwesome.Sharp.IconButton btnXuLyPhanCa;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnXuLyTinhLuong;
        private System.Windows.Forms.PictureBox ptcMain;
        private FontAwesome.Sharp.IconButton btnCongDoan;
        private FontAwesome.Sharp.IconButton btnCaLam;
        private System.Windows.Forms.Label lblWelcome;
    }
}