
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmCongDoan
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
            this.pnlSP = new System.Windows.Forms.Panel();
            this.lstvSanPham = new System.Windows.Forms.ListView();
            this.lblDSSP = new System.Windows.Forms.Label();
            this.pnlCa = new System.Windows.Forms.Panel();
            this.lstvCongDoan = new System.Windows.Forms.ListView();
            this.lblList = new System.Windows.Forms.Label();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnTimKimSP = new FontAwesome.Sharp.IconButton();
            this.txtTenSearch = new System.Windows.Forms.TextBox();
            this.txtTenSPCapNhat = new System.Windows.Forms.TextBox();
            this.txtCongDoanCapNhat = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.lblTenCD = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.gboTT = new System.Windows.Forms.GroupBox();
            this.nudDonGiaCapNhat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNen)).BeginInit();
            this.pnlSP.SuspendLayout();
            this.pnlCa.SuspendLayout();
            this.gboTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaCapNhat)).BeginInit();
            this.SuspendLayout();
            // 
            // ptcNen
            // 
            this.ptcNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptcNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.ptcNen.Location = new System.Drawing.Point(0, 0);
            this.ptcNen.Name = "ptcNen";
            this.ptcNen.Size = new System.Drawing.Size(1386, 918);
            this.ptcNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcNen.TabIndex = 0;
            this.ptcNen.TabStop = false;
            // 
            // pnlSP
            // 
            this.pnlSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSP.BackColor = System.Drawing.Color.Transparent;
            this.pnlSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSP.Controls.Add(this.lstvSanPham);
            this.pnlSP.Controls.Add(this.lblDSSP);
            this.pnlSP.Location = new System.Drawing.Point(27, 74);
            this.pnlSP.Name = "pnlSP";
            this.pnlSP.Size = new System.Drawing.Size(517, 395);
            this.pnlSP.TabIndex = 37;
            // 
            // lstvSanPham
            // 
            this.lstvSanPham.HideSelection = false;
            this.lstvSanPham.Location = new System.Drawing.Point(16, 46);
            this.lstvSanPham.Name = "lstvSanPham";
            this.lstvSanPham.Size = new System.Drawing.Size(477, 332);
            this.lstvSanPham.TabIndex = 1;
            this.lstvSanPham.UseCompatibleStateImageBehavior = false;
            this.lstvSanPham.SelectedIndexChanged += new System.EventHandler(this.lstvSanPham_SelectedIndexChanged);
            // 
            // lblDSSP
            // 
            this.lblDSSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDSSP.Location = new System.Drawing.Point(0, 0);
            this.lblDSSP.Name = "lblDSSP";
            this.lblDSSP.Size = new System.Drawing.Size(513, 32);
            this.lblDSSP.TabIndex = 0;
            this.lblDSSP.Text = "Danh sách sản phẩm";
            // 
            // pnlCa
            // 
            this.pnlCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCa.BackColor = System.Drawing.Color.Transparent;
            this.pnlCa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCa.Controls.Add(this.lstvCongDoan);
            this.pnlCa.Controls.Add(this.lblList);
            this.pnlCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlCa.Location = new System.Drawing.Point(27, 565);
            this.pnlCa.Name = "pnlCa";
            this.pnlCa.Size = new System.Drawing.Size(1319, 341);
            this.pnlCa.TabIndex = 36;
            // 
            // lstvCongDoan
            // 
            this.lstvCongDoan.HideSelection = false;
            this.lstvCongDoan.Location = new System.Drawing.Point(16, 55);
            this.lstvCongDoan.Name = "lstvCongDoan";
            this.lstvCongDoan.Size = new System.Drawing.Size(1279, 265);
            this.lstvCongDoan.TabIndex = 1;
            this.lstvCongDoan.UseCompatibleStateImageBehavior = false;
            this.lstvCongDoan.SelectedIndexChanged += new System.EventHandler(this.lstvCongDoan_SelectedIndexChanged);
            // 
            // lblList
            // 
            this.lblList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblList.Location = new System.Drawing.Point(0, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(1315, 41);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "Danh sách công đoạn";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Red;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 25;
            this.btnXoa.Location = new System.Drawing.Point(538, 337);
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
            this.btnSua.Location = new System.Drawing.Point(300, 337);
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
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(42)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 25;
            this.btnThem.Location = new System.Drawing.Point(45, 337);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 43);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKimSP
            // 
            this.btnTimKimSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKimSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKimSP.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKimSP.IconColor = System.Drawing.Color.Blue;
            this.btnTimKimSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKimSP.IconSize = 25;
            this.btnTimKimSP.Location = new System.Drawing.Point(480, 25);
            this.btnTimKimSP.Name = "btnTimKimSP";
            this.btnTimKimSP.Size = new System.Drawing.Size(62, 30);
            this.btnTimKimSP.TabIndex = 35;
            this.btnTimKimSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKimSP.UseVisualStyleBackColor = true;
            this.btnTimKimSP.Click += new System.EventHandler(this.btnTimKimSP_Click);
            // 
            // txtTenSearch
            // 
            this.txtTenSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSearch.Location = new System.Drawing.Point(198, 23);
            this.txtTenSearch.Name = "txtTenSearch";
            this.txtTenSearch.Size = new System.Drawing.Size(258, 30);
            this.txtTenSearch.TabIndex = 30;
            // 
            // txtTenSPCapNhat
            // 
            this.txtTenSPCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSPCapNhat.Enabled = false;
            this.txtTenSPCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSPCapNhat.Location = new System.Drawing.Point(264, 43);
            this.txtTenSPCapNhat.Name = "txtTenSPCapNhat";
            this.txtTenSPCapNhat.Size = new System.Drawing.Size(371, 30);
            this.txtTenSPCapNhat.TabIndex = 28;
            // 
            // txtCongDoanCapNhat
            // 
            this.txtCongDoanCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCongDoanCapNhat.Enabled = false;
            this.txtCongDoanCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCongDoanCapNhat.Location = new System.Drawing.Point(262, 121);
            this.txtCongDoanCapNhat.Name = "txtCongDoanCapNhat";
            this.txtCongDoanCapNhat.Size = new System.Drawing.Size(373, 30);
            this.txtCongDoanCapNhat.TabIndex = 26;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(29, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 25);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Tên sản phẩm";
            // 
            // lblDongia
            // 
            this.lblDongia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDongia.AutoSize = true;
            this.lblDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDongia.Location = new System.Drawing.Point(40, 210);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(79, 25);
            this.lblDongia.TabIndex = 24;
            this.lblDongia.Text = "Đơn giá";
            // 
            // lblTenCD
            // 
            this.lblTenCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenCD.AutoSize = true;
            this.lblTenCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTenCD.Location = new System.Drawing.Point(40, 126);
            this.lblTenCD.Name = "lblTenCD";
            this.lblTenCD.Size = new System.Drawing.Size(144, 25);
            this.lblTenCD.TabIndex = 23;
            this.lblTenCD.Text = "Tên công đoạn";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTenSP.Location = new System.Drawing.Point(40, 48);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(138, 25);
            this.lblTenSP.TabIndex = 21;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // gboTT
            // 
            this.gboTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboTT.Controls.Add(this.btnXoa);
            this.gboTT.Controls.Add(this.btnSua);
            this.gboTT.Controls.Add(this.btnThem);
            this.gboTT.Controls.Add(this.nudDonGiaCapNhat);
            this.gboTT.Controls.Add(this.txtTenSPCapNhat);
            this.gboTT.Controls.Add(this.txtCongDoanCapNhat);
            this.gboTT.Controls.Add(this.lblDongia);
            this.gboTT.Controls.Add(this.lblTenCD);
            this.gboTT.Controls.Add(this.lblTenSP);
            this.gboTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboTT.Location = new System.Drawing.Point(678, 74);
            this.gboTT.Name = "gboTT";
            this.gboTT.Size = new System.Drawing.Size(668, 395);
            this.gboTT.TabIndex = 38;
            this.gboTT.TabStop = false;
            this.gboTT.Text = "Thông tin công đoạn";
            // 
            // nudDonGiaCapNhat
            // 
            this.nudDonGiaCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudDonGiaCapNhat.Enabled = false;
            this.nudDonGiaCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDonGiaCapNhat.Location = new System.Drawing.Point(262, 205);
            this.nudDonGiaCapNhat.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudDonGiaCapNhat.Name = "nudDonGiaCapNhat";
            this.nudDonGiaCapNhat.Size = new System.Drawing.Size(371, 30);
            this.nudDonGiaCapNhat.TabIndex = 30;
            this.nudDonGiaCapNhat.ThousandsSeparator = true;
            // 
            // frmCongDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1386, 918);
            this.Controls.Add(this.gboTT);
            this.Controls.Add(this.pnlSP);
            this.Controls.Add(this.pnlCa);
            this.Controls.Add(this.btnTimKimSP);
            this.Controls.Add(this.txtTenSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ptcNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCongDoan";
            this.Text = "frmCongDoan";
            this.Load += new System.EventHandler(this.frmCongDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcNen)).EndInit();
            this.pnlSP.ResumeLayout(false);
            this.pnlCa.ResumeLayout(false);
            this.gboTT.ResumeLayout(false);
            this.gboTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaCapNhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcNen;
        private System.Windows.Forms.Panel pnlSP;
        private System.Windows.Forms.ListView lstvSanPham;
        private System.Windows.Forms.Label lblDSSP;
        private System.Windows.Forms.Panel pnlCa;
        private System.Windows.Forms.ListView lstvCongDoan;
        private System.Windows.Forms.Label lblList;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnTimKimSP;
        private System.Windows.Forms.TextBox txtTenSearch;
        private System.Windows.Forms.TextBox txtTenSPCapNhat;
        private System.Windows.Forms.TextBox txtCongDoanCapNhat;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label lblTenCD;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.GroupBox gboTT;
        private System.Windows.Forms.NumericUpDown nudDonGiaCapNhat;
    }
}