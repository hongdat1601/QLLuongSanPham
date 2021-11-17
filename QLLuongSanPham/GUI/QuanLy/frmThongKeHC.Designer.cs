
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
            this.pnlLuong = new System.Windows.Forms.Panel();
            this.lstvLuong = new System.Windows.Forms.ListView();
            this.lblDSLuong = new System.Windows.Forms.Label();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bangLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangLuongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangLuongBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bangLuongBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bangLuongBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.phongBanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
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
            // pnlLuong
            // 
            this.pnlLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLuong.Controls.Add(this.lstvLuong);
            this.pnlLuong.Controls.Add(this.lblDSLuong);
            this.pnlLuong.Location = new System.Drawing.Point(32, 635);
            this.pnlLuong.Name = "pnlLuong";
            this.pnlLuong.Size = new System.Drawing.Size(1283, 327);
            this.pnlLuong.TabIndex = 31;
            // 
            // lstvLuong
            // 
            this.lstvLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvLuong.HideSelection = false;
            this.lstvLuong.Location = new System.Drawing.Point(20, 51);
            this.lstvLuong.Name = "lstvLuong";
            this.lstvLuong.Size = new System.Drawing.Size(1245, 269);
            this.lstvLuong.TabIndex = 1;
            this.lstvLuong.UseCompatibleStateImageBehavior = false;
            // 
            // lblDSLuong
            // 
            this.lblDSLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDSLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDSLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSLuong.Location = new System.Drawing.Point(0, 0);
            this.lblDSLuong.Name = "lblDSLuong";
            this.lblDSLuong.Size = new System.Drawing.Size(1279, 37);
            this.lblDSLuong.TabIndex = 0;
            this.lblDSLuong.Text = "Danh sách bảng lương";
            this.lblDSLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chartThongKe
            // 
            this.chartThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(163, 77);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "BangLuong";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(1018, 491);
            this.chartThongKe.TabIndex = 32;
            this.chartThongKe.Text = "chart1";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 974);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.pnlLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeHC";
            this.Text = "frmThongKeHC";
            this.Load += new System.EventHandler(this.frmThongKeHC_Load);
            this.pnlLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
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
        private System.Windows.Forms.Panel pnlLuong;
        private System.Windows.Forms.ListView lstvLuong;
        private System.Windows.Forms.Label lblDSLuong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
    }
}