
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
            this.picNen = new System.Windows.Forms.PictureBox();
            this.btnChamCong = new FontAwesome.Sharp.IconButton();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.dtmNgayLam = new System.Windows.Forms.DateTimePicker();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTenCongDoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.pnlCa = new System.Windows.Forms.Panel();
            this.lstvLich = new System.Windows.Forms.ListView();
            this.lblList = new System.Windows.Forms.Label();
            this.gbxTT = new System.Windows.Forms.GroupBox();
            this.chkCoMat = new System.Windows.Forms.CheckBox();
            this.cboTenCa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.pnlCa.SuspendLayout();
            this.gbxTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(1478, 869);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 0;
            this.picNen.TabStop = false;
            // 
            // btnChamCong
            // 
            this.btnChamCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnChamCong.IconColor = System.Drawing.Color.Green;
            this.btnChamCong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChamCong.IconSize = 22;
            this.btnChamCong.Location = new System.Drawing.Point(822, 346);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(138, 43);
            this.btnChamCong.TabIndex = 59;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudSoLuong.Enabled = false;
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(525, 359);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(139, 30);
            this.nudSoLuong.TabIndex = 58;
            // 
            // dtmNgayLam
            // 
            this.dtmNgayLam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtmNgayLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmNgayLam.Location = new System.Drawing.Point(525, 38);
            this.dtmNgayLam.Name = "dtmNgayLam";
            this.dtmNgayLam.Size = new System.Drawing.Size(435, 30);
            this.dtmNgayLam.TabIndex = 57;
            this.dtmNgayLam.ValueChanged += new System.EventHandler(this.dtmNgayLam_ValueChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenNV.Location = new System.Drawing.Point(525, 176);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(435, 30);
            this.txtTenNV.TabIndex = 55;
            // 
            // txtTenCongDoan
            // 
            this.txtTenCongDoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenCongDoan.Enabled = false;
            this.txtTenCongDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenCongDoan.Location = new System.Drawing.Point(525, 232);
            this.txtTenCongDoan.Name = "txtTenCongDoan";
            this.txtTenCongDoan.Size = new System.Drawing.Size(435, 30);
            this.txtTenCongDoan.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(192, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Ngày làm";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(192, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ca";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(192, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(192, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Số lượng";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTenSP.Location = new System.Drawing.Point(192, 237);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(144, 25);
            this.lblTenSP.TabIndex = 53;
            this.lblTenSP.Text = "Tên công đoạn";
            // 
            // pnlCa
            // 
            this.pnlCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCa.BackColor = System.Drawing.Color.Transparent;
            this.pnlCa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCa.Controls.Add(this.lstvLich);
            this.pnlCa.Controls.Add(this.lblList);
            this.pnlCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlCa.Location = new System.Drawing.Point(95, 553);
            this.pnlCa.Name = "pnlCa";
            this.pnlCa.Size = new System.Drawing.Size(1327, 304);
            this.pnlCa.TabIndex = 47;
            // 
            // lstvLich
            // 
            this.lstvLich.HideSelection = false;
            this.lstvLich.Location = new System.Drawing.Point(15, 55);
            this.lstvLich.Name = "lstvLich";
            this.lstvLich.Size = new System.Drawing.Size(1285, 233);
            this.lstvLich.TabIndex = 1;
            this.lstvLich.UseCompatibleStateImageBehavior = false;
            this.lstvLich.SelectedIndexChanged += new System.EventHandler(this.lstvLich_SelectedIndexChanged);
            // 
            // lblList
            // 
            this.lblList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblList.Location = new System.Drawing.Point(0, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(1323, 41);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "Danh sách lịch làm việc";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxTT
            // 
            this.gbxTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxTT.Controls.Add(this.chkCoMat);
            this.gbxTT.Controls.Add(this.cboTenCa);
            this.gbxTT.Controls.Add(this.btnChamCong);
            this.gbxTT.Controls.Add(this.nudSoLuong);
            this.gbxTT.Controls.Add(this.dtmNgayLam);
            this.gbxTT.Controls.Add(this.txtTenNV);
            this.gbxTT.Controls.Add(this.txtTenCongDoan);
            this.gbxTT.Controls.Add(this.label2);
            this.gbxTT.Controls.Add(this.label1);
            this.gbxTT.Controls.Add(this.label3);
            this.gbxTT.Controls.Add(this.label4);
            this.gbxTT.Controls.Add(this.label5);
            this.gbxTT.Controls.Add(this.lblTenSP);
            this.gbxTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTT.Location = new System.Drawing.Point(95, 37);
            this.gbxTT.Name = "gbxTT";
            this.gbxTT.Size = new System.Drawing.Size(1327, 423);
            this.gbxTT.TabIndex = 62;
            this.gbxTT.TabStop = false;
            this.gbxTT.Text = "Thông tin chấm công";
            // 
            // chkCoMat
            // 
            this.chkCoMat.AutoSize = true;
            this.chkCoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCoMat.Location = new System.Drawing.Point(525, 295);
            this.chkCoMat.Name = "chkCoMat";
            this.chkCoMat.Size = new System.Drawing.Size(62, 29);
            this.chkCoMat.TabIndex = 61;
            this.chkCoMat.Text = "Có";
            this.chkCoMat.UseVisualStyleBackColor = true;
            this.chkCoMat.CheckedChanged += new System.EventHandler(this.chkCoMat_CheckedChanged);
            // 
            // cboTenCa
            // 
            this.cboTenCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenCa.FormattingEnabled = true;
            this.cboTenCa.Location = new System.Drawing.Point(525, 101);
            this.cboTenCa.Name = "cboTenCa";
            this.cboTenCa.Size = new System.Drawing.Size(435, 33);
            this.cboTenCa.TabIndex = 60;
            this.cboTenCa.SelectedIndexChanged += new System.EventHandler(this.cboTenCa_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(192, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Có mặt";
            // 
            // frmChamCongCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1478, 869);
            this.Controls.Add(this.gbxTT);
            this.Controls.Add(this.pnlCa);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamCongCN";
            this.Text = "frmChamCongHC";
            this.Load += new System.EventHandler(this.frmChamCongCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.pnlCa.ResumeLayout(false);
            this.gbxTT.ResumeLayout(false);
            this.gbxTT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private FontAwesome.Sharp.IconButton btnChamCong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.DateTimePicker dtmNgayLam;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTenCongDoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Panel pnlCa;
        private System.Windows.Forms.ListView lstvLich;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.GroupBox gbxTT;
        private System.Windows.Forms.ComboBox cboTenCa;
        private System.Windows.Forms.CheckBox chkCoMat;
        private System.Windows.Forms.Label label5;
    }
}