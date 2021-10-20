
namespace QLLuongSanPham
{
    partial class frmMainEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainEmployee));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnSalary = new FontAwesome.Sharp.IconButton();
            this.btnInfor = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnBars = new FontAwesome.Sharp.IconButton();
            this.lblName = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.panelTab = new System.Windows.Forms.Panel();
            this.btnHide = new FontAwesome.Sharp.IconButton();
            this.btnShow = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnInforDesktop = new FontAwesome.Sharp.IconButton();
            this.lblNameDesktop = new System.Windows.Forms.Label();
            this.pcbLogoDesktop = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.panelTab.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoDesktop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnSalary);
            this.panelMenu.Controls.Add(this.btnInfor);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 706);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 32;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 645);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExit.Size = new System.Drawing.Size(250, 61);
            this.btnExit.TabIndex = 5;
            this.btnExit.Tag = "Đăng xuất";
            this.btnExit.Text = "Đăng xuất";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSalary
            // 
            this.btnSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnSalary.ForeColor = System.Drawing.Color.White;
            this.btnSalary.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnSalary.IconColor = System.Drawing.Color.White;
            this.btnSalary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalary.IconSize = 32;
            this.btnSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.Location = new System.Drawing.Point(0, 325);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalary.Size = new System.Drawing.Size(250, 60);
            this.btnSalary.TabIndex = 3;
            this.btnSalary.Tag = "Lương";
            this.btnSalary.Text = "Lương";
            this.btnSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnInfor
            // 
            this.btnInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfor.FlatAppearance.BorderSize = 0;
            this.btnInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfor.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnInfor.ForeColor = System.Drawing.Color.White;
            this.btnInfor.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnInfor.IconColor = System.Drawing.Color.White;
            this.btnInfor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfor.IconSize = 32;
            this.btnInfor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfor.Location = new System.Drawing.Point(0, 265);
            this.btnInfor.Name = "btnInfor";
            this.btnInfor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInfor.Size = new System.Drawing.Size(250, 60);
            this.btnInfor.TabIndex = 2;
            this.btnInfor.Tag = "Thông tin cá nhân";
            this.btnInfor.Text = "Thông tin cá nhân";
            this.btnInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfor.UseVisualStyleBackColor = true;
            this.btnInfor.Click += new System.EventHandler(this.btnInfor_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 205);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Tag = "Tổng quan";
            this.btnHome.Text = "Tổng quan";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogo.Controls.Add(this.btnBars);
            this.panelLogo.Controls.Add(this.lblName);
            this.panelLogo.Controls.Add(this.pcbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 205);
            this.panelLogo.TabIndex = 0;
            // 
            // btnBars
            // 
            this.btnBars.FlatAppearance.BorderSize = 0;
            this.btnBars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBars.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnBars.IconColor = System.Drawing.Color.White;
            this.btnBars.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBars.IconSize = 32;
            this.btnBars.Location = new System.Drawing.Point(208, 0);
            this.btnBars.Name = "btnBars";
            this.btnBars.Size = new System.Drawing.Size(41, 35);
            this.btnBars.TabIndex = 2;
            this.btnBars.UseVisualStyleBackColor = true;
            this.btnBars.Click += new System.EventHandler(this.btnBars_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(34, 154);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(187, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Võ Minh Phương";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(62, 36);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(106, 95);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // panelTab
            // 
            this.panelTab.Controls.Add(this.btnHide);
            this.panelTab.Controls.Add(this.btnShow);
            this.panelTab.Controls.Add(this.btnClose);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTab.Location = new System.Drawing.Point(250, 0);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(802, 37);
            this.panelTab.TabIndex = 1;
            this.panelTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTab_MouseDown);
            // 
            // btnHide
            // 
            this.btnHide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnHide.IconColor = System.Drawing.Color.Black;
            this.btnHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHide.IconSize = 20;
            this.btnHide.Location = new System.Drawing.Point(678, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(41, 37);
            this.btnHide.TabIndex = 2;
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.btnShow.IconColor = System.Drawing.Color.Black;
            this.btnShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShow.IconSize = 20;
            this.btnShow.Location = new System.Drawing.Point(719, 0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(42, 37);
            this.btnShow.TabIndex = 1;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 60;
            this.btnClose.Location = new System.Drawing.Point(761, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.iconButton2);
            this.panelDesktop.Controls.Add(this.btnInforDesktop);
            this.panelDesktop.Controls.Add(this.lblNameDesktop);
            this.panelDesktop.Controls.Add(this.pcbLogoDesktop);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(250, 37);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(802, 669);
            this.panelDesktop.TabIndex = 2;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(61)))), ((int)(((byte)(191)))));
            this.iconButton2.FlatAppearance.BorderSize = 2;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(61)))), ((int)(((byte)(191)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(61)))), ((int)(((byte)(191)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(437, 358);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(80, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(281, 158);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "Lương";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // btnInforDesktop
            // 
            this.btnInforDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInforDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInforDesktop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInforDesktop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(61)))), ((int)(((byte)(191)))));
            this.btnInforDesktop.FlatAppearance.BorderSize = 2;
            this.btnInforDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforDesktop.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnInforDesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(61)))), ((int)(((byte)(191)))));
            this.btnInforDesktop.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnInforDesktop.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(61)))), ((int)(((byte)(191)))));
            this.btnInforDesktop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInforDesktop.IconSize = 32;
            this.btnInforDesktop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInforDesktop.Location = new System.Drawing.Point(54, 358);
            this.btnInforDesktop.Name = "btnInforDesktop";
            this.btnInforDesktop.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInforDesktop.Size = new System.Drawing.Size(257, 158);
            this.btnInforDesktop.TabIndex = 3;
            this.btnInforDesktop.Text = "Thông tin cá nhân";
            this.btnInforDesktop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInforDesktop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInforDesktop.UseVisualStyleBackColor = true;
            // 
            // lblNameDesktop
            // 
            this.lblNameDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameDesktop.AutoSize = true;
            this.lblNameDesktop.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDesktop.ForeColor = System.Drawing.Color.Black;
            this.lblNameDesktop.Location = new System.Drawing.Point(173, 185);
            this.lblNameDesktop.Name = "lblNameDesktop";
            this.lblNameDesktop.Size = new System.Drawing.Size(431, 23);
            this.lblNameDesktop.TabIndex = 2;
            this.lblNameDesktop.Text = "Chào mừng nhân viên Võ Minh Phương";
            // 
            // pcbLogoDesktop
            // 
            this.pcbLogoDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbLogoDesktop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbLogoDesktop.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogoDesktop.Image")));
            this.pcbLogoDesktop.Location = new System.Drawing.Point(235, 15);
            this.pcbLogoDesktop.Name = "pcbLogoDesktop";
            this.pcbLogoDesktop.Size = new System.Drawing.Size(314, 142);
            this.pcbLogoDesktop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoDesktop.TabIndex = 1;
            this.pcbLogoDesktop.TabStop = false;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1052, 706);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.panelTab.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoDesktop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnSalary;
        private FontAwesome.Sharp.IconButton btnInfor;
        private System.Windows.Forms.Label lblNameDesktop;
        private System.Windows.Forms.PictureBox pcbLogoDesktop;
        private FontAwesome.Sharp.IconButton btnBars;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnInforDesktop;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnShow;
        private FontAwesome.Sharp.IconButton btnHide;
    }
}