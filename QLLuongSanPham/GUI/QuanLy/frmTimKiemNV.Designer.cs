
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmTimKiemNV
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
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.gbxInfoWork = new System.Windows.Forms.GroupBox();
            this.nudThamNien = new System.Windows.Forms.NumericUpDown();
            this.cboHV = new System.Windows.Forms.ComboBox();
            this.cboCV = new System.Windows.Forms.ComboBox();
            this.cboPB = new System.Windows.Forms.ComboBox();
            this.lblSeniority = new System.Windows.Forms.Label();
            this.lblStudy = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDeparment = new System.Windows.Forms.Label();
            this.gbxInfor = new System.Windows.Forms.GroupBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lablBirthDay = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlLich = new System.Windows.Forms.Panel();
            this.lstvNhanVien = new System.Windows.Forms.ListView();
            this.lblDSLich = new System.Windows.Forms.Label();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.gbxInfoWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThamNien)).BeginInit();
            this.gbxInfor.SuspendLayout();
            this.pnlLich.SuspendLayout();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(1513, 968);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 0;
            this.picNen.TabStop = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.Blue;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 30;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(948, 518);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(236, 52);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gbxInfoWork
            // 
            this.gbxInfoWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxInfoWork.Controls.Add(this.nudThamNien);
            this.gbxInfoWork.Controls.Add(this.cboHV);
            this.gbxInfoWork.Controls.Add(this.cboCV);
            this.gbxInfoWork.Controls.Add(this.cboPB);
            this.gbxInfoWork.Controls.Add(this.lblSeniority);
            this.gbxInfoWork.Controls.Add(this.lblStudy);
            this.gbxInfoWork.Controls.Add(this.lblPosition);
            this.gbxInfoWork.Controls.Add(this.lblDeparment);
            this.gbxInfoWork.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbxInfoWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxInfoWork.Font = new System.Drawing.Font("Verdana", 8F);
            this.gbxInfoWork.ForeColor = System.Drawing.Color.Black;
            this.gbxInfoWork.Location = new System.Drawing.Point(21, 270);
            this.gbxInfoWork.Name = "gbxInfoWork";
            this.gbxInfoWork.Size = new System.Drawing.Size(886, 300);
            this.gbxInfoWork.TabIndex = 19;
            this.gbxInfoWork.TabStop = false;
            this.gbxInfoWork.Text = "Thông tin công việc";
            // 
            // nudThamNien
            // 
            this.nudThamNien.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudThamNien.Location = new System.Drawing.Point(339, 196);
            this.nudThamNien.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudThamNien.Name = "nudThamNien";
            this.nudThamNien.Size = new System.Drawing.Size(169, 29);
            this.nudThamNien.TabIndex = 4;
            this.nudThamNien.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // cboHV
            // 
            this.cboHV.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHV.FormattingEnabled = true;
            this.cboHV.Items.AddRange(new object[] {
            "Tất cả"});
            this.cboHV.Location = new System.Drawing.Point(339, 140);
            this.cboHV.Name = "cboHV";
            this.cboHV.Size = new System.Drawing.Size(410, 30);
            this.cboHV.TabIndex = 3;
            this.cboHV.Text = "Tất cả";
            // 
            // cboCV
            // 
            this.cboCV.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCV.FormattingEnabled = true;
            this.cboCV.Items.AddRange(new object[] {
            "Tất cả"});
            this.cboCV.Location = new System.Drawing.Point(339, 85);
            this.cboCV.Name = "cboCV";
            this.cboCV.Size = new System.Drawing.Size(410, 30);
            this.cboCV.TabIndex = 3;
            this.cboCV.Text = "Tất cả";
            // 
            // cboPB
            // 
            this.cboPB.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPB.FormattingEnabled = true;
            this.cboPB.Items.AddRange(new object[] {
            "Tất cả"});
            this.cboPB.Location = new System.Drawing.Point(339, 30);
            this.cboPB.Name = "cboPB";
            this.cboPB.Size = new System.Drawing.Size(410, 30);
            this.cboPB.TabIndex = 3;
            this.cboPB.Text = "Tất cả";
            // 
            // lblSeniority
            // 
            this.lblSeniority.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeniority.AutoSize = true;
            this.lblSeniority.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblSeniority.Location = new System.Drawing.Point(14, 199);
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
            this.lblStudy.Location = new System.Drawing.Point(14, 144);
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
            this.lblPosition.Location = new System.Drawing.Point(14, 89);
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
            this.lblDeparment.Location = new System.Drawing.Point(14, 34);
            this.lblDeparment.Name = "lblDeparment";
            this.lblDeparment.Size = new System.Drawing.Size(104, 22);
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
            this.gbxInfor.Controls.Add(this.txtNgaySinh);
            this.gbxInfor.Controls.Add(this.txtName);
            this.gbxInfor.Controls.Add(this.lblAdress);
            this.gbxInfor.Controls.Add(this.lblID);
            this.gbxInfor.Controls.Add(this.lblPhone);
            this.gbxInfor.Controls.Add(this.lablBirthDay);
            this.gbxInfor.Controls.Add(this.lblSex);
            this.gbxInfor.Controls.Add(this.lblName);
            this.gbxInfor.Font = new System.Drawing.Font("Verdana", 8F);
            this.gbxInfor.Location = new System.Drawing.Point(21, 28);
            this.gbxInfor.Name = "gbxInfor";
            this.gbxInfor.Size = new System.Drawing.Size(889, 205);
            this.gbxInfor.TabIndex = 18;
            this.gbxInfor.TabStop = false;
            this.gbxInfor.Text = "Thông tin cá nhân";
            // 
            // cboSex
            // 
            this.cboSex.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Tất cả",
            "Nam",
            "Nữ"});
            this.cboSex.Location = new System.Drawing.Point(687, 69);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(121, 30);
            this.cboSex.TabIndex = 3;
            this.cboSex.Text = "Tất cả";
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
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtNgaySinh.Location = new System.Drawing.Point(211, 72);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(265, 29);
            this.txtNgaySinh.TabIndex = 2;
            this.txtNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.lblAdress.Size = new System.Drawing.Size(71, 22);
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
            this.lblID.Size = new System.Drawing.Size(126, 22);
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
            this.lblPhone.Size = new System.Drawing.Size(128, 22);
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
            this.lablBirthDay.Size = new System.Drawing.Size(98, 22);
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
            this.lblSex.Size = new System.Drawing.Size(85, 22);
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
            this.lblName.Size = new System.Drawing.Size(137, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên nhân viên";
            // 
            // pnlLich
            // 
            this.pnlLich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLich.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLich.Controls.Add(this.lstvNhanVien);
            this.pnlLich.Controls.Add(this.lblDSLich);
            this.pnlLich.Location = new System.Drawing.Point(21, 597);
            this.pnlLich.Name = "pnlLich";
            this.pnlLich.Size = new System.Drawing.Size(1467, 359);
            this.pnlLich.TabIndex = 17;
            // 
            // lstvNhanVien
            // 
            this.lstvNhanVien.HideSelection = false;
            this.lstvNhanVien.Location = new System.Drawing.Point(18, 52);
            this.lstvNhanVien.Name = "lstvNhanVien";
            this.lstvNhanVien.Size = new System.Drawing.Size(1419, 286);
            this.lstvNhanVien.TabIndex = 1;
            this.lstvNhanVien.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSLich
            // 
            this.lblDSLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSLich.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDSLich.Location = new System.Drawing.Point(0, 0);
            this.lblDSLich.Name = "lblDSLich";
            this.lblDSLich.Size = new System.Drawing.Size(1463, 33);
            this.lblDSLich.TabIndex = 0;
            this.lblDSLich.Text = "Danh sách nhân viên";
            this.lblDSLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnReset.IconColor = System.Drawing.Color.Blue;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 30;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(1252, 518);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(236, 52);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmTimKiemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1513, 968);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.gbxInfoWork);
            this.Controls.Add(this.gbxInfor);
            this.Controls.Add(this.pnlLich);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiemNV";
            this.Load += new System.EventHandler(this.frmTimKiemNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.gbxInfoWork.ResumeLayout(false);
            this.gbxInfoWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThamNien)).EndInit();
            this.gbxInfor.ResumeLayout(false);
            this.gbxInfor.PerformLayout();
            this.pnlLich.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.GroupBox gbxInfoWork;
        private System.Windows.Forms.ComboBox cboHV;
        private System.Windows.Forms.ComboBox cboCV;
        private System.Windows.Forms.ComboBox cboPB;
        private System.Windows.Forms.Label lblSeniority;
        private System.Windows.Forms.Label lblStudy;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDeparment;
        private System.Windows.Forms.GroupBox gbxInfor;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lablBirthDay;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlLich;
        private System.Windows.Forms.ListView lstvNhanVien;
        private System.Windows.Forms.Label lblDSLich;
        private FontAwesome.Sharp.IconButton btnReset;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.NumericUpDown nudThamNien;
    }
}