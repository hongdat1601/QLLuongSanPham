
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmTiemKiemHD
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
            this.btnTiemKiem = new FontAwesome.Sharp.IconButton();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.txtNgayBD = new System.Windows.Forms.TextBox();
            this.txtNgayKT = new System.Windows.Forms.TextBox();
            this.lbltenHD = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.pnlHD = new System.Windows.Forms.Panel();
            this.lvwDSHD = new System.Windows.Forms.ListView();
            this.lblDSHD = new System.Windows.Forms.Label();
            this.gboTT = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.pnlHD.SuspendLayout();
            this.gboTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(1202, 821);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 0;
            this.picNen.TabStop = false;
            // 
            // btnTiemKiem
            // 
            this.btnTiemKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTiemKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiemKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTiemKiem.IconColor = System.Drawing.Color.Blue;
            this.btnTiemKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTiemKiem.IconSize = 30;
            this.btnTiemKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTiemKiem.Location = new System.Drawing.Point(776, 353);
            this.btnTiemKiem.Name = "btnTiemKiem";
            this.btnTiemKiem.Size = new System.Drawing.Size(414, 52);
            this.btnTiemKiem.TabIndex = 28;
            this.btnTiemKiem.Text = "Tìm kiếm";
            this.btnTiemKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTiemKiem.UseVisualStyleBackColor = true;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKH.BackColor = System.Drawing.Color.White;
            this.txtTenKH.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtTenKH.Location = new System.Drawing.Point(260, 299);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(410, 32);
            this.txtTenKH.TabIndex = 24;
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblNgayKT.Location = new System.Drawing.Point(7, 222);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(142, 23);
            this.lblNgayKT.TabIndex = 20;
            this.lblNgayKT.Text = "Ngày kết thúc";
            // 
            // txtNgayBD
            // 
            this.txtNgayBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgayBD.BackColor = System.Drawing.Color.White;
            this.txtNgayBD.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNgayBD.Location = new System.Drawing.Point(260, 119);
            this.txtNgayBD.Name = "txtNgayBD";
            this.txtNgayBD.Size = new System.Drawing.Size(410, 32);
            this.txtNgayBD.TabIndex = 25;
            // 
            // txtNgayKT
            // 
            this.txtNgayKT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgayKT.BackColor = System.Drawing.Color.White;
            this.txtNgayKT.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNgayKT.Location = new System.Drawing.Point(260, 213);
            this.txtNgayKT.Name = "txtNgayKT";
            this.txtNgayKT.Size = new System.Drawing.Size(410, 32);
            this.txtNgayKT.TabIndex = 26;
            // 
            // lbltenHD
            // 
            this.lbltenHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltenHD.AutoSize = true;
            this.lbltenHD.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lbltenHD.Location = new System.Drawing.Point(7, 44);
            this.lbltenHD.Name = "lbltenHD";
            this.lbltenHD.Size = new System.Drawing.Size(143, 23);
            this.lbltenHD.TabIndex = 21;
            this.lbltenHD.Text = "Tên hợp đồng";
            // 
            // lblTenKH
            // 
            this.lblTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblTenKH.Location = new System.Drawing.Point(7, 308);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(162, 23);
            this.lblTenKH.TabIndex = 22;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // txtTenHD
            // 
            this.txtTenHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenHD.BackColor = System.Drawing.Color.White;
            this.txtTenHD.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtTenHD.Location = new System.Drawing.Point(260, 35);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(410, 32);
            this.txtTenHD.TabIndex = 27;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblNgayBD.Location = new System.Drawing.Point(6, 128);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(137, 23);
            this.lblNgayBD.TabIndex = 23;
            this.lblNgayBD.Text = "Ngày bắt đầu";
            // 
            // pnlHD
            // 
            this.pnlHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHD.Controls.Add(this.lvwDSHD);
            this.pnlHD.Controls.Add(this.lblDSHD);
            this.pnlHD.Location = new System.Drawing.Point(14, 432);
            this.pnlHD.Name = "pnlHD";
            this.pnlHD.Size = new System.Drawing.Size(1178, 359);
            this.pnlHD.TabIndex = 19;
            // 
            // lvwDSHD
            // 
            this.lvwDSHD.HideSelection = false;
            this.lvwDSHD.Location = new System.Drawing.Point(19, 53);
            this.lvwDSHD.Name = "lvwDSHD";
            this.lvwDSHD.Size = new System.Drawing.Size(1131, 286);
            this.lvwDSHD.TabIndex = 1;
            this.lvwDSHD.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSHD
            // 
            this.lblDSHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDSHD.Location = new System.Drawing.Point(0, 0);
            this.lblDSHD.Name = "lblDSHD";
            this.lblDSHD.Size = new System.Drawing.Size(1174, 33);
            this.lblDSHD.TabIndex = 0;
            this.lblDSHD.Text = "Danh sách hợp đồng";
            this.lblDSHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboTT
            // 
            this.gboTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboTT.Controls.Add(this.txtTenKH);
            this.gboTT.Controls.Add(this.lblNgayKT);
            this.gboTT.Controls.Add(this.txtNgayBD);
            this.gboTT.Controls.Add(this.txtNgayKT);
            this.gboTT.Controls.Add(this.lbltenHD);
            this.gboTT.Controls.Add(this.lblTenKH);
            this.gboTT.Controls.Add(this.txtTenHD);
            this.gboTT.Controls.Add(this.lblNgayBD);
            this.gboTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboTT.Location = new System.Drawing.Point(24, 33);
            this.gboTT.Name = "gboTT";
            this.gboTT.Size = new System.Drawing.Size(688, 371);
            this.gboTT.TabIndex = 29;
            this.gboTT.TabStop = false;
            this.gboTT.Text = "Thông tin hợp đồng";
            // 
            // frmTiemKiemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1202, 821);
            this.Controls.Add(this.gboTT);
            this.Controls.Add(this.btnTiemKiem);
            this.Controls.Add(this.pnlHD);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTiemKiemHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTiemKiemHD";
            this.Load += new System.EventHandler(this.frmTiemKiemHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.pnlHD.ResumeLayout(false);
            this.gboTT.ResumeLayout(false);
            this.gboTT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private FontAwesome.Sharp.IconButton btnTiemKiem;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.TextBox txtNgayBD;
        private System.Windows.Forms.TextBox txtNgayKT;
        private System.Windows.Forms.Label lbltenHD;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenHD;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.Panel pnlHD;
        private System.Windows.Forms.ListView lvwDSHD;
        private System.Windows.Forms.Label lblDSHD;
        private System.Windows.Forms.GroupBox gboTT;
    }
}