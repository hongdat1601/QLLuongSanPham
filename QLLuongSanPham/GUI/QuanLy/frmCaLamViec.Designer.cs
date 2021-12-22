
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
            this.ptcNen = new System.Windows.Forms.PictureBox();
            this.pnlDS = new System.Windows.Forms.Panel();
            this.lvwDSCA = new System.Windows.Forms.ListView();
            this.lblList = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtCalam = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCalam = new System.Windows.Forms.Label();
            this.gboTT = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNen)).BeginInit();
            this.pnlDS.SuspendLayout();
            this.gboTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptcNen
            // 
            this.ptcNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptcNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.ptcNen.Location = new System.Drawing.Point(0, 0);
            this.ptcNen.Name = "ptcNen";
            this.ptcNen.Size = new System.Drawing.Size(1251, 825);
            this.ptcNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcNen.TabIndex = 0;
            this.ptcNen.TabStop = false;
            // 
            // pnlDS
            // 
            this.pnlDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDS.Controls.Add(this.lvwDSCA);
            this.pnlDS.Controls.Add(this.lblList);
            this.pnlDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlDS.Location = new System.Drawing.Point(49, 448);
            this.pnlDS.Name = "pnlDS";
            this.pnlDS.Size = new System.Drawing.Size(1136, 365);
            this.pnlDS.TabIndex = 11;
            // 
            // lvwDSCA
            // 
            this.lvwDSCA.HideSelection = false;
            this.lvwDSCA.Location = new System.Drawing.Point(16, 65);
            this.lvwDSCA.Name = "lvwDSCA";
            this.lvwDSCA.Size = new System.Drawing.Size(1097, 278);
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
            this.lblList.Size = new System.Drawing.Size(1132, 41);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "Danh sách ca làm việc";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(915, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 43);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 25;
            this.btnEdit.Location = new System.Drawing.Point(518, 227);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 43);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(42)))));
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 25;
            this.btnAdd.Location = new System.Drawing.Point(136, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 43);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTime
            // 
            this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTime.Location = new System.Drawing.Point(518, 138);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(506, 30);
            this.txtTime.TabIndex = 6;
            // 
            // txtCalam
            // 
            this.txtCalam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCalam.Enabled = false;
            this.txtCalam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCalam.Location = new System.Drawing.Point(518, 48);
            this.txtCalam.Name = "txtCalam";
            this.txtCalam.Size = new System.Drawing.Size(506, 30);
            this.txtCalam.TabIndex = 7;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTime.Location = new System.Drawing.Point(131, 143);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(169, 25);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Thời gian làm việc";
            // 
            // lblCalam
            // 
            this.lblCalam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCalam.AutoSize = true;
            this.lblCalam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCalam.Location = new System.Drawing.Point(131, 53);
            this.lblCalam.Name = "lblCalam";
            this.lblCalam.Size = new System.Drawing.Size(73, 25);
            this.lblCalam.TabIndex = 5;
            this.lblCalam.Text = "Tên ca";
            // 
            // gboTT
            // 
            this.gboTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboTT.Controls.Add(this.btnDelete);
            this.gboTT.Controls.Add(this.btnEdit);
            this.gboTT.Controls.Add(this.btnAdd);
            this.gboTT.Controls.Add(this.txtTime);
            this.gboTT.Controls.Add(this.txtCalam);
            this.gboTT.Controls.Add(this.lblTime);
            this.gboTT.Controls.Add(this.lblCalam);
            this.gboTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboTT.Location = new System.Drawing.Point(49, 31);
            this.gboTT.Name = "gboTT";
            this.gboTT.Size = new System.Drawing.Size(1136, 290);
            this.gboTT.TabIndex = 12;
            this.gboTT.TabStop = false;
            this.gboTT.Text = "Thông tin ca làm việc";
            // 
            // frmCaLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1251, 825);
            this.Controls.Add(this.gboTT);
            this.Controls.Add(this.pnlDS);
            this.Controls.Add(this.ptcNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCaLamViec";
            this.Load += new System.EventHandler(this.frmCaLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcNen)).EndInit();
            this.pnlDS.ResumeLayout(false);
            this.gboTT.ResumeLayout(false);
            this.gboTT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcNen;
        private System.Windows.Forms.Panel pnlDS;
        private System.Windows.Forms.ListView lvwDSCA;
        private System.Windows.Forms.Label lblList;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtCalam;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCalam;
        private System.Windows.Forms.GroupBox gboTT;
    }
}