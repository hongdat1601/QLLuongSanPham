﻿
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmTiemKiemPB
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
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.txtTenTP = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.lblTenTP = new System.Windows.Forms.Label();
            this.txtPhongBan = new System.Windows.Forms.TextBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblPhongban = new System.Windows.Forms.Label();
            this.pnlLich = new System.Windows.Forms.Panel();
            this.lvwPhongBan = new System.Windows.Forms.ListView();
            this.lblDSPB = new System.Windows.Forms.Label();
            this.gboTT = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.pnlLich.SuspendLayout();
            this.gboTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(1216, 792);
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
            this.btnTimKiem.Location = new System.Drawing.Point(785, 335);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(419, 52);
            this.btnTimKiem.TabIndex = 31;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // numSL
            // 
            this.numSL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSL.Location = new System.Drawing.Point(288, 215);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(410, 30);
            this.numSL.TabIndex = 30;
            // 
            // txtTenTP
            // 
            this.txtTenTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenTP.BackColor = System.Drawing.Color.White;
            this.txtTenTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTP.Location = new System.Drawing.Point(288, 314);
            this.txtTenTP.Name = "txtTenTP";
            this.txtTenTP.Size = new System.Drawing.Size(410, 30);
            this.txtTenTP.TabIndex = 27;
            // 
            // txtNgay
            // 
            this.txtNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgay.BackColor = System.Drawing.Color.White;
            this.txtNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(288, 123);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(410, 30);
            this.txtNgay.TabIndex = 28;
            // 
            // lblTenTP
            // 
            this.lblTenTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenTP.AutoSize = true;
            this.lblTenTP.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblTenTP.Location = new System.Drawing.Point(20, 321);
            this.lblTenTP.Name = "lblTenTP";
            this.lblTenTP.Size = new System.Drawing.Size(182, 23);
            this.lblTenTP.TabIndex = 23;
            this.lblTenTP.Text = "Tên trưởng phòng";
            // 
            // txtPhongBan
            // 
            this.txtPhongBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhongBan.BackColor = System.Drawing.Color.White;
            this.txtPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhongBan.Location = new System.Drawing.Point(288, 34);
            this.txtPhongBan.Name = "txtPhongBan";
            this.txtPhongBan.Size = new System.Drawing.Size(410, 30);
            this.txtPhongBan.TabIndex = 29;
            // 
            // lblSL
            // 
            this.lblSL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblSL.Location = new System.Drawing.Point(20, 222);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(197, 23);
            this.lblSL.TabIndex = 24;
            this.lblSL.Text = "Số lượng nhân viên";
            // 
            // lblNgay
            // 
            this.lblNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblNgay.Location = new System.Drawing.Point(21, 130);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(155, 23);
            this.lblNgay.TabIndex = 25;
            this.lblNgay.Text = "Ngày thành lập";
            // 
            // lblPhongban
            // 
            this.lblPhongban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhongban.AutoSize = true;
            this.lblPhongban.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblPhongban.Location = new System.Drawing.Point(21, 41);
            this.lblPhongban.Name = "lblPhongban";
            this.lblPhongban.Size = new System.Drawing.Size(154, 23);
            this.lblPhongban.TabIndex = 26;
            this.lblPhongban.Text = "Tên phòng ban";
            // 
            // pnlLich
            // 
            this.pnlLich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLich.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLich.Controls.Add(this.lvwPhongBan);
            this.pnlLich.Controls.Add(this.lblDSPB);
            this.pnlLich.Location = new System.Drawing.Point(12, 413);
            this.pnlLich.Name = "pnlLich";
            this.pnlLich.Size = new System.Drawing.Size(1192, 359);
            this.pnlLich.TabIndex = 22;
            // 
            // lvwPhongBan
            // 
            this.lvwPhongBan.HideSelection = false;
            this.lvwPhongBan.Location = new System.Drawing.Point(15, 53);
            this.lvwPhongBan.Name = "lvwPhongBan";
            this.lvwPhongBan.Size = new System.Drawing.Size(1151, 286);
            this.lvwPhongBan.TabIndex = 1;
            this.lvwPhongBan.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSPB
            // 
            this.lblDSPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSPB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDSPB.Location = new System.Drawing.Point(0, 0);
            this.lblDSPB.Name = "lblDSPB";
            this.lblDSPB.Size = new System.Drawing.Size(1188, 33);
            this.lblDSPB.TabIndex = 0;
            this.lblDSPB.Text = "Danh sách phòng ban";
            this.lblDSPB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboTT
            // 
            this.gboTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboTT.Controls.Add(this.numSL);
            this.gboTT.Controls.Add(this.txtTenTP);
            this.gboTT.Controls.Add(this.txtNgay);
            this.gboTT.Controls.Add(this.lblTenTP);
            this.gboTT.Controls.Add(this.txtPhongBan);
            this.gboTT.Controls.Add(this.lblSL);
            this.gboTT.Controls.Add(this.lblNgay);
            this.gboTT.Controls.Add(this.lblPhongban);
            this.gboTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboTT.Location = new System.Drawing.Point(19, 14);
            this.gboTT.Name = "gboTT";
            this.gboTT.Size = new System.Drawing.Size(724, 373);
            this.gboTT.TabIndex = 32;
            this.gboTT.TabStop = false;
            this.gboTT.Text = "Thông tin phòng ban";
            // 
            // frmTiemKiemPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1216, 792);
            this.Controls.Add(this.gboTT);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.pnlLich);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTiemKiemPB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTiemKiemPB";
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.pnlLich.ResumeLayout(false);
            this.gboTT.ResumeLayout(false);
            this.gboTT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.TextBox txtTenTP;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label lblTenTP;
        private System.Windows.Forms.TextBox txtPhongBan;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblPhongban;
        private System.Windows.Forms.Panel pnlLich;
        private System.Windows.Forms.ListView lvwPhongBan;
        private System.Windows.Forms.Label lblDSPB;
        private System.Windows.Forms.GroupBox gboTT;
    }
}