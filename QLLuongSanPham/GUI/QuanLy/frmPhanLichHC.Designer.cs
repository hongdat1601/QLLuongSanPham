
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmPhanLichHC
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
            this.btSearchLich = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.pnlLich = new System.Windows.Forms.Panel();
            this.lvwDSLich = new System.Windows.Forms.ListView();
            this.lblDSLich = new System.Windows.Forms.Label();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnSearchNV = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.txtDateStart = new System.Windows.Forms.TextBox();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.txtTenNVLich = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.pnlDSSP = new System.Windows.Forms.Panel();
            this.lvwDSNV = new System.Windows.Forms.ListView();
            this.lblDSNV = new System.Windows.Forms.Label();
            this.pnlNgayLam = new System.Windows.Forms.Panel();
            this.dtmNgay = new System.Windows.Forms.DateTimePicker();
            this.tblThu = new System.Windows.Forms.TableLayoutPanel();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblNgayDiLam = new System.Windows.Forms.Label();
            this.pnlXuLy = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNen)).BeginInit();
            this.pnlLich.SuspendLayout();
            this.pnlDSSP.SuspendLayout();
            this.pnlNgayLam.SuspendLayout();
            this.pnlXuLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptcNen
            // 
            this.ptcNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptcNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.ptcNen.Location = new System.Drawing.Point(0, 0);
            this.ptcNen.Name = "ptcNen";
            this.ptcNen.Size = new System.Drawing.Size(1221, 856);
            this.ptcNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcNen.TabIndex = 0;
            this.ptcNen.TabStop = false;
            // 
            // btSearchLich
            // 
            this.btSearchLich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSearchLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchLich.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btSearchLich.IconColor = System.Drawing.Color.Blue;
            this.btSearchLich.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSearchLich.IconSize = 22;
            this.btSearchLich.Location = new System.Drawing.Point(1037, 490);
            this.btSearchLich.Name = "btSearchLich";
            this.btSearchLich.Size = new System.Drawing.Size(161, 33);
            this.btSearchLich.TabIndex = 41;
            this.btSearchLich.Text = "Tìm kiếm";
            this.btSearchLich.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearchLich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSearchLich.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Red;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 25;
            this.btnXoa.Location = new System.Drawing.Point(545, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(179, 43);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pnlLich
            // 
            this.pnlLich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLich.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLich.Controls.Add(this.lvwDSLich);
            this.pnlLich.Controls.Add(this.lblDSLich);
            this.pnlLich.Location = new System.Drawing.Point(27, 541);
            this.pnlLich.Name = "pnlLich";
            this.pnlLich.Size = new System.Drawing.Size(1171, 303);
            this.pnlLich.TabIndex = 37;
            // 
            // lvwDSLich
            // 
            this.lvwDSLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDSLich.HideSelection = false;
            this.lvwDSLich.Location = new System.Drawing.Point(21, 47);
            this.lvwDSLich.Name = "lvwDSLich";
            this.lvwDSLich.Size = new System.Drawing.Size(1131, 237);
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
            this.lblDSLich.Size = new System.Drawing.Size(1167, 33);
            this.lblDSLich.TabIndex = 0;
            this.lblDSLich.Text = "Danh sách lịch làm việc";
            this.lblDSLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 25;
            this.btnSua.Location = new System.Drawing.Point(301, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(179, 43);
            this.btnSua.TabIndex = 39;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchNV.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchNV.IconColor = System.Drawing.Color.Blue;
            this.btnSearchNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchNV.IconSize = 20;
            this.btnSearchNV.Location = new System.Drawing.Point(365, 17);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Size = new System.Drawing.Size(52, 30);
            this.btnSearchNV.TabIndex = 36;
            this.btnSearchNV.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(42)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 25;
            this.btnThem.Location = new System.Drawing.Point(25, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(179, 43);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Phân lịch";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateStart.Location = new System.Drawing.Point(707, 493);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.Size = new System.Drawing.Size(276, 30);
            this.txtDateStart.TabIndex = 33;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBD.ForeColor = System.Drawing.Color.White;
            this.lblNgayBD.Location = new System.Drawing.Point(526, 496);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(140, 25);
            this.lblNgayBD.TabIndex = 30;
            this.lblNgayBD.Text = "Ngày bắt đầu";
            // 
            // txtTenNVLich
            // 
            this.txtTenNVLich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNVLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNVLich.Location = new System.Drawing.Point(188, 493);
            this.txtTenNVLich.Name = "txtTenNVLich";
            this.txtTenNVLich.Size = new System.Drawing.Size(295, 30);
            this.txtTenNVLich.TabIndex = 34;
            // 
            // lblname
            // 
            this.lblname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(22, 498);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(150, 25);
            this.lblname.TabIndex = 31;
            this.lblname.Text = "Tên nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(178, 17);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(168, 30);
            this.txtTenNV.TabIndex = 35;
            // 
            // lblTen
            // 
            this.lblTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(22, 22);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(150, 25);
            this.lblTen.TabIndex = 32;
            this.lblTen.Text = "Tên nhân viên";
            // 
            // pnlDSSP
            // 
            this.pnlDSSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDSSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSSP.Controls.Add(this.lvwDSNV);
            this.pnlDSSP.Controls.Add(this.lblDSNV);
            this.pnlDSSP.Location = new System.Drawing.Point(27, 61);
            this.pnlDSSP.Name = "pnlDSSP";
            this.pnlDSSP.Size = new System.Drawing.Size(389, 403);
            this.pnlDSSP.TabIndex = 29;
            // 
            // lvwDSNV
            // 
            this.lvwDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDSNV.HideSelection = false;
            this.lvwDSNV.Location = new System.Drawing.Point(14, 46);
            this.lvwDSNV.Name = "lvwDSNV";
            this.lvwDSNV.Size = new System.Drawing.Size(355, 344);
            this.lvwDSNV.TabIndex = 1;
            this.lvwDSNV.UseCompatibleStateImageBehavior = false;
            this.lvwDSNV.SelectedIndexChanged += new System.EventHandler(this.lvwDSNV_SelectedIndexChanged);
            // 
            // lblDSNV
            // 
            this.lblDSNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDSNV.Location = new System.Drawing.Point(0, 0);
            this.lblDSNV.Name = "lblDSNV";
            this.lblDSNV.Size = new System.Drawing.Size(385, 33);
            this.lblDSNV.TabIndex = 0;
            this.lblDSNV.Text = "Danh sách nhân viên";
            this.lblDSNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNgayLam
            // 
            this.pnlNgayLam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlNgayLam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlNgayLam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNgayLam.Controls.Add(this.dtmNgay);
            this.pnlNgayLam.Controls.Add(this.tblThu);
            this.pnlNgayLam.Controls.Add(this.lblNgay);
            this.pnlNgayLam.Controls.Add(this.lblNgayDiLam);
            this.pnlNgayLam.Location = new System.Drawing.Point(443, 63);
            this.pnlNgayLam.Name = "pnlNgayLam";
            this.pnlNgayLam.Size = new System.Drawing.Size(755, 308);
            this.pnlNgayLam.TabIndex = 28;
            // 
            // dtmNgay
            // 
            this.dtmNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtmNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgay.Location = new System.Drawing.Point(192, 65);
            this.dtmNgay.Name = "dtmNgay";
            this.dtmNgay.Size = new System.Drawing.Size(346, 30);
            this.dtmNgay.TabIndex = 44;
            this.dtmNgay.ValueChanged += new System.EventHandler(this.dtmNgay_ValueChanged);
            // 
            // tblThu
            // 
            this.tblThu.AutoScroll = true;
            this.tblThu.BackColor = System.Drawing.Color.White;
            this.tblThu.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblThu.ColumnCount = 6;
            this.tblThu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.63636F));
            this.tblThu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.36364F));
            this.tblThu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tblThu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tblThu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblThu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tblThu.Location = new System.Drawing.Point(28, 128);
            this.tblThu.Name = "tblThu";
            this.tblThu.RowCount = 2;
            this.tblThu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThu.Size = new System.Drawing.Size(699, 151);
            this.tblThu.TabIndex = 1;
            // 
            // lblNgay
            // 
            this.lblNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgay.AutoSize = true;
            this.lblNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.ForeColor = System.Drawing.Color.White;
            this.lblNgay.Location = new System.Drawing.Point(23, 70);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(117, 25);
            this.lblNgay.TabIndex = 43;
            this.lblNgay.Text = "Chọn ngày";
            // 
            // lblNgayDiLam
            // 
            this.lblNgayDiLam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNgayDiLam.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNgayDiLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDiLam.Location = new System.Drawing.Point(0, 0);
            this.lblNgayDiLam.Name = "lblNgayDiLam";
            this.lblNgayDiLam.Size = new System.Drawing.Size(751, 42);
            this.lblNgayDiLam.TabIndex = 0;
            this.lblNgayDiLam.Text = "Ngày đi làm trong tuần";
            this.lblNgayDiLam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlXuLy
            // 
            this.pnlXuLy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlXuLy.AutoScroll = true;
            this.pnlXuLy.Controls.Add(this.btnThem);
            this.pnlXuLy.Controls.Add(this.btnSua);
            this.pnlXuLy.Controls.Add(this.btnXoa);
            this.pnlXuLy.Location = new System.Drawing.Point(443, 385);
            this.pnlXuLy.Name = "pnlXuLy";
            this.pnlXuLy.Size = new System.Drawing.Size(753, 68);
            this.pnlXuLy.TabIndex = 42;
            // 
            // frmPhanLichHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1221, 856);
            this.Controls.Add(this.pnlXuLy);
            this.Controls.Add(this.btSearchLich);
            this.Controls.Add(this.pnlLich);
            this.Controls.Add(this.btnSearchNV);
            this.Controls.Add(this.txtDateStart);
            this.Controls.Add(this.lblNgayBD);
            this.Controls.Add(this.txtTenNVLich);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.pnlDSSP);
            this.Controls.Add(this.pnlNgayLam);
            this.Controls.Add(this.ptcNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhanLichHC";
            this.Text = "frmPhanCongHC";
            this.Load += new System.EventHandler(this.frmPhanCongHC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcNen)).EndInit();
            this.pnlLich.ResumeLayout(false);
            this.pnlDSSP.ResumeLayout(false);
            this.pnlNgayLam.ResumeLayout(false);
            this.pnlNgayLam.PerformLayout();
            this.pnlXuLy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcNen;
        private FontAwesome.Sharp.IconButton btSearchLich;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.Panel pnlLich;
        private System.Windows.Forms.ListView lvwDSLich;
        private System.Windows.Forms.Label lblDSLich;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnSearchNV;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.TextBox txtDateStart;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.TextBox txtTenNVLich;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Panel pnlDSSP;
        private System.Windows.Forms.ListView lvwDSNV;
        private System.Windows.Forms.Label lblDSNV;
        private System.Windows.Forms.Panel pnlNgayLam;
        private System.Windows.Forms.TableLayoutPanel tblThu;
        private System.Windows.Forms.Label lblNgayDiLam;
        private System.Windows.Forms.Panel pnlXuLy;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtmNgay;
    }
}