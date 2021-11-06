
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmPhongBan
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
            this.pnlDSPB = new System.Windows.Forms.Panel();
            this.lblDS = new System.Windows.Forms.Label();
            this.lstvPhongBan = new System.Windows.Forms.ListView();
            this.txtTenSearch = new System.Windows.Forms.TextBox();
            this.gboTT = new System.Windows.Forms.GroupBox();
            this.dtmNgayThanhLap = new System.Windows.Forms.DateTimePicker();
            this.txtTenQL = new System.Windows.Forms.TextBox();
            this.txtSLNV = new System.Windows.Forms.TextBox();
            this.txtTenPhongBan = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblNgayTL = new System.Windows.Forms.Label();
            this.lblTenQL = new System.Windows.Forms.Label();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.ptcNen = new System.Windows.Forms.PictureBox();
            this.pnlXuLy = new System.Windows.Forms.Panel();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.pnlDSPB.SuspendLayout();
            this.gboTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNen)).BeginInit();
            this.pnlXuLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDSPB
            // 
            this.pnlDSPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDSPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSPB.Controls.Add(this.lblDS);
            this.pnlDSPB.Controls.Add(this.lstvPhongBan);
            this.pnlDSPB.Location = new System.Drawing.Point(788, 121);
            this.pnlDSPB.Name = "pnlDSPB";
            this.pnlDSPB.Size = new System.Drawing.Size(703, 472);
            this.pnlDSPB.TabIndex = 27;
            // 
            // lblDS
            // 
            this.lblDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDS.Location = new System.Drawing.Point(0, 0);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(699, 35);
            this.lblDS.TabIndex = 15;
            this.lblDS.Text = "Danh sách phòng ban";
            this.lblDS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstvPhongBan
            // 
            this.lstvPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstvPhongBan.HideSelection = false;
            this.lstvPhongBan.Location = new System.Drawing.Point(6, 63);
            this.lstvPhongBan.MultiSelect = false;
            this.lstvPhongBan.Name = "lstvPhongBan";
            this.lstvPhongBan.Size = new System.Drawing.Size(689, 402);
            this.lstvPhongBan.TabIndex = 0;
            this.lstvPhongBan.UseCompatibleStateImageBehavior = false;
            this.lstvPhongBan.SelectedIndexChanged += new System.EventHandler(this.lvwPhongBan_SelectedIndexChanged);
            // 
            // txtTenSearch
            // 
            this.txtTenSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSearch.Location = new System.Drawing.Point(969, 48);
            this.txtTenSearch.Name = "txtTenSearch";
            this.txtTenSearch.Size = new System.Drawing.Size(400, 30);
            this.txtTenSearch.TabIndex = 26;
            // 
            // gboTT
            // 
            this.gboTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboTT.Controls.Add(this.dtmNgayThanhLap);
            this.gboTT.Controls.Add(this.txtTenQL);
            this.gboTT.Controls.Add(this.txtSLNV);
            this.gboTT.Controls.Add(this.txtTenPhongBan);
            this.gboTT.Controls.Add(this.lblNumber);
            this.gboTT.Controls.Add(this.lblNgayTL);
            this.gboTT.Controls.Add(this.lblTenQL);
            this.gboTT.Controls.Add(this.lblTenPB);
            this.gboTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboTT.Location = new System.Drawing.Point(19, 50);
            this.gboTT.Name = "gboTT";
            this.gboTT.Size = new System.Drawing.Size(739, 436);
            this.gboTT.TabIndex = 25;
            this.gboTT.TabStop = false;
            this.gboTT.Text = "Thông tin phòng ban";
            // 
            // dtmNgayThanhLap
            // 
            this.dtmNgayThanhLap.Enabled = false;
            this.dtmNgayThanhLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayThanhLap.Location = new System.Drawing.Point(264, 171);
            this.dtmNgayThanhLap.Name = "dtmNgayThanhLap";
            this.dtmNgayThanhLap.Size = new System.Drawing.Size(448, 38);
            this.dtmNgayThanhLap.TabIndex = 14;
            // 
            // txtTenQL
            // 
            this.txtTenQL.Enabled = false;
            this.txtTenQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenQL.Location = new System.Drawing.Point(264, 259);
            this.txtTenQL.Name = "txtTenQL";
            this.txtTenQL.Size = new System.Drawing.Size(448, 38);
            this.txtTenQL.TabIndex = 13;
            // 
            // txtSLNV
            // 
            this.txtSLNV.Enabled = false;
            this.txtSLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLNV.Location = new System.Drawing.Point(264, 355);
            this.txtSLNV.Name = "txtSLNV";
            this.txtSLNV.Size = new System.Drawing.Size(141, 38);
            this.txtSLNV.TabIndex = 12;
            // 
            // txtTenPhongBan
            // 
            this.txtTenPhongBan.Enabled = false;
            this.txtTenPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhongBan.Location = new System.Drawing.Point(264, 71);
            this.txtTenPhongBan.Name = "txtTenPhongBan";
            this.txtTenPhongBan.Size = new System.Drawing.Size(448, 38);
            this.txtTenPhongBan.TabIndex = 10;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(22, 362);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(219, 25);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "Số Lượng Nhân Viên:";
            // 
            // lblNgayTL
            // 
            this.lblNgayTL.AutoSize = true;
            this.lblNgayTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTL.Location = new System.Drawing.Point(62, 174);
            this.lblNgayTL.Name = "lblNgayTL";
            this.lblNgayTL.Size = new System.Drawing.Size(179, 25);
            this.lblNgayTL.TabIndex = 6;
            this.lblNgayTL.Text = "Ngày Thành Lập:";
            // 
            // lblTenQL
            // 
            this.lblTenQL.AutoSize = true;
            this.lblTenQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenQL.Location = new System.Drawing.Point(96, 266);
            this.lblTenQL.Name = "lblTenQL";
            this.lblTenQL.Size = new System.Drawing.Size(145, 25);
            this.lblTenQL.TabIndex = 4;
            this.lblTenQL.Text = "Tên Quản Lý:";
            // 
            // lblTenPB
            // 
            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPB.Location = new System.Drawing.Point(72, 78);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(169, 25);
            this.lblTenPB.TabIndex = 2;
            this.lblTenPB.Text = "Tên Phòng Ban:";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Red;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 25;
            this.btnXoa.Location = new System.Drawing.Point(617, 16);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 43);
            this.btnXoa.TabIndex = 30;
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
            this.btnSua.Location = new System.Drawing.Point(315, 16);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 43);
            this.btnSua.TabIndex = 29;
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
            this.btnThem.Location = new System.Drawing.Point(27, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 43);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(1417, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(74, 38);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // ptcNen
            // 
            this.ptcNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptcNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.ptcNen.Location = new System.Drawing.Point(0, 0);
            this.ptcNen.Name = "ptcNen";
            this.ptcNen.Size = new System.Drawing.Size(1513, 617);
            this.ptcNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcNen.TabIndex = 0;
            this.ptcNen.TabStop = false;
            // 
            // pnlXuLy
            // 
            this.pnlXuLy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlXuLy.Controls.Add(this.btnThem);
            this.pnlXuLy.Controls.Add(this.btnXoa);
            this.pnlXuLy.Controls.Add(this.btnSua);
            this.pnlXuLy.Location = new System.Drawing.Point(19, 524);
            this.pnlXuLy.Name = "pnlXuLy";
            this.pnlXuLy.Size = new System.Drawing.Size(739, 69);
            this.pnlXuLy.TabIndex = 31;
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSearch.Location = new System.Drawing.Point(785, 53);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(145, 25);
            this.lblNameSearch.TabIndex = 32;
            this.lblNameSearch.Text = "Tên phòng ban";
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1513, 617);
            this.Controls.Add(this.lblNameSearch);
            this.Controls.Add(this.pnlXuLy);
            this.Controls.Add(this.pnlDSPB);
            this.Controls.Add(this.txtTenSearch);
            this.Controls.Add(this.gboTT);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.ptcNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLPhongBan";
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            this.pnlDSPB.ResumeLayout(false);
            this.gboTT.ResumeLayout(false);
            this.gboTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNen)).EndInit();
            this.pnlXuLy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcNen;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Panel pnlDSPB;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.ListView lstvPhongBan;
        private System.Windows.Forms.TextBox txtTenSearch;
        private System.Windows.Forms.GroupBox gboTT;
        private System.Windows.Forms.DateTimePicker dtmNgayThanhLap;
        private System.Windows.Forms.TextBox txtTenQL;
        private System.Windows.Forms.TextBox txtSLNV;
        private System.Windows.Forms.TextBox txtTenPhongBan;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblNgayTL;
        private System.Windows.Forms.Label lblTenQL;
        private System.Windows.Forms.Label lblTenPB;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.Panel pnlXuLy;
        private System.Windows.Forms.Label lblNameSearch;
    }
}