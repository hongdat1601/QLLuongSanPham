
namespace QLLuongSanPham.GUI.NhanVienGUI
{
    partial class frmLuongNhanVien
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
            this.lvwSalary = new System.Windows.Forms.ListView();
            this.pnlList = new System.Windows.Forms.Panel();
            this.lblList = new System.Windows.Forms.Label();
            this.lblSumSalary = new System.Windows.Forms.Label();
            this.txtSumSalry = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCa = new System.Windows.Forms.Label();
            this.lblCongDoan = new System.Windows.Forms.Label();
            this.lblGiaCĐ = new System.Windows.Forms.Label();
            this.lblNgayNghi = new System.Windows.Forms.Label();
            this.lblThuong = new System.Windows.Forms.Label();
            this.txtNgayLam = new System.Windows.Forms.TextBox();
            this.txtCalam = new System.Windows.Forms.TextBox();
            this.txtCongdoan = new System.Windows.Forms.TextBox();
            this.txtGiaCĐ = new System.Windows.Forms.TextBox();
            this.txtNgayNghi = new System.Windows.Forms.TextBox();
            this.txtThuongPhat = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwSalary
            // 
            this.lvwSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvwSalary.Font = new System.Drawing.Font("Verdana", 12F);
            this.lvwSalary.HideSelection = false;
            this.lvwSalary.Location = new System.Drawing.Point(14, 54);
            this.lvwSalary.Name = "lvwSalary";
            this.lvwSalary.Size = new System.Drawing.Size(1190, 387);
            this.lvwSalary.TabIndex = 0;
            this.lvwSalary.UseCompatibleStateImageBehavior = false;
            // 
            // pnlList
            // 
            this.pnlList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlList.Controls.Add(this.lblList);
            this.pnlList.Controls.Add(this.lvwSalary);
            this.pnlList.Location = new System.Drawing.Point(122, 180);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1221, 466);
            this.pnlList.TabIndex = 1;
            // 
            // lblList
            // 
            this.lblList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblList.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblList.Location = new System.Drawing.Point(0, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(1220, 39);
            this.lblList.TabIndex = 1;
            this.lblList.Text = "Chi tiết bảng lương";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSumSalary
            // 
            this.lblSumSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSumSalary.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSumSalary.Location = new System.Drawing.Point(478, 726);
            this.lblSumSalary.Name = "lblSumSalary";
            this.lblSumSalary.Size = new System.Drawing.Size(143, 46);
            this.lblSumSalary.TabIndex = 2;
            this.lblSumSalary.Text = "Tổng lương";
            this.lblSumSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSumSalry
            // 
            this.txtSumSalry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSumSalry.Enabled = false;
            this.txtSumSalry.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtSumSalry.Location = new System.Drawing.Point(689, 735);
            this.txtSumSalry.Name = "txtSumSalry";
            this.txtSumSalry.Size = new System.Drawing.Size(355, 29);
            this.txtSumSalry.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblDate.Location = new System.Drawing.Point(12, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Ngày làm";
            // 
            // lblCa
            // 
            this.lblCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCa.AutoSize = true;
            this.lblCa.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblCa.Location = new System.Drawing.Point(12, 96);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(76, 23);
            this.lblCa.TabIndex = 5;
            this.lblCa.Text = "Ca làm";
            // 
            // lblCongDoan
            // 
            this.lblCongDoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCongDoan.AutoSize = true;
            this.lblCongDoan.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblCongDoan.Location = new System.Drawing.Point(409, 35);
            this.lblCongDoan.Name = "lblCongDoan";
            this.lblCongDoan.Size = new System.Drawing.Size(113, 23);
            this.lblCongDoan.TabIndex = 4;
            this.lblCongDoan.Text = "Công đoạn";
            // 
            // lblGiaCĐ
            // 
            this.lblGiaCĐ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGiaCĐ.AutoSize = true;
            this.lblGiaCĐ.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblGiaCĐ.Location = new System.Drawing.Point(409, 93);
            this.lblGiaCĐ.Name = "lblGiaCĐ";
            this.lblGiaCĐ.Size = new System.Drawing.Size(149, 23);
            this.lblGiaCĐ.TabIndex = 5;
            this.lblGiaCĐ.Text = "Giá công đoạn";
            // 
            // lblNgayNghi
            // 
            this.lblNgayNghi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgayNghi.AutoSize = true;
            this.lblNgayNghi.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblNgayNghi.Location = new System.Drawing.Point(856, 35);
            this.lblNgayNghi.Name = "lblNgayNghi";
            this.lblNgayNghi.Size = new System.Drawing.Size(107, 23);
            this.lblNgayNghi.TabIndex = 4;
            this.lblNgayNghi.Text = "Ngày nghĩ";
            // 
            // lblThuong
            // 
            this.lblThuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThuong.AutoSize = true;
            this.lblThuong.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblThuong.Location = new System.Drawing.Point(856, 95);
            this.lblThuong.Name = "lblThuong";
            this.lblThuong.Size = new System.Drawing.Size(132, 23);
            this.lblThuong.TabIndex = 5;
            this.lblThuong.Text = "Thưởng/Phạt";
            // 
            // txtNgayLam
            // 
            this.txtNgayLam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgayLam.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.txtNgayLam.Location = new System.Drawing.Point(127, 29);
            this.txtNgayLam.Name = "txtNgayLam";
            this.txtNgayLam.Size = new System.Drawing.Size(254, 29);
            this.txtNgayLam.TabIndex = 6;
            // 
            // txtCalam
            // 
            this.txtCalam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCalam.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.txtCalam.Location = new System.Drawing.Point(127, 89);
            this.txtCalam.Name = "txtCalam";
            this.txtCalam.Size = new System.Drawing.Size(254, 29);
            this.txtCalam.TabIndex = 6;
            // 
            // txtCongdoan
            // 
            this.txtCongdoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCongdoan.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.txtCongdoan.Location = new System.Drawing.Point(584, 29);
            this.txtCongdoan.Name = "txtCongdoan";
            this.txtCongdoan.Size = new System.Drawing.Size(254, 29);
            this.txtCongdoan.TabIndex = 6;
            // 
            // txtGiaCĐ
            // 
            this.txtGiaCĐ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiaCĐ.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.txtGiaCĐ.Location = new System.Drawing.Point(584, 90);
            this.txtGiaCĐ.Name = "txtGiaCĐ";
            this.txtGiaCĐ.Size = new System.Drawing.Size(254, 29);
            this.txtGiaCĐ.TabIndex = 6;
            // 
            // txtNgayNghi
            // 
            this.txtNgayNghi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgayNghi.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.txtNgayNghi.Location = new System.Drawing.Point(1010, 29);
            this.txtNgayNghi.Name = "txtNgayNghi";
            this.txtNgayNghi.Size = new System.Drawing.Size(254, 29);
            this.txtNgayNghi.TabIndex = 6;
            // 
            // txtThuongPhat
            // 
            this.txtThuongPhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThuongPhat.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.txtThuongPhat.Location = new System.Drawing.Point(1010, 87);
            this.txtThuongPhat.Name = "txtThuongPhat";
            this.txtThuongPhat.Size = new System.Drawing.Size(254, 29);
            this.txtThuongPhat.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSearch.FlatAppearance.BorderSize = 4;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 20;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1304, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 45);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1468, 811);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtThuongPhat);
            this.Controls.Add(this.txtGiaCĐ);
            this.Controls.Add(this.txtCalam);
            this.Controls.Add(this.txtNgayNghi);
            this.Controls.Add(this.txtCongdoan);
            this.Controls.Add(this.txtNgayLam);
            this.Controls.Add(this.lblThuong);
            this.Controls.Add(this.lblGiaCĐ);
            this.Controls.Add(this.lblNgayNghi);
            this.Controls.Add(this.lblCongDoan);
            this.Controls.Add(this.lblCa);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtSumSalry);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.lblSumSalary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLuongNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLuongNhanVien";
            this.Load += new System.EventHandler(this.frmLuongNhanVien_Load);
            this.pnlList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwSalary;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblSumSalary;
        private System.Windows.Forms.TextBox txtSumSalry;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCa;
        private System.Windows.Forms.Label lblCongDoan;
        private System.Windows.Forms.Label lblGiaCĐ;
        private System.Windows.Forms.Label lblNgayNghi;
        private System.Windows.Forms.Label lblThuong;
        private System.Windows.Forms.TextBox txtNgayLam;
        private System.Windows.Forms.TextBox txtCalam;
        private System.Windows.Forms.TextBox txtCongdoan;
        private System.Windows.Forms.TextBox txtGiaCĐ;
        private System.Windows.Forms.TextBox txtNgayNghi;
        private System.Windows.Forms.TextBox txtThuongPhat;
        private FontAwesome.Sharp.IconButton btnSearch;
    }
}