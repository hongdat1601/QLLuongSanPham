
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmTinhLuongHC
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
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.btnTinh = new FontAwesome.Sharp.IconButton();
            this.pnlLuong = new System.Windows.Forms.Panel();
            this.lstvLuong = new System.Windows.Forms.ListView();
            this.lblDSLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTP = new System.Windows.Forms.Label();
            this.pnlCongViec = new System.Windows.Forms.Panel();
            this.lstvNgayNghi = new System.Windows.Forms.ListView();
            this.lblCongViec = new System.Windows.Forms.Label();
            this.pnlDSNV = new System.Windows.Forms.Panel();
            this.lstvNhanVien = new System.Windows.Forms.ListView();
            this.lblDSNV = new System.Windows.Forms.Label();
            this.gboLuong = new System.Windows.Forms.GroupBox();
            this.nudThuongPhat = new System.Windows.Forms.NumericUpDown();
            this.nudNgayNghi = new System.Windows.Forms.NumericUpDown();
            this.nudTongSoNgay = new System.Windows.Forms.NumericUpDown();
            this.nudLuongLamThem = new System.Windows.Forms.NumericUpDown();
            this.nudSoBuoiLamThem = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nudTongPhuCap = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.pnlLuong.SuspendLayout();
            this.pnlCongViec.SuspendLayout();
            this.pnlDSNV.SuspendLayout();
            this.gboLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThuongPhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNgayNghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongLamThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoBuoiLamThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongPhuCap)).BeginInit();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(1336, 994);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 0;
            this.picNen.TabStop = false;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTim.IconColor = System.Drawing.Color.Blue;
            this.btnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTim.IconSize = 20;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(603, 28);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(125, 35);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(86, 30);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(511, 30);
            this.txtTen.TabIndex = 23;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(30, 33);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(50, 25);
            this.lblTen.TabIndex = 21;
            this.lblTen.Text = "Tên";
            // 
            // btnTinh
            // 
            this.btnTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnTinh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTinh.IconSize = 22;
            this.btnTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTinh.Location = new System.Drawing.Point(414, 286);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(250, 43);
            this.btnTinh.TabIndex = 19;
            this.btnTinh.Text = "Tính lương";
            this.btnTinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // pnlLuong
            // 
            this.pnlLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLuong.Controls.Add(this.lstvLuong);
            this.pnlLuong.Controls.Add(this.lblDSLuong);
            this.pnlLuong.Location = new System.Drawing.Point(767, 597);
            this.pnlLuong.Name = "pnlLuong";
            this.pnlLuong.Size = new System.Drawing.Size(546, 343);
            this.pnlLuong.TabIndex = 18;
            // 
            // lstvLuong
            // 
            this.lstvLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvLuong.HideSelection = false;
            this.lstvLuong.Location = new System.Drawing.Point(20, 51);
            this.lstvLuong.Name = "lstvLuong";
            this.lstvLuong.Size = new System.Drawing.Size(508, 276);
            this.lstvLuong.TabIndex = 1;
            this.lstvLuong.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSLuong
            // 
            this.lblDSLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSLuong.Location = new System.Drawing.Point(0, 0);
            this.lblDSLuong.Name = "lblDSLuong";
            this.lblDSLuong.Size = new System.Drawing.Size(542, 37);
            this.lblDSLuong.TabIndex = 0;
            this.lblDSLuong.Text = "Danh sách bảng lương";
            this.lblDSLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số buổi làm thêm";
            // 
            // lblTP
            // 
            this.lblTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTP.AutoSize = true;
            this.lblTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTP.Location = new System.Drawing.Point(19, 246);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(126, 25);
            this.lblTP.TabIndex = 15;
            this.lblTP.Text = "Thưởng/Phạt";
            // 
            // pnlCongViec
            // 
            this.pnlCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCongViec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCongViec.Controls.Add(this.lstvNgayNghi);
            this.pnlCongViec.Controls.Add(this.lblCongViec);
            this.pnlCongViec.Location = new System.Drawing.Point(767, 71);
            this.pnlCongViec.Name = "pnlCongViec";
            this.pnlCongViec.Size = new System.Drawing.Size(546, 502);
            this.pnlCongViec.TabIndex = 12;
            // 
            // lstvNgayNghi
            // 
            this.lstvNgayNghi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvNgayNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvNgayNghi.HideSelection = false;
            this.lstvNgayNghi.Location = new System.Drawing.Point(19, 55);
            this.lstvNgayNghi.Name = "lstvNgayNghi";
            this.lstvNgayNghi.Size = new System.Drawing.Size(506, 425);
            this.lstvNgayNghi.TabIndex = 1;
            this.lstvNgayNghi.UseCompatibleStateImageBehavior = false;
            // 
            // lblCongViec
            // 
            this.lblCongViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCongViec.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongViec.Location = new System.Drawing.Point(0, 0);
            this.lblCongViec.Name = "lblCongViec";
            this.lblCongViec.Size = new System.Drawing.Size(542, 37);
            this.lblCongViec.TabIndex = 0;
            this.lblCongViec.Text = "Chi tiết ngày nghỉ";
            this.lblCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDSNV
            // 
            this.pnlDSNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSNV.Controls.Add(this.lstvNhanVien);
            this.pnlDSNV.Controls.Add(this.lblDSNV);
            this.pnlDSNV.Location = new System.Drawing.Point(28, 69);
            this.pnlDSNV.Name = "pnlDSNV";
            this.pnlDSNV.Size = new System.Drawing.Size(700, 502);
            this.pnlDSNV.TabIndex = 11;
            // 
            // lstvNhanVien
            // 
            this.lstvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvNhanVien.HideSelection = false;
            this.lstvNhanVien.Location = new System.Drawing.Point(13, 53);
            this.lstvNhanVien.MultiSelect = false;
            this.lstvNhanVien.Name = "lstvNhanVien";
            this.lstvNhanVien.Size = new System.Drawing.Size(672, 428);
            this.lstvNhanVien.TabIndex = 1;
            this.lstvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lstvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lstvNhanVien_SelectedIndexChanged);
            // 
            // lblDSNV
            // 
            this.lblDSNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSNV.Location = new System.Drawing.Point(0, 0);
            this.lblDSNV.Name = "lblDSNV";
            this.lblDSNV.Size = new System.Drawing.Size(696, 37);
            this.lblDSNV.TabIndex = 0;
            this.lblDSNV.Text = "Danh sách nhân viên hành chánh";
            this.lblDSNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gboLuong
            // 
            this.gboLuong.Controls.Add(this.nudThuongPhat);
            this.gboLuong.Controls.Add(this.nudTongPhuCap);
            this.gboLuong.Controls.Add(this.nudNgayNghi);
            this.gboLuong.Controls.Add(this.nudTongSoNgay);
            this.gboLuong.Controls.Add(this.nudLuongLamThem);
            this.gboLuong.Controls.Add(this.nudSoBuoiLamThem);
            this.gboLuong.Controls.Add(this.label12);
            this.gboLuong.Controls.Add(this.label5);
            this.gboLuong.Controls.Add(this.label4);
            this.gboLuong.Controls.Add(this.label6);
            this.gboLuong.Controls.Add(this.btnTinh);
            this.gboLuong.Controls.Add(this.label1);
            this.gboLuong.Controls.Add(this.lblTP);
            this.gboLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboLuong.Location = new System.Drawing.Point(28, 597);
            this.gboLuong.Name = "gboLuong";
            this.gboLuong.Size = new System.Drawing.Size(700, 343);
            this.gboLuong.TabIndex = 25;
            this.gboLuong.TabStop = false;
            this.gboLuong.Text = "Cập nhật lương";
            // 
            // nudThuongPhat
            // 
            this.nudThuongPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudThuongPhat.Location = new System.Drawing.Point(247, 243);
            this.nudThuongPhat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudThuongPhat.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudThuongPhat.Name = "nudThuongPhat";
            this.nudThuongPhat.Size = new System.Drawing.Size(417, 30);
            this.nudThuongPhat.TabIndex = 18;
            this.nudThuongPhat.ThousandsSeparator = true;
            // 
            // nudNgayNghi
            // 
            this.nudNgayNghi.Enabled = false;
            this.nudNgayNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNgayNghi.Location = new System.Drawing.Point(247, 161);
            this.nudNgayNghi.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudNgayNghi.Name = "nudNgayNghi";
            this.nudNgayNghi.Size = new System.Drawing.Size(417, 30);
            this.nudNgayNghi.TabIndex = 18;
            this.nudNgayNghi.ThousandsSeparator = true;
            // 
            // nudTongSoNgay
            // 
            this.nudTongSoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTongSoNgay.Location = new System.Drawing.Point(247, 38);
            this.nudTongSoNgay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudTongSoNgay.Name = "nudTongSoNgay";
            this.nudTongSoNgay.Size = new System.Drawing.Size(417, 30);
            this.nudTongSoNgay.TabIndex = 18;
            this.nudTongSoNgay.ThousandsSeparator = true;
            this.nudTongSoNgay.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            // 
            // nudLuongLamThem
            // 
            this.nudLuongLamThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLuongLamThem.Location = new System.Drawing.Point(247, 120);
            this.nudLuongLamThem.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudLuongLamThem.Name = "nudLuongLamThem";
            this.nudLuongLamThem.Size = new System.Drawing.Size(417, 30);
            this.nudLuongLamThem.TabIndex = 18;
            this.nudLuongLamThem.ThousandsSeparator = true;
            this.nudLuongLamThem.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // nudSoBuoiLamThem
            // 
            this.nudSoBuoiLamThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoBuoiLamThem.Location = new System.Drawing.Point(247, 79);
            this.nudSoBuoiLamThem.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSoBuoiLamThem.Name = "nudSoBuoiLamThem";
            this.nudSoBuoiLamThem.Size = new System.Drawing.Size(417, 30);
            this.nudSoBuoiLamThem.TabIndex = 18;
            this.nudSoBuoiLamThem.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số ngày nghỉ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tổng số ngày";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lương/buổi làm thêm";
            // 
            // cboThang
            // 
            this.cboThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(951, 29);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(147, 33);
            this.cboThang.TabIndex = 26;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(871, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1104, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Năm";
            // 
            // cboNam
            // 
            this.cboNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(1166, 29);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(147, 33);
            this.cboNam.TabIndex = 26;
            this.cboNam.SelectedIndexChanged += new System.EventHandler(this.cboNam_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tổng phụ cấp";
            // 
            // nudTongPhuCap
            // 
            this.nudTongPhuCap.Enabled = false;
            this.nudTongPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTongPhuCap.Location = new System.Drawing.Point(246, 202);
            this.nudTongPhuCap.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTongPhuCap.Name = "nudTongPhuCap";
            this.nudTongPhuCap.Size = new System.Drawing.Size(417, 30);
            this.nudTongPhuCap.TabIndex = 18;
            this.nudTongPhuCap.ThousandsSeparator = true;
            // 
            // frmTinhLuongHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1336, 994);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.gboLuong);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.pnlLuong);
            this.Controls.Add(this.pnlCongViec);
            this.Controls.Add(this.pnlDSNV);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTinhLuongHC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTinhLuongHC";
            this.Load += new System.EventHandler(this.frmTinhLuongHC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.pnlLuong.ResumeLayout(false);
            this.pnlCongViec.ResumeLayout(false);
            this.pnlDSNV.ResumeLayout(false);
            this.gboLuong.ResumeLayout(false);
            this.gboLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThuongPhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNgayNghi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuongLamThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoBuoiLamThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongPhuCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private FontAwesome.Sharp.IconButton btnTim;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private FontAwesome.Sharp.IconButton btnTinh;
        private System.Windows.Forms.Panel pnlLuong;
        private System.Windows.Forms.ListView lstvLuong;
        private System.Windows.Forms.Label lblDSLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Panel pnlCongViec;
        private System.Windows.Forms.ListView lstvNgayNghi;
        private System.Windows.Forms.Label lblCongViec;
        private System.Windows.Forms.Panel pnlDSNV;
        private System.Windows.Forms.ListView lstvNhanVien;
        private System.Windows.Forms.Label lblDSNV;
        private System.Windows.Forms.GroupBox gboLuong;
        private System.Windows.Forms.NumericUpDown nudSoBuoiLamThem;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.NumericUpDown nudThuongPhat;
        private System.Windows.Forms.NumericUpDown nudNgayNghi;
        private System.Windows.Forms.NumericUpDown nudTongSoNgay;
        private System.Windows.Forms.NumericUpDown nudLuongLamThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudTongPhuCap;
        private System.Windows.Forms.Label label12;
    }
}