
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmChamCongCN
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
            this.pnlCa = new System.Windows.Forms.Panel();
            this.lstvLich = new System.Windows.Forms.ListView();
            this.lblList = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.dtmNgayLam = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnTinhLuong = new FontAwesome.Sharp.IconButton();
            this.cboTenCa = new System.Windows.Forms.ComboBox();
            this.txtCongDoan = new System.Windows.Forms.TextBox();
            this.pnlCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCa
            // 
            this.pnlCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCa.BackColor = System.Drawing.Color.Transparent;
            this.pnlCa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCa.Controls.Add(this.lstvLich);
            this.pnlCa.Controls.Add(this.lblList);
            this.pnlCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlCa.Location = new System.Drawing.Point(40, 552);
            this.pnlCa.Name = "pnlCa";
            this.pnlCa.Size = new System.Drawing.Size(1161, 250);
            this.pnlCa.TabIndex = 38;
            // 
            // lstvLich
            // 
            this.lstvLich.HideSelection = false;
            this.lstvLich.Location = new System.Drawing.Point(16, 55);
            this.lstvLich.Name = "lstvLich";
            this.lstvLich.Size = new System.Drawing.Size(1138, 188);
            this.lstvLich.TabIndex = 1;
            this.lstvLich.UseCompatibleStateImageBehavior = false;
            // 
            // lblList
            // 
            this.lblList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblList.Location = new System.Drawing.Point(0, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(1157, 41);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "Danh sách lịch làm việc";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTenSP.Location = new System.Drawing.Point(320, 278);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(144, 25);
            this.lblTenSP.TabIndex = 40;
            this.lblTenSP.Text = "Tên công đoạn";
            // 
            // dtmNgayLam
            // 
            this.dtmNgayLam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtmNgayLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayLam.Location = new System.Drawing.Point(534, 37);
            this.dtmNgayLam.Name = "dtmNgayLam";
            this.dtmNgayLam.Size = new System.Drawing.Size(368, 30);
            this.dtmNgayLam.TabIndex = 42;
            this.dtmNgayLam.ValueChanged += new System.EventHandler(this.dtmNgayLam_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(320, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tên Ca";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(320, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Ngày làm";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(320, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tên nhân viên";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenNhanVien.Location = new System.Drawing.Point(534, 216);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(371, 30);
            this.txtTenNhanVien.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(320, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Số lượng";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(538, 334);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(139, 30);
            this.nudSoLuong.TabIndex = 43;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnTinhLuong.IconColor = System.Drawing.Color.Green;
            this.btnTinhLuong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTinhLuong.IconSize = 22;
            this.btnTinhLuong.Location = new System.Drawing.Point(767, 396);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(138, 43);
            this.btnTinhLuong.TabIndex = 44;
            this.btnTinhLuong.Text = "Chấm công";
            this.btnTinhLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            // 
            // cboTenCa
            // 
            this.cboTenCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTenCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenCa.FormattingEnabled = true;
            this.cboTenCa.Location = new System.Drawing.Point(534, 92);
            this.cboTenCa.Name = "cboTenCa";
            this.cboTenCa.Size = new System.Drawing.Size(371, 33);
            this.cboTenCa.TabIndex = 45;
            this.cboTenCa.SelectedIndexChanged += new System.EventHandler(this.cboTenCa_SelectedIndexChanged);
            // 
            // txtCongDoan
            // 
            this.txtCongDoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCongDoan.Enabled = false;
            this.txtCongDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCongDoan.Location = new System.Drawing.Point(534, 275);
            this.txtCongDoan.Name = "txtCongDoan";
            this.txtCongDoan.Size = new System.Drawing.Size(371, 30);
            this.txtCongDoan.TabIndex = 41;
            // 
            // frmChamCongCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 826);
            this.Controls.Add(this.cboTenCa);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.dtmNgayLam);
            this.Controls.Add(this.txtCongDoan);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.pnlCa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamCongCN";
            this.Text = "frmChamCongHC";
            this.Load += new System.EventHandler(this.frmChamCongCN_Load);
            this.pnlCa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlCa;
        private System.Windows.Forms.ListView lstvLich;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.DateTimePicker dtmNgayLam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private FontAwesome.Sharp.IconButton btnTinhLuong;
        private System.Windows.Forms.ComboBox cboTenCa;
        private System.Windows.Forms.TextBox txtCongDoan;
    }
}