
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
            this.pnlHD = new System.Windows.Forms.Panel();
            this.lvwDSHD = new System.Windows.Forms.ListView();
            this.lblDSHD = new System.Windows.Forms.Label();
            this.txtNgayBD = new System.Windows.Forms.TextBox();
            this.lbltenHD = new System.Windows.Forms.Label();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtNgayKT = new System.Windows.Forms.TextBox();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.btnTiemKiem = new FontAwesome.Sharp.IconButton();
            this.pnlHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHD
            // 
            this.pnlHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHD.Controls.Add(this.lvwDSHD);
            this.pnlHD.Controls.Add(this.lblDSHD);
            this.pnlHD.Location = new System.Drawing.Point(12, 427);
            this.pnlHD.Name = "pnlHD";
            this.pnlHD.Size = new System.Drawing.Size(1178, 359);
            this.pnlHD.TabIndex = 13;
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
            // txtNgayBD
            // 
            this.txtNgayBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgayBD.BackColor = System.Drawing.Color.White;
            this.txtNgayBD.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNgayBD.Location = new System.Drawing.Point(282, 135);
            this.txtNgayBD.Name = "txtNgayBD";
            this.txtNgayBD.Size = new System.Drawing.Size(410, 32);
            this.txtNgayBD.TabIndex = 16;
            // 
            // lbltenHD
            // 
            this.lbltenHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltenHD.AutoSize = true;
            this.lbltenHD.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lbltenHD.Location = new System.Drawing.Point(15, 33);
            this.lbltenHD.Name = "lbltenHD";
            this.lbltenHD.Size = new System.Drawing.Size(143, 23);
            this.lbltenHD.TabIndex = 14;
            this.lbltenHD.Text = "Tên hợp đồng";
            // 
            // txtTenHD
            // 
            this.txtTenHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenHD.BackColor = System.Drawing.Color.White;
            this.txtTenHD.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtTenHD.Location = new System.Drawing.Point(282, 24);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(410, 32);
            this.txtTenHD.TabIndex = 17;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblNgayBD.Location = new System.Drawing.Point(8, 144);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(137, 23);
            this.lblNgayBD.TabIndex = 15;
            this.lblNgayBD.Text = "Ngày bắt đầu";
            // 
            // lblTenKH
            // 
            this.lblTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblTenKH.Location = new System.Drawing.Point(8, 377);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(162, 23);
            this.lblTenKH.TabIndex = 15;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // txtNgayKT
            // 
            this.txtNgayKT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgayKT.BackColor = System.Drawing.Color.White;
            this.txtNgayKT.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtNgayKT.Location = new System.Drawing.Point(291, 254);
            this.txtNgayKT.Name = "txtNgayKT";
            this.txtNgayKT.Size = new System.Drawing.Size(410, 32);
            this.txtNgayKT.TabIndex = 17;
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblNgayKT.Location = new System.Drawing.Point(12, 263);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(142, 23);
            this.lblNgayKT.TabIndex = 14;
            this.lblNgayKT.Text = "Ngày kết thúc";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKH.BackColor = System.Drawing.Color.White;
            this.txtTenKH.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtTenKH.Location = new System.Drawing.Point(282, 368);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(410, 32);
            this.txtTenKH.TabIndex = 16;
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
            this.btnTiemKiem.Location = new System.Drawing.Point(774, 348);
            this.btnTiemKiem.Name = "btnTiemKiem";
            this.btnTiemKiem.Size = new System.Drawing.Size(414, 52);
            this.btnTiemKiem.TabIndex = 18;
            this.btnTiemKiem.Text = "Tìm kiếm";
            this.btnTiemKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTiemKiem.UseVisualStyleBackColor = true;
            // 
            // frmTiemKiemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 821);
            this.Controls.Add(this.btnTiemKiem);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lblNgayKT);
            this.Controls.Add(this.txtNgayBD);
            this.Controls.Add(this.txtNgayKT);
            this.Controls.Add(this.lbltenHD);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.txtTenHD);
            this.Controls.Add(this.lblNgayBD);
            this.Controls.Add(this.pnlHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTiemKiemHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTiemKiemHD";
            this.pnlHD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHD;
        private System.Windows.Forms.ListView lvwDSHD;
        private System.Windows.Forms.Label lblDSHD;
        private System.Windows.Forms.TextBox txtNgayBD;
        private System.Windows.Forms.Label lbltenHD;
        private System.Windows.Forms.TextBox txtTenHD;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtNgayKT;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.TextBox txtTenKH;
        private FontAwesome.Sharp.IconButton btnTiemKiem;
    }
}