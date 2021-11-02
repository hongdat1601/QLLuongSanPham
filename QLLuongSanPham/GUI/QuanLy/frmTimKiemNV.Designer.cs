﻿
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
            this.pnlLich = new System.Windows.Forms.Panel();
            this.lvwDSLich = new System.Windows.Forms.ListView();
            this.lblDSLich = new System.Windows.Forms.Label();
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
            this.gbxInfoWork = new System.Windows.Forms.GroupBox();
            this.txtSeniority = new System.Windows.Forms.TextBox();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblSeniority = new System.Windows.Forms.Label();
            this.txtStudy = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtDeparment = new System.Windows.Forms.TextBox();
            this.lblStudy = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDeparment = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pnlLich.SuspendLayout();
            this.gbxInfor.SuspendLayout();
            this.gbxInfoWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLich
            // 
            this.pnlLich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLich.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLich.Controls.Add(this.lvwDSLich);
            this.pnlLich.Controls.Add(this.lblDSLich);
            this.pnlLich.Location = new System.Drawing.Point(18, 565);
            this.pnlLich.Name = "pnlLich";
            this.pnlLich.Size = new System.Drawing.Size(1467, 359);
            this.pnlLich.TabIndex = 12;
            // 
            // lvwDSLich
            // 
            this.lvwDSLich.HideSelection = false;
            this.lvwDSLich.Location = new System.Drawing.Point(18, 52);
            this.lvwDSLich.Name = "lvwDSLich";
            this.lvwDSLich.Size = new System.Drawing.Size(1419, 286);
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
            this.lblDSLich.Size = new System.Drawing.Size(1463, 33);
            this.lblDSLich.TabIndex = 0;
            this.lblDSLich.Text = "Danh sách lịch làm việc";
            this.lblDSLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.gbxInfor.Location = new System.Drawing.Point(35, 24);
            this.gbxInfor.Name = "gbxInfor";
            this.gbxInfor.Size = new System.Drawing.Size(889, 205);
            this.gbxInfor.TabIndex = 13;
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
            this.cboSex.Text = "Nam";
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtAdress.Location = new System.Drawing.Point(211, 158);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(658, 29);
            this.txtAdress.TabIndex = 2;
            this.txtAdress.Text = "số 41 đường 20 phường Hiệp Bình chánh TP Thủ Đức";
            this.txtAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(687, 23);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(182, 29);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Text = "0396887293";
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(211, 112);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(265, 29);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "321736242";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBirhDay
            // 
            this.txtBirhDay.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtBirhDay.Location = new System.Drawing.Point(211, 70);
            this.txtBirhDay.Name = "txtBirhDay";
            this.txtBirhDay.Size = new System.Drawing.Size(265, 29);
            this.txtBirhDay.TabIndex = 2;
            this.txtBirhDay.Text = "28/12/2001";
            this.txtBirhDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(211, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 29);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "VÕ MINH PHƯƠNG";
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
            // gbxInfoWork
            // 
            this.gbxInfoWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxInfoWork.Controls.Add(this.txtSeniority);
            this.gbxInfoWork.Controls.Add(this.lblDateStart);
            this.gbxInfoWork.Controls.Add(this.txtStartDate);
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
            this.gbxInfoWork.Location = new System.Drawing.Point(38, 242);
            this.gbxInfoWork.Name = "gbxInfoWork";
            this.gbxInfoWork.Size = new System.Drawing.Size(886, 300);
            this.gbxInfoWork.TabIndex = 15;
            this.gbxInfoWork.TabStop = false;
            this.gbxInfoWork.Text = "Thông tin công việc";
            // 
            // txtSeniority
            // 
            this.txtSeniority.BackColor = System.Drawing.Color.White;
            this.txtSeniority.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtSeniority.Location = new System.Drawing.Point(339, 249);
            this.txtSeniority.Name = "txtSeniority";
            this.txtSeniority.Size = new System.Drawing.Size(410, 29);
            this.txtSeniority.TabIndex = 2;
            this.txtSeniority.Text = "2 năm";
            // 
            // lblDateStart
            // 
            this.lblDateStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblDateStart.Location = new System.Drawing.Point(56, 195);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(225, 23);
            this.lblDateStart.TabIndex = 1;
            this.lblDateStart.Text = "Ngày bắt đầu công tác";
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.Color.White;
            this.txtStartDate.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtStartDate.Location = new System.Drawing.Point(339, 189);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(410, 29);
            this.txtStartDate.TabIndex = 2;
            this.txtStartDate.Text = "15/10/2021";
            // 
            // lblSeniority
            // 
            this.lblSeniority.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeniority.AutoSize = true;
            this.lblSeniority.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblSeniority.Location = new System.Drawing.Point(56, 255);
            this.lblSeniority.Name = "lblSeniority";
            this.lblSeniority.Size = new System.Drawing.Size(199, 23);
            this.lblSeniority.TabIndex = 1;
            this.lblSeniority.Text = "Thâm niên công tác";
            // 
            // txtStudy
            // 
            this.txtStudy.BackColor = System.Drawing.Color.White;
            this.txtStudy.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtStudy.Location = new System.Drawing.Point(339, 128);
            this.txtStudy.Name = "txtStudy";
            this.txtStudy.Size = new System.Drawing.Size(410, 29);
            this.txtStudy.TabIndex = 2;
            this.txtStudy.Text = "Đại học";
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.White;
            this.txtPosition.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtPosition.Location = new System.Drawing.Point(339, 74);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(410, 29);
            this.txtPosition.TabIndex = 2;
            this.txtPosition.Text = "Nhân viên";
            // 
            // txtDeparment
            // 
            this.txtDeparment.BackColor = System.Drawing.Color.White;
            this.txtDeparment.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtDeparment.Location = new System.Drawing.Point(339, 21);
            this.txtDeparment.Name = "txtDeparment";
            this.txtDeparment.Size = new System.Drawing.Size(410, 29);
            this.txtDeparment.TabIndex = 2;
            this.txtDeparment.Text = "Ban quản trị";
            // 
            // lblStudy
            // 
            this.lblStudy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudy.AutoSize = true;
            this.lblStudy.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblStudy.Location = new System.Drawing.Point(56, 134);
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
            this.lblPosition.Location = new System.Drawing.Point(56, 80);
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
            this.lblDeparment.Location = new System.Drawing.Point(56, 27);
            this.lblDeparment.Name = "lblDeparment";
            this.lblDeparment.Size = new System.Drawing.Size(111, 23);
            this.lblDeparment.TabIndex = 1;
            this.lblDeparment.Text = "Phòng ban";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Blue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(961, 491);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(522, 52);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.Text = "Tìm kiếm";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // frmTimKiemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 936);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.gbxInfoWork);
            this.Controls.Add(this.gbxInfor);
            this.Controls.Add(this.pnlLich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiemNV";
            this.pnlLich.ResumeLayout(false);
            this.gbxInfor.ResumeLayout(false);
            this.gbxInfor.PerformLayout();
            this.gbxInfoWork.ResumeLayout(false);
            this.gbxInfoWork.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLich;
        private System.Windows.Forms.ListView lvwDSLich;
        private System.Windows.Forms.Label lblDSLich;
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
        private System.Windows.Forms.GroupBox gbxInfoWork;
        private System.Windows.Forms.TextBox txtSeniority;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblSeniority;
        private System.Windows.Forms.TextBox txtStudy;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtDeparment;
        private System.Windows.Forms.Label lblStudy;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDeparment;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}