namespace PixelGridEditor
{
    partial class Form1
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
            this.pbGrid = new System.Windows.Forms.PictureBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.rtbExportResult = new System.Windows.Forms.RichTextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.rbBucket = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.chkShowGrid = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGrid
            // 
            this.pbGrid.Location = new System.Drawing.Point(12, 12);
            this.pbGrid.Name = "pbGrid";
            this.pbGrid.Size = new System.Drawing.Size(455, 484);
            this.pbGrid.TabIndex = 0;
            this.pbGrid.TabStop = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(10, 115);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(124, 20);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Luas Area: 0 px²";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(842, 21);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(132, 32);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export ke Array";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // rtbExportResult
            // 
            this.rtbExportResult.Location = new System.Drawing.Point(842, 72);
            this.rtbExportResult.Name = "rtbExportResult";
            this.rtbExportResult.Size = new System.Drawing.Size(163, 179);
            this.rtbExportResult.TabIndex = 3;
            this.rtbExportResult.Text = "";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(14, 71);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(273, 31);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Pilih Warna";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Checked = true;
            this.rbPen.Location = new System.Drawing.Point(6, 36);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(119, 24);
            this.rbPen.TabIndex = 5;
            this.rbPen.TabStop = true;
            this.rbPen.Text = "Mode: Pena";
            this.rbPen.UseVisualStyleBackColor = true;
            // 
            // rbBucket
            // 
            this.rbBucket.AutoSize = true;
            this.rbBucket.Location = new System.Drawing.Point(155, 36);
            this.rbBucket.Name = "rbBucket";
            this.rbBucket.Size = new System.Drawing.Size(132, 24);
            this.rbBucket.TabIndex = 6;
            this.rbBucket.TabStop = true;
            this.rbBucket.Text = "Mode: Bucket";
            this.rbBucket.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(155, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 31);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset Canvas";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(12, 74);
            this.nudWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 26);
            this.nudWidth.TabIndex = 8;
            this.nudWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(12, 42);
            this.nudHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 26);
            this.nudHeight.TabIndex = 9;
            this.nudHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(155, 58);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(147, 31);
            this.btnResize.TabIndex = 10;
            this.btnResize.Text = "Ubah Ukuran Grid";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(14, 34);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(132, 31);
            this.btnUndo.TabIndex = 11;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(14, 84);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(132, 31);
            this.btnSaveImage.TabIndex = 12;
            this.btnSaveImage.Text = "Simpan (.PNG)";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            // 
            // chkShowGrid
            // 
            this.chkShowGrid.AutoSize = true;
            this.chkShowGrid.Checked = true;
            this.chkShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowGrid.Location = new System.Drawing.Point(155, 88);
            this.chkShowGrid.Name = "chkShowGrid";
            this.chkShowGrid.Size = new System.Drawing.Size(149, 24);
            this.chkShowGrid.TabIndex = 13;
            this.chkShowGrid.Text = "Tampilkan Garis";
            this.chkShowGrid.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Controls.Add(this.nudHeight);
            this.groupBox1.Controls.Add(this.nudWidth);
            this.groupBox1.Controls.Add(this.btnResize);
            this.groupBox1.Location = new System.Drawing.Point(491, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 147);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pengaturan Grid";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPen);
            this.groupBox2.Controls.Add(this.rbBucket);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Location = new System.Drawing.Point(491, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 117);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alat Menggambar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUndo);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnSaveImage);
            this.groupBox3.Controls.Add(this.chkShowGrid);
            this.groupBox3.Location = new System.Drawing.Point(491, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 133);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Managemen Canvas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbExportResult);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pbGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGrid;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RichTextBox rtbExportResult;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.RadioButton rbBucket;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.CheckBox chkShowGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

