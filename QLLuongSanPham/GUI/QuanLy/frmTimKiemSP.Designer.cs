
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmTimKiemSP
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
            this.lvwDSSP = new System.Windows.Forms.ListView();
            this.lblDSSP = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDG = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.pnlSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSP
            // 
            this.pnlSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSP.Controls.Add(this.lvwDSSP);
            this.pnlSP.Controls.Add(this.lblDSSP);
            this.pnlSP.Location = new System.Drawing.Point(30, 367);
            this.pnlSP.Name = "pnlSP";
            this.pnlSP.Size = new System.Drawing.Size(1150, 302);
            this.pnlSP.TabIndex = 13;
            // 
            // lvwDSSP
            // 
            this.lvwDSSP.HideSelection = false;
            this.lvwDSSP.Location = new System.Drawing.Point(22, 52);
            this.lvwDSSP.Name = "lvwDSSP";
            this.lvwDSSP.Size = new System.Drawing.Size(1103, 228);
            this.lvwDSSP.TabIndex = 1;
            this.lvwDSSP.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSSP
            // 
            this.lblDSSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDSSP.Location = new System.Drawing.Point(0, 0);
            this.lblDSSP.Name = "lblDSSP";
            this.lblDSSP.Size = new System.Drawing.Size(1146, 33);
            this.lblDSSP.TabIndex = 0;
            this.lblDSSP.Text = "Danh sách sản phẩm";
            this.lblDSSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(221, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 29);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblName.Location = new System.Drawing.Point(26, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 23);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Tên sản phẩm";
            // 
            // lblDG
            // 
            this.lblDG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDG.AutoSize = true;
            this.lblDG.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.lblDG.Location = new System.Drawing.Point(26, 153);
            this.lblDG.Name = "lblDG";
            this.lblDG.Size = new System.Drawing.Size(85, 23);
            this.lblDG.TabIndex = 14;
            this.lblDG.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonGia.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtDonGia.Location = new System.Drawing.Point(221, 147);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(265, 29);
            this.txtDonGia.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.Blue;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 30;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(30, 258);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(522, 52);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // frmTimKiemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 780);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDG);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiemSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiemSP";
            this.pnlSP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSP;
        private System.Windows.Forms.ListView lvwDSSP;
        private System.Windows.Forms.Label lblDSSP;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDG;
        private System.Windows.Forms.TextBox txtDonGia;
        private FontAwesome.Sharp.IconButton btnTimKiem;
    }
}