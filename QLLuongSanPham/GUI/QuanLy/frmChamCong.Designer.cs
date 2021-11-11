
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmChamCong
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
            this.tblNav = new System.Windows.Forms.TableLayoutPanel();
            this.btnHC = new FontAwesome.Sharp.IconButton();
            this.btnCongNhan = new FontAwesome.Sharp.IconButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.picNen = new System.Windows.Forms.PictureBox();
            this.tblNav.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.SuspendLayout();
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
            this.tblNav.Size = new System.Drawing.Size(1191, 56);
            this.tblNav.TabIndex = 3;
            // 
            // btnHC
            // 
            this.btnHC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnHC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHC.IconColor = System.Drawing.Color.Black;
            this.btnHC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHC.Location = new System.Drawing.Point(6, 6);
            this.btnHC.Name = "btnHC";
            this.btnHC.Size = new System.Drawing.Size(585, 44);
            this.btnHC.TabIndex = 0;
            this.btnHC.Text = "Nhân viên hành chánh";
            this.btnHC.UseVisualStyleBackColor = false;
            this.btnHC.Click += new System.EventHandler(this.btnHC_Click);
            // 
            // btnCongNhan
            // 
            this.btnCongNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCongNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCongNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCongNhan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCongNhan.IconColor = System.Drawing.Color.Black;
            this.btnCongNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCongNhan.Location = new System.Drawing.Point(600, 6);
            this.btnCongNhan.Name = "btnCongNhan";
            this.btnCongNhan.Size = new System.Drawing.Size(585, 44);
            this.btnCongNhan.TabIndex = 1;
            this.btnCongNhan.Text = "Công nhân";
            this.btnCongNhan.UseVisualStyleBackColor = false;
            this.btnCongNhan.Click += new System.EventHandler(this.btnCongNhan_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.pnlMain.Controls.Add(this.picNen);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 56);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1191, 696);
            this.pnlMain.TabIndex = 4;
            // 
            // picNen
            // 
            this.picNen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.timekeeping;
            this.picNen.Location = new System.Drawing.Point(205, 134);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(801, 449);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 0;
            this.picNen.TabStop = false;
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 752);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tblNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamCong";
            this.Text = "frmChamCong";
            this.tblNav.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblNav;
        private FontAwesome.Sharp.IconButton btnHC;
        private FontAwesome.Sharp.IconButton btnCongNhan;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox picNen;
    }
}