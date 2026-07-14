namespace Inventaris_Lahan
{
    partial class FormMain
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
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.timerJam = new System.Windows.Forms.Timer(this.components);
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnDataKavling = new System.Windows.Forms.Button();
            this.btnPeta = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(136, 40);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(51, 20);
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "label1";
            // 
            // lblJam
            // 
            this.lblJam.AutoSize = true;
            this.lblJam.Location = new System.Drawing.Point(136, 78);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(51, 20);
            this.lblJam.TabIndex = 1;
            this.lblJam.Text = "label2";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(62, 180);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 40);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnDataKavling
            // 
            this.btnDataKavling.Location = new System.Drawing.Point(62, 134);
            this.btnDataKavling.Name = "btnDataKavling";
            this.btnDataKavling.Size = new System.Drawing.Size(200, 40);
            this.btnDataKavling.TabIndex = 3;
            this.btnDataKavling.Text = "Data Kavling";
            this.btnDataKavling.UseVisualStyleBackColor = true;
            this.btnDataKavling.Click += new System.EventHandler(this.btnDataKavling_Click);
            // 
            // btnPeta
            // 
            this.btnPeta.Location = new System.Drawing.Point(62, 226);
            this.btnPeta.Name = "btnPeta";
            this.btnPeta.Size = new System.Drawing.Size(200, 40);
            this.btnPeta.TabIndex = 4;
            this.btnPeta.Text = "Peta Kavling";
            this.btnPeta.UseVisualStyleBackColor = true;
            this.btnPeta.Click += new System.EventHandler(this.btnPeta_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(62, 272);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(200, 40);
            this.btnKeluar.TabIndex = 5;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 507);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnPeta);
            this.Controls.Add(this.btnDataKavling);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblJam);
            this.Controls.Add(this.lblTanggal);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Timer timerJam;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnDataKavling;
        private System.Windows.Forms.Button btnPeta;
        private System.Windows.Forms.Button btnKeluar;
    }
}