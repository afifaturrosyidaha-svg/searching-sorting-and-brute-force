namespace Inventaris_Lahan
{
    partial class FormPetaKavling
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
            this.timerJam = new System.Windows.Forms.Timer(this.components);
            this.dgvKavling = new System.Windows.Forms.DataGridView();
            this.panelPeta = new System.Windows.Forms.Panel();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbBentuk = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKavling)).BeginInit();
            this.SuspendLayout();
            // 
            // timerJam
            // 
            this.timerJam.Interval = 1000;
            // 
            // dgvKavling
            // 
            this.dgvKavling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKavling.Location = new System.Drawing.Point(20, 20);
            this.dgvKavling.Name = "dgvKavling";
            this.dgvKavling.RowHeadersWidth = 62;
            this.dgvKavling.RowTemplate.Height = 28;
            this.dgvKavling.Size = new System.Drawing.Size(811, 200);
            this.dgvKavling.TabIndex = 0;
            // 
            // panelPeta
            // 
            this.panelPeta.AutoScroll = true;
            this.panelPeta.Location = new System.Drawing.Point(20, 240);
            this.panelPeta.Name = "panelPeta";
            this.panelPeta.Size = new System.Drawing.Size(940, 380);
            this.panelPeta.TabIndex = 1;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(851, 20);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 26);
            this.txtNama.TabIndex = 2;
            // 
            // cmbBentuk
            // 
            this.cmbBentuk.FormattingEnabled = true;
            this.cmbBentuk.Location = new System.Drawing.Point(851, 52);
            this.cmbBentuk.Name = "cmbBentuk";
            this.cmbBentuk.Size = new System.Drawing.Size(200, 28);
            this.cmbBentuk.TabIndex = 3;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(851, 90);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(90, 30);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(962, 90);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(851, 130);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 30);
            this.btnHapus.TabIndex = 6;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(962, 130);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormPetaKavling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 646);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.cmbBentuk);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.panelPeta);
            this.Controls.Add(this.dgvKavling);
            this.Name = "FormPetaKavling";
            this.Text = "FormPetaKavling";
            this.Load += new System.EventHandler(this.FormPetaKavling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKavling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerJam;
        private System.Windows.Forms.DataGridView dgvKavling;
        private System.Windows.Forms.Panel panelPeta;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbBentuk;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
    }
}