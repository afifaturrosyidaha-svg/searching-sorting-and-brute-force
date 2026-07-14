namespace Inventaris_Lahan
{
    partial class FormDashboard
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
            this.lblTotalKavling = new System.Windows.Forms.Label();
            this.lblTersedia = new System.Windows.Forms.Label();
            this.lblTerjual = new System.Windows.Forms.Label();
            this.lblTotalLuas = new System.Windows.Forms.Label();
            this.chartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalKavling
            // 
            this.lblTotalKavling.AutoSize = true;
            this.lblTotalKavling.Location = new System.Drawing.Point(366, 28);
            this.lblTotalKavling.Name = "lblTotalKavling";
            this.lblTotalKavling.Size = new System.Drawing.Size(119, 20);
            this.lblTotalKavling.TabIndex = 0;
            this.lblTotalKavling.Text = "Total Kavling : 0";
            // 
            // lblTersedia
            // 
            this.lblTersedia.AutoSize = true;
            this.lblTersedia.Location = new System.Drawing.Point(366, 60);
            this.lblTersedia.Name = "lblTersedia";
            this.lblTersedia.Size = new System.Drawing.Size(145, 20);
            this.lblTersedia.TabIndex = 1;
            this.lblTersedia.Text = "Kavling Tersedia : 0";
            // 
            // lblTerjual
            // 
            this.lblTerjual.AutoSize = true;
            this.lblTerjual.Location = new System.Drawing.Point(366, 93);
            this.lblTerjual.Name = "lblTerjual";
            this.lblTerjual.Size = new System.Drawing.Size(131, 20);
            this.lblTerjual.TabIndex = 2;
            this.lblTerjual.Text = "Kavling Terjual : 0";
            // 
            // lblTotalLuas
            // 
            this.lblTotalLuas.AutoSize = true;
            this.lblTotalLuas.Location = new System.Drawing.Point(366, 123);
            this.lblTotalLuas.Name = "lblTotalLuas";
            this.lblTotalLuas.Size = new System.Drawing.Size(180, 20);
            this.lblTotalLuas.TabIndex = 3;
            this.lblTotalLuas.Text = "Total Luas Kavling : 0 m²";
            // 
            // chartDashboard
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDashboard.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDashboard.Legends.Add(legend1);
            this.chartDashboard.Location = new System.Drawing.Point(34, 28);
            this.chartDashboard.Name = "chartDashboard";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDashboard.Series.Add(series1);
            this.chartDashboard.Size = new System.Drawing.Size(300, 300);
            this.chartDashboard.TabIndex = 4;
            this.chartDashboard.Text = "chart1";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartDashboard);
            this.Controls.Add(this.lblTotalLuas);
            this.Controls.Add(this.lblTerjual);
            this.Controls.Add(this.lblTersedia);
            this.Controls.Add(this.lblTotalKavling);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalKavling;
        private System.Windows.Forms.Label lblTersedia;
        private System.Windows.Forms.Label lblTerjual;
        private System.Windows.Forms.Label lblTotalLuas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard;
    }
}