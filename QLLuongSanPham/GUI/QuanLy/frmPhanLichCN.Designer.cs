
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
            this.ptcNen = new System.Windows.Forms.PictureBox();
            this.btnRight = new FontAwesome.Sharp.IconButton();
            this.btnLeft = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.pnlDSCV = new System.Windows.Forms.Panel();
            this.lvwDSLich = new System.Windows.Forms.ListView();
            this.lblDSLich = new System.Windows.Forms.Label();
            this.lvwDSNV = new System.Windows.Forms.ListView();
            this.lsbDSNV = new System.Windows.Forms.Label();
            this.pnlDSCN = new System.Windows.Forms.Panel();
            this.pnlDSPC = new System.Windows.Forms.Panel();
            this.lvwDSPC = new System.Windows.Forms.ListView();
            this.lblDSPhanCong = new System.Windows.Forms.Label();
            this.dtmNgay = new System.Windows.Forms.DateTimePicker();
            this.cboCa = new System.Windows.Forms.ComboBox();
            this.cboTenCD = new System.Windows.Forms.ComboBox();
            this.txtTenSpInput = new System.Windows.Forms.TextBox();
            this.lblCa = new System.Windows.Forms.Label();
            this.lblTenCĐ = new System.Windows.Forms.Label();
            this.lblNameSP = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.btnTimDSSP = new FontAwesome.Sharp.IconButton();
            this.txtSpSearch = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.pnlDSSP = new System.Windows.Forms.Panel();
            this.lvwDSSP = new System.Windows.Forms.ListView();
            this.lblDSSP = new System.Windows.Forms.Label();
            this.gboTT = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNen)).BeginInit();
            this.pnlDSCV.SuspendLayout();
            this.pnlDSCN.SuspendLayout();
            this.pnlDSPC.SuspendLayout();
            this.pnlDSSP.SuspendLayout();
            this.gboTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptcNen
            // 
            this.ptcNen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ptcNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptcNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.ptcNen.Location = new System.Drawing.Point(0, 0);
            this.ptcNen.Name = "ptcNen";
            this.ptcNen.Size = new System.Drawing.Size(1615, 966);
            this.ptcNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcNen.TabIndex = 0;
            this.ptcNen.TabStop = false;
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRight.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnRight.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRight.IconSize = 30;
            this.btnRight.Location = new System.Drawing.Point(1218, 333);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(62, 56);
            this.btnRight.TabIndex = 50;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeft.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnLeft.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLeft.IconSize = 30;
            this.btnLeft.Location = new System.Drawing.Point(1218, 240);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(62, 59);
            this.btnLeft.TabIndex = 49;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 25;
            this.btnThem.Location = new System.Drawing.Point(172, 452);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 43);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Phân lịch";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlDSCV
            // 
            this.pnlDSCV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDSCV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSCV.Controls.Add(this.lvwDSLich);
            this.pnlDSCV.Controls.Add(this.lblDSLich);
            this.pnlDSCV.Location = new System.Drawing.Point(20, 633);
            this.pnlDSCV.Name = "pnlDSCV";
            this.pnlDSCV.Size = new System.Drawing.Size(1578, 303);
            this.pnlDSCV.TabIndex = 44;
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
            // lvwDSNV
            // 
            this.lvwDSNV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lvwDSNV.HideSelection = false;
            this.lvwDSNV.Location = new System.Drawing.Point(14, 46);
            this.lvwDSNV.Name = "lvwDSNV";
            this.lvwDSNV.Size = new System.Drawing.Size(279, 449);
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
            // pnlDSCN
            // 
            this.pnlDSCN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDSCN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSCN.Controls.Add(this.lvwDSNV);
            this.pnlDSCN.Controls.Add(this.lsbDSNV);
            this.pnlDSCN.Location = new System.Drawing.Point(1286, 68);
            this.pnlDSCN.Name = "pnlDSCN";
            this.pnlDSCN.Size = new System.Drawing.Size(312, 510);
            this.pnlDSCN.TabIndex = 43;
            // 
            // pnlDSPC
            // 
            this.pnlDSPC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDSPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSPC.Controls.Add(this.lvwDSPC);
            this.pnlDSPC.Controls.Add(this.lblDSPhanCong);
            this.pnlDSPC.Location = new System.Drawing.Point(906, 68);
            this.pnlDSPC.Name = "pnlDSPC";
            this.pnlDSPC.Size = new System.Drawing.Size(306, 510);
            this.pnlDSPC.TabIndex = 42;
            // 
            // lvwDSPC
            // 
            this.lvwDSPC.HideSelection = false;
            this.lvwDSPC.Location = new System.Drawing.Point(13, 50);
            this.lvwDSPC.Name = "lvwDSPC";
            this.lvwDSPC.Size = new System.Drawing.Size(269, 445);
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
            // dtmNgay
            // 
            this.dtmNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtmNgay.Enabled = false;
            this.dtmNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtmNgay.Location = new System.Drawing.Point(172, 50);
            this.dtmNgay.Name = "dtmNgay";
            this.dtmNgay.Size = new System.Drawing.Size(274, 30);
            this.dtmNgay.TabIndex = 41;
            // 
            // cboCa
            // 
            this.cboCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCa.Enabled = false;
            this.cboCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboCa.FormattingEnabled = true;
            this.cboCa.Location = new System.Drawing.Point(172, 349);
            this.cboCa.Name = "cboCa";
            this.cboCa.Size = new System.Drawing.Size(274, 33);
            this.cboCa.TabIndex = 40;
            // 
            // cboTenCD
            // 
            this.cboTenCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTenCD.Enabled = false;
            this.cboTenCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboTenCD.FormattingEnabled = true;
            this.cboTenCD.Location = new System.Drawing.Point(172, 255);
            this.cboTenCD.Name = "cboTenCD";
            this.cboTenCD.Size = new System.Drawing.Size(274, 33);
            this.cboTenCD.TabIndex = 39;
            this.cboTenCD.SelectedIndexChanged += new System.EventHandler(this.cboTenCD_SelectedIndexChanged);
            // 
            // txtTenSpInput
            // 
            this.txtTenSpInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSpInput.Enabled = false;
            this.txtTenSpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSpInput.Location = new System.Drawing.Point(172, 138);
            this.txtTenSpInput.Name = "txtTenSpInput";
            this.txtTenSpInput.Size = new System.Drawing.Size(274, 30);
            this.txtTenSpInput.TabIndex = 35;
            // 
            // lblCa
            // 
            this.lblCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCa.AutoSize = true;
            this.lblCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCa.Location = new System.Drawing.Point(6, 357);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(38, 25);
            this.lblCa.TabIndex = 33;
            this.lblCa.Text = "Ca";
            // 
            // lblTenCĐ
            // 
            this.lblTenCĐ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenCĐ.AutoSize = true;
            this.lblTenCĐ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTenCĐ.Location = new System.Drawing.Point(6, 263);
            this.lblTenCĐ.Name = "lblTenCĐ";
            this.lblTenCĐ.Size = new System.Drawing.Size(144, 25);
            this.lblTenCĐ.TabIndex = 31;
            this.lblTenCĐ.Text = "Tên công đoạn";
            // 
            // lblNameSP
            // 
            this.lblNameSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameSP.AutoSize = true;
            this.lblNameSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNameSP.Location = new System.Drawing.Point(6, 143);
            this.lblNameSP.Name = "lblNameSP";
            this.lblNameSP.Size = new System.Drawing.Size(138, 25);
            this.lblNameSP.TabIndex = 29;
            this.lblNameSP.Text = "Tên sản phẩm";
            // 
            // lblNgay
            // 
            this.lblNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNgay.Location = new System.Drawing.Point(6, 46);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(58, 25);
            this.lblNgay.TabIndex = 27;
            this.lblNgay.Text = "Ngày";
            // 
            // btnTimDSSP
            // 
            this.btnTimDSSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimDSSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimDSSP.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimDSSP.IconColor = System.Drawing.Color.Blue;
            this.btnTimDSSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimDSSP.IconSize = 20;
            this.btnTimDSSP.Location = new System.Drawing.Point(344, 17);
            this.btnTimDSSP.Name = "btnTimDSSP";
            this.btnTimDSSP.Size = new System.Drawing.Size(63, 30);
            this.btnTimDSSP.TabIndex = 26;
            this.btnTimDSSP.UseVisualStyleBackColor = true;
            this.btnTimDSSP.Click += new System.EventHandler(this.btnTimDSSP_Click);
            // 
            // txtSpSearch
            // 
            this.txtSpSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpSearch.Location = new System.Drawing.Point(101, 21);
            this.txtSpSearch.Name = "txtSpSearch";
            this.txtSpSearch.Size = new System.Drawing.Size(229, 26);
            this.txtSpSearch.TabIndex = 25;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.White;
            this.lblTenSP.Location = new System.Drawing.Point(16, 27);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(70, 20);
            this.lblTenSP.TabIndex = 24;
            this.lblTenSP.Text = "Tên SP";
            // 
            // pnlDSSP
            // 
            this.pnlDSSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDSSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSSP.Controls.Add(this.lvwDSSP);
            this.pnlDSSP.Controls.Add(this.lblDSSP);
            this.pnlDSSP.Location = new System.Drawing.Point(20, 68);
            this.pnlDSSP.Name = "pnlDSSP";
            this.pnlDSSP.Size = new System.Drawing.Size(389, 510);
            this.pnlDSSP.TabIndex = 23;
            // 
            // lvwDSSP
            // 
            this.lvwDSSP.HideSelection = false;
            this.lvwDSSP.Location = new System.Drawing.Point(14, 46);
            this.lvwDSSP.Name = "lvwDSSP";
            this.lvwDSSP.Size = new System.Drawing.Size(355, 450);
            this.lvwDSSP.TabIndex = 1;
            this.lvwDSSP.UseCompatibleStateImageBehavior = false;
            this.lvwDSSP.SelectedIndexChanged += new System.EventHandler(this.lvwDSSP_SelectedIndexChanged);
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
            // gboTT
            // 
            this.gboTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboTT.Controls.Add(this.btnThem);
            this.gboTT.Controls.Add(this.dtmNgay);
            this.gboTT.Controls.Add(this.cboCa);
            this.gboTT.Controls.Add(this.cboTenCD);
            this.gboTT.Controls.Add(this.txtTenSpInput);
            this.gboTT.Controls.Add(this.lblCa);
            this.gboTT.Controls.Add(this.lblTenCĐ);
            this.gboTT.Controls.Add(this.lblNameSP);
            this.gboTT.Controls.Add(this.lblNgay);
            this.gboTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboTT.Location = new System.Drawing.Point(425, 70);
            this.gboTT.Name = "gboTT";
            this.gboTT.Size = new System.Drawing.Size(466, 508);
            this.gboTT.TabIndex = 52;
            this.gboTT.TabStop = false;
            this.gboTT.Text = "Thông tin lịch làm việc";
            // 
            // frmPhanLichCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1615, 966);
            this.Controls.Add(this.gboTT);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.pnlDSCV);
            this.Controls.Add(this.pnlDSCN);
            this.Controls.Add(this.pnlDSPC);
            this.Controls.Add(this.btnTimDSSP);
            this.Controls.Add(this.txtSpSearch);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.pnlDSSP);
            this.Controls.Add(this.ptcNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhanLichCN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanLichCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcNen)).EndInit();
            this.pnlDSCV.ResumeLayout(false);
            this.pnlDSCN.ResumeLayout(false);
            this.pnlDSPC.ResumeLayout(false);
            this.pnlDSSP.ResumeLayout(false);
            this.gboTT.ResumeLayout(false);
            this.gboTT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcNen;
        private FontAwesome.Sharp.IconButton btnRight;
        private FontAwesome.Sharp.IconButton btnLeft;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Panel pnlDSCV;
        private System.Windows.Forms.ListView lvwDSLich;
        private System.Windows.Forms.Label lblDSLich;
        private System.Windows.Forms.Label lsbDSNV;
        private System.Windows.Forms.Panel pnlDSCN;
        private System.Windows.Forms.Panel pnlDSPC;
        private System.Windows.Forms.Label lblDSPhanCong;
        private System.Windows.Forms.DateTimePicker dtmNgay;
        private System.Windows.Forms.ComboBox cboCa;
        private System.Windows.Forms.ComboBox cboTenCD;
        private System.Windows.Forms.TextBox txtTenSpInput;
        private System.Windows.Forms.Label lblCa;
        private System.Windows.Forms.Label lblTenCĐ;
        private System.Windows.Forms.Label lblNameSP;
        private System.Windows.Forms.Label lblNgay;
        private FontAwesome.Sharp.IconButton btnTimDSSP;
        private System.Windows.Forms.TextBox txtSpSearch;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Panel pnlDSSP;
        private System.Windows.Forms.ListView lvwDSSP;
        private System.Windows.Forms.Label lblDSSP;
        private System.Windows.Forms.GroupBox gboTT;
        private System.Windows.Forms.ListView lvwDSPC;
        private System.Windows.Forms.ListView lvwDSNV;
    }
}