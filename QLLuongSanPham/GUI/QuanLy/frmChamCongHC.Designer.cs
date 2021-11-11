
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmChamCongHC
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
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.btnTinhLuong = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlSP = new System.Windows.Forms.Panel();
            this.lvwDSNV = new System.Windows.Forms.ListView();
            this.lblDSSP = new System.Windows.Forms.Label();
            this.pnlCa = new System.Windows.Forms.Panel();
            this.lvwDSLich = new System.Windows.Forms.ListView();
            this.lblList = new System.Windows.Forms.Label();
            this.gbxTT = new System.Windows.Forms.GroupBox();
            this.cboPhep = new System.Windows.Forms.ComboBox();
            this.btnTimKimSP = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.pnlSP.SuspendLayout();
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
            this.picNen.Size = new System.Drawing.Size(1268, 785);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 0;
            this.picNen.TabStop = false;
            // 
            // chkYes
            // 
            this.chkYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkYes.AutoSize = true;
            this.chkYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYes.Location = new System.Drawing.Point(247, 275);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(60, 29);
            this.chkYes.TabIndex = 71;
            this.chkYes.Text = "Có";
            this.chkYes.UseVisualStyleBackColor = true;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnTinhLuong.IconColor = System.Drawing.Color.Green;
            this.btnTinhLuong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTinhLuong.IconSize = 22;
            this.btnTinhLuong.Location = new System.Drawing.Point(466, 316);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(138, 43);
            this.btnTinhLuong.TabIndex = 70;
            this.btnTinhLuong.Text = "Chấm công";
            this.btnTinhLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(19, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 68;
            this.label4.Text = "Có mặt";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(19, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nghỉ phép";
            // 
            // dtmDate
            // 
            this.dtmDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtmDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDate.Location = new System.Drawing.Point(236, 114);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(368, 30);
            this.dtmDate.TabIndex = 67;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenNV.Location = new System.Drawing.Point(233, 41);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(371, 30);
            this.txtTenNV.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(19, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Ngày làm";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(19, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tên nhân viên";
            // 
            // txtTenSearch
            // 
            this.txtTenSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSearch.Location = new System.Drawing.Point(196, 22);
            this.txtTenSearch.Name = "txtTenSearch";
            this.txtTenSearch.Size = new System.Drawing.Size(208, 30);
            this.txtTenSearch.TabIndex = 63;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(55, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 20);
            this.lblName.TabIndex = 62;
            this.lblName.Text = "Tên nhân viên";
            // 
            // pnlSP
            // 
            this.pnlSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSP.BackColor = System.Drawing.Color.Transparent;
            this.pnlSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSP.Controls.Add(this.lvwDSNV);
            this.pnlSP.Controls.Add(this.lblDSSP);
            this.pnlSP.Location = new System.Drawing.Point(53, 82);
            this.pnlSP.Name = "pnlSP";
            this.pnlSP.Size = new System.Drawing.Size(429, 395);
            this.pnlSP.TabIndex = 61;
            // 
            // lvwDSNV
            // 
            this.lvwDSNV.BackColor = System.Drawing.Color.White;
            this.lvwDSNV.HideSelection = false;
            this.lvwDSNV.Location = new System.Drawing.Point(16, 48);
            this.lvwDSNV.Name = "lvwDSNV";
            this.lvwDSNV.Size = new System.Drawing.Size(396, 330);
            this.lvwDSNV.TabIndex = 1;
            this.lvwDSNV.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSSP
            // 
            this.lblDSSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDSSP.Location = new System.Drawing.Point(0, 0);
            this.lblDSSP.Name = "lblDSSP";
            this.lblDSSP.Size = new System.Drawing.Size(425, 32);
            this.lblDSSP.TabIndex = 0;
            this.lblDSSP.Text = "Danh sách nhân viên";
            // 
            // pnlCa
            // 
            this.pnlCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCa.BackColor = System.Drawing.Color.Transparent;
            this.pnlCa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCa.Controls.Add(this.lvwDSLich);
            this.pnlCa.Controls.Add(this.lblList);
            this.pnlCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlCa.Location = new System.Drawing.Point(53, 511);
            this.pnlCa.Name = "pnlCa";
            this.pnlCa.Size = new System.Drawing.Size(1161, 250);
            this.pnlCa.TabIndex = 60;
            // 
            // lvwDSLich
            // 
            this.lvwDSLich.HideSelection = false;
            this.lvwDSLich.Location = new System.Drawing.Point(16, 55);
            this.lvwDSLich.Name = "lvwDSLich";
            this.lvwDSLich.Size = new System.Drawing.Size(1125, 173);
            this.lvwDSLich.TabIndex = 1;
            this.lvwDSLich.UseCompatibleStateImageBehavior = false;
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
            // gbxTT
            // 
            this.gbxTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxTT.Controls.Add(this.cboPhep);
            this.gbxTT.Controls.Add(this.chkYes);
            this.gbxTT.Controls.Add(this.btnTinhLuong);
            this.gbxTT.Controls.Add(this.label4);
            this.gbxTT.Controls.Add(this.label1);
            this.gbxTT.Controls.Add(this.dtmDate);
            this.gbxTT.Controls.Add(this.txtTenNV);
            this.gbxTT.Controls.Add(this.label2);
            this.gbxTT.Controls.Add(this.label3);
            this.gbxTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTT.Location = new System.Drawing.Point(569, 103);
            this.gbxTT.Name = "gbxTT";
            this.gbxTT.Size = new System.Drawing.Size(645, 374);
            this.gbxTT.TabIndex = 73;
            this.gbxTT.TabStop = false;
            this.gbxTT.Text = "Thông tin chấm công";
            // 
            // cboPhep
            // 
            this.cboPhep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPhep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhep.FormattingEnabled = true;
            this.cboPhep.Location = new System.Drawing.Point(236, 189);
            this.cboPhep.Name = "cboPhep";
            this.cboPhep.Size = new System.Drawing.Size(368, 33);
            this.cboPhep.TabIndex = 72;
            // 
            // btnTimKimSP
            // 
            this.btnTimKimSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKimSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKimSP.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKimSP.IconColor = System.Drawing.Color.Blue;
            this.btnTimKimSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKimSP.IconSize = 25;
            this.btnTimKimSP.Location = new System.Drawing.Point(420, 22);
            this.btnTimKimSP.Name = "btnTimKimSP";
            this.btnTimKimSP.Size = new System.Drawing.Size(62, 30);
            this.btnTimKimSP.TabIndex = 74;
            this.btnTimKimSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKimSP.UseVisualStyleBackColor = true;
            this.btnTimKimSP.Click += new System.EventHandler(this.btnTimKimSP_Click);
            // 
            // frmChamCongHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1268, 785);
            this.Controls.Add(this.btnTimKimSP);
            this.Controls.Add(this.gbxTT);
            this.Controls.Add(this.txtTenSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlSP);
            this.Controls.Add(this.pnlCa);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamCongHC";
            this.Text = "frmChamCongHC";
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.pnlSP.ResumeLayout(false);
            this.pnlCa.ResumeLayout(false);
            this.gbxTT.ResumeLayout(false);
            this.gbxTT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private System.Windows.Forms.CheckBox chkYes;
        private FontAwesome.Sharp.IconButton btnTinhLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlSP;
        private System.Windows.Forms.Label lblDSSP;
        private System.Windows.Forms.Panel pnlCa;
        private System.Windows.Forms.ListView lvwDSLich;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.GroupBox gbxTT;
        private FontAwesome.Sharp.IconButton btnTimKimSP;
        private System.Windows.Forms.ComboBox cboPhep;
        private System.Windows.Forms.ListView lvwDSNV;
    }
}