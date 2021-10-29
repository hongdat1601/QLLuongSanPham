
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmPhongBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lvwPhongBan = new System.Windows.Forms.ListView();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenQL = new System.Windows.Forms.TextBox();
            this.txtSLNV = new System.Windows.Forms.TextBox();
            this.txtNgayThanhLap = new System.Windows.Forms.TextBox();
            this.txtTenPhongBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1513, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng Ban";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txtPos);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.lvwPhongBan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(799, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 403);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng ban";
            // 
            // txtPos
            // 
            this.txtPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPos.Location = new System.Drawing.Point(277, 328);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(149, 38);
            this.txtPos.TabIndex = 14;
            this.txtPos.Text = "0";
            this.txtPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(432, 325);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(129, 45);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(142, 325);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(129, 45);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(7, 325);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(129, 45);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLast.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(567, 325);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(129, 45);
            this.btnLast.TabIndex = 8;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lvwPhongBan
            // 
            this.lvwPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwPhongBan.HideSelection = false;
            this.lvwPhongBan.Location = new System.Drawing.Point(7, 29);
            this.lvwPhongBan.MultiSelect = false;
            this.lvwPhongBan.Name = "lvwPhongBan";
            this.lvwPhongBan.Size = new System.Drawing.Size(689, 286);
            this.lvwPhongBan.TabIndex = 0;
            this.lvwPhongBan.UseCompatibleStateImageBehavior = false;
            this.lvwPhongBan.SelectedIndexChanged += new System.EventHandler(this.lvwPhongBan_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.White;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 24;
            this.btnTimKiem.Location = new System.Drawing.Point(1427, 161);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(74, 45);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenQL);
            this.groupBox2.Controls.Add(this.txtSLNV);
            this.groupBox2.Controls.Add(this.txtNgayThanhLap);
            this.groupBox2.Controls.Add(this.txtTenPhongBan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 370);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng ban";
            // 
            // txtTenQL
            // 
            this.txtTenQL.Enabled = false;
            this.txtTenQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenQL.Location = new System.Drawing.Point(247, 270);
            this.txtTenQL.Name = "txtTenQL";
            this.txtTenQL.Size = new System.Drawing.Size(448, 38);
            this.txtTenQL.TabIndex = 13;
            // 
            // txtSLNV
            // 
            this.txtSLNV.Enabled = false;
            this.txtSLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLNV.Location = new System.Drawing.Point(247, 202);
            this.txtSLNV.Name = "txtSLNV";
            this.txtSLNV.Size = new System.Drawing.Size(448, 38);
            this.txtSLNV.TabIndex = 12;
            // 
            // txtNgayThanhLap
            // 
            this.txtNgayThanhLap.Enabled = false;
            this.txtNgayThanhLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayThanhLap.Location = new System.Drawing.Point(247, 134);
            this.txtNgayThanhLap.Name = "txtNgayThanhLap";
            this.txtNgayThanhLap.Size = new System.Drawing.Size(448, 38);
            this.txtNgayThanhLap.TabIndex = 11;
            // 
            // txtTenPhongBan
            // 
            this.txtTenPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhongBan.Location = new System.Drawing.Point(247, 62);
            this.txtTenPhongBan.Name = "txtTenPhongBan";
            this.txtTenPhongBan.Size = new System.Drawing.Size(448, 38);
            this.txtTenPhongBan.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số Lượng Nhân Viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày Thành Lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Quản Lý:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Phòng Ban:";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(484, 606);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 45);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(349, 606);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 45);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LimeGreen;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(619, 606);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 45);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(799, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(613, 38);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Tim kiem";
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 696);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhongBan";
            this.Text = "frmQLPhongBan";
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListView lvwPhongBan;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenQL;
        private System.Windows.Forms.TextBox txtSLNV;
        private System.Windows.Forms.TextBox txtNgayThanhLap;
        private System.Windows.Forms.TextBox txtTenPhongBan;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.TextBox textBox1;
    }
}