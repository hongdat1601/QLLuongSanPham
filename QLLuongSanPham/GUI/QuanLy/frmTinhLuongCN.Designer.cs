﻿
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmTinhLuongCN
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
            this.btnTinhLuong = new FontAwesome.Sharp.IconButton();
            this.btnTiemKiem = new FontAwesome.Sharp.IconButton();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.pnlLuong = new System.Windows.Forms.Panel();
            this.lvwDSLuong = new System.Windows.Forms.ListView();
            this.lbluong = new System.Windows.Forms.Label();
            this.lblThuong = new System.Windows.Forms.Label();
            this.pnlChiTiet = new System.Windows.Forms.Panel();
            this.lvwChiTiet = new System.Windows.Forms.ListView();
            this.lblCV = new System.Windows.Forms.Label();
            this.pnlDSNV = new System.Windows.Forms.Panel();
            this.lvwDSNV = new System.Windows.Forms.ListView();
            this.lblDSNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.pnlLuong.SuspendLayout();
            this.pnlChiTiet.SuspendLayout();
            this.pnlDSNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(1191, 968);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 0;
            this.picNen.TabStop = false;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnTinhLuong.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTinhLuong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTinhLuong.IconSize = 22;
            this.btnTinhLuong.Location = new System.Drawing.Point(1019, 537);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(138, 43);
            this.btnTinhLuong.TabIndex = 11;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            // 
            // btnTiemKiem
            // 
            this.btnTiemKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTiemKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiemKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTiemKiem.IconColor = System.Drawing.Color.Blue;
            this.btnTiemKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTiemKiem.IconSize = 25;
            this.btnTiemKiem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTiemKiem.Location = new System.Drawing.Point(374, 18);
            this.btnTiemKiem.Name = "btnTiemKiem";
            this.btnTiemKiem.Size = new System.Drawing.Size(44, 38);
            this.btnTiemKiem.TabIndex = 15;
            this.btnTiemKiem.UseVisualStyleBackColor = true;
            // 
            // txtTP
            // 
            this.txtTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTP.Location = new System.Drawing.Point(630, 550);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(294, 30);
            this.txtTP.TabIndex = 9;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(182, 20);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(178, 30);
            this.txtTen.TabIndex = 14;
            // 
            // lblTen
            // 
            this.lblTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(33, 27);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(132, 20);
            this.lblTen.TabIndex = 13;
            this.lblTen.Text = "Tên công nhân";
            // 
            // pnlLuong
            // 
            this.pnlLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLuong.Controls.Add(this.lvwDSLuong);
            this.pnlLuong.Controls.Add(this.lbluong);
            this.pnlLuong.Location = new System.Drawing.Point(37, 613);
            this.pnlLuong.Name = "pnlLuong";
            this.pnlLuong.Size = new System.Drawing.Size(1122, 340);
            this.pnlLuong.TabIndex = 12;
            // 
            // lvwDSLuong
            // 
            this.lvwDSLuong.HideSelection = false;
            this.lvwDSLuong.Location = new System.Drawing.Point(14, 54);
            this.lvwDSLuong.Name = "lvwDSLuong";
            this.lvwDSLuong.Size = new System.Drawing.Size(1085, 269);
            this.lvwDSLuong.TabIndex = 1;
            this.lvwDSLuong.UseCompatibleStateImageBehavior = false;
            // 
            // lbluong
            // 
            this.lbluong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbluong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluong.Location = new System.Drawing.Point(0, 0);
            this.lbluong.Name = "lbluong";
            this.lbluong.Size = new System.Drawing.Size(1118, 39);
            this.lbluong.TabIndex = 0;
            this.lbluong.Text = "Danh sách lương nhân viên";
            this.lbluong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThuong
            // 
            this.lblThuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThuong.AutoSize = true;
            this.lblThuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuong.ForeColor = System.Drawing.Color.White;
            this.lblThuong.Location = new System.Drawing.Point(442, 555);
            this.lblThuong.Name = "lblThuong";
            this.lblThuong.Size = new System.Drawing.Size(150, 25);
            this.lblThuong.TabIndex = 7;
            this.lblThuong.Text = "Thưởng/Phạt: ";
            // 
            // pnlChiTiet
            // 
            this.pnlChiTiet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChiTiet.Controls.Add(this.lvwChiTiet);
            this.pnlChiTiet.Controls.Add(this.lblCV);
            this.pnlChiTiet.Location = new System.Drawing.Point(447, 67);
            this.pnlChiTiet.Name = "pnlChiTiet";
            this.pnlChiTiet.Size = new System.Drawing.Size(712, 452);
            this.pnlChiTiet.TabIndex = 10;
            // 
            // lvwChiTiet
            // 
            this.lvwChiTiet.HideSelection = false;
            this.lvwChiTiet.Location = new System.Drawing.Point(14, 55);
            this.lvwChiTiet.Name = "lvwChiTiet";
            this.lvwChiTiet.Size = new System.Drawing.Size(679, 376);
            this.lvwChiTiet.TabIndex = 1;
            this.lvwChiTiet.UseCompatibleStateImageBehavior = false;
            // 
            // lblCV
            // 
            this.lblCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV.Location = new System.Drawing.Point(0, 0);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(708, 39);
            this.lblCV.TabIndex = 0;
            this.lblCV.Text = "Chi tiết công việc";
            this.lblCV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDSNV
            // 
            this.pnlDSNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDSNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSNV.Controls.Add(this.lvwDSNV);
            this.pnlDSNV.Controls.Add(this.lblDSNV);
            this.pnlDSNV.Location = new System.Drawing.Point(37, 67);
            this.pnlDSNV.Name = "pnlDSNV";
            this.pnlDSNV.Size = new System.Drawing.Size(381, 513);
            this.pnlDSNV.TabIndex = 8;
            // 
            // lvwDSNV
            // 
            this.lvwDSNV.HideSelection = false;
            this.lvwDSNV.Location = new System.Drawing.Point(14, 54);
            this.lvwDSNV.Name = "lvwDSNV";
            this.lvwDSNV.Size = new System.Drawing.Size(345, 437);
            this.lvwDSNV.TabIndex = 1;
            this.lvwDSNV.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSNV
            // 
            this.lblDSNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSNV.Location = new System.Drawing.Point(0, 0);
            this.lblDSNV.Name = "lblDSNV";
            this.lblDSNV.Size = new System.Drawing.Size(377, 39);
            this.lblDSNV.TabIndex = 0;
            this.lblDSNV.Text = "Danh sách công nhân";
            this.lblDSNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmTinhLuongCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1191, 968);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.btnTiemKiem);
            this.Controls.Add(this.txtTP);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.pnlLuong);
            this.Controls.Add(this.lblThuong);
            this.Controls.Add(this.pnlChiTiet);
            this.Controls.Add(this.pnlDSNV);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTinhLuongCN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTinhLuongCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.pnlLuong.ResumeLayout(false);
            this.pnlChiTiet.ResumeLayout(false);
            this.pnlDSNV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private FontAwesome.Sharp.IconButton btnTinhLuong;
        private FontAwesome.Sharp.IconButton btnTiemKiem;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Panel pnlLuong;
        private System.Windows.Forms.ListView lvwDSLuong;
        private System.Windows.Forms.Label lbluong;
        private System.Windows.Forms.Label lblThuong;
        private System.Windows.Forms.Panel pnlChiTiet;
        private System.Windows.Forms.ListView lvwChiTiet;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.Panel pnlDSNV;
        private System.Windows.Forms.ListView lvwDSNV;
        private System.Windows.Forms.Label lblDSNV;
    }
}