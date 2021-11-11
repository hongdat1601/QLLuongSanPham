
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmTinhLuongHC
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
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.btnTinh = new FontAwesome.Sharp.IconButton();
            this.pnlLuong = new System.Windows.Forms.Panel();
            this.lvwDSLuong = new System.Windows.Forms.ListView();
            this.lblDSLuong = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThuongPhat = new System.Windows.Forms.TextBox();
            this.lblTP = new System.Windows.Forms.Label();
            this.pnlNgayNghi = new System.Windows.Forms.Panel();
            this.lvwNgayNghi = new System.Windows.Forms.ListView();
            this.lblNgayNghi = new System.Windows.Forms.Label();
            this.pnlCongViec = new System.Windows.Forms.Panel();
            this.lvwCongViec = new System.Windows.Forms.ListView();
            this.lblCongViec = new System.Windows.Forms.Label();
            this.pnlDSNV = new System.Windows.Forms.Panel();
            this.lvwDSNV = new System.Windows.Forms.ListView();
            this.lblDSNV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.pnlLuong.SuspendLayout();
            this.pnlNgayNghi.SuspendLayout();
            this.pnlCongViec.SuspendLayout();
            this.pnlDSNV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(1336, 994);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 0;
            this.picNen.TabStop = false;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTim.IconColor = System.Drawing.Color.Blue;
            this.btnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTim.IconSize = 20;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(601, 18);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(125, 30);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(120, 22);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(444, 26);
            this.txtTen.TabIndex = 23;
            // 
            // lblTen
            // 
            this.lblTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(23, 23);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(50, 25);
            this.lblTen.TabIndex = 21;
            this.lblTen.Text = "Tên";
            // 
            // btnTinh
            // 
            this.btnTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnTinh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTinh.IconSize = 22;
            this.btnTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTinh.Location = new System.Drawing.Point(232, 623);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(250, 43);
            this.btnTinh.TabIndex = 19;
            this.btnTinh.Text = "Tính lương";
            this.btnTinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinh.UseVisualStyleBackColor = true;
            // 
            // pnlLuong
            // 
            this.pnlLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLuong.Controls.Add(this.lvwDSLuong);
            this.pnlLuong.Controls.Add(this.lblDSLuong);
            this.pnlLuong.Location = new System.Drawing.Point(30, 692);
            this.pnlLuong.Name = "pnlLuong";
            this.pnlLuong.Size = new System.Drawing.Size(1283, 280);
            this.pnlLuong.TabIndex = 18;
            // 
            // lvwDSLuong
            // 
            this.lvwDSLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDSLuong.HideSelection = false;
            this.lvwDSLuong.Location = new System.Drawing.Point(20, 51);
            this.lvwDSLuong.Name = "lvwDSLuong";
            this.lvwDSLuong.Size = new System.Drawing.Size(1245, 213);
            this.lvwDSLuong.TabIndex = 1;
            this.lvwDSLuong.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSLuong
            // 
            this.lblDSLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSLuong.Location = new System.Drawing.Point(0, 0);
            this.lblDSLuong.Name = "lblDSLuong";
            this.lblDSLuong.Size = new System.Drawing.Size(1279, 37);
            this.lblDSLuong.TabIndex = 0;
            this.lblDSLuong.Text = "Danh sách bảng lương";
            this.lblDSLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(247, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(417, 30);
            this.textBox3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số buổi làm thêm";
            // 
            // txtThuongPhat
            // 
            this.txtThuongPhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThuongPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuongPhat.Location = new System.Drawing.Point(247, 156);
            this.txtThuongPhat.Name = "txtThuongPhat";
            this.txtThuongPhat.Size = new System.Drawing.Size(417, 30);
            this.txtThuongPhat.TabIndex = 17;
            // 
            // lblTP
            // 
            this.lblTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTP.AutoSize = true;
            this.lblTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTP.Location = new System.Drawing.Point(19, 161);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(126, 25);
            this.lblTP.TabIndex = 15;
            this.lblTP.Text = "Thưởng/Phạt";
            // 
            // pnlNgayNghi
            // 
            this.pnlNgayNghi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlNgayNghi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNgayNghi.Controls.Add(this.lvwNgayNghi);
            this.pnlNgayNghi.Controls.Add(this.lblNgayNghi);
            this.pnlNgayNghi.Location = new System.Drawing.Point(788, 367);
            this.pnlNgayNghi.Name = "pnlNgayNghi";
            this.pnlNgayNghi.Size = new System.Drawing.Size(519, 299);
            this.pnlNgayNghi.TabIndex = 13;
            // 
            // lvwNgayNghi
            // 
            this.lvwNgayNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwNgayNghi.HideSelection = false;
            this.lvwNgayNghi.Location = new System.Drawing.Point(13, 53);
            this.lvwNgayNghi.Name = "lvwNgayNghi";
            this.lvwNgayNghi.Size = new System.Drawing.Size(488, 217);
            this.lvwNgayNghi.TabIndex = 1;
            this.lvwNgayNghi.UseCompatibleStateImageBehavior = false;
            // 
            // lblNgayNghi
            // 
            this.lblNgayNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNgayNghi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNgayNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNghi.Location = new System.Drawing.Point(0, 0);
            this.lblNgayNghi.Name = "lblNgayNghi";
            this.lblNgayNghi.Size = new System.Drawing.Size(515, 37);
            this.lblNgayNghi.TabIndex = 0;
            this.lblNgayNghi.Text = "Chi tiết ngày nghỉ";
            this.lblNgayNghi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCongViec
            // 
            this.pnlCongViec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCongViec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCongViec.Controls.Add(this.lvwCongViec);
            this.pnlCongViec.Controls.Add(this.lblCongViec);
            this.pnlCongViec.Location = new System.Drawing.Point(788, 59);
            this.pnlCongViec.Name = "pnlCongViec";
            this.pnlCongViec.Size = new System.Drawing.Size(521, 274);
            this.pnlCongViec.TabIndex = 12;
            // 
            // lvwCongViec
            // 
            this.lvwCongViec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvwCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwCongViec.HideSelection = false;
            this.lvwCongViec.Location = new System.Drawing.Point(20, 53);
            this.lvwCongViec.Name = "lvwCongViec";
            this.lvwCongViec.Size = new System.Drawing.Size(481, 197);
            this.lvwCongViec.TabIndex = 1;
            this.lvwCongViec.UseCompatibleStateImageBehavior = false;
            // 
            // lblCongViec
            // 
            this.lblCongViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCongViec.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongViec.Location = new System.Drawing.Point(0, 0);
            this.lblCongViec.Name = "lblCongViec";
            this.lblCongViec.Size = new System.Drawing.Size(517, 37);
            this.lblCongViec.TabIndex = 0;
            this.lblCongViec.Text = "Chi tiết công việc";
            this.lblCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDSNV
            // 
            this.pnlDSNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDSNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDSNV.Controls.Add(this.lvwDSNV);
            this.pnlDSNV.Controls.Add(this.lblDSNV);
            this.pnlDSNV.Location = new System.Drawing.Point(28, 59);
            this.pnlDSNV.Name = "pnlDSNV";
            this.pnlDSNV.Size = new System.Drawing.Size(700, 274);
            this.pnlDSNV.TabIndex = 11;
            // 
            // lvwDSNV
            // 
            this.lvwDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDSNV.HideSelection = false;
            this.lvwDSNV.Location = new System.Drawing.Point(13, 53);
            this.lvwDSNV.Name = "lvwDSNV";
            this.lvwDSNV.Size = new System.Drawing.Size(672, 200);
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
            this.lblDSNV.Size = new System.Drawing.Size(696, 37);
            this.lblDSNV.TabIndex = 0;
            this.lblDSNV.Text = "Danh sách nhân viên hành chánh";
            this.lblDSNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtThuongPhat);
            this.groupBox1.Controls.Add(this.lblTP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 233);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật lương";
            // 
            // frmTinhLuongHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1336, 994);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.pnlLuong);
            this.Controls.Add(this.pnlNgayNghi);
            this.Controls.Add(this.pnlCongViec);
            this.Controls.Add(this.pnlDSNV);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTinhLuongHC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTinhLuongHC";
            this.Load += new System.EventHandler(this.frmTinhLuongHC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.pnlLuong.ResumeLayout(false);
            this.pnlNgayNghi.ResumeLayout(false);
            this.pnlCongViec.ResumeLayout(false);
            this.pnlDSNV.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private FontAwesome.Sharp.IconButton btnTim;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private FontAwesome.Sharp.IconButton btnTinh;
        private System.Windows.Forms.Panel pnlLuong;
        private System.Windows.Forms.ListView lvwDSLuong;
        private System.Windows.Forms.Label lblDSLuong;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThuongPhat;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Panel pnlNgayNghi;
        private System.Windows.Forms.ListView lvwNgayNghi;
        private System.Windows.Forms.Label lblNgayNghi;
        private System.Windows.Forms.Panel pnlCongViec;
        private System.Windows.Forms.ListView lvwCongViec;
        private System.Windows.Forms.Label lblCongViec;
        private System.Windows.Forms.Panel pnlDSNV;
        private System.Windows.Forms.ListView lvwDSNV;
        private System.Windows.Forms.Label lblDSNV;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}