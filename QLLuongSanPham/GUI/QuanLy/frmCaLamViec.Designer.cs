
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmCaLamViec
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
            this.lblCalam = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtCalam = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.pnlDS = new System.Windows.Forms.Panel();
            this.lvwList = new System.Windows.Forms.ListView();
            this.lblList = new System.Windows.Forms.Label();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.pnlDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalam
            // 
            this.lblCalam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCalam.AutoSize = true;
            this.lblCalam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCalam.Location = new System.Drawing.Point(21, 17);
            this.lblCalam.Name = "lblCalam";
            this.lblCalam.Size = new System.Drawing.Size(73, 25);
            this.lblCalam.TabIndex = 0;
            this.lblCalam.Text = "Tên ca";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTime.Location = new System.Drawing.Point(21, 104);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(169, 25);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Thời gian làm việc";
            // 
            // txtCalam
            // 
            this.txtCalam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCalam.Enabled = false;
            this.txtCalam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCalam.Location = new System.Drawing.Point(350, 12);
            this.txtCalam.Name = "txtCalam";
            this.txtCalam.Size = new System.Drawing.Size(332, 30);
            this.txtCalam.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTime.Location = new System.Drawing.Point(350, 99);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(332, 30);
            this.txtTime.TabIndex = 1;
            // 
            // pnlDS
            // 
            this.pnlDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDS.Controls.Add(this.lvwList);
            this.pnlDS.Controls.Add(this.lblList);
            this.pnlDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlDS.Location = new System.Drawing.Point(26, 352);
            this.pnlDS.Name = "pnlDS";
            this.pnlDS.Size = new System.Drawing.Size(1111, 327);
            this.pnlDS.TabIndex = 3;
            // 
            // lvwList
            // 
            this.lvwList.HideSelection = false;
            this.lvwList.Location = new System.Drawing.Point(22, 64);
            this.lvwList.Name = "lvwList";
            this.lvwList.Size = new System.Drawing.Size(1049, 237);
            this.lvwList.TabIndex = 1;
            this.lvwList.UseCompatibleStateImageBehavior = false;
            // 
            // lblList
            // 
            this.lblList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblList.Location = new System.Drawing.Point(0, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(1107, 41);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "Danh sách ca làm việc";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 25;
            this.btnAdd.Location = new System.Drawing.Point(26, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 25;
            this.btnEdit.Location = new System.Drawing.Point(305, 191);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 43);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(587, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 43);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(1671, 249);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(145, 43);
            this.iconButton5.TabIndex = 2;
            this.iconButton5.Text = "iconButton1";
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // frmCaLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 709);
            this.Controls.Add(this.pnlDS);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtCalam);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCalam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCaLamViec";
            this.pnlDS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCalam;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtCalam;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Panel pnlDS;
        private System.Windows.Forms.Label lblList;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.ListView lvwList;
        private FontAwesome.Sharp.IconButton iconButton5;
    }
}