
namespace QLLuongSanPham.GUI.NhanVienGUI
{
    partial class frmTongQuan
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picAvata = new System.Windows.Forms.PictureBox();
            this.btnSalaryDestop = new FontAwesome.Sharp.IconButton();
            this.btnInfoDesktop = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.picAvata)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(384, 313);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(431, 23);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Chào mừng nhân viên Võ Minh Phương";
            // 
            // picAvata
            // 
            this.picAvata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAvata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAvata.Location = new System.Drawing.Point(423, 78);
            this.picAvata.Name = "picAvata";
            this.picAvata.Size = new System.Drawing.Size(360, 183);
            this.picAvata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvata.TabIndex = 9;
            this.picAvata.TabStop = false;
            // 
            // btnSalaryDestop
            // 
            this.btnSalaryDestop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalaryDestop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalaryDestop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(61)))), ((int)(((byte)(191)))));
            this.btnSalaryDestop.FlatAppearance.BorderSize = 2;
            this.btnSalaryDestop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(61)))), ((int)(((byte)(191)))));
            this.btnSalaryDestop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryDestop.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalaryDestop.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnSalaryDestop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(61)))), ((int)(((byte)(191)))));
            this.btnSalaryDestop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalaryDestop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaryDestop.Location = new System.Drawing.Point(824, 599);
            this.btnSalaryDestop.Name = "btnSalaryDestop";
            this.btnSalaryDestop.Size = new System.Drawing.Size(253, 129);
            this.btnSalaryDestop.TabIndex = 7;
            this.btnSalaryDestop.Text = "Lương";
            this.btnSalaryDestop.UseVisualStyleBackColor = true;
            this.btnSalaryDestop.Click += new System.EventHandler(this.btnSalaryDestop_Click);
            // 
            // btnInfoDesktop
            // 
            this.btnInfoDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInfoDesktop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoDesktop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(61)))), ((int)(((byte)(191)))));
            this.btnInfoDesktop.FlatAppearance.BorderSize = 2;
            this.btnInfoDesktop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(61)))), ((int)(((byte)(191)))));
            this.btnInfoDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoDesktop.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnInfoDesktop.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnInfoDesktop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(61)))), ((int)(((byte)(191)))));
            this.btnInfoDesktop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfoDesktop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoDesktop.Location = new System.Drawing.Point(152, 599);
            this.btnInfoDesktop.Name = "btnInfoDesktop";
            this.btnInfoDesktop.Size = new System.Drawing.Size(253, 129);
            this.btnInfoDesktop.TabIndex = 8;
            this.btnInfoDesktop.Text = "Thông tin cá nhân";
            this.btnInfoDesktop.UseVisualStyleBackColor = true;
            this.btnInfoDesktop.Click += new System.EventHandler(this.btnInfoDesktop_Click);
            // 
            // frmTongQuan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1239, 814);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.picAvata);
            this.Controls.Add(this.btnSalaryDestop);
            this.Controls.Add(this.btnInfoDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTongQuan";
            this.Text = "frmTongQuan";
            ((System.ComponentModel.ISupportInitialize)(this.picAvata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picAvata;
        private FontAwesome.Sharp.IconButton btnSalaryDestop;
        private FontAwesome.Sharp.IconButton btnInfoDesktop;
    }
}