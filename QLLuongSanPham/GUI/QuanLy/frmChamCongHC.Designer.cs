
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxTT = new System.Windows.Forms.GroupBox();
            this.nudPhuCap = new System.Windows.Forms.NumericUpDown();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.cboPhep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHV = new System.Windows.Forms.Panel();
            this.lblDS = new System.Windows.Forms.Label();
            this.lstvNhanVien = new System.Windows.Forms.ListView();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lstvNgayNghi = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.gbxTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhuCap)).BeginInit();
            this.txtHV.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(1459, 885);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 0;
            this.picNen.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(60, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Loại phép";
            // 
            // dtmDate
            // 
            this.dtmDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtmDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDate.Location = new System.Drawing.Point(273, 146);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(368, 30);
            this.dtmDate.TabIndex = 67;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenNV.Location = new System.Drawing.Point(273, 93);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(371, 30);
            this.txtTenNV.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(60, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tên nhân viên";
            // 
            // gbxTT
            // 
            this.gbxTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxTT.Controls.Add(this.nudPhuCap);
            this.gbxTT.Controls.Add(this.btnXoa);
            this.gbxTT.Controls.Add(this.btnSua);
            this.gbxTT.Controls.Add(this.btnThem);
            this.gbxTT.Controls.Add(this.cboPhep);
            this.gbxTT.Controls.Add(this.dtmDate);
            this.gbxTT.Controls.Add(this.label7);
            this.gbxTT.Controls.Add(this.label1);
            this.gbxTT.Controls.Add(this.txtCMND);
            this.gbxTT.Controls.Add(this.txtTenNV);
            this.gbxTT.Controls.Add(this.label5);
            this.gbxTT.Controls.Add(this.label4);
            this.gbxTT.Controls.Add(this.label3);
            this.gbxTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTT.Location = new System.Drawing.Point(717, 95);
            this.gbxTT.Name = "gbxTT";
            this.gbxTT.Size = new System.Drawing.Size(710, 376);
            this.gbxTT.TabIndex = 73;
            this.gbxTT.TabStop = false;
            this.gbxTT.Text = "Thông tin chấm công";
            // 
            // nudPhuCap
            // 
            this.nudPhuCap.Enabled = false;
            this.nudPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPhuCap.Location = new System.Drawing.Point(273, 250);
            this.nudPhuCap.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPhuCap.Name = "nudPhuCap";
            this.nudPhuCap.Size = new System.Drawing.Size(368, 30);
            this.nudPhuCap.TabIndex = 76;
            this.nudPhuCap.ThousandsSeparator = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Red;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 25;
            this.btnXoa.Location = new System.Drawing.Point(526, 316);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 43);
            this.btnXoa.TabIndex = 75;
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
            this.btnSua.Location = new System.Drawing.Point(318, 316);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 43);
            this.btnSua.TabIndex = 74;
            this.btnSua.Text = "Sửa";
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
            this.btnThem.Location = new System.Drawing.Point(93, 316);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 43);
            this.btnThem.TabIndex = 73;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboPhep
            // 
            this.cboPhep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPhep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhep.FormattingEnabled = true;
            this.cboPhep.Location = new System.Drawing.Point(273, 198);
            this.cboPhep.Name = "cboPhep";
            this.cboPhep.Size = new System.Drawing.Size(368, 33);
            this.cboPhep.TabIndex = 72;
            this.cboPhep.SelectedIndexChanged += new System.EventHandler(this.cboPhep_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(60, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 69;
            this.label7.Text = "Phụ cấp";
            // 
            // txtCMND
            // 
            this.txtCMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCMND.Enabled = false;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCMND.Location = new System.Drawing.Point(273, 40);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(371, 30);
            this.txtCMND.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(60, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "CMND";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(60, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 65;
            this.label4.Text = "Ngày";
            // 
            // txtHV
            // 
            this.txtHV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtHV.Controls.Add(this.lblDS);
            this.txtHV.Controls.Add(this.lstvNhanVien);
            this.txtHV.Location = new System.Drawing.Point(22, 95);
            this.txtHV.Name = "txtHV";
            this.txtHV.Size = new System.Drawing.Size(594, 760);
            this.txtHV.TabIndex = 74;
            // 
            // lblDS
            // 
            this.lblDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDS.Location = new System.Drawing.Point(0, 0);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(590, 35);
            this.lblDS.TabIndex = 15;
            this.lblDS.Text = "Danh sách nhân viên";
            this.lblDS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstvNhanVien
            // 
            this.lstvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvNhanVien.HideSelection = false;
            this.lstvNhanVien.Location = new System.Drawing.Point(19, 54);
            this.lstvNhanVien.MultiSelect = false;
            this.lstvNhanVien.Name = "lstvNhanVien";
            this.lstvNhanVien.Size = new System.Drawing.Size(556, 688);
            this.lstvNhanVien.TabIndex = 0;
            this.lstvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lstvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lstvNhanVien_SelectedIndexChanged);
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSearch.ForeColor = System.Drawing.Color.White;
            this.lblNameSearch.Location = new System.Drawing.Point(17, 32);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(150, 25);
            this.lblNameSearch.TabIndex = 76;
            this.lblNameSearch.Text = "Tên nhân viên";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.Location = new System.Drawing.Point(208, 29);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(406, 30);
            this.txtNameSearch.TabIndex = 75;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.txtNameSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(719, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 76;
            this.label2.Text = "Phòng ban";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Items.AddRange(new object[] {
            "Tất cả"});
            this.cboPhongBan.Location = new System.Drawing.Point(937, 26);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(490, 33);
            this.cboPhongBan.TabIndex = 73;
            this.cboPhongBan.Text = "Tất cả";
            this.cboPhongBan.SelectedIndexChanged += new System.EventHandler(this.cboPhongBan_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lstvNgayNghi);
            this.panel1.Location = new System.Drawing.Point(710, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 326);
            this.panel1.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(713, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "Danh sách ngày nghỉ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstvNgayNghi
            // 
            this.lstvNgayNghi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvNgayNghi.HideSelection = false;
            this.lstvNgayNghi.Location = new System.Drawing.Point(19, 54);
            this.lstvNgayNghi.MultiSelect = false;
            this.lstvNgayNghi.Name = "lstvNgayNghi";
            this.lstvNgayNghi.Size = new System.Drawing.Size(679, 244);
            this.lstvNgayNghi.TabIndex = 0;
            this.lstvNgayNghi.UseCompatibleStateImageBehavior = false;
            this.lstvNgayNghi.SelectedIndexChanged += new System.EventHandler(this.lstvNgayNghi_SelectedIndexChanged);
            // 
            // frmChamCongHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1459, 885);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboPhongBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNameSearch);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.txtHV);
            this.Controls.Add(this.gbxTT);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamCongHC";
            this.Text = "frmChamCongHC";
            this.Load += new System.EventHandler(this.frmChamCongHC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.gbxTT.ResumeLayout(false);
            this.gbxTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhuCap)).EndInit();
            this.txtHV.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxTT;
        private System.Windows.Forms.ComboBox cboPhep;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel txtHV;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.ListView lstvNhanVien;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstvNgayNghi;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPhuCap;
        private System.Windows.Forms.Label label7;
    }
}