
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
            this.chkDiemDanh = new System.Windows.Forms.CheckBox();
            this.btnChamCong = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCa = new System.Windows.Forms.Panel();
            this.lstvLich = new System.Windows.Forms.ListView();
            this.lblList = new System.Windows.Forms.Label();
            this.gbxTT = new System.Windows.Forms.GroupBox();
            this.cboPhep = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
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
            // chkDiemDanh
            // 
            this.chkDiemDanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkDiemDanh.AutoSize = true;
            this.chkDiemDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiemDanh.Location = new System.Drawing.Point(238, 269);
            this.chkDiemDanh.Name = "chkDiemDanh";
            this.chkDiemDanh.Size = new System.Drawing.Size(62, 29);
            this.chkDiemDanh.TabIndex = 71;
            this.chkDiemDanh.Text = "Có";
            this.chkDiemDanh.UseVisualStyleBackColor = true;
            // 
            // btnChamCong
            // 
            this.btnChamCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnChamCong.IconColor = System.Drawing.Color.Green;
            this.btnChamCong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChamCong.IconSize = 22;
            this.btnChamCong.Location = new System.Drawing.Point(469, 310);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(138, 43);
            this.btnChamCong.TabIndex = 70;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(21, 271);
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
            this.label1.Location = new System.Drawing.Point(21, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nghỉ phép";
            // 
            // dtmDate
            // 
            this.dtmDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtmDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDate.Location = new System.Drawing.Point(846, 475);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(368, 30);
            this.dtmDate.TabIndex = 67;
            this.dtmDate.ValueChanged += new System.EventHandler(this.dtmDate_ValueChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenNV.Location = new System.Drawing.Point(238, 138);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(371, 30);
            this.txtTenNV.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(21, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tên nhân viên";
            // 
            // pnlCa
            // 
            this.pnlCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCa.BackColor = System.Drawing.Color.Transparent;
            this.pnlCa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCa.Controls.Add(this.lstvLich);
            this.pnlCa.Controls.Add(this.lblList);
            this.pnlCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlCa.Location = new System.Drawing.Point(53, 511);
            this.pnlCa.Name = "pnlCa";
            this.pnlCa.Size = new System.Drawing.Size(1161, 250);
            this.pnlCa.TabIndex = 60;
            // 
            // lstvLich
            // 
            this.lstvLich.HideSelection = false;
            this.lstvLich.Location = new System.Drawing.Point(16, 55);
            this.lstvLich.MultiSelect = false;
            this.lstvLich.Name = "lstvLich";
            this.lstvLich.Size = new System.Drawing.Size(1125, 173);
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
            this.lblList.Size = new System.Drawing.Size(1157, 41);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "Danh sách lịch làm việc";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxTT
            // 
            this.gbxTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxTT.Controls.Add(this.cboPhep);
            this.gbxTT.Controls.Add(this.chkDiemDanh);
            this.gbxTT.Controls.Add(this.btnChamCong);
            this.gbxTT.Controls.Add(this.label4);
            this.gbxTT.Controls.Add(this.label1);
            this.gbxTT.Controls.Add(this.txtMaNV);
            this.gbxTT.Controls.Add(this.txtTenNV);
            this.gbxTT.Controls.Add(this.label5);
            this.gbxTT.Controls.Add(this.label3);
            this.gbxTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTT.Location = new System.Drawing.Point(298, 58);
            this.gbxTT.Name = "gbxTT";
            this.gbxTT.Size = new System.Drawing.Size(645, 376);
            this.gbxTT.TabIndex = 73;
            this.gbxTT.TabStop = false;
            this.gbxTT.Text = "Thông tin chấm công";
            // 
            // cboPhep
            // 
            this.cboPhep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPhep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhep.FormattingEnabled = true;
            this.cboPhep.Items.AddRange(new object[] {
            "Không"});
            this.cboPhep.Location = new System.Drawing.Point(238, 202);
            this.cboPhep.Name = "cboPhep";
            this.cboPhep.Size = new System.Drawing.Size(368, 33);
            this.cboPhep.TabIndex = 72;
            this.cboPhep.Text = "Không";
            this.cboPhep.SelectedIndexChanged += new System.EventHandler(this.cboPhep_SelectedIndexChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaNV.Location = new System.Drawing.Point(238, 73);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(371, 30);
            this.txtMaNV.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(21, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "Mã nhân viên";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(731, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Ngày Làm";
            // 
            // frmChamCongHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1268, 785);
            this.Controls.Add(this.gbxTT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtmDate);
            this.Controls.Add(this.pnlCa);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamCongHC";
            this.Text = "frmChamCongHC";
            this.Load += new System.EventHandler(this.frmChamCongHC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.pnlCa.ResumeLayout(false);
            this.gbxTT.ResumeLayout(false);
            this.gbxTT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private System.Windows.Forms.CheckBox chkDiemDanh;
        private FontAwesome.Sharp.IconButton btnChamCong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCa;
        private System.Windows.Forms.ListView lstvLich;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.GroupBox gbxTT;
        private System.Windows.Forms.ComboBox cboPhep;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}