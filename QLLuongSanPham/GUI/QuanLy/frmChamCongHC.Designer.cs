
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
            this.txtTenSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlSP = new System.Windows.Forms.Panel();
            this.lstvSanPham = new System.Windows.Forms.ListView();
            this.lblDSSP = new System.Windows.Forms.Label();
            this.pnlCa = new System.Windows.Forms.Panel();
            this.lstvCongDoan = new System.Windows.Forms.ListView();
            this.lblList = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTinhLuong = new FontAwesome.Sharp.IconButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlSP.SuspendLayout();
            this.pnlCa.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenSearch
            // 
            this.txtTenSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSearch.Location = new System.Drawing.Point(209, 24);
            this.txtTenSearch.Name = "txtTenSearch";
            this.txtTenSearch.Size = new System.Drawing.Size(274, 30);
            this.txtTenSearch.TabIndex = 50;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(56, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 25);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "Tên nhân viên";
            // 
            // pnlSP
            // 
            this.pnlSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSP.BackColor = System.Drawing.Color.Transparent;
            this.pnlSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSP.Controls.Add(this.lstvSanPham);
            this.pnlSP.Controls.Add(this.lblDSSP);
            this.pnlSP.Location = new System.Drawing.Point(54, 82);
            this.pnlSP.Name = "pnlSP";
            this.pnlSP.Size = new System.Drawing.Size(429, 395);
            this.pnlSP.TabIndex = 48;
            // 
            // lstvSanPham
            // 
            this.lstvSanPham.HideSelection = false;
            this.lstvSanPham.Location = new System.Drawing.Point(16, 46);
            this.lstvSanPham.Name = "lstvSanPham";
            this.lstvSanPham.Size = new System.Drawing.Size(397, 332);
            this.lstvSanPham.TabIndex = 1;
            this.lstvSanPham.UseCompatibleStateImageBehavior = false;
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
            this.pnlCa.Controls.Add(this.lstvCongDoan);
            this.pnlCa.Controls.Add(this.lblList);
            this.pnlCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlCa.Location = new System.Drawing.Point(54, 511);
            this.pnlCa.Name = "pnlCa";
            this.pnlCa.Size = new System.Drawing.Size(1161, 250);
            this.pnlCa.TabIndex = 47;
            // 
            // lstvCongDoan
            // 
            this.lstvCongDoan.HideSelection = false;
            this.lstvCongDoan.Location = new System.Drawing.Point(16, 55);
            this.lstvCongDoan.Name = "lstvCongDoan";
            this.lstvCongDoan.Size = new System.Drawing.Size(1138, 188);
            this.lstvCongDoan.TabIndex = 1;
            this.lstvCongDoan.UseCompatibleStateImageBehavior = false;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(845, 216);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(368, 30);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(845, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(371, 30);
            this.textBox2.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(631, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Ngày làm";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(631, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(631, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nghỉ phép";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(631, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Có mặt";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnTinhLuong.IconColor = System.Drawing.Color.Green;
            this.btnTinhLuong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTinhLuong.IconSize = 22;
            this.btnTinhLuong.Location = new System.Drawing.Point(1075, 434);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(138, 43);
            this.btnTinhLuong.TabIndex = 57;
            this.btnTinhLuong.Text = "Chấm công";
            this.btnTinhLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(845, 349);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 29);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Có";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(845, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 33);
            this.comboBox1.TabIndex = 59;
            // 
            // frmChamCongHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 785);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlSP);
            this.Controls.Add(this.pnlCa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamCongHC";
            this.Text = "frmChamCongHC";
            this.pnlSP.ResumeLayout(false);
            this.pnlCa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlSP;
        private System.Windows.Forms.ListView lstvSanPham;
        private System.Windows.Forms.Label lblDSSP;
        private System.Windows.Forms.Panel pnlCa;
        private System.Windows.Forms.ListView lstvCongDoan;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnTinhLuong;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}