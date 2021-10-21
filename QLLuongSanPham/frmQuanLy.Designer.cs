
namespace QLLuongSanPham
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
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlQLSanPham = new System.Windows.Forms.Panel();
            this.btnCongDoan = new FontAwesome.Sharp.IconButton();
            this.btnDSSanPham = new FontAwesome.Sharp.IconButton();
            this.btnSanPham = new FontAwesome.Sharp.IconButton();
            this.pnlTinhLuong = new System.Windows.Forms.Panel();
            this.btnTInhLuongHC = new FontAwesome.Sharp.IconButton();
            this.btnTinhLuongCN = new FontAwesome.Sharp.IconButton();
            this.btnTinhLuong = new FontAwesome.Sharp.IconButton();
            this.pnlChamCong = new System.Windows.Forms.Panel();
            this.btnChamCongHC = new FontAwesome.Sharp.IconButton();
            this.btnChamCongCN = new FontAwesome.Sharp.IconButton();
            this.btnChamCong = new FontAwesome.Sharp.IconButton();
            this.btnQLPhongBan = new FontAwesome.Sharp.IconButton();
            this.pnlQLNhanSu = new System.Windows.Forms.Panel();
            this.btnQLTrinhDoHV = new FontAwesome.Sharp.IconButton();
            this.btnQLChucVu = new FontAwesome.Sharp.IconButton();
            this.btnQLNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnQLNhanSu = new FontAwesome.Sharp.IconButton();
            this.btnTongQuan = new FontAwesome.Sharp.IconButton();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.pnlSeperate = new System.Windows.Forms.Panel();
            this.picAvatar = new FontAwesome.Sharp.IconPictureBox();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnLapHopDong = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.btnThongKeCT = new FontAwesome.Sharp.IconButton();
            this.btnThongKeHC = new FontAwesome.Sharp.IconButton();
            this.btnThongKeCN = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pnLeft.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlQLSanPham.SuspendLayout();
            this.pnlTinhLuong.SuspendLayout();
            this.pnlChamCong.SuspendLayout();
            this.pnlQLNhanSu.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.pnlThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.AutoSize = true;
            this.pnLeft.BackColor = System.Drawing.Color.RoyalBlue;
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
            this.pnlMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlMenu.Controls.Add(this.pnlThongKe);
            this.pnlMenu.Controls.Add(this.btnThongKe);
            this.pnlMenu.Controls.Add(this.btnLapHopDong);
            this.pnlMenu.Controls.Add(this.pnlQLSanPham);
            this.pnlMenu.Controls.Add(this.btnSanPham);
            this.pnlMenu.Controls.Add(this.pnlTinhLuong);
            this.pnlMenu.Controls.Add(this.btnTinhLuong);
            this.pnlMenu.Controls.Add(this.pnlChamCong);
            this.pnlMenu.Controls.Add(this.btnChamCong);
            this.pnlMenu.Controls.Add(this.btnQLPhongBan);
            this.pnlMenu.Controls.Add(this.pnlQLNhanSu);
            this.pnlMenu.Controls.Add(this.btnQLNhanSu);
            this.pnlMenu.Controls.Add(this.btnTongQuan);
            this.pnlMenu.Location = new System.Drawing.Point(0, 354);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(317, 524);
            this.pnlMenu.TabIndex = 2;
            // 
            // pnlQLSanPham
            // 
            this.pnlQLSanPham.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlQLSanPham.Controls.Add(this.btnCongDoan);
            this.pnlQLSanPham.Controls.Add(this.btnDSSanPham);
            this.pnlQLSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQLSanPham.Location = new System.Drawing.Point(0, 839);
            this.pnlQLSanPham.Name = "pnlQLSanPham";
            this.pnlQLSanPham.Size = new System.Drawing.Size(296, 131);
            this.pnlQLSanPham.TabIndex = 22;
            // 
            // btnCongDoan
            // 
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
            this.btnCongDoan.Location = new System.Drawing.Point(0, 63);
            this.btnCongDoan.Name = "btnCongDoan";
            this.btnCongDoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCongDoan.Size = new System.Drawing.Size(296, 63);
            this.btnCongDoan.TabIndex = 9;
            this.btnCongDoan.Text = "Công Đoạn";
            this.btnCongDoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCongDoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCongDoan.UseVisualStyleBackColor = true;
            // 
            // btnDSSanPham
            // 
            this.btnDSSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDSSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDSSanPham.FlatAppearance.BorderSize = 0;
            this.btnDSSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSSanPham.ForeColor = System.Drawing.Color.White;
            this.btnDSSanPham.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDSSanPham.IconColor = System.Drawing.Color.White;
            this.btnDSSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDSSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSSanPham.Location = new System.Drawing.Point(0, 0);
            this.btnDSSanPham.Name = "btnDSSanPham";
            this.btnDSSanPham.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDSSanPham.Size = new System.Drawing.Size(296, 63);
            this.btnDSSanPham.TabIndex = 8;
            this.btnDSSanPham.Text = "Danh Sách Sản Phẩm";
            this.btnDSSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSSanPham.UseVisualStyleBackColor = true;
            // 
            // btnSanPham
            // 
            this.btnSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btnSanPham.IconColor = System.Drawing.Color.White;
            this.btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(0, 776);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSanPham.Size = new System.Drawing.Size(296, 63);
            this.btnSanPham.TabIndex = 21;
            this.btnSanPham.Text = "Quản Lý Sản Phẩm";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = true;
            // 
            // pnlTinhLuong
            // 
            this.pnlTinhLuong.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTinhLuong.Controls.Add(this.btnTInhLuongHC);
            this.pnlTinhLuong.Controls.Add(this.btnTinhLuongCN);
            this.pnlTinhLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTinhLuong.Location = new System.Drawing.Point(0, 642);
            this.pnlTinhLuong.Name = "pnlTinhLuong";
            this.pnlTinhLuong.Size = new System.Drawing.Size(296, 134);
            this.pnlTinhLuong.TabIndex = 20;
            // 
            // btnTInhLuongHC
            // 
            this.btnTInhLuongHC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTInhLuongHC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTInhLuongHC.FlatAppearance.BorderSize = 0;
            this.btnTInhLuongHC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTInhLuongHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTInhLuongHC.ForeColor = System.Drawing.Color.White;
            this.btnTInhLuongHC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTInhLuongHC.IconColor = System.Drawing.Color.White;
            this.btnTInhLuongHC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTInhLuongHC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTInhLuongHC.Location = new System.Drawing.Point(0, 63);
            this.btnTInhLuongHC.Name = "btnTInhLuongHC";
            this.btnTInhLuongHC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTInhLuongHC.Size = new System.Drawing.Size(296, 63);
            this.btnTInhLuongHC.TabIndex = 9;
            this.btnTInhLuongHC.Text = "Hành Chánh";
            this.btnTInhLuongHC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTInhLuongHC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTInhLuongHC.UseVisualStyleBackColor = true;
            // 
            // btnTinhLuongCN
            // 
            this.btnTinhLuongCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhLuongCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTinhLuongCN.FlatAppearance.BorderSize = 0;
            this.btnTinhLuongCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhLuongCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuongCN.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuongCN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTinhLuongCN.IconColor = System.Drawing.Color.White;
            this.btnTinhLuongCN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTinhLuongCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhLuongCN.Location = new System.Drawing.Point(0, 0);
            this.btnTinhLuongCN.Name = "btnTinhLuongCN";
            this.btnTinhLuongCN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTinhLuongCN.Size = new System.Drawing.Size(296, 63);
            this.btnTinhLuongCN.TabIndex = 8;
            this.btnTinhLuongCN.Text = "Công nhân";
            this.btnTinhLuongCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhLuongCN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinhLuongCN.UseVisualStyleBackColor = true;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTinhLuong.FlatAppearance.BorderSize = 0;
            this.btnTinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuong.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnTinhLuong.IconColor = System.Drawing.Color.White;
            this.btnTinhLuong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTinhLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhLuong.Location = new System.Drawing.Point(0, 579);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTinhLuong.Size = new System.Drawing.Size(296, 63);
            this.btnTinhLuong.TabIndex = 19;
            this.btnTinhLuong.Text = "Tính Lương";
            this.btnTinhLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            // 
            // pnlChamCong
            // 
            this.pnlChamCong.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlChamCong.Controls.Add(this.btnChamCongHC);
            this.pnlChamCong.Controls.Add(this.btnChamCongCN);
            this.pnlChamCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChamCong.Location = new System.Drawing.Point(0, 445);
            this.pnlChamCong.Name = "pnlChamCong";
            this.pnlChamCong.Size = new System.Drawing.Size(296, 134);
            this.pnlChamCong.TabIndex = 14;
            // 
            // btnChamCongHC
            // 
            this.btnChamCongHC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamCongHC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChamCongHC.FlatAppearance.BorderSize = 0;
            this.btnChamCongHC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCongHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCongHC.ForeColor = System.Drawing.Color.White;
            this.btnChamCongHC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChamCongHC.IconColor = System.Drawing.Color.White;
            this.btnChamCongHC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChamCongHC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCongHC.Location = new System.Drawing.Point(0, 63);
            this.btnChamCongHC.Name = "btnChamCongHC";
            this.btnChamCongHC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChamCongHC.Size = new System.Drawing.Size(296, 63);
            this.btnChamCongHC.TabIndex = 9;
            this.btnChamCongHC.Text = "Hành Chánh";
            this.btnChamCongHC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCongHC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChamCongHC.UseVisualStyleBackColor = true;
            // 
            // btnChamCongCN
            // 
            this.btnChamCongCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamCongCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChamCongCN.FlatAppearance.BorderSize = 0;
            this.btnChamCongCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCongCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCongCN.ForeColor = System.Drawing.Color.White;
            this.btnChamCongCN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChamCongCN.IconColor = System.Drawing.Color.White;
            this.btnChamCongCN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChamCongCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCongCN.Location = new System.Drawing.Point(0, 0);
            this.btnChamCongCN.Name = "btnChamCongCN";
            this.btnChamCongCN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChamCongCN.Size = new System.Drawing.Size(296, 63);
            this.btnChamCongCN.TabIndex = 8;
            this.btnChamCongCN.Text = "Công nhân";
            this.btnChamCongCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCongCN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChamCongCN.UseVisualStyleBackColor = true;
            // 
            // btnChamCong
            // 
            this.btnChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.ForeColor = System.Drawing.Color.White;
            this.btnChamCong.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnChamCong.IconColor = System.Drawing.Color.White;
            this.btnChamCong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.Location = new System.Drawing.Point(0, 382);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChamCong.Size = new System.Drawing.Size(296, 63);
            this.btnChamCong.TabIndex = 9;
            this.btnChamCong.Text = "Chấm Công";
            this.btnChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChamCong.UseVisualStyleBackColor = true;
            // 
            // btnQLPhongBan
            // 
            this.btnQLPhongBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLPhongBan.FlatAppearance.BorderSize = 0;
            this.btnQLPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnQLPhongBan.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnQLPhongBan.IconColor = System.Drawing.Color.White;
            this.btnQLPhongBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLPhongBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhongBan.Location = new System.Drawing.Point(0, 319);
            this.btnQLPhongBan.Name = "btnQLPhongBan";
            this.btnQLPhongBan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLPhongBan.Size = new System.Drawing.Size(296, 63);
            this.btnQLPhongBan.TabIndex = 8;
            this.btnQLPhongBan.Text = "Quản Lý Phòng Ban";
            this.btnQLPhongBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhongBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLPhongBan.UseVisualStyleBackColor = true;
            // 
            // pnlQLNhanSu
            // 
            this.pnlQLNhanSu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlQLNhanSu.Controls.Add(this.btnQLTrinhDoHV);
            this.pnlQLNhanSu.Controls.Add(this.btnQLChucVu);
            this.pnlQLNhanSu.Controls.Add(this.btnQLNhanVien);
            this.pnlQLNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQLNhanSu.Location = new System.Drawing.Point(0, 126);
            this.pnlQLNhanSu.Name = "pnlQLNhanSu";
            this.pnlQLNhanSu.Size = new System.Drawing.Size(296, 193);
            this.pnlQLNhanSu.TabIndex = 7;
            // 
            // btnQLTrinhDoHV
            // 
            this.btnQLTrinhDoHV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLTrinhDoHV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTrinhDoHV.FlatAppearance.BorderSize = 0;
            this.btnQLTrinhDoHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTrinhDoHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTrinhDoHV.ForeColor = System.Drawing.Color.White;
            this.btnQLTrinhDoHV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnQLTrinhDoHV.IconColor = System.Drawing.Color.White;
            this.btnQLTrinhDoHV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLTrinhDoHV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTrinhDoHV.Location = new System.Drawing.Point(0, 126);
            this.btnQLTrinhDoHV.Name = "btnQLTrinhDoHV";
            this.btnQLTrinhDoHV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLTrinhDoHV.Size = new System.Drawing.Size(296, 63);
            this.btnQLTrinhDoHV.TabIndex = 10;
            this.btnQLTrinhDoHV.Text = "Trình Độ Học Vấn";
            this.btnQLTrinhDoHV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTrinhDoHV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLTrinhDoHV.UseVisualStyleBackColor = true;
            // 
            // btnQLChucVu
            // 
            this.btnQLChucVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLChucVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLChucVu.FlatAppearance.BorderSize = 0;
            this.btnQLChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLChucVu.ForeColor = System.Drawing.Color.White;
            this.btnQLChucVu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnQLChucVu.IconColor = System.Drawing.Color.White;
            this.btnQLChucVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLChucVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLChucVu.Location = new System.Drawing.Point(0, 63);
            this.btnQLChucVu.Name = "btnQLChucVu";
            this.btnQLChucVu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLChucVu.Size = new System.Drawing.Size(296, 63);
            this.btnQLChucVu.TabIndex = 9;
            this.btnQLChucVu.Text = "Chức vụ";
            this.btnQLChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLChucVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLChucVu.UseVisualStyleBackColor = true;
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQLNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQLNhanVien.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnQLNhanVien.IconColor = System.Drawing.Color.White;
            this.btnQLNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLNhanVien.Size = new System.Drawing.Size(296, 63);
            this.btnQLNhanVien.TabIndex = 8;
            this.btnQLNhanVien.Text = "Nhân viên";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnQLNhanSu
            // 
            this.btnQLNhanSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNhanSu.FlatAppearance.BorderSize = 0;
            this.btnQLNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanSu.ForeColor = System.Drawing.Color.White;
            this.btnQLNhanSu.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnQLNhanSu.IconColor = System.Drawing.Color.White;
            this.btnQLNhanSu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLNhanSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanSu.Location = new System.Drawing.Point(0, 63);
            this.btnQLNhanSu.Name = "btnQLNhanSu";
            this.btnQLNhanSu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLNhanSu.Size = new System.Drawing.Size(296, 63);
            this.btnQLNhanSu.TabIndex = 1;
            this.btnQLNhanSu.Text = "Quản Lý Nhân Sự";
            this.btnQLNhanSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNhanSu.UseVisualStyleBackColor = true;
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTongQuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTongQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTongQuan.FlatAppearance.BorderSize = 0;
            this.btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongQuan.ForeColor = System.Drawing.Color.White;
            this.btnTongQuan.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnTongQuan.IconColor = System.Drawing.Color.White;
            this.btnTongQuan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTongQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.Location = new System.Drawing.Point(0, 0);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTongQuan.Size = new System.Drawing.Size(296, 63);
            this.btnTongQuan.TabIndex = 0;
            this.btnTongQuan.Text = "Tổng Quan";
            this.btnTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTongQuan.UseVisualStyleBackColor = false;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlInfo.Controls.Add(this.button1);
            this.pnlInfo.Controls.Add(this.txtChucVu);
            this.pnlInfo.Controls.Add(this.txtTen);
            this.pnlInfo.Controls.Add(this.pnlSeperate);
            this.pnlInfo.Controls.Add(this.picAvatar);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(320, 348);
            this.pnlInfo.TabIndex = 1;
            // 
            // txtChucVu
            // 
            this.txtChucVu.BackColor = System.Drawing.Color.RoyalBlue;
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
            this.txtTen.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.White;
            this.txtTen.Location = new System.Drawing.Point(0, 200);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(320, 31);
            this.txtTen.TabIndex = 2;
            this.txtTen.Text = "Nguyễn Hồng Đạt";
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlSeperate
            // 
            this.pnlSeperate.BackColor = System.Drawing.Color.White;
            this.pnlSeperate.Location = new System.Drawing.Point(3, 344);
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
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnHelp);
            this.pnlControl.Controls.Add(this.btnThoat);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(320, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1062, 50);
            this.pnlControl.TabIndex = 3;
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
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(320, 50);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1062, 1052);
            this.pnlBody.TabIndex = 4;
            // 
            // btnLapHopDong
            // 
            this.btnLapHopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLapHopDong.FlatAppearance.BorderSize = 0;
            this.btnLapHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHopDong.ForeColor = System.Drawing.Color.White;
            this.btnLapHopDong.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnLapHopDong.IconColor = System.Drawing.Color.White;
            this.btnLapHopDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLapHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapHopDong.Location = new System.Drawing.Point(0, 970);
            this.btnLapHopDong.Name = "btnLapHopDong";
            this.btnLapHopDong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLapHopDong.Size = new System.Drawing.Size(296, 63);
            this.btnLapHopDong.TabIndex = 23;
            this.btnLapHopDong.Text = "Lập Hợp Đồng";
            this.btnLapHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapHopDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLapHopDong.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
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
            this.btnThongKe.Location = new System.Drawing.Point(0, 1033);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(296, 63);
            this.btnThongKe.TabIndex = 25;
            this.btnThongKe.Text = "Thống Kê Lương";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlThongKe.Controls.Add(this.btnThongKeCT);
            this.pnlThongKe.Controls.Add(this.btnThongKeHC);
            this.pnlThongKe.Controls.Add(this.btnThongKeCN);
            this.pnlThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongKe.Location = new System.Drawing.Point(0, 1096);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(296, 196);
            this.pnlThongKe.TabIndex = 26;
            // 
            // btnThongKeCT
            // 
            this.btnThongKeCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKeCT.FlatAppearance.BorderSize = 0;
            this.btnThongKeCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeCT.ForeColor = System.Drawing.Color.White;
            this.btnThongKeCT.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThongKeCT.IconColor = System.Drawing.Color.White;
            this.btnThongKeCT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKeCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeCT.Location = new System.Drawing.Point(0, 126);
            this.btnThongKeCT.Name = "btnThongKeCT";
            this.btnThongKeCT.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongKeCT.Size = new System.Drawing.Size(296, 63);
            this.btnThongKeCT.TabIndex = 10;
            this.btnThongKeCT.Text = "Toàn Công Ty";
            this.btnThongKeCT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKeCT.UseVisualStyleBackColor = true;
            // 
            // btnThongKeHC
            // 
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
            this.btnThongKeHC.Location = new System.Drawing.Point(0, 63);
            this.btnThongKeHC.Name = "btnThongKeHC";
            this.btnThongKeHC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongKeHC.Size = new System.Drawing.Size(296, 63);
            this.btnThongKeHC.TabIndex = 9;
            this.btnThongKeHC.Text = "Hành Chánh";
            this.btnThongKeHC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeHC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKeHC.UseVisualStyleBackColor = true;
            // 
            // btnThongKeCN
            // 
            this.btnThongKeCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKeCN.FlatAppearance.BorderSize = 0;
            this.btnThongKeCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeCN.ForeColor = System.Drawing.Color.White;
            this.btnThongKeCN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThongKeCN.IconColor = System.Drawing.Color.White;
            this.btnThongKeCN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKeCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeCN.Location = new System.Drawing.Point(0, 0);
            this.btnThongKeCN.Name = "btnThongKeCN";
            this.btnThongKeCN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongKeCN.Size = new System.Drawing.Size(296, 63);
            this.btnThongKeCN.TabIndex = 8;
            this.btnThongKeCN.Text = "Công nhân";
            this.btnThongKeCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeCN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKeCN.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chỉnh Sửa Thông Tin";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 1102);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagement";
            this.Text = "frmManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnLeft.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlQLSanPham.ResumeLayout(false);
            this.pnlTinhLuong.ResumeLayout(false);
            this.pnlChamCong.ResumeLayout(false);
            this.pnlQLNhanSu.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlThongKe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnlInfo;
        private FontAwesome.Sharp.IconPictureBox picAvatar;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnQLNhanSu;
        private FontAwesome.Sharp.IconButton btnTongQuan;
        private System.Windows.Forms.Panel pnlSeperate;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtTen;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlQLNhanSu;
        private FontAwesome.Sharp.IconButton btnQLNhanVien;
        private FontAwesome.Sharp.IconButton btnQLPhongBan;
        private FontAwesome.Sharp.IconButton btnQLChucVu;
        private FontAwesome.Sharp.IconButton btnChamCong;
        private FontAwesome.Sharp.IconButton btnQLTrinhDoHV;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private System.Windows.Forms.Panel pnlQLSanPham;
        private FontAwesome.Sharp.IconButton btnCongDoan;
        private FontAwesome.Sharp.IconButton btnDSSanPham;
        private FontAwesome.Sharp.IconButton btnSanPham;
        private System.Windows.Forms.Panel pnlTinhLuong;
        private FontAwesome.Sharp.IconButton btnTInhLuongHC;
        private FontAwesome.Sharp.IconButton btnTinhLuongCN;
        private FontAwesome.Sharp.IconButton btnTinhLuong;
        private System.Windows.Forms.Panel pnlChamCong;
        private FontAwesome.Sharp.IconButton btnChamCongHC;
        private FontAwesome.Sharp.IconButton btnChamCongCN;
        private FontAwesome.Sharp.IconButton btnHelp;
        private FontAwesome.Sharp.IconButton btnLapHopDong;
        private System.Windows.Forms.Panel pnlThongKe;
        private FontAwesome.Sharp.IconButton btnThongKeCT;
        private FontAwesome.Sharp.IconButton btnThongKeHC;
        private FontAwesome.Sharp.IconButton btnThongKeCN;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private System.Windows.Forms.Button button1;
    }
}