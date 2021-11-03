
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmCongDoan
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
            this.lvwDSCa = new System.Windows.Forms.ListView();
            this.lblList = new System.Windows.Forms.Label();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnTimKimCa = new FontAwesome.Sharp.IconButton();
            this.txtDonGiaCapNhat = new System.Windows.Forms.TextBox();
            this.txtCongDoanCapNhat = new System.Windows.Forms.TextBox();
            this.lblDongia = new System.Windows.Forms.Label();
            this.lblTenCD = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSPCapNhat = new System.Windows.Forms.TextBox();
            this.pnlSP = new System.Windows.Forms.Panel();
            this.lvwDSSP = new System.Windows.Forms.ListView();
            this.lblDSSP = new System.Windows.Forms.Label();
            this.lblNameSP = new System.Windows.Forms.Label();
            this.txtTenSPTK = new System.Windows.Forms.TextBox();
            this.lblNameCD = new System.Windows.Forms.Label();
            this.txtCDTK = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDGTK = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnTimKimSP = new FontAwesome.Sharp.IconButton();
            this.pnlCa.SuspendLayout();
            this.pnlSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCa
            // 
            this.pnlCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCa.Controls.Add(this.lvwDSCa);
            this.pnlCa.Controls.Add(this.lblList);
            this.pnlCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlCa.Location = new System.Drawing.Point(10, 556);
            this.pnlCa.Name = "pnlCa";
            this.pnlCa.Size = new System.Drawing.Size(1104, 341);
            this.pnlCa.TabIndex = 19;
            // 
            // lvwDSCa
            // 
            this.lvwDSCa.HideSelection = false;
            this.lvwDSCa.Location = new System.Drawing.Point(16, 55);
            this.lvwDSCa.Name = "lvwDSCa";
            this.lvwDSCa.Size = new System.Drawing.Size(1068, 265);
            this.lvwDSCa.TabIndex = 1;
            this.lvwDSCa.UseCompatibleStateImageBehavior = false;
            // 
            // lblList
            // 
            this.lblList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblList.Location = new System.Drawing.Point(0, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(1100, 41);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "Danh sách công đoạn";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Red;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 25;
            this.btnXoa.Location = new System.Drawing.Point(1021, 404);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 43);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 25;
            this.btnSua.Location = new System.Drawing.Point(773, 404);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 43);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 25;
            this.btnThem.Location = new System.Drawing.Point(526, 404);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 43);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTimKimCa
            // 
            this.btnTimKimCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKimCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKimCa.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKimCa.IconColor = System.Drawing.Color.Blue;
            this.btnTimKimCa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKimCa.IconSize = 25;
            this.btnTimKimCa.Location = new System.Drawing.Point(989, 503);
            this.btnTimKimCa.Name = "btnTimKimCa";
            this.btnTimKimCa.Size = new System.Drawing.Size(127, 43);
            this.btnTimKimCa.TabIndex = 18;
            this.btnTimKimCa.Text = "Tìm kiếm";
            this.btnTimKimCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKimCa.UseVisualStyleBackColor = true;
            // 
            // txtDonGiaCapNhat
            // 
            this.txtDonGiaCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonGiaCapNhat.Enabled = false;
            this.txtDonGiaCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDonGiaCapNhat.Location = new System.Drawing.Point(743, 309);
            this.txtDonGiaCapNhat.Name = "txtDonGiaCapNhat";
            this.txtDonGiaCapNhat.Size = new System.Drawing.Size(373, 30);
            this.txtDonGiaCapNhat.TabIndex = 13;
            // 
            // txtCongDoanCapNhat
            // 
            this.txtCongDoanCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCongDoanCapNhat.Enabled = false;
            this.txtCongDoanCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCongDoanCapNhat.Location = new System.Drawing.Point(743, 186);
            this.txtCongDoanCapNhat.Name = "txtCongDoanCapNhat";
            this.txtCongDoanCapNhat.Size = new System.Drawing.Size(373, 30);
            this.txtCongDoanCapNhat.TabIndex = 12;
            // 
            // lblDongia
            // 
            this.lblDongia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDongia.AutoSize = true;
            this.lblDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDongia.Location = new System.Drawing.Point(521, 314);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(79, 25);
            this.lblDongia.TabIndex = 9;
            this.lblDongia.Text = "Đơn giá";
            // 
            // lblTenCD
            // 
            this.lblTenCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenCD.AutoSize = true;
            this.lblTenCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTenCD.Location = new System.Drawing.Point(520, 191);
            this.lblTenCD.Name = "lblTenCD";
            this.lblTenCD.Size = new System.Drawing.Size(144, 25);
            this.lblTenCD.TabIndex = 7;
            this.lblTenCD.Text = "Tên công đoạn";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTenSP.Location = new System.Drawing.Point(520, 78);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(138, 25);
            this.lblTenSP.TabIndex = 6;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // txtTenSPCapNhat
            // 
            this.txtTenSPCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSPCapNhat.Enabled = false;
            this.txtTenSPCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSPCapNhat.Location = new System.Drawing.Point(743, 75);
            this.txtTenSPCapNhat.Name = "txtTenSPCapNhat";
            this.txtTenSPCapNhat.Size = new System.Drawing.Size(371, 30);
            this.txtTenSPCapNhat.TabIndex = 12;
            // 
            // pnlSP
            // 
            this.pnlSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSP.Controls.Add(this.lvwDSSP);
            this.pnlSP.Controls.Add(this.lblDSSP);
            this.pnlSP.Location = new System.Drawing.Point(10, 69);
            this.pnlSP.Name = "pnlSP";
            this.pnlSP.Size = new System.Drawing.Size(429, 378);
            this.pnlSP.TabIndex = 20;
            // 
            // lvwDSSP
            // 
            this.lvwDSSP.HideSelection = false;
            this.lvwDSSP.Location = new System.Drawing.Point(17, 46);
            this.lvwDSSP.Name = "lvwDSSP";
            this.lvwDSSP.Size = new System.Drawing.Size(397, 316);
            this.lvwDSSP.TabIndex = 1;
            this.lvwDSSP.UseCompatibleStateImageBehavior = false;
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
            this.lblDSSP.Text = "Danh sách sản phẩm";
            // 
            // lblNameSP
            // 
            this.lblNameSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameSP.AutoSize = true;
            this.lblNameSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNameSP.Location = new System.Drawing.Point(7, 514);
            this.lblNameSP.Name = "lblNameSP";
            this.lblNameSP.Size = new System.Drawing.Size(115, 20);
            this.lblNameSP.TabIndex = 6;
            this.lblNameSP.Text = "Tên sản phẩm";
            // 
            // txtTenSPTK
            // 
            this.txtTenSPTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSPTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTenSPTK.Location = new System.Drawing.Point(138, 511);
            this.txtTenSPTK.Name = "txtTenSPTK";
            this.txtTenSPTK.Size = new System.Drawing.Size(191, 26);
            this.txtTenSPTK.TabIndex = 12;
            // 
            // lblNameCD
            // 
            this.lblNameCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameCD.AutoSize = true;
            this.lblNameCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNameCD.Location = new System.Drawing.Point(344, 514);
            this.lblNameCD.Name = "lblNameCD";
            this.lblNameCD.Size = new System.Drawing.Size(119, 20);
            this.lblNameCD.TabIndex = 7;
            this.lblNameCD.Text = "Tên công đoạn";
            // 
            // txtCDTK
            // 
            this.txtCDTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCDTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCDTK.Location = new System.Drawing.Point(486, 511);
            this.txtCDTK.Name = "txtCDTK";
            this.txtCDTK.Size = new System.Drawing.Size(191, 26);
            this.txtCDTK.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(7, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 25);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Tên sản phẩm";
            // 
            // txtDGTK
            // 
            this.txtDGTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDGTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDGTK.Location = new System.Drawing.Point(773, 511);
            this.txtDGTK.Name = "txtDGTK";
            this.txtDGTK.Size = new System.Drawing.Size(175, 26);
            this.txtDGTK.TabIndex = 13;
            // 
            // lblGia
            // 
            this.lblGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGia.Location = new System.Drawing.Point(694, 514);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(66, 20);
            this.lblGia.TabIndex = 9;
            this.lblGia.Text = "Đơn giá";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox5.Location = new System.Drawing.Point(160, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(191, 30);
            this.textBox5.TabIndex = 13;
            // 
            // btnTimKimSP
            // 
            this.btnTimKimSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKimSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKimSP.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKimSP.IconColor = System.Drawing.Color.Blue;
            this.btnTimKimSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKimSP.IconSize = 25;
            this.btnTimKimSP.Location = new System.Drawing.Point(377, 12);
            this.btnTimKimSP.Name = "btnTimKimSP";
            this.btnTimKimSP.Size = new System.Drawing.Size(62, 34);
            this.btnTimKimSP.TabIndex = 18;
            this.btnTimKimSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKimSP.UseVisualStyleBackColor = true;
            // 
            // frmCongDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 918);
            this.Controls.Add(this.pnlSP);
            this.Controls.Add(this.pnlCa);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKimSP);
            this.Controls.Add(this.btnTimKimCa);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtDGTK);
            this.Controls.Add(this.txtDonGiaCapNhat);
            this.Controls.Add(this.txtTenSPTK);
            this.Controls.Add(this.txtTenSPCapNhat);
            this.Controls.Add(this.txtCDTK);
            this.Controls.Add(this.txtCongDoanCapNhat);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDongia);
            this.Controls.Add(this.lblNameCD);
            this.Controls.Add(this.lblTenCD);
            this.Controls.Add(this.lblNameSP);
            this.Controls.Add(this.lblTenSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCongDoan";
            this.Text = "frmCongDoan";
            this.pnlCa.ResumeLayout(false);
            this.pnlSP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlCa;
        private System.Windows.Forms.ListView lvwDSCa;
        private System.Windows.Forms.Label lblList;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnTimKimCa;
        private System.Windows.Forms.TextBox txtDonGiaCapNhat;
        private System.Windows.Forms.TextBox txtCongDoanCapNhat;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label lblTenCD;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSPCapNhat;
        private System.Windows.Forms.Panel pnlSP;
        private System.Windows.Forms.Label lblNameSP;
        private System.Windows.Forms.TextBox txtTenSPTK;
        private System.Windows.Forms.Label lblNameCD;
        private System.Windows.Forms.TextBox txtCDTK;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDGTK;
        private System.Windows.Forms.Label lblDSSP;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.ListView lvwDSSP;
        private System.Windows.Forms.TextBox textBox5;
        private FontAwesome.Sharp.IconButton btnTimKimSP;
    }
}