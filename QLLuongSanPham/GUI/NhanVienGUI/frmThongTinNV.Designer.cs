
namespace QLLuongSanPham.GUI.NhanVienGUI
{
    partial class frmThongtinNV
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
            this.btnFixInfo = new FontAwesome.Sharp.IconButton();
            this.gbxInfoSlary = new System.Windows.Forms.GroupBox();
            this.txtIndexSalary = new System.Windows.Forms.TextBox();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.lblIndexSalary = new System.Windows.Forms.Label();
            this.lblSalaryBasic = new System.Windows.Forms.Label();
            this.gbxInfoWork = new System.Windows.Forms.GroupBox();
            this.txtSeniority = new System.Windows.Forms.TextBox();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.lblSeniority = new System.Windows.Forms.Label();
            this.txtStudy = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtDeparment = new System.Windows.Forms.TextBox();
            this.lblStudy = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDeparment = new System.Windows.Forms.Label();
            this.gbxInfor = new System.Windows.Forms.GroupBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtBirhDay = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lablBirthDay = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new FontAwesome.Sharp.IconButton();
            this.gbxInfoSlary.SuspendLayout();
            this.gbxInfoWork.SuspendLayout();
            this.gbxInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFixInfo
            // 
            this.btnFixInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFixInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnFixInfo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFixInfo.IconColor = System.Drawing.Color.Black;
            this.btnFixInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFixInfo.Location = new System.Drawing.Point(1007, 234);
            this.btnFixInfo.Name = "btnFixInfo";
            this.btnFixInfo.Size = new System.Drawing.Size(165, 38);
            this.btnFixInfo.TabIndex = 12;
            this.btnFixInfo.Text = "Sữa thông tin";
            this.btnFixInfo.UseVisualStyleBackColor = true;
            this.btnFixInfo.Click += new System.EventHandler(this.btnFixInfo_Click);
            // 
            // gbxInfoSlary
            // 
            this.gbxInfoSlary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxInfoSlary.Controls.Add(this.txtIndexSalary);
            this.gbxInfoSlary.Controls.Add(this.txtBasicSalary);
            this.gbxInfoSlary.Controls.Add(this.lblIndexSalary);
            this.gbxInfoSlary.Controls.Add(this.lblSalaryBasic);
            this.gbxInfoSlary.Font = new System.Drawing.Font("Verdana", 8F);
            this.gbxInfoSlary.Location = new System.Drawing.Point(35, 632);
            this.gbxInfoSlary.Name = "gbxInfoSlary";
            this.gbxInfoSlary.Size = new System.Drawing.Size(818, 163);
            this.gbxInfoSlary.TabIndex = 10;
            this.gbxInfoSlary.TabStop = false;
            this.gbxInfoSlary.Text = "Thông tin lương";
            // 
            // txtIndexSalary
            // 
            this.txtIndexSalary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIndexSalary.Enabled = false;
            this.txtIndexSalary.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtIndexSalary.Location = new System.Drawing.Point(339, 100);
            this.txtIndexSalary.Name = "txtIndexSalary";
            this.txtIndexSalary.Size = new System.Drawing.Size(410, 29);
            this.txtIndexSalary.TabIndex = 2;
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.lblIndexSalary.Size = new System.Drawing.Size(131, 23);
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
            this.lblSalaryBasic.Size = new System.Drawing.Size(151, 23);
            this.lblSalaryBasic.TabIndex = 1;
            this.lblSalaryBasic.Text = "Lương căn bản";
            // 
            // gbxInfoWork
            // 
            this.gbxInfoWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxInfoWork.Controls.Add(this.txtSeniority);
            this.gbxInfoWork.Controls.Add(this.lblEnglish);
            this.gbxInfoWork.Controls.Add(this.txtEnglish);
            this.gbxInfoWork.Controls.Add(this.lblSeniority);
            this.gbxInfoWork.Controls.Add(this.txtStudy);
            this.gbxInfoWork.Controls.Add(this.txtPosition);
            this.gbxInfoWork.Controls.Add(this.txtDeparment);
            this.gbxInfoWork.Controls.Add(this.lblStudy);
            this.gbxInfoWork.Controls.Add(this.lblPosition);
            this.gbxInfoWork.Controls.Add(this.lblDeparment);
            this.gbxInfoWork.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbxInfoWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxInfoWork.Font = new System.Drawing.Font("Verdana", 8F);
            this.gbxInfoWork.ForeColor = System.Drawing.Color.Black;
            this.gbxInfoWork.Location = new System.Drawing.Point(35, 306);
            this.gbxInfoWork.Name = "gbxInfoWork";
            this.gbxInfoWork.Size = new System.Drawing.Size(818, 300);
            this.gbxInfoWork.TabIndex = 9;
            this.gbxInfoWork.TabStop = false;
            this.gbxInfoWork.Text = "Thông tin công việc";
            // 
            // txtSeniority
            // 
            this.txtSeniority.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSeniority.Enabled = false;
            this.txtSeniority.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtSeniority.Location = new System.Drawing.Point(339, 249);
            this.txtSeniority.Name = "txtSeniority";
            this.txtSeniority.Size = new System.Drawing.Size(410, 29);
            this.txtSeniority.TabIndex = 2;
            // 
            // lblEnglish
            // 
            this.lblEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblEnglish.Location = new System.Drawing.Point(22, 195);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(267, 23);
            this.lblEnglish.TabIndex = 1;
            this.lblEnglish.Text = "Trình độ tiếng anh (IELST)";
            // 
            // txtEnglish
            // 
            this.txtEnglish.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEnglish.Enabled = false;
            this.txtEnglish.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtEnglish.Location = new System.Drawing.Point(339, 189);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(410, 29);
            this.txtEnglish.TabIndex = 2;
            // 
            // lblSeniority
            // 
            this.lblSeniority.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeniority.AutoSize = true;
            this.lblSeniority.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblSeniority.Location = new System.Drawing.Point(22, 255);
            this.lblSeniority.Name = "lblSeniority";
            this.lblSeniority.Size = new System.Drawing.Size(199, 23);
            this.lblSeniority.TabIndex = 1;
            this.lblSeniority.Text = "Thâm niên công tác";
            // 
            // txtStudy
            // 
            this.txtStudy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStudy.Enabled = false;
            this.txtStudy.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtStudy.Location = new System.Drawing.Point(339, 128);
            this.txtStudy.Name = "txtStudy";
            this.txtStudy.Size = new System.Drawing.Size(410, 29);
            this.txtStudy.TabIndex = 2;
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPosition.Enabled = false;
            this.txtPosition.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtPosition.Location = new System.Drawing.Point(339, 74);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(410, 29);
            this.txtPosition.TabIndex = 2;
            // 
            // txtDeparment
            // 
            this.txtDeparment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDeparment.Enabled = false;
            this.txtDeparment.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtDeparment.Location = new System.Drawing.Point(339, 21);
            this.txtDeparment.Name = "txtDeparment";
            this.txtDeparment.Size = new System.Drawing.Size(410, 29);
            this.txtDeparment.TabIndex = 2;
            // 
            // lblStudy
            // 
            this.lblStudy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudy.AutoSize = true;
            this.lblStudy.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblStudy.Location = new System.Drawing.Point(22, 134);
            this.lblStudy.Name = "lblStudy";
            this.lblStudy.Size = new System.Drawing.Size(87, 23);
            this.lblStudy.TabIndex = 1;
            this.lblStudy.Text = "Học vấn";
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblPosition.Location = new System.Drawing.Point(22, 80);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(87, 23);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Chức vụ";
            // 
            // lblDeparment
            // 
            this.lblDeparment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeparment.AutoSize = true;
            this.lblDeparment.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblDeparment.Location = new System.Drawing.Point(22, 27);
            this.lblDeparment.Name = "lblDeparment";
            this.lblDeparment.Size = new System.Drawing.Size(111, 23);
            this.lblDeparment.TabIndex = 1;
            this.lblDeparment.Text = "Phòng ban";
            // 
            // gbxInfor
            // 
            this.gbxInfor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxInfor.Controls.Add(this.cboSex);
            this.gbxInfor.Controls.Add(this.txtAdress);
            this.gbxInfor.Controls.Add(this.txtPhone);
            this.gbxInfor.Controls.Add(this.txtID);
            this.gbxInfor.Controls.Add(this.txtBirhDay);
            this.gbxInfor.Controls.Add(this.txtName);
            this.gbxInfor.Controls.Add(this.lblAdress);
            this.gbxInfor.Controls.Add(this.lblID);
            this.gbxInfor.Controls.Add(this.lblPhone);
            this.gbxInfor.Controls.Add(this.lablBirthDay);
            this.gbxInfor.Controls.Add(this.lblSex);
            this.gbxInfor.Controls.Add(this.lblName);
            this.gbxInfor.Font = new System.Drawing.Font("Verdana", 8F);
            this.gbxInfor.Location = new System.Drawing.Point(283, 13);
            this.gbxInfor.Name = "gbxInfor";
            this.gbxInfor.Size = new System.Drawing.Size(889, 205);
            this.gbxInfor.TabIndex = 8;
            this.gbxInfor.TabStop = false;
            this.gbxInfor.Text = "Thông tin cá nhân";
            // 
            // cboSex
            // 
            this.cboSex.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Name",
            "Nữ"});
            this.cboSex.Location = new System.Drawing.Point(687, 69);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(121, 30);
            this.cboSex.TabIndex = 3;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtAdress.Location = new System.Drawing.Point(211, 158);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(658, 29);
            this.txtAdress.TabIndex = 2;
            this.txtAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(687, 23);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(182, 29);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(211, 112);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(265, 29);
            this.txtID.TabIndex = 2;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBirhDay
            // 
            this.txtBirhDay.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtBirhDay.Location = new System.Drawing.Point(211, 70);
            this.txtBirhDay.Name = "txtBirhDay";
            this.txtBirhDay.Size = new System.Drawing.Size(265, 29);
            this.txtBirhDay.TabIndex = 2;
            this.txtBirhDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(211, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 29);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAdress
            // 
            this.lblAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblAdress.Location = new System.Drawing.Point(17, 164);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(77, 23);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "Địa chỉ";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblID.Location = new System.Drawing.Point(16, 118);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(131, 23);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "CMND/CCCD";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblPhone.Location = new System.Drawing.Point(501, 29);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(138, 23);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lablBirthDay
            // 
            this.lablBirthDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lablBirthDay.AutoSize = true;
            this.lablBirthDay.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lablBirthDay.Location = new System.Drawing.Point(17, 75);
            this.lablBirthDay.Name = "lablBirthDay";
            this.lablBirthDay.Size = new System.Drawing.Size(105, 23);
            this.lablBirthDay.TabIndex = 1;
            this.lablBirthDay.Text = "Ngày sinh";
            // 
            // lblSex
            // 
            this.lblSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblSex.Location = new System.Drawing.Point(501, 76);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(93, 23);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "Giới tính";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblName.Location = new System.Drawing.Point(16, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(146, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên nhân viên";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(32, 245);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(0, 18);
            this.lblRole.TabIndex = 7;
            // 
            // picImage
            // 
            this.picImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImage.Location = new System.Drawing.Point(35, 26);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(221, 192);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 6;
            this.picImage.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChonAnh.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnChonAnh.IconColor = System.Drawing.Color.Peru;
            this.btnChonAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChonAnh.IconSize = 25;
            this.btnChonAnh.Location = new System.Drawing.Point(141, 234);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(115, 40);
            this.btnChonAnh.TabIndex = 36;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // frmThongtinNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1205, 809);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnFixInfo);
            this.Controls.Add(this.gbxInfoSlary);
            this.Controls.Add(this.gbxInfoWork);
            this.Controls.Add(this.gbxInfor);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.picImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongtinNV";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmThongtinNV_Load);
            this.gbxInfoSlary.ResumeLayout(false);
            this.gbxInfoSlary.PerformLayout();
            this.gbxInfoWork.ResumeLayout(false);
            this.gbxInfoWork.PerformLayout();
            this.gbxInfor.ResumeLayout(false);
            this.gbxInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnFixInfo;
        private System.Windows.Forms.GroupBox gbxInfoSlary;
        private System.Windows.Forms.TextBox txtIndexSalary;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.Label lblIndexSalary;
        private System.Windows.Forms.Label lblSalaryBasic;
        private System.Windows.Forms.GroupBox gbxInfoWork;
        private System.Windows.Forms.TextBox txtSeniority;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label lblSeniority;
        private System.Windows.Forms.TextBox txtStudy;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtDeparment;
        private System.Windows.Forms.Label lblStudy;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDeparment;
        private System.Windows.Forms.GroupBox gbxInfor;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtBirhDay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lablBirthDay;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.PictureBox picImage;
        private FontAwesome.Sharp.IconButton btnChonAnh;
    }
}