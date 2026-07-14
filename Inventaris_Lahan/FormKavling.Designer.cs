namespace Inventaris_Lahan
{
    partial class FormKavling
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbBentuk = new System.Windows.Forms.ComboBox();
            this.lblSisi = new System.Windows.Forms.Label();
            this.txtSisi = new System.Windows.Forms.TextBox();
            this.lblPanjang = new System.Windows.Forms.Label();
            this.txtPanjang = new System.Windows.Forms.TextBox();
            this.lblLebar = new System.Windows.Forms.Label();
            this.txtLebar = new System.Windows.Forms.TextBox();
            this.lblJariJari = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.txtJariJari = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.txtCariNama = new System.Windows.Forms.TextBox();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.nudLuasMin = new System.Windows.Forms.NumericUpDown();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvKavling = new System.Windows.Forms.DataGridView();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblTotalTersedia = new System.Windows.Forms.Label();
            this.lblTotalTerjual = new System.Windows.Forms.Label();
            this.lblTotalLuas = new System.Windows.Forms.Label();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.chartStatistik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbAsc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLuasMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKavling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistik)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(110, 20);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(250, 26);
            this.txtNama.TabIndex = 0;
            // 
            // cmbBentuk
            // 
            this.cmbBentuk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBentuk.FormattingEnabled = true;
            this.cmbBentuk.Items.AddRange(new object[] {
            "Persegi",
            "Persegi Panjang",
            "Lingkaran"});
            this.cmbBentuk.Location = new System.Drawing.Point(110, 55);
            this.cmbBentuk.Name = "cmbBentuk";
            this.cmbBentuk.Size = new System.Drawing.Size(250, 28);
            this.cmbBentuk.TabIndex = 1;
            // 
            // lblSisi
            // 
            this.lblSisi.AutoSize = true;
            this.lblSisi.Location = new System.Drawing.Point(20, 92);
            this.lblSisi.Name = "lblSisi";
            this.lblSisi.Size = new System.Drawing.Size(34, 20);
            this.lblSisi.TabIndex = 2;
            this.lblSisi.Text = "Sisi";
            // 
            // txtSisi
            // 
            this.txtSisi.Location = new System.Drawing.Point(110, 89);
            this.txtSisi.Name = "txtSisi";
            this.txtSisi.Size = new System.Drawing.Size(250, 26);
            this.txtSisi.TabIndex = 3;
            // 
            // lblPanjang
            // 
            this.lblPanjang.AutoSize = true;
            this.lblPanjang.Location = new System.Drawing.Point(20, 124);
            this.lblPanjang.Name = "lblPanjang";
            this.lblPanjang.Size = new System.Drawing.Size(67, 20);
            this.lblPanjang.TabIndex = 4;
            this.lblPanjang.Text = "Panjang";
            // 
            // txtPanjang
            // 
            this.txtPanjang.Location = new System.Drawing.Point(110, 121);
            this.txtPanjang.Name = "txtPanjang";
            this.txtPanjang.Size = new System.Drawing.Size(250, 26);
            this.txtPanjang.TabIndex = 5;
            this.txtPanjang.Enter += new System.EventHandler(this.txtDimensi_Enter);
            this.txtPanjang.Leave += new System.EventHandler(this.txtDimensi_Leave);
            // 
            // lblLebar
            // 
            this.lblLebar.AutoSize = true;
            this.lblLebar.Location = new System.Drawing.Point(20, 188);
            this.lblLebar.Name = "lblLebar";
            this.lblLebar.Size = new System.Drawing.Size(50, 20);
            this.lblLebar.TabIndex = 6;
            this.lblLebar.Text = "Lebar";
            // 
            // txtLebar
            // 
            this.txtLebar.Location = new System.Drawing.Point(110, 185);
            this.txtLebar.Name = "txtLebar";
            this.txtLebar.Size = new System.Drawing.Size(250, 26);
            this.txtLebar.TabIndex = 7;
            // 
            // lblJariJari
            // 
            this.lblJariJari.AutoSize = true;
            this.lblJariJari.Location = new System.Drawing.Point(20, 156);
            this.lblJariJari.Name = "lblJariJari";
            this.lblJariJari.Size = new System.Drawing.Size(64, 20);
            this.lblJariJari.TabIndex = 8;
            this.lblJariJari.Text = "Jari-Jari";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(20, 318);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(74, 20);
            this.lblDeskripsi.TabIndex = 9;
            this.lblDeskripsi.Text = "Deskripsi";
            // 
            // txtJariJari
            // 
            this.txtJariJari.Location = new System.Drawing.Point(110, 153);
            this.txtJariJari.Name = "txtJariJari";
            this.txtJariJari.Size = new System.Drawing.Size(250, 26);
            this.txtJariJari.TabIndex = 10;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(110, 251);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(250, 26);
            this.txtHarga.TabIndex = 11;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(110, 315);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(330, 80);
            this.txtDeskripsi.TabIndex = 12;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Tersedia",
            "Terjual"});
            this.cmbStatus.Location = new System.Drawing.Point(110, 217);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(250, 28);
            this.cmbStatus.TabIndex = 13;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggal.Location = new System.Drawing.Point(110, 283);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(250, 26);
            this.dtpTanggal.TabIndex = 14;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(20, 425);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 30);
            this.btnTambah.TabIndex = 15;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(126, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(232, 425);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 30);
            this.btnHapus.TabIndex = 17;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txtCariNama
            // 
            this.txtCariNama.Location = new System.Drawing.Point(580, 17);
            this.txtCariNama.Name = "txtCariNama";
            this.txtCariNama.Size = new System.Drawing.Size(200, 26);
            this.txtCariNama.TabIndex = 18;
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "Semua",
            "Tersedia",
            "Terjual"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(580, 49);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(200, 28);
            this.cmbFilterStatus.TabIndex = 19;
            // 
            // nudLuasMin
            // 
            this.nudLuasMin.Location = new System.Drawing.Point(580, 83);
            this.nudLuasMin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLuasMin.Name = "nudLuasMin";
            this.nudLuasMin.Size = new System.Drawing.Size(200, 26);
            this.nudLuasMin.TabIndex = 20;
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Items.AddRange(new object[] {
            "Nama",
            "Luas",
            "Harga",
            "Tanggal"});
            this.cmbSortBy.Location = new System.Drawing.Point(580, 116);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(200, 28);
            this.cmbSortBy.TabIndex = 21;
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.Location = new System.Drawing.Point(580, 187);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(119, 24);
            this.rbDesc.TabIndex = 22;
            this.rbDesc.Text = "Descending";
            this.rbDesc.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(580, 244);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(90, 30);
            this.btnCari.TabIndex = 23;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(690, 244);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 30);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // dgvKavling
            // 
            this.dgvKavling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKavling.Location = new System.Drawing.Point(20, 471);
            this.dgvKavling.Name = "dgvKavling";
            this.dgvKavling.RowHeadersWidth = 62;
            this.dgvKavling.RowTemplate.Height = 28;
            this.dgvKavling.Size = new System.Drawing.Size(1232, 263);
            this.dgvKavling.TabIndex = 25;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(803, 425);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(138, 30);
            this.btnPrev.TabIndex = 26;
            this.btnPrev.Text = "◀ Sebelumnya";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1043, 425);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 30);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "Selanjutnya ▶";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(947, 430);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(90, 20);
            this.lblPage.TabIndex = 28;
            this.lblPage.Text = "Page 1 of 1";
            // 
            // lblTotalTersedia
            // 
            this.lblTotalTersedia.AutoSize = true;
            this.lblTotalTersedia.Location = new System.Drawing.Point(920, 265);
            this.lblTotalTersedia.Name = "lblTotalTersedia";
            this.lblTotalTersedia.Size = new System.Drawing.Size(165, 20);
            this.lblTotalTersedia.TabIndex = 29;
            this.lblTotalTersedia.Text = "Total Luas Tersedia: 0";
            // 
            // lblTotalTerjual
            // 
            this.lblTotalTerjual.AutoSize = true;
            this.lblTotalTerjual.Location = new System.Drawing.Point(920, 288);
            this.lblTotalTerjual.Name = "lblTotalTerjual";
            this.lblTotalTerjual.Size = new System.Drawing.Size(151, 20);
            this.lblTotalTerjual.TabIndex = 30;
            this.lblTotalTerjual.Text = "Total Luas Terjual: 0";
            // 
            // lblTotalLuas
            // 
            this.lblTotalLuas.AutoSize = true;
            this.lblTotalLuas.Location = new System.Drawing.Point(920, 311);
            this.lblTotalLuas.Name = "lblTotalLuas";
            this.lblTotalLuas.Size = new System.Drawing.Size(193, 20);
            this.lblTotalLuas.TabIndex = 31;
            this.lblTotalLuas.Text = "Total Luas Keseluruhan: 0";
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(920, 340);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(140, 30);
            this.btnGrafik.TabIndex = 32;
            this.btnGrafik.Text = "Tampilkan Grafik";
            this.btnGrafik.UseVisualStyleBackColor = true;
            // 
            // chartStatistik
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistik.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistik.Legends.Add(legend1);
            this.chartStatistik.Location = new System.Drawing.Point(924, 12);
            this.chartStatistik.Name = "chartStatistik";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStatistik.Series.Add(series1);
            this.chartStatistik.Size = new System.Drawing.Size(423, 240);
            this.chartStatistik.TabIndex = 33;
            this.chartStatistik.Text = "chart1";
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.Checked = true;
            this.rbAsc.Location = new System.Drawing.Point(580, 156);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(109, 24);
            this.rbAsc.TabIndex = 41;
            this.rbAsc.TabStop = true;
            this.rbAsc.Text = "Ascending";
            this.rbAsc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Bentuk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Tanggal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Cari Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Filter Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Luas Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "Urutkan";
            // 
            // FormKavling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 746);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbAsc);
            this.Controls.Add(this.chartStatistik);
            this.Controls.Add(this.btnGrafik);
            this.Controls.Add(this.lblTotalLuas);
            this.Controls.Add(this.lblTotalTerjual);
            this.Controls.Add(this.lblTotalTersedia);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.dgvKavling);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.rbDesc);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.nudLuasMin);
            this.Controls.Add(this.cmbFilterStatus);
            this.Controls.Add(this.txtCariNama);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtJariJari);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.lblJariJari);
            this.Controls.Add(this.txtLebar);
            this.Controls.Add(this.lblLebar);
            this.Controls.Add(this.txtPanjang);
            this.Controls.Add(this.lblPanjang);
            this.Controls.Add(this.txtSisi);
            this.Controls.Add(this.lblSisi);
            this.Controls.Add(this.cmbBentuk);
            this.Controls.Add(this.txtNama);
            this.Name = "FormKavling";
            this.Text = "FormKavling";
            ((System.ComponentModel.ISupportInitialize)(this.nudLuasMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKavling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbBentuk;
        private System.Windows.Forms.Label lblSisi;
        private System.Windows.Forms.TextBox txtSisi;
        private System.Windows.Forms.Label lblPanjang;
        private System.Windows.Forms.TextBox txtPanjang;
        private System.Windows.Forms.Label lblLebar;
        private System.Windows.Forms.TextBox txtLebar;
        private System.Windows.Forms.Label lblJariJari;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtJariJari;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox txtCariNama;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.NumericUpDown nudLuasMin;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.RadioButton rbDesc;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvKavling;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblTotalTersedia;
        private System.Windows.Forms.Label lblTotalTerjual;
        private System.Windows.Forms.Label lblTotalLuas;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistik;
        private System.Windows.Forms.RadioButton rbAsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}