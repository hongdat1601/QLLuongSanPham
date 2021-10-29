
namespace QLLuongSanPham.GUI.NhanVienGUI
{
    partial class frmDoiMatKhau
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.btnYes = new FontAwesome.Sharp.IconButton();
            this.btnNo = new FontAwesome.Sharp.IconButton();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(695, 49);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Đổi mật khẩu";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblOldPass.Location = new System.Drawing.Point(37, 92);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(208, 23);
            this.lblOldPass.TabIndex = 1;
            this.lblOldPass.Text = "Nhập mật khẩu cũ";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblNewPass.Location = new System.Drawing.Point(37, 164);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(223, 23);
            this.lblNewPass.TabIndex = 1;
            this.lblNewPass.Text = "Nhập mật khẩu mới";
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPass.Location = new System.Drawing.Point(37, 242);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(221, 23);
            this.lblConfirmPass.TabIndex = 1;
            this.lblConfirmPass.Text = "Xác nhận mật khẩu";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnYes.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnYes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnYes.IconColor = System.Drawing.Color.Black;
            this.btnYes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnYes.Location = new System.Drawing.Point(88, 342);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(138, 58);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Xác nhận";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnNo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNo.IconColor = System.Drawing.Color.Black;
            this.btnNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNo.Location = new System.Drawing.Point(440, 342);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(147, 58);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "Hủy bỏ";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.txtOldPass.Location = new System.Drawing.Point(300, 86);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(257, 29);
            this.txtOldPass.TabIndex = 3;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.txtNewPass.Location = new System.Drawing.Point(300, 158);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(257, 29);
            this.txtNewPass.TabIndex = 3;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.txtConfirmPass.Location = new System.Drawing.Point(300, 236);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(257, 29);
            this.txtConfirmPass.TabIndex = 3;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(695, 443);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblOldPass);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFixPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private FontAwesome.Sharp.IconButton btnYes;
        private FontAwesome.Sharp.IconButton btnNo;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
    }
}