
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlLuong = new System.Windows.Forms.Panel();
            this.lstvLuong = new System.Windows.Forms.ListView();
            this.lblDSLuong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblChenhLech = new System.Windows.Forms.Label();
            this.lblTrungBinh = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picNen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.pnlLuong.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).BeginInit();
            this.SuspendLayout();
            // 
            // chartThongKe
            // 
            this.chartThongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(721, 82);
            this.chartThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "BangLuong";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(659, 482);
            this.chartThongKe.TabIndex = 34;
            this.chartThongKe.Text = "chart";
            // 
            // pnlLuong
            // 
            this.pnlLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLuong.Controls.Add(this.lstvLuong);
            this.pnlLuong.Controls.Add(this.lblDSLuong);
            this.pnlLuong.Location = new System.Drawing.Point(32, 82);
            this.pnlLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLuong.Name = "pnlLuong";
            this.pnlLuong.Size = new System.Drawing.Size(636, 858);
            this.pnlLuong.TabIndex = 33;
            // 
            // lstvLuong
            // 
            this.lstvLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvLuong.HideSelection = false;
            this.lstvLuong.Location = new System.Drawing.Point(21, 50);
            this.lstvLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstvLuong.Name = "lstvLuong";
            this.lstvLuong.Size = new System.Drawing.Size(587, 786);
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
            this.lblDSLuong.Size = new System.Drawing.Size(632, 37);
            this.lblDSLuong.TabIndex = 0;
            this.lblDSLuong.Text = "Danh sách bảng lương";
            this.lblDSLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Controls.Add(this.lblMax);
            this.panel1.Controls.Add(this.lblChenhLech);
            this.panel1.Controls.Add(this.lblTrungBinh);
            this.panel1.Controls.Add(this.lblTong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(721, 632);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 308);
            this.panel1.TabIndex = 35;
            // 
            // lblMin
            // 
            this.lblMin.BackColor = System.Drawing.Color.White;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(184, 243);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(425, 32);
            this.lblMin.TabIndex = 1;
            // 
            // lblMax
            // 
            this.lblMax.BackColor = System.Drawing.Color.White;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(184, 188);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(425, 32);
            this.lblMax.TabIndex = 1;
            // 
            // lblChenhLech
            // 
            this.lblChenhLech.BackColor = System.Drawing.Color.White;
            this.lblChenhLech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChenhLech.Location = new System.Drawing.Point(184, 136);
            this.lblChenhLech.Name = "lblChenhLech";
            this.lblChenhLech.Size = new System.Drawing.Size(425, 32);
            this.lblChenhLech.TabIndex = 1;
            // 
            // lblTrungBinh
            // 
            this.lblTrungBinh.BackColor = System.Drawing.Color.White;
            this.lblTrungBinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrungBinh.Location = new System.Drawing.Point(184, 81);
            this.lblTrungBinh.Name = "lblTrungBinh";
            this.lblTrungBinh.Size = new System.Drawing.Size(425, 32);
            this.lblTrungBinh.TabIndex = 1;
            // 
            // lblTong
            // 
            this.lblTong.BackColor = System.Drawing.Color.White;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(184, 28);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(425, 32);
            this.lblTong.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thấp nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lớn nhất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chênh lệch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng cộng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trung bình";
            // 
            // cboNam
            // 
            this.cboNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "Tất cả"});
            this.cboNam.Location = new System.Drawing.Point(477, 31);
            this.cboNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(189, 33);
            this.cboNam.TabIndex = 38;
            this.cboNam.Text = "Tất cả";
            this.cboNam.SelectedIndexChanged += new System.EventHandler(this.cboNam_SelectedIndexChanged);
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "Tất cả",
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cboThang.Location = new System.Drawing.Point(123, 31);
            this.cboThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(189, 33);
            this.cboThang.TabIndex = 39;
            this.cboThang.Text = "Tất cả";
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(385, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(218)))), ((int)(((byte)(161)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tháng";
            // 
            // picNen
            // 
            this.picNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNen.Image = global::QLLuongSanPham.Properties.Resources.back3;
            this.picNen.Location = new System.Drawing.Point(0, 0);
            this.picNen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picNen.Name = "picNen";
            this.picNen.Size = new System.Drawing.Size(1415, 974);
            this.picNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNen.TabIndex = 0;
            this.picNen.TabStop = false;
            // 
            // frmThongKeHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1415, 974);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.pnlLuong);
            this.Controls.Add(this.picNen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKeHC";
            this.Text = "frmThongKeHC";
            this.Load += new System.EventHandler(this.frmThongKeHC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.pnlLuong.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picNen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.Panel pnlLuong;
        private System.Windows.Forms.ListView lstvLuong;
        private System.Windows.Forms.Label lblDSLuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblChenhLech;
        private System.Windows.Forms.Label lblTrungBinh;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label label7;
    }
}