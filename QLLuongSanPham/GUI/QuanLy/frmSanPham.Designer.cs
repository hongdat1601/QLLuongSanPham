﻿
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmSanPham
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
            this.gboTT = new System.Windows.Forms.GroupBox();
            this.btnChonAnh = new FontAwesome.Sharp.IconButton();
            this.ptcAvata = new System.Windows.Forms.PictureBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.lblDS = new System.Windows.Forms.Label();
            this.lvwDSSP = new System.Windows.Forms.ListView();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.lbNameSearch = new System.Windows.Forms.Label();
            this.gboTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAvata)).BeginInit();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboTT
            // 
            this.gboTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboTT.Controls.Add(this.btnChonAnh);
            this.gboTT.Controls.Add(this.ptcAvata);
            this.gboTT.Controls.Add(this.txtDVT);
            this.gboTT.Controls.Add(this.txtDG);
            this.gboTT.Controls.Add(this.txtTenSP);
            this.gboTT.Controls.Add(this.lblDonVi);
            this.gboTT.Controls.Add(this.lblDonGia);
            this.gboTT.Controls.Add(this.lblName);
            this.gboTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboTT.Location = new System.Drawing.Point(12, 107);
            this.gboTT.Name = "gboTT";
            this.gboTT.Size = new System.Drawing.Size(674, 408);
            this.gboTT.TabIndex = 20;
            this.gboTT.TabStop = false;
            this.gboTT.Text = "Thông tin hợp đồng";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChonAnh.Enabled = false;
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChonAnh.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnChonAnh.IconColor = System.Drawing.Color.Peru;
            this.btnChonAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChonAnh.IconSize = 25;
            this.btnChonAnh.Location = new System.Drawing.Point(6, 223);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(140, 40);
            this.btnChonAnh.TabIndex = 34;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // ptcAvata
            // 
            this.ptcAvata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptcAvata.Location = new System.Drawing.Point(6, 60);
            this.ptcAvata.Name = "ptcAvata";
            this.ptcAvata.Size = new System.Drawing.Size(140, 134);
            this.ptcAvata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcAvata.TabIndex = 3;
            this.ptcAvata.TabStop = false;
            // 
            // txtDVT
            // 
            this.txtDVT.Enabled = false;
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Location = new System.Drawing.Point(342, 353);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(322, 30);
            this.txtDVT.TabIndex = 2;
            // 
            // txtDG
            // 
            this.txtDG.Enabled = false;
            this.txtDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDG.Location = new System.Drawing.Point(342, 204);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(322, 30);
            this.txtDG.TabIndex = 2;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Enabled = false;
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(342, 60);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(322, 30);
            this.txtTenSP.TabIndex = 2;
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonVi.Location = new System.Drawing.Point(167, 358);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(114, 25);
            this.lblDonVi.TabIndex = 1;
            this.lblDonVi.Text = "Đơn vị tính: ";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(167, 209);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(85, 25);
            this.lblDonGia.TabIndex = 1;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(167, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên sản phẩm:";
            // 
            // pnlList
            // 
            this.pnlList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlList.Controls.Add(this.lblDS);
            this.pnlList.Controls.Add(this.lvwDSSP);
            this.pnlList.Location = new System.Drawing.Point(715, 105);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(768, 495);
            this.pnlList.TabIndex = 19;
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
            this.lblDS.Text = "Danh sách sản phẩm";
            this.lblDS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwDSSP
            // 
            this.lvwDSSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDSSP.HideSelection = false;
            this.lvwDSSP.Location = new System.Drawing.Point(6, 63);
            this.lvwDSSP.MultiSelect = false;
            this.lvwDSSP.Name = "lvwDSSP";
            this.lvwDSSP.Size = new System.Drawing.Size(755, 425);
            this.lvwDSSP.TabIndex = 0;
            this.lvwDSSP.UseCompatibleStateImageBehavior = false;
            this.lvwDSSP.SelectedIndexChanged += new System.EventHandler(this.lvwDSSP_SelectedIndexChanged);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.Location = new System.Drawing.Point(898, 48);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(463, 30);
            this.txtNameSearch.TabIndex = 18;
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
            this.btnTimKiem.Location = new System.Drawing.Point(1409, 42);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(74, 38);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Red;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 25;
            this.btnXoa.Location = new System.Drawing.Point(591, 552);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 43);
            this.btnXoa.TabIndex = 33;
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
            this.btnSua.Location = new System.Drawing.Point(311, 552);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 43);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 25;
            this.btnThem.Location = new System.Drawing.Point(12, 557);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 43);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbNameSearch
            // 
            this.lbNameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNameSearch.AutoSize = true;
            this.lbNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSearch.Location = new System.Drawing.Point(710, 53);
            this.lbNameSearch.Name = "lbNameSearch";
            this.lbNameSearch.Size = new System.Drawing.Size(144, 25);
            this.lbNameSearch.TabIndex = 0;
            this.lbNameSearch.Text = "Tên sản phẩm:";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 728);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gboTT);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lbNameSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.gboTT.ResumeLayout(false);
            this.gboTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAvata)).EndInit();
            this.pnlList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboTT;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.ListView lvwDSSP;
        private System.Windows.Forms.TextBox txtNameSearch;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.PictureBox ptcAvata;
        private FontAwesome.Sharp.IconButton btnChonAnh;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Label lbNameSearch;
    }
}