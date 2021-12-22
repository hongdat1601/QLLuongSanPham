
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmThongKeHC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.picNen = new System.Windows.Forms.PictureBox();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlLuong = new System.Windows.Forms.Panel();
            this.lstvLuong = new System.Windows.Forms.ListView();
            this.lblDSLuong = new System.Windows.Forms.Label();
            this.bangLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangLuongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangLuongBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bangLuongBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bangLuongBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.phongBanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.pnlLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(995, 791);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 0;
            this.picNen.TabStop = false;
            // 
            // chartThongKe
            // 
            this.chartThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartThongKe.BackColor = System.Drawing.Color.Aqua;
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(115, 37);
            this.chartThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "BangLuong";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(764, 399);
            this.chartThongKe.TabIndex = 34;
            this.chartThongKe.Text = "chart";
            this.chartThongKe.Click += new System.EventHandler(this.chartThongKe_Click);
            // 
            // pnlLuong
            // 
            this.pnlLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLuong.Controls.Add(this.lstvLuong);
            this.pnlLuong.Controls.Add(this.lblDSLuong);
            this.pnlLuong.Location = new System.Drawing.Point(16, 490);
            this.pnlLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLuong.Name = "pnlLuong";
            this.pnlLuong.Size = new System.Drawing.Size(963, 266);
            this.pnlLuong.TabIndex = 33;
            // 
            // lstvLuong
            // 
            this.lstvLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvLuong.HideSelection = false;
            this.lstvLuong.Location = new System.Drawing.Point(15, 41);
            this.lstvLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstvLuong.Name = "lstvLuong";
            this.lstvLuong.Size = new System.Drawing.Size(935, 219);
            this.lstvLuong.TabIndex = 1;
            this.lstvLuong.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSLuong
            // 
            this.lblDSLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSLuong.Location = new System.Drawing.Point(0, 0);
            this.lblDSLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDSLuong.Name = "lblDSLuong";
            this.lblDSLuong.Size = new System.Drawing.Size(959, 30);
            this.lblDSLuong.TabIndex = 0;
            this.lblDSLuong.Text = "Danh sách bảng lương";
            this.lblDSLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bangLuongBindingSource
            // 
            this.bangLuongBindingSource.DataSource = typeof(QLLuongSanPham.Entities.BangLuong);
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataSource = typeof(QLLuongSanPham.Entities.PhongBan);
            // 
            // bangLuongBindingSource1
            // 
            this.bangLuongBindingSource1.DataSource = typeof(QLLuongSanPham.Entities.BangLuong);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(QLLuongSanPham.Entities.NhanVien);
            // 
            // bangLuongBindingSource2
            // 
            this.bangLuongBindingSource2.DataSource = typeof(QLLuongSanPham.Entities.BangLuong);
            // 
            // bangLuongBindingSource3
            // 
            this.bangLuongBindingSource3.DataSource = typeof(QLLuongSanPham.Entities.BangLuong);
            // 
            // bangLuongBindingSource4
            // 
            this.bangLuongBindingSource4.DataSource = typeof(QLLuongSanPham.Entities.BangLuong);
            // 
            // phongBanBindingSource1
            // 
            this.phongBanBindingSource1.DataSource = typeof(QLLuongSanPham.Entities.PhongBan);
            // 
            // frmThongKeHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(995, 791);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.pnlLuong);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmThongKeHC";
            this.Text = "frmThongKeHC";
            this.Load += new System.EventHandler(this.frmThongKeHC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.pnlLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bangLuongBindingSource;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private System.Windows.Forms.BindingSource bangLuongBindingSource1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.BindingSource bangLuongBindingSource2;
        private System.Windows.Forms.BindingSource bangLuongBindingSource3;
        private System.Windows.Forms.BindingSource bangLuongBindingSource4;
        private System.Windows.Forms.BindingSource phongBanBindingSource1;
        private System.Windows.Forms.PictureBox picNen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.Panel pnlLuong;
        private System.Windows.Forms.ListView lstvLuong;
        private System.Windows.Forms.Label lblDSLuong;
    }
}