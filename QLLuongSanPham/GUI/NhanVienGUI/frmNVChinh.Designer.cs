
namespace QLLuongSanPham.GUI.NhanVienGUI
{
    partial class frmNVChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNVChinh));
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
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.panelTab.SuspendLayout();
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
            this.panelMenu.Size = new System.Drawing.Size(250, 811);
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
            this.btnExit.Location = new System.Drawing.Point(0, 750);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExit.Size = new System.Drawing.Size(250, 61);
            this.btnExit.TabIndex = 5;
            this.btnExit.Tag = "Đăng xuất";
            this.btnExit.Text = "Đăng xuất";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.lblName.Size = new System.Drawing.Size(0, 23);
            this.lblName.TabIndex = 1;
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
            this.panelTab.Size = new System.Drawing.Size(976, 37);
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
            this.btnHide.Location = new System.Drawing.Point(852, 0);
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
            this.btnShow.Location = new System.Drawing.Point(893, 0);
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
            this.btnClose.Location = new System.Drawing.Point(935, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(250, 37);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(976, 774);
            this.pnlDesktop.TabIndex = 3;
            // 
            // frmNVChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1226, 811);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNVChinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainEmployee_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.panelTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblName;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnSalary;
        private FontAwesome.Sharp.IconButton btnInfor;
        private FontAwesome.Sharp.IconButton btnBars;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnShow;
        private FontAwesome.Sharp.IconButton btnHide;
        private System.Windows.Forms.Panel pnlDesktop;
    }
}