
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
            this.pnlList.Location = new System.Drawing.Point(122, 132);
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
            // frmLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1468, 811);
            this.Controls.Add(this.pnlList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLuongNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLuongNhanVien";
            this.Load += new System.EventHandler(this.frmLuongNhanVien_Load);
            this.pnlList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwSalary;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblList;
    }
}