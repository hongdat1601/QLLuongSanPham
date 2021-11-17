
namespace QLLuongSanPham.GUI.QuanLy
{
    partial class frmThongKeSP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.picNen = new System.Windows.Forms.PictureBox();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlLuong = new System.Windows.Forms.Panel();
            this.lstvLuong = new System.Windows.Forms.ListView();
            this.lblDSLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.pnlLuong.SuspendLayout();
            this.SuspendLayout();
            // 
            // picNen
            // 
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(1327, 974);
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
            this.chartThongKe.Location = new System.Drawing.Point(153, 45);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "BangLuong";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(1018, 491);
            this.chartThongKe.TabIndex = 36;
            this.chartThongKe.Text = "chart1";
            // 
            // pnlLuong
            // 
            this.pnlLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLuong.Controls.Add(this.lstvLuong);
            this.pnlLuong.Controls.Add(this.lblDSLuong);
            this.pnlLuong.Location = new System.Drawing.Point(22, 603);
            this.pnlLuong.Name = "pnlLuong";
            this.pnlLuong.Size = new System.Drawing.Size(1283, 327);
            this.pnlLuong.TabIndex = 35;
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
            // frmThongKeSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 974);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.pnlLuong);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeSP";
            this.Text = "frmThongKeSP";
            this.Load += new System.EventHandler(this.frmThongKeSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.pnlLuong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.Panel pnlLuong;
        private System.Windows.Forms.ListView lstvLuong;
        private System.Windows.Forms.Label lblDSLuong;
    }
}