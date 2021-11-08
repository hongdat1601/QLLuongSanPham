
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
            this.pnlSP = new System.Windows.Forms.Panel();
            this.lstvSanPham = new System.Windows.Forms.ListView();
            this.lblDSSP = new System.Windows.Forms.Label();
            this.pnlCa = new System.Windows.Forms.Panel();
            this.lstvCongDoan = new System.Windows.Forms.ListView();
            this.lblList = new System.Windows.Forms.Label();
            this.txtTenSPCapNhat = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnTinhLuong = new FontAwesome.Sharp.IconButton();
            this.txtTenSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlSP.SuspendLayout();
            this.pnlCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSP
            // 
            this.pnlSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSP.BackColor = System.Drawing.Color.Transparent;
            this.pnlSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSP.Controls.Add(this.lstvSanPham);
            this.pnlSP.Controls.Add(this.lblDSSP);
            this.pnlSP.Location = new System.Drawing.Point(40, 123);
            this.pnlSP.Name = "pnlSP";
            this.pnlSP.Size = new System.Drawing.Size(429, 395);
            this.pnlSP.TabIndex = 39;
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
            this.pnlCa.Location = new System.Drawing.Point(40, 552);
            this.pnlCa.Name = "pnlCa";
            this.pnlCa.Size = new System.Drawing.Size(1161, 250);
            this.pnlCa.TabIndex = 38;
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
            // txtTenSPCapNhat
            // 
            this.txtTenSPCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSPCapNhat.Enabled = false;
            this.txtTenSPCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSPCapNhat.Location = new System.Drawing.Point(831, 344);
            this.txtTenSPCapNhat.Name = "txtTenSPCapNhat";
            this.txtTenSPCapNhat.Size = new System.Drawing.Size(371, 30);
            this.txtTenSPCapNhat.TabIndex = 41;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTenSP.Location = new System.Drawing.Point(617, 347);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(144, 25);
            this.lblTenSP.TabIndex = 40;
            this.lblTenSP.Text = "Tên công đoạn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(831, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(368, 30);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(617, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ca";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(831, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 30);
            this.textBox1.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(617, 229);
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
            this.label3.Location = new System.Drawing.Point(617, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tên nhân viên";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(831, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(371, 30);
            this.textBox2.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(617, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Số lượng";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(831, 403);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(139, 30);
            this.numericUpDown1.TabIndex = 43;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnTinhLuong.IconColor = System.Drawing.Color.Green;
            this.btnTinhLuong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTinhLuong.IconSize = 22;
            this.btnTinhLuong.Location = new System.Drawing.Point(1064, 475);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(138, 43);
            this.btnTinhLuong.TabIndex = 44;
            this.btnTinhLuong.Text = "Chấm công";
            this.btnTinhLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            // 
            // txtTenSearch
            // 
            this.txtTenSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSearch.Location = new System.Drawing.Point(195, 65);
            this.txtTenSearch.Name = "txtTenSearch";
            this.txtTenSearch.Size = new System.Drawing.Size(274, 30);
            this.txtTenSearch.TabIndex = 46;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(42, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 25);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Tên nhân viên";
            // 
            // frmChamCongCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 826);
            this.Controls.Add(this.txtTenSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTenSPCapNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.pnlSP);
            this.Controls.Add(this.pnlCa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamCongCN";
            this.Text = "frmChamCongHC";
            this.pnlSP.ResumeLayout(false);
            this.pnlCa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSP;
        private System.Windows.Forms.ListView lstvSanPham;
        private System.Windows.Forms.Label lblDSSP;
        private System.Windows.Forms.Panel pnlCa;
        private System.Windows.Forms.ListView lstvCongDoan;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.TextBox txtTenSPCapNhat;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private FontAwesome.Sharp.IconButton btnTinhLuong;
        private System.Windows.Forms.TextBox txtTenSearch;
        private System.Windows.Forms.Label lblName;
    }
}