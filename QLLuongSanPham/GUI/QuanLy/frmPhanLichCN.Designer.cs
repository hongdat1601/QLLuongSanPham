
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmPhanLichCN
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
            this.pnlDSSP = new System.Windows.Forms.Panel();
            this.lvwDSSP = new System.Windows.Forms.ListView();
            this.lblDSSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtSpSearch = new System.Windows.Forms.TextBox();
            this.btnTimDSSP = new FontAwesome.Sharp.IconButton();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblNameSP = new System.Windows.Forms.Label();
            this.txtTenSpInput = new System.Windows.Forms.TextBox();
            this.cboTenCD = new System.Windows.Forms.ComboBox();
            this.lblTenCĐ = new System.Windows.Forms.Label();
            this.lblCa = new System.Windows.Forms.Label();
            this.cboCa = new System.Windows.Forms.ComboBox();
            this.dtmNgay = new System.Windows.Forms.DateTimePicker();
            this.pnlDSPC = new System.Windows.Forms.Panel();
            this.lvwDSPC = new System.Windows.Forms.ListView();
            this.lblDSPhanCong = new System.Windows.Forms.Label();
            this.pnlDSNV = new System.Windows.Forms.Panel();
            this.lvwDSNV = new System.Windows.Forms.ListView();
            this.lsbDSNV = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvwDSLich = new System.Windows.Forms.ListView();
            this.lblDSLich = new System.Windows.Forms.Label();
            this.txtNgaySearch = new System.Windows.Forms.TextBox();
            this.lblDateSearch = new System.Windows.Forms.Label();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.txtTenSpSearch = new System.Windows.Forms.TextBox();
            this.lblCDSearch = new System.Windows.Forms.Label();
            this.txtCDSearch = new System.Windows.Forms.TextBox();
            this.lblCaSearch = new System.Windows.Forms.Label();
            this.btnTimDSSCa = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnLeft = new FontAwesome.Sharp.IconButton();
            this.btnRight = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlDSSP.SuspendLayout();
            this.pnlDSPC.SuspendLayout();
            this.pnlDSNV.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDSSP
            // 
            this.pnlDSSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDSSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSSP.Controls.Add(this.lvwDSSP);
            this.pnlDSSP.Controls.Add(this.lblDSSP);
            this.pnlDSSP.Location = new System.Drawing.Point(25, 72);
            this.pnlDSSP.Name = "pnlDSSP";
            this.pnlDSSP.Size = new System.Drawing.Size(389, 510);
            this.pnlDSSP.TabIndex = 0;
            // 
            // lvwDSSP
            // 
            this.lvwDSSP.HideSelection = false;
            this.lvwDSSP.Location = new System.Drawing.Point(14, 46);
            this.lvwDSSP.Name = "lvwDSSP";
            this.lvwDSSP.Size = new System.Drawing.Size(355, 440);
            this.lvwDSSP.TabIndex = 1;
            this.lvwDSSP.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSSP
            // 
            this.lblDSSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDSSP.Location = new System.Drawing.Point(0, 0);
            this.lblDSSP.Name = "lblDSSP";
            this.lblDSSP.Size = new System.Drawing.Size(385, 33);
            this.lblDSSP.TabIndex = 0;
            this.lblDSSP.Text = "Danh sách sản phẩm";
            this.lblDSSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(21, 31);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(64, 20);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên SP";
            // 
            // txtSpSearch
            // 
            this.txtSpSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpSearch.Location = new System.Drawing.Point(96, 25);
            this.txtSpSearch.Name = "txtSpSearch";
            this.txtSpSearch.Size = new System.Drawing.Size(229, 26);
            this.txtSpSearch.TabIndex = 2;
            // 
            // btnTimDSSP
            // 
            this.btnTimDSSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimDSSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimDSSP.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimDSSP.IconColor = System.Drawing.Color.Blue;
            this.btnTimDSSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimDSSP.IconSize = 20;
            this.btnTimDSSP.Location = new System.Drawing.Point(351, 21);
            this.btnTimDSSP.Name = "btnTimDSSP";
            this.btnTimDSSP.Size = new System.Drawing.Size(63, 30);
            this.btnTimDSSP.TabIndex = 3;
            this.btnTimDSSP.UseVisualStyleBackColor = true;
            // 
            // lblNgay
            // 
            this.lblNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNgay.Location = new System.Drawing.Point(438, 145);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(58, 25);
            this.lblNgay.TabIndex = 4;
            this.lblNgay.Text = "Ngày";
            // 
            // lblNameSP
            // 
            this.lblNameSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameSP.AutoSize = true;
            this.lblNameSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNameSP.Location = new System.Drawing.Point(437, 231);
            this.lblNameSP.Name = "lblNameSP";
            this.lblNameSP.Size = new System.Drawing.Size(138, 25);
            this.lblNameSP.TabIndex = 4;
            this.lblNameSP.Text = "Tên sản phẩm";
            // 
            // txtTenSpInput
            // 
            this.txtTenSpInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSpInput.Location = new System.Drawing.Point(602, 225);
            this.txtTenSpInput.Name = "txtTenSpInput";
            this.txtTenSpInput.Size = new System.Drawing.Size(274, 30);
            this.txtTenSpInput.TabIndex = 5;
            // 
            // cboTenCD
            // 
            this.cboTenCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTenCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboTenCD.FormattingEnabled = true;
            this.cboTenCD.Location = new System.Drawing.Point(602, 313);
            this.cboTenCD.Name = "cboTenCD";
            this.cboTenCD.Size = new System.Drawing.Size(274, 33);
            this.cboTenCD.TabIndex = 6;
            // 
            // lblTenCĐ
            // 
            this.lblTenCĐ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenCĐ.AutoSize = true;
            this.lblTenCĐ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTenCĐ.Location = new System.Drawing.Point(438, 321);
            this.lblTenCĐ.Name = "lblTenCĐ";
            this.lblTenCĐ.Size = new System.Drawing.Size(144, 25);
            this.lblTenCĐ.TabIndex = 4;
            this.lblTenCĐ.Text = "Tên công đoạn";
            // 
            // lblCa
            // 
            this.lblCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCa.AutoSize = true;
            this.lblCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCa.Location = new System.Drawing.Point(437, 419);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(38, 25);
            this.lblCa.TabIndex = 4;
            this.lblCa.Text = "Ca";
            // 
            // cboCa
            // 
            this.cboCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboCa.FormattingEnabled = true;
            this.cboCa.Location = new System.Drawing.Point(602, 411);
            this.cboCa.Name = "cboCa";
            this.cboCa.Size = new System.Drawing.Size(274, 33);
            this.cboCa.TabIndex = 6;
            // 
            // dtmNgay
            // 
            this.dtmNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtmNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtmNgay.Location = new System.Drawing.Point(602, 140);
            this.dtmNgay.Name = "dtmNgay";
            this.dtmNgay.Size = new System.Drawing.Size(274, 30);
            this.dtmNgay.TabIndex = 7;
            // 
            // pnlDSPC
            // 
            this.pnlDSPC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDSPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSPC.Controls.Add(this.lvwDSPC);
            this.pnlDSPC.Controls.Add(this.lblDSPhanCong);
            this.pnlDSPC.Location = new System.Drawing.Point(911, 72);
            this.pnlDSPC.Name = "pnlDSPC";
            this.pnlDSPC.Size = new System.Drawing.Size(306, 510);
            this.pnlDSPC.TabIndex = 8;
            // 
            // lvwDSPC
            // 
            this.lvwDSPC.HideSelection = false;
            this.lvwDSPC.Location = new System.Drawing.Point(14, 46);
            this.lvwDSPC.Name = "lvwDSPC";
            this.lvwDSPC.Size = new System.Drawing.Size(275, 440);
            this.lvwDSPC.TabIndex = 1;
            this.lvwDSPC.UseCompatibleStateImageBehavior = false;
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
            this.lblDSPhanCong.Text = "Danh sách phân công";
            this.lblDSPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDSNV
            // 
            this.pnlDSNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDSNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSNV.Controls.Add(this.lvwDSNV);
            this.pnlDSNV.Controls.Add(this.lsbDSNV);
            this.pnlDSNV.Location = new System.Drawing.Point(1291, 72);
            this.pnlDSNV.Name = "pnlDSNV";
            this.pnlDSNV.Size = new System.Drawing.Size(312, 510);
            this.pnlDSNV.TabIndex = 9;
            // 
            // lvwDSNV
            // 
            this.lvwDSNV.HideSelection = false;
            this.lvwDSNV.Location = new System.Drawing.Point(14, 46);
            this.lvwDSNV.Name = "lvwDSNV";
            this.lvwDSNV.Size = new System.Drawing.Size(279, 440);
            this.lvwDSNV.TabIndex = 1;
            this.lvwDSNV.UseCompatibleStateImageBehavior = false;
            // 
            // lsbDSNV
            // 
            this.lsbDSNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsbDSNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsbDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lsbDSNV.Location = new System.Drawing.Point(0, 0);
            this.lsbDSNV.Name = "lsbDSNV";
            this.lsbDSNV.Size = new System.Drawing.Size(308, 33);
            this.lsbDSNV.TabIndex = 0;
            this.lsbDSNV.Text = "Danh sách công nhân";
            this.lsbDSNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lvwDSLich);
            this.panel3.Controls.Add(this.lblDSLich);
            this.panel3.Location = new System.Drawing.Point(25, 651);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1578, 303);
            this.panel3.TabIndex = 10;
            // 
            // lvwDSLich
            // 
            this.lvwDSLich.HideSelection = false;
            this.lvwDSLich.Location = new System.Drawing.Point(14, 47);
            this.lvwDSLich.Name = "lvwDSLich";
            this.lvwDSLich.Size = new System.Drawing.Size(1545, 237);
            this.lvwDSLich.TabIndex = 1;
            this.lvwDSLich.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSLich
            // 
            this.lblDSLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSLich.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDSLich.Location = new System.Drawing.Point(0, 0);
            this.lblDSLich.Name = "lblDSLich";
            this.lblDSLich.Size = new System.Drawing.Size(1574, 33);
            this.lblDSLich.TabIndex = 0;
            this.lblDSLich.Text = "Danh sách lịch làm việc";
            this.lblDSLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNgaySearch
            // 
            this.txtNgaySearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgaySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNgaySearch.Location = new System.Drawing.Point(83, 613);
            this.txtNgaySearch.Name = "txtNgaySearch";
            this.txtNgaySearch.Size = new System.Drawing.Size(168, 26);
            this.txtNgaySearch.TabIndex = 5;
            // 
            // lblDateSearch
            // 
            this.lblDateSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateSearch.AutoSize = true;
            this.lblDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDateSearch.Location = new System.Drawing.Point(21, 616);
            this.lblDateSearch.Name = "lblDateSearch";
            this.lblDateSearch.Size = new System.Drawing.Size(47, 20);
            this.lblDateSearch.TabIndex = 4;
            this.lblDateSearch.Text = "Ngày";
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNameSearch.Location = new System.Drawing.Point(347, 619);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(115, 20);
            this.lblNameSearch.TabIndex = 4;
            this.lblNameSearch.Text = "Tên sản phẩm";
            // 
            // txtTenSpSearch
            // 
            this.txtTenSpSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTenSpSearch.Location = new System.Drawing.Point(490, 613);
            this.txtTenSpSearch.Name = "txtTenSpSearch";
            this.txtTenSpSearch.Size = new System.Drawing.Size(177, 26);
            this.txtTenSpSearch.TabIndex = 5;
            // 
            // lblCDSearch
            // 
            this.lblCDSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCDSearch.AutoSize = true;
            this.lblCDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCDSearch.Location = new System.Drawing.Point(777, 619);
            this.lblCDSearch.Name = "lblCDSearch";
            this.lblCDSearch.Size = new System.Drawing.Size(119, 20);
            this.lblCDSearch.TabIndex = 4;
            this.lblCDSearch.Text = "Tên công đoạn";
            // 
            // txtCDSearch
            // 
            this.txtCDSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCDSearch.Location = new System.Drawing.Point(927, 613);
            this.txtCDSearch.Name = "txtCDSearch";
            this.txtCDSearch.Size = new System.Drawing.Size(177, 26);
            this.txtCDSearch.TabIndex = 5;
            // 
            // lblCaSearch
            // 
            this.lblCaSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaSearch.AutoSize = true;
            this.lblCaSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCaSearch.Location = new System.Drawing.Point(1185, 619);
            this.lblCaSearch.Name = "lblCaSearch";
            this.lblCaSearch.Size = new System.Drawing.Size(30, 20);
            this.lblCaSearch.TabIndex = 4;
            this.lblCaSearch.Text = "Ca";
            // 
            // btnTimDSSCa
            // 
            this.btnTimDSSCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimDSSCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimDSSCa.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimDSSCa.IconColor = System.Drawing.Color.Blue;
            this.btnTimDSSCa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimDSSCa.IconSize = 20;
            this.btnTimDSSCa.Location = new System.Drawing.Point(1480, 607);
            this.btnTimDSSCa.Name = "btnTimDSSCa";
            this.btnTimDSSCa.Size = new System.Drawing.Size(121, 32);
            this.btnTimDSSCa.TabIndex = 11;
            this.btnTimDSSCa.Text = "Tìm kiếm";
            this.btnTimDSSCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimDSSCa.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Red;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 25;
            this.btnXoa.Location = new System.Drawing.Point(781, 539);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 43);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 25;
            this.btnSua.Location = new System.Drawing.Point(620, 539);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 43);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 25;
            this.btnThem.Location = new System.Drawing.Point(441, 539);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 43);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Phân lịch";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeft.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnLeft.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLeft.IconSize = 30;
            this.btnLeft.Location = new System.Drawing.Point(1223, 244);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(62, 59);
            this.btnLeft.TabIndex = 21;
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRight.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnRight.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRight.IconSize = 30;
            this.btnRight.Location = new System.Drawing.Point(1223, 337);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(62, 56);
            this.btnRight.TabIndex = 21;
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1244, 613);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 28);
            this.comboBox1.TabIndex = 22;
            // 
            // frmPhanLichCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 966);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimDSSCa);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlDSNV);
            this.Controls.Add(this.pnlDSPC);
            this.Controls.Add(this.dtmNgay);
            this.Controls.Add(this.cboCa);
            this.Controls.Add(this.cboTenCD);
            this.Controls.Add(this.txtNgaySearch);
            this.Controls.Add(this.txtCDSearch);
            this.Controls.Add(this.txtTenSpSearch);
            this.Controls.Add(this.txtTenSpInput);
            this.Controls.Add(this.lblCaSearch);
            this.Controls.Add(this.lblCa);
            this.Controls.Add(this.lblCDSearch);
            this.Controls.Add(this.lblTenCĐ);
            this.Controls.Add(this.lblNameSearch);
            this.Controls.Add(this.lblNameSP);
            this.Controls.Add(this.lblDateSearch);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.btnTimDSSP);
            this.Controls.Add(this.txtSpSearch);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.pnlDSSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhanLichCN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlDSSP.ResumeLayout(false);
            this.pnlDSPC.ResumeLayout(false);
            this.pnlDSNV.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDSSP;
        private System.Windows.Forms.Label lblDSSP;
        private System.Windows.Forms.ListView lvwDSSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtSpSearch;
        private FontAwesome.Sharp.IconButton btnTimDSSP;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblNameSP;
        private System.Windows.Forms.TextBox txtTenSpInput;
        private System.Windows.Forms.ComboBox cboTenCD;
        private System.Windows.Forms.Label lblTenCĐ;
        private System.Windows.Forms.Label lblCa;
        private System.Windows.Forms.ComboBox cboCa;
        private System.Windows.Forms.DateTimePicker dtmNgay;
        private System.Windows.Forms.Panel pnlDSPC;
        private System.Windows.Forms.ListView lvwDSPC;
        private System.Windows.Forms.Label lblDSPhanCong;
        private System.Windows.Forms.Panel pnlDSNV;
        private System.Windows.Forms.ListView lvwDSNV;
        private System.Windows.Forms.Label lsbDSNV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvwDSLich;
        private System.Windows.Forms.Label lblDSLich;
        private System.Windows.Forms.TextBox txtNgaySearch;
        private System.Windows.Forms.Label lblDateSearch;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.TextBox txtTenSpSearch;
        private System.Windows.Forms.Label lblCDSearch;
        private System.Windows.Forms.TextBox txtCDSearch;
        private System.Windows.Forms.Label lblCaSearch;
        private FontAwesome.Sharp.IconButton btnTimDSSCa;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnLeft;
        private FontAwesome.Sharp.IconButton btnRight;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}