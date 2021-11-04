
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
            this.lvwDSCA = new System.Windows.Forms.ListView();
            this.lblList = new System.Windows.Forms.Label();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.pnlDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalam
            // 
            this.lblCalam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCalam.AutoSize = true;
            this.lblCalam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCalam.Location = new System.Drawing.Point(21, 41);
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
            this.lblTime.Location = new System.Drawing.Point(21, 139);
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
            this.txtCalam.Location = new System.Drawing.Point(350, 36);
            this.txtCalam.Name = "txtCalam";
            this.txtCalam.Size = new System.Drawing.Size(332, 30);
            this.txtCalam.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTime.Location = new System.Drawing.Point(350, 134);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(332, 30);
            this.txtTime.TabIndex = 1;
            // 
            // pnlDS
            // 
            this.pnlDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDS.Controls.Add(this.lvwDSCA);
            this.pnlDS.Controls.Add(this.lblList);
            this.pnlDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlDS.Location = new System.Drawing.Point(26, 352);
            this.pnlDS.Name = "pnlDS";
            this.pnlDS.Size = new System.Drawing.Size(1111, 327);
            this.pnlDS.TabIndex = 3;
            // 
            // lvwDSCA
            // 
            this.lvwDSCA.HideSelection = false;
            this.lvwDSCA.Location = new System.Drawing.Point(19, 64);
            this.lvwDSCA.Name = "lvwDSCA";
            this.lvwDSCA.Size = new System.Drawing.Size(1068, 237);
            this.lvwDSCA.TabIndex = 1;
            this.lvwDSCA.UseCompatibleStateImageBehavior = false;
            this.lvwDSCA.SelectedIndexChanged += new System.EventHandler(this.lvwDSCA_SelectedIndexChanged);
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
            this.btnAdd.Location = new System.Drawing.Point(26, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 25;
            this.btnEdit.Location = new System.Drawing.Point(295, 239);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 43);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(587, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 43);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtCalam);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCalam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCaLamViec";
            this.Load += new System.EventHandler(this.frmCaLamViec_Load);
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
        private System.Windows.Forms.ListView lvwDSCA;
    }
}