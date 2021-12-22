
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmHopDong
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
            this.picNen = new System.Windows.Forms.PictureBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnLapHopDong = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstvCTHopDong = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlDSPC = new System.Windows.Forms.Panel();
            this.lstvSanPham = new System.Windows.Forms.ListView();
            this.lblDSPhanCong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDS = new System.Windows.Forms.Label();
            this.lstvHopDong = new System.Windows.Forms.ListView();
            this.txtHDTK = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.gboChiTiet = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.txtTenHopDong = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtDieuKhoan = new System.Windows.Forms.TextBox();
            this.dtmNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtmNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlDSPC.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gboChiTiet.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(1495, 955);
            this.picNen.TabIndex = 0;
            this.picNen.TabStop = false;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(177, 132);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(120, 30);
            this.nudSoLuong.TabIndex = 47;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Red;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 25;
            this.btnXoa.Location = new System.Drawing.Point(446, 217);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 43);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLapHopDong
            // 
            this.btnLapHopDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLapHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLapHopDong.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnLapHopDong.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLapHopDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLapHopDong.IconSize = 25;
            this.btnLapHopDong.Location = new System.Drawing.Point(518, 501);
            this.btnLapHopDong.Name = "btnLapHopDong";
            this.btnLapHopDong.Size = new System.Drawing.Size(150, 43);
            this.btnLapHopDong.TabIndex = 46;
            this.btnLapHopDong.Text = "Lập hợp đồng";
            this.btnLapHopDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLapHopDong.UseVisualStyleBackColor = true;
            this.btnLapHopDong.Click += new System.EventHandler(this.btnLapHopDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Enabled = false;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 25;
            this.btnThem.Location = new System.Drawing.Point(16, 217);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 43);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "Số lượng: ";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSanPham.Enabled = false;
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Location = new System.Drawing.Point(177, 53);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(364, 30);
            this.txtTenSanPham.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Tên sản phẩm:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lstvCTHopDong);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(911, 637);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 294);
            this.panel2.TabIndex = 40;
            // 
            // lstvCTHopDong
            // 
            this.lstvCTHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvCTHopDong.HideSelection = false;
            this.lstvCTHopDong.Location = new System.Drawing.Point(15, 56);
            this.lstvCTHopDong.Name = "lstvCTHopDong";
            this.lstvCTHopDong.Size = new System.Drawing.Size(541, 231);
            this.lstvCTHopDong.TabIndex = 1;
            this.lstvCTHopDong.UseCompatibleStateImageBehavior = false;
            this.lstvCTHopDong.Click += new System.EventHandler(this.lstvCTHopDong_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(568, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chi tiết hợp đồng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDSPC
            // 
            this.pnlDSPC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDSPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSPC.Controls.Add(this.lstvSanPham);
            this.pnlDSPC.Controls.Add(this.lblDSPhanCong);
            this.pnlDSPC.Location = new System.Drawing.Point(14, 637);
            this.pnlDSPC.Name = "pnlDSPC";
            this.pnlDSPC.Size = new System.Drawing.Size(306, 294);
            this.pnlDSPC.TabIndex = 39;
            // 
            // lstvSanPham
            // 
            this.lstvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvSanPham.HideSelection = false;
            this.lstvSanPham.Location = new System.Drawing.Point(15, 56);
            this.lstvSanPham.Name = "lstvSanPham";
            this.lstvSanPham.Size = new System.Drawing.Size(275, 231);
            this.lstvSanPham.TabIndex = 1;
            this.lstvSanPham.UseCompatibleStateImageBehavior = false;
            this.lstvSanPham.SelectedIndexChanged += new System.EventHandler(this.lstvSanPham_SelectedIndexChanged);
            // 
            // lblDSPhanCong
            // 
            this.lblDSPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSPhanCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDSPhanCong.Location = new System.Drawing.Point(0, 0);
            this.lblDSPhanCong.Name = "lblDSPhanCong";
            this.lblDSPhanCong.Size = new System.Drawing.Size(302, 33);
            this.lblDSPhanCong.TabIndex = 0;
            this.lblDSPhanCong.Text = "Danh sách sản phẩm";
            this.lblDSPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDS);
            this.panel1.Controls.Add(this.lstvHopDong);
            this.panel1.Location = new System.Drawing.Point(715, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 517);
            this.panel1.TabIndex = 37;
            // 
            // lblDS
            // 
            this.lblDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDS.Location = new System.Drawing.Point(0, 0);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(764, 35);
            this.lblDS.TabIndex = 15;
            this.lblDS.Text = "Danh sách hợp đồng";
            this.lblDS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstvHopDong
            // 
            this.lstvHopDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstvHopDong.HideSelection = false;
            this.lstvHopDong.Location = new System.Drawing.Point(5, 50);
            this.lstvHopDong.MultiSelect = false;
            this.lstvHopDong.Name = "lstvHopDong";
            this.lstvHopDong.Size = new System.Drawing.Size(747, 450);
            this.lstvHopDong.TabIndex = 0;
            this.lstvHopDong.UseCompatibleStateImageBehavior = false;
            this.lstvHopDong.SelectedIndexChanged += new System.EventHandler(this.lstvHopDong_SelectedIndexChanged);
            // 
            // txtHDTK
            // 
            this.txtHDTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHDTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHDTK.Location = new System.Drawing.Point(869, 40);
            this.txtHDTK.Name = "txtHDTK";
            this.txtHDTK.Size = new System.Drawing.Size(498, 30);
            this.txtHDTK.TabIndex = 36;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.Blue;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 24;
            this.btnTimKiem.Location = new System.Drawing.Point(1409, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(74, 34);
            this.btnTimKiem.TabIndex = 35;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNameSearch.ForeColor = System.Drawing.Color.White;
            this.lblNameSearch.Location = new System.Drawing.Point(712, 45);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(146, 25);
            this.lblNameSearch.TabIndex = 48;
            this.lblNameSearch.Text = "Tên hợp đồng";
            // 
            // gboChiTiet
            // 
            this.gboChiTiet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboChiTiet.Controls.Add(this.btnThem);
            this.gboChiTiet.Controls.Add(this.btnXoa);
            this.gboChiTiet.Controls.Add(this.nudSoLuong);
            this.gboChiTiet.Controls.Add(this.label9);
            this.gboChiTiet.Controls.Add(this.txtTenSanPham);
            this.gboChiTiet.Controls.Add(this.label8);
            this.gboChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboChiTiet.Location = new System.Drawing.Point(337, 639);
            this.gboChiTiet.Name = "gboChiTiet";
            this.gboChiTiet.Size = new System.Drawing.Size(559, 292);
            this.gboChiTiet.TabIndex = 49;
            this.gboChiTiet.TabStop = false;
            this.gboChiTiet.Text = "Chi tiết hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hợp đồng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Điều khoản:";
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthai.Location = new System.Drawing.Point(49, 455);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(106, 25);
            this.lblTrangthai.TabIndex = 1;
            this.lblTrangthai.Text = "Trạng thái:";
            // 
            // txtTenHopDong
            // 
            this.txtTenHopDong.Enabled = false;
            this.txtTenHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHopDong.Location = new System.Drawing.Point(172, 39);
            this.txtTenHopDong.Name = "txtTenHopDong";
            this.txtTenHopDong.Size = new System.Drawing.Size(489, 30);
            this.txtTenHopDong.TabIndex = 2;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Enabled = false;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(170, 240);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(489, 30);
            this.txtTenKhachHang.TabIndex = 2;
            // 
            // txtDieuKhoan
            // 
            this.txtDieuKhoan.Enabled = false;
            this.txtDieuKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDieuKhoan.Location = new System.Drawing.Point(172, 302);
            this.txtDieuKhoan.Multiline = true;
            this.txtDieuKhoan.Name = "txtDieuKhoan";
            this.txtDieuKhoan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDieuKhoan.Size = new System.Drawing.Size(489, 108);
            this.txtDieuKhoan.TabIndex = 2;
            // 
            // dtmNgayBatDau
            // 
            this.dtmNgayBatDau.Enabled = false;
            this.dtmNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayBatDau.Location = new System.Drawing.Point(172, 101);
            this.dtmNgayBatDau.Name = "dtmNgayBatDau";
            this.dtmNgayBatDau.Size = new System.Drawing.Size(308, 30);
            this.dtmNgayBatDau.TabIndex = 3;
            // 
            // dtmNgayKetThuc
            // 
            this.dtmNgayKetThuc.Enabled = false;
            this.dtmNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayKetThuc.Location = new System.Drawing.Point(172, 169);
            this.dtmNgayKetThuc.Name = "dtmNgayKetThuc";
            this.dtmNgayKetThuc.Size = new System.Drawing.Size(308, 30);
            this.dtmNgayKetThuc.TabIndex = 3;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(172, 450);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(245, 30);
            this.txtTrangThai.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtTrangThai);
            this.groupBox2.Controls.Add(this.dtmNgayKetThuc);
            this.groupBox2.Controls.Add(this.dtmNgayBatDau);
            this.groupBox2.Controls.Add(this.btnLapHopDong);
            this.groupBox2.Controls.Add(this.txtDieuKhoan);
            this.groupBox2.Controls.Add(this.txtTenKhachHang);
            this.groupBox2.Controls.Add(this.txtTenHopDong);
            this.groupBox2.Controls.Add(this.lblTrangthai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 559);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hợp đồng";
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1495, 955);
            this.Controls.Add(this.gboChiTiet);
            this.Controls.Add(this.lblNameSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDSPC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtHDTK);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHopDong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlDSPC.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gboChiTiet.ResumeLayout(false);
            this.gboChiTiet.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnLapHopDong;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstvCTHopDong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlDSPC;
        private System.Windows.Forms.ListView lstvSanPham;
        private System.Windows.Forms.Label lblDSPhanCong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.ListView lstvHopDong;
        private System.Windows.Forms.TextBox txtHDTK;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.GroupBox gboChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTrangthai;
        private System.Windows.Forms.TextBox txtTenHopDong;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtDieuKhoan;
        private System.Windows.Forms.DateTimePicker dtmNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtmNgayKetThuc;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}