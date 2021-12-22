
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmNhanVien
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
            this.ptcNen = new System.Windows.Forms.PictureBox();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.txtHV = new System.Windows.Forms.Panel();
            this.lblDS = new System.Windows.Forms.Label();
            this.lvwDSNV = new System.Windows.Forms.ListView();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.gbxInfoSlary = new System.Windows.Forms.GroupBox();
            this.txtIndexSalary = new System.Windows.Forms.TextBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.lblIndexSalary = new System.Windows.Forms.Label();
            this.lblSalaryBasic = new System.Windows.Forms.Label();
            this.gbxInfoWork = new System.Windows.Forms.GroupBox();
            this.cboHV = new System.Windows.Forms.ComboBox();
            this.cboCV = new System.Windows.Forms.ComboBox();
            this.cboPB = new System.Windows.Forms.ComboBox();
            this.txtNN = new System.Windows.Forms.TextBox();
            this.txtSeniority = new System.Windows.Forms.TextBox();
            this.lblNN = new System.Windows.Forms.Label();
            this.lblSeniority = new System.Windows.Forms.Label();
            this.lblStudy = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDeparment = new System.Windows.Forms.Label();
            this.gbxInfor = new System.Windows.Forms.GroupBox();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lablBirthDay = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNen)).BeginInit();
            this.txtHV.SuspendLayout();
            this.gbxInfoSlary.SuspendLayout();
            this.gbxInfoWork.SuspendLayout();
            this.gbxInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptcNen
            // 
            this.ptcNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptcNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.ptcNen.Location = new System.Drawing.Point(0, 0);
            this.ptcNen.Name = "ptcNen";
            this.ptcNen.Size = new System.Drawing.Size(1657, 919);
            this.ptcNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcNen.TabIndex = 0;
            this.ptcNen.TabStop = false;
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSearch.ForeColor = System.Drawing.Color.White;
            this.lblNameSearch.Location = new System.Drawing.Point(922, 22);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(150, 25);
            this.lblNameSearch.TabIndex = 37;
            this.lblNameSearch.Text = "Tên nhân viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Red;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 25;
            this.btnXoa.Location = new System.Drawing.Point(533, 746);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 43);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 25;
            this.btnSua.Location = new System.Drawing.Point(285, 749);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 43);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(42)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 25;
            this.btnThem.Location = new System.Drawing.Point(19, 749);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 43);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtHV
            // 
            this.txtHV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtHV.Controls.Add(this.lblDS);
            this.txtHV.Controls.Add(this.btnXoa);
            this.txtHV.Controls.Add(this.lvwDSNV);
            this.txtHV.Controls.Add(this.btnSua);
            this.txtHV.Controls.Add(this.btnThem);
            this.txtHV.Location = new System.Drawing.Point(927, 74);
            this.txtHV.Name = "txtHV";
            this.txtHV.Size = new System.Drawing.Size(647, 817);
            this.txtHV.TabIndex = 33;
            // 
            // lblDS
            // 
            this.lblDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDS.Location = new System.Drawing.Point(0, 0);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(643, 35);
            this.lblDS.TabIndex = 15;
            this.lblDS.Text = "Danh sách nhân viên";
            this.lblDS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwDSNV
            // 
            this.lvwDSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDSNV.HideSelection = false;
            this.lvwDSNV.Location = new System.Drawing.Point(19, 54);
            this.lvwDSNV.MultiSelect = false;
            this.lvwDSNV.Name = "lvwDSNV";
            this.lvwDSNV.Size = new System.Drawing.Size(609, 673);
            this.lvwDSNV.TabIndex = 0;
            this.lvwDSNV.UseCompatibleStateImageBehavior = false;
            this.lvwDSNV.SelectedIndexChanged += new System.EventHandler(this.lvwDSNV_SelectedIndexChanged);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.Location = new System.Drawing.Point(1105, 17);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(350, 30);
            this.txtNameSearch.TabIndex = 32;
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
            this.btnTimKiem.Location = new System.Drawing.Point(1505, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(67, 30);
            this.btnTimKiem.TabIndex = 31;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gbxInfoSlary
            // 
            this.gbxInfoSlary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxInfoSlary.Controls.Add(this.txtIndexSalary);
            this.gbxInfoSlary.Controls.Add(this.txtBasicSalary);
            this.gbxInfoSlary.Controls.Add(this.lblIndexSalary);
            this.gbxInfoSlary.Controls.Add(this.lblSalaryBasic);
            this.gbxInfoSlary.Font = new System.Drawing.Font("Verdana", 8F);
            this.gbxInfoSlary.Location = new System.Drawing.Point(42, 728);
            this.gbxInfoSlary.Name = "gbxInfoSlary";
            this.gbxInfoSlary.Size = new System.Drawing.Size(818, 163);
            this.gbxInfoSlary.TabIndex = 30;
            this.gbxInfoSlary.TabStop = false;
            this.gbxInfoSlary.Text = "Thông tin lương";
            // 
            // txtIndexSalary
            // 
            this.txtIndexSalary.BackColor = System.Drawing.SystemColors.Window;
            this.txtIndexSalary.Enabled = false;
            this.txtIndexSalary.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtIndexSalary.Location = new System.Drawing.Point(339, 100);
            this.txtIndexSalary.Name = "txtIndexSalary";
            this.txtIndexSalary.Size = new System.Drawing.Size(410, 29);
            this.txtIndexSalary.TabIndex = 2;
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.BackColor = System.Drawing.SystemColors.Window;
            this.txtBasicSalary.Enabled = false;
            this.txtBasicSalary.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtBasicSalary.Location = new System.Drawing.Point(339, 34);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(410, 29);
            this.txtBasicSalary.TabIndex = 2;
            // 
            // lblIndexSalary
            // 
            this.lblIndexSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIndexSalary.AutoSize = true;
            this.lblIndexSalary.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblIndexSalary.Location = new System.Drawing.Point(22, 106);
            this.lblIndexSalary.Name = "lblIndexSalary";
            this.lblIndexSalary.Size = new System.Drawing.Size(120, 22);
            this.lblIndexSalary.TabIndex = 1;
            this.lblIndexSalary.Text = "Chỉ số lương";
            // 
            // lblSalaryBasic
            // 
            this.lblSalaryBasic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalaryBasic.AutoSize = true;
            this.lblSalaryBasic.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblSalaryBasic.Location = new System.Drawing.Point(22, 40);
            this.lblSalaryBasic.Name = "lblSalaryBasic";
            this.lblSalaryBasic.Size = new System.Drawing.Size(140, 22);
            this.lblSalaryBasic.TabIndex = 1;
            this.lblSalaryBasic.Text = "Lương căn bản";
            // 
            // gbxInfoWork
            // 
            this.gbxInfoWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxInfoWork.Controls.Add(this.cboHV);
            this.gbxInfoWork.Controls.Add(this.cboCV);
            this.gbxInfoWork.Controls.Add(this.cboPB);
            this.gbxInfoWork.Controls.Add(this.txtNN);
            this.gbxInfoWork.Controls.Add(this.txtSeniority);
            this.gbxInfoWork.Controls.Add(this.lblNN);
            this.gbxInfoWork.Controls.Add(this.lblSeniority);
            this.gbxInfoWork.Controls.Add(this.lblStudy);
            this.gbxInfoWork.Controls.Add(this.lblPosition);
            this.gbxInfoWork.Controls.Add(this.lblDeparment);
            this.gbxInfoWork.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbxInfoWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxInfoWork.Font = new System.Drawing.Font("Verdana", 8F);
            this.gbxInfoWork.ForeColor = System.Drawing.Color.Black;
            this.gbxInfoWork.Location = new System.Drawing.Point(42, 292);
            this.gbxInfoWork.Name = "gbxInfoWork";
            this.gbxInfoWork.Size = new System.Drawing.Size(818, 348);
            this.gbxInfoWork.TabIndex = 29;
            this.gbxInfoWork.TabStop = false;
            this.gbxInfoWork.Text = "Thông tin công việc";
            // 
            // cboHV
            // 
            this.cboHV.Enabled = false;
            this.cboHV.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHV.FormattingEnabled = true;
            this.cboHV.Location = new System.Drawing.Point(339, 164);
            this.cboHV.Name = "cboHV";
            this.cboHV.Size = new System.Drawing.Size(410, 30);
            this.cboHV.TabIndex = 3;
            // 
            // cboCV
            // 
            this.cboCV.Enabled = false;
            this.cboCV.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCV.FormattingEnabled = true;
            this.cboCV.Location = new System.Drawing.Point(339, 93);
            this.cboCV.Name = "cboCV";
            this.cboCV.Size = new System.Drawing.Size(410, 30);
            this.cboCV.TabIndex = 3;
            this.cboCV.SelectedIndexChanged += new System.EventHandler(this.cboCV_SelectedIndexChanged);
            // 
            // cboPB
            // 
            this.cboPB.Enabled = false;
            this.cboPB.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPB.FormattingEnabled = true;
            this.cboPB.Location = new System.Drawing.Point(339, 23);
            this.cboPB.Name = "cboPB";
            this.cboPB.Size = new System.Drawing.Size(410, 30);
            this.cboPB.TabIndex = 3;
            // 
            // txtNN
            // 
            this.txtNN.BackColor = System.Drawing.SystemColors.Window;
            this.txtNN.Enabled = false;
            this.txtNN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtNN.Location = new System.Drawing.Point(339, 302);
            this.txtNN.Name = "txtNN";
            this.txtNN.Size = new System.Drawing.Size(410, 29);
            this.txtNN.TabIndex = 2;
            // 
            // txtSeniority
            // 
            this.txtSeniority.BackColor = System.Drawing.SystemColors.Window;
            this.txtSeniority.Enabled = false;
            this.txtSeniority.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtSeniority.Location = new System.Drawing.Point(339, 238);
            this.txtSeniority.Name = "txtSeniority";
            this.txtSeniority.Size = new System.Drawing.Size(410, 29);
            this.txtSeniority.TabIndex = 2;
            // 
            // lblNN
            // 
            this.lblNN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNN.AutoSize = true;
            this.lblNN.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblNN.Location = new System.Drawing.Point(22, 308);
            this.lblNN.Name = "lblNN";
            this.lblNN.Size = new System.Drawing.Size(249, 22);
            this.lblNN.TabIndex = 1;
            this.lblNN.Text = "Trình độ ngoại ngữ (IELTS)";
            // 
            // lblSeniority
            // 
            this.lblSeniority.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeniority.AutoSize = true;
            this.lblSeniority.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblSeniority.Location = new System.Drawing.Point(26, 244);
            this.lblSeniority.Name = "lblSeniority";
            this.lblSeniority.Size = new System.Drawing.Size(186, 22);
            this.lblSeniority.TabIndex = 1;
            this.lblSeniority.Text = "Thâm niên công tác";
            // 
            // lblStudy
            // 
            this.lblStudy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudy.AutoSize = true;
            this.lblStudy.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblStudy.Location = new System.Drawing.Point(26, 171);
            this.lblStudy.Name = "lblStudy";
            this.lblStudy.Size = new System.Drawing.Size(83, 22);
            this.lblStudy.TabIndex = 1;
            this.lblStudy.Text = "Học vấn";
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblPosition.Location = new System.Drawing.Point(26, 100);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(82, 22);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Chức vụ";
            // 
            // lblDeparment
            // 
            this.lblDeparment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeparment.AutoSize = true;
            this.lblDeparment.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblDeparment.Location = new System.Drawing.Point(22, 30);
            this.lblDeparment.Name = "lblDeparment";
            this.lblDeparment.Size = new System.Drawing.Size(104, 22);
            this.lblDeparment.TabIndex = 1;
            this.lblDeparment.Text = "Phòng ban";
            // 
            // gbxInfor
            // 
            this.gbxInfor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.gbxInfor.Controls.Add(this.dtmDate);
            this.gbxInfor.Controls.Add(this.cboSex);
            this.gbxInfor.Controls.Add(this.txtAdress);
            this.gbxInfor.Controls.Add(this.txtPhone);
            this.gbxInfor.Controls.Add(this.txtCMND);
            this.gbxInfor.Controls.Add(this.txtName);
            this.gbxInfor.Controls.Add(this.lblAdress);
            this.gbxInfor.Controls.Add(this.lblID);
            this.gbxInfor.Controls.Add(this.lblPhone);
            this.gbxInfor.Controls.Add(this.lablBirthDay);
            this.gbxInfor.Controls.Add(this.lblSex);
            this.gbxInfor.Controls.Add(this.lblName);
            this.gbxInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxInfor.Font = new System.Drawing.Font("Verdana", 8F);
            this.gbxInfor.Location = new System.Drawing.Point(42, 22);
            this.gbxInfor.Name = "gbxInfor";
            this.gbxInfor.Size = new System.Drawing.Size(818, 226);
            this.gbxInfor.TabIndex = 28;
            this.gbxInfor.TabStop = false;
            this.gbxInfor.Text = "Thông tin cá nhân";
            // 
            // dtmDate
            // 
            this.dtmDate.Enabled = false;
            this.dtmDate.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDate.Location = new System.Drawing.Point(211, 79);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(265, 29);
            this.dtmDate.TabIndex = 5;
            // 
            // cboSex
            // 
            this.cboSex.Enabled = false;
            this.cboSex.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboSex.Location = new System.Drawing.Point(630, 78);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(182, 30);
            this.cboSex.TabIndex = 3;
            // 
            // txtAdress
            // 
            this.txtAdress.Enabled = false;
            this.txtAdress.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtAdress.Location = new System.Drawing.Point(211, 179);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(601, 29);
            this.txtAdress.TabIndex = 2;
            this.txtAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(630, 26);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(182, 29);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCMND
            // 
            this.txtCMND.Enabled = false;
            this.txtCMND.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtCMND.Location = new System.Drawing.Point(211, 129);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(265, 29);
            this.txtCMND.TabIndex = 2;
            this.txtCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(211, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 29);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblAdress.Location = new System.Drawing.Point(22, 185);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(71, 22);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "Địa chỉ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblID.Location = new System.Drawing.Point(22, 135);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(126, 22);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "CMND/CCCD";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblPhone.Location = new System.Drawing.Point(483, 32);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(128, 22);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lablBirthDay
            // 
            this.lablBirthDay.AutoSize = true;
            this.lablBirthDay.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lablBirthDay.Location = new System.Drawing.Point(22, 85);
            this.lablBirthDay.Name = "lablBirthDay";
            this.lablBirthDay.Size = new System.Drawing.Size(98, 22);
            this.lablBirthDay.TabIndex = 1;
            this.lablBirthDay.Text = "Ngày sinh";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblSex.Location = new System.Drawing.Point(483, 85);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(85, 22);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "Giới tính";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblName.Location = new System.Drawing.Point(26, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên nhân viên";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1657, 919);
            this.Controls.Add(this.lblNameSearch);
            this.Controls.Add(this.txtHV);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.gbxInfoSlary);
            this.Controls.Add(this.gbxInfoWork);
            this.Controls.Add(this.gbxInfor);
            this.Controls.Add(this.ptcNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcNen)).EndInit();
            this.txtHV.ResumeLayout(false);
            this.gbxInfoSlary.ResumeLayout(false);
            this.gbxInfoSlary.PerformLayout();
            this.gbxInfoWork.ResumeLayout(false);
            this.gbxInfoWork.PerformLayout();
            this.gbxInfor.ResumeLayout(false);
            this.gbxInfor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcNen;
        private System.Windows.Forms.Label lblNameSearch;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Panel txtHV;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.ListView lvwDSNV;
        private System.Windows.Forms.TextBox txtNameSearch;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.GroupBox gbxInfoSlary;
        private System.Windows.Forms.TextBox txtIndexSalary;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.Label lblIndexSalary;
        private System.Windows.Forms.Label lblSalaryBasic;
        private System.Windows.Forms.GroupBox gbxInfoWork;
        private System.Windows.Forms.ComboBox cboHV;
        private System.Windows.Forms.ComboBox cboCV;
        private System.Windows.Forms.ComboBox cboPB;
        private System.Windows.Forms.TextBox txtNN;
        private System.Windows.Forms.TextBox txtSeniority;
        private System.Windows.Forms.Label lblNN;
        private System.Windows.Forms.Label lblSeniority;
        private System.Windows.Forms.Label lblStudy;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDeparment;
        private System.Windows.Forms.GroupBox gbxInfor;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lablBirthDay;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
    }
}