
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
            this.picNen = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back1;
            this.picNen.Location = new System.Drawing.Point(225, 127);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(685, 502);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNen.TabIndex = 1;
            this.picNen.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(225, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(685, 72);
            this.lblName.TabIndex = 2;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1127, 653);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTongQuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTongQuan";
            this.Load += new System.EventHandler(this.frmTongQuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private System.Windows.Forms.Label lblName;
    }
}