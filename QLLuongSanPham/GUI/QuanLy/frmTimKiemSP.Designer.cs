
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmTimKiemSP
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
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDG = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlSP = new System.Windows.Forms.Panel();
            this.lstvDSSP = new System.Windows.Forms.ListView();
            this.lblDSSP = new System.Windows.Forms.Label();
            this.gboTT = new System.Windows.Forms.GroupBox();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.pnlSP.SuspendLayout();
            this.gboTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(1583, 899);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.btnTimKiem.Location = new System.Drawing.Point(190, 288);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(351, 52);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonGia.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.txtDonGia.Location = new System.Drawing.Point(562, 156);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(649, 38);
            this.txtDonGia.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(562, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(649, 38);
            this.txtName.TabIndex = 22;
            // 
            // lblDG
            // 
            this.lblDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDG.AutoSize = true;
            this.lblDG.Font = new System.Drawing.Font("Verdana", 15F);
            this.lblDG.Location = new System.Drawing.Point(184, 154);
            this.lblDG.Name = "lblDG";
            this.lblDG.Size = new System.Drawing.Size(110, 31);
            this.lblDG.TabIndex = 19;
            this.lblDG.Text = "Đơn giá";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 15F);
            this.lblName.Location = new System.Drawing.Point(182, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(193, 31);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Tên sản phẩm";
            // 
            // pnlSP
            // 
            this.pnlSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSP.Controls.Add(this.lstvDSSP);
            this.pnlSP.Controls.Add(this.lblDSSP);
            this.pnlSP.Location = new System.Drawing.Point(33, 512);
            this.pnlSP.Name = "pnlSP";
            this.pnlSP.Size = new System.Drawing.Size(1519, 363);
            this.pnlSP.TabIndex = 18;
            // 
            // lstvDSSP
            // 
            this.lstvDSSP.HideSelection = false;
            this.lstvDSSP.Location = new System.Drawing.Point(22, 52);
            this.lstvDSSP.Name = "lstvDSSP";
            this.lstvDSSP.Size = new System.Drawing.Size(1464, 286);
            this.lstvDSSP.TabIndex = 1;
            this.lstvDSSP.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSSP
            // 
            this.lblDSSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDSSP.Location = new System.Drawing.Point(0, 0);
            this.lblDSSP.Name = "lblDSSP";
            this.lblDSSP.Size = new System.Drawing.Size(1515, 33);
            this.lblDSSP.TabIndex = 0;
            this.lblDSSP.Text = "Danh sách sản phẩm";
            this.lblDSSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboTT
            // 
            this.gboTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboTT.Controls.Add(this.txtDonGia);
            this.gboTT.Controls.Add(this.btnReset);
            this.gboTT.Controls.Add(this.txtName);
            this.gboTT.Controls.Add(this.btnTimKiem);
            this.gboTT.Controls.Add(this.lblDG);
            this.gboTT.Controls.Add(this.lblName);
            this.gboTT.Location = new System.Drawing.Point(33, 64);
            this.gboTT.Name = "gboTT";
            this.gboTT.Size = new System.Drawing.Size(1517, 382);
            this.gboTT.TabIndex = 24;
            this.gboTT.TabStop = false;
            this.gboTT.Text = "Thông tin sản phẩm";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnReset.IconColor = System.Drawing.Color.Blue;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 30;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(828, 288);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(383, 52);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmTimKiemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1583, 899);
            this.Controls.Add(this.gboTT);
            this.Controls.Add(this.pnlSP);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiemSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiemSP";
            this.Load += new System.EventHandler(this.frmTimKiemSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.pnlSP.ResumeLayout(false);
            this.gboTT.ResumeLayout(false);
            this.gboTT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDG;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlSP;
        private System.Windows.Forms.ListView lstvDSSP;
        private System.Windows.Forms.Label lblDSSP;
        private System.Windows.Forms.GroupBox gboTT;
        private FontAwesome.Sharp.IconButton btnReset;
    }
}