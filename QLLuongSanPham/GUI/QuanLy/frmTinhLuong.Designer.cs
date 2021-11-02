
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmTinhLuong
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tblNav = new System.Windows.Forms.TableLayoutPanel();
            this.btnHC = new FontAwesome.Sharp.IconButton();
            this.btnCongNhan = new FontAwesome.Sharp.IconButton();
            this.tblNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 46);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1209, 753);
            this.pnlMain.TabIndex = 3;
            // 
            // tblNav
            // 
            this.tblNav.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tblNav.ColumnCount = 2;
            this.tblNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNav.Controls.Add(this.btnHC, 0, 0);
            this.tblNav.Controls.Add(this.btnCongNhan, 1, 0);
            this.tblNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblNav.Location = new System.Drawing.Point(0, 0);
            this.tblNav.Name = "tblNav";
            this.tblNav.RowCount = 1;
            this.tblNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNav.Size = new System.Drawing.Size(1209, 46);
            this.tblNav.TabIndex = 2;
            // 
            // btnHC
            // 
            this.btnHC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHC.IconColor = System.Drawing.Color.Black;
            this.btnHC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHC.Location = new System.Drawing.Point(6, 6);
            this.btnHC.Name = "btnHC";
            this.btnHC.Size = new System.Drawing.Size(594, 34);
            this.btnHC.TabIndex = 0;
            this.btnHC.Text = "Nhân viên hành chánh";
            this.btnHC.UseVisualStyleBackColor = true;
            this.btnHC.Click += new System.EventHandler(this.btnHC_Click);
            // 
            // btnCongNhan
            // 
            this.btnCongNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCongNhan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCongNhan.IconColor = System.Drawing.Color.Black;
            this.btnCongNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCongNhan.Location = new System.Drawing.Point(609, 6);
            this.btnCongNhan.Name = "btnCongNhan";
            this.btnCongNhan.Size = new System.Drawing.Size(594, 34);
            this.btnCongNhan.TabIndex = 1;
            this.btnCongNhan.Text = "Công nhân";
            this.btnCongNhan.UseVisualStyleBackColor = true;
            this.btnCongNhan.Click += new System.EventHandler(this.btnCongNhan_Click);
            // 
            // frmTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 799);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tblNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTinhLuong";
            this.Text = "frmTinhLuong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tblNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tblNav;
        private FontAwesome.Sharp.IconButton btnHC;
        private FontAwesome.Sharp.IconButton btnCongNhan;
    }
}