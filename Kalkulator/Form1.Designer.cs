namespace Kalkulator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblExpression = new System.Windows.Forms.Label();
            this.pnlDisplay.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlDisplay -> panel layar hasil kalkulator (putih polos, seperti kalkulator biasa)
            //
            this.pnlDisplay.BackColor = System.Drawing.Color.White;
            this.pnlDisplay.Controls.Add(this.lblResult);
            this.pnlDisplay.Controls.Add(this.lblExpression);
            this.pnlDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(360, 150);
            this.pnlDisplay.TabIndex = 0;
            //
            // lblExpression -> baris ekspresi kecil (mis. "12 +")
            //
            this.lblExpression.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExpression.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblExpression.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblExpression.Height = 40;
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblResult -> angka hasil utama, font besar, teks hitam khas layar kalkulator
            //
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 38F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(0, 0, 20, 10);
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            this.ClientSize = new System.Drawing.Size(360, 580);
            this.Controls.Add(this.pnlDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkula";
            this.pnlDisplay.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Label lblResult;
    }
}