using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Inventaris_Lahan
{
    public partial class FormKavling : Form
    {
        private string connectionString = "server=localhost;port=3306;database=inventaris_lahan;uid=root;pwd=;";
        private int selectedId = -1;
        private DataTable dtKavling;
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPages = 1;
        private bool formatting = false;
        public FormKavling()
        {
            InitializeComponent();
            InitializeDatabase();
            AttachEvents();
        }
        private void AttachEvents() //menyambungkan event klik tombol dan event lainnya ke metode yang sesuai
        {
            this.Load += FormKavling_Load;
            dgvKavling.CellClick += dgvKavling_CellClick;
            btnTambah.Click += btnTambah_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnHapus.Click += btnHapus_Click;
            btnCari.Click += btnCari_Click;
            btnReset.Click += btnReset_Click;
            txtCariNama.TextChanged += TriggerFilter;
            cmbFilterStatus.SelectedIndexChanged += TriggerFilter;
            nudLuasMin.ValueChanged += TriggerFilter;
            cmbSortBy.SelectedIndexChanged += TriggerFilter;
            rbAsc.CheckedChanged += TriggerFilter;
            rbDesc.CheckedChanged += TriggerFilter;
            btnGrafik.Click += btnGrafik_Click;
            btnPrev.Click += btnPrev_Click;
            btnNext.Click += btnNext_Click;
            cmbBentuk.SelectedIndexChanged += cmbBentuk_SelectedIndexChanged;
            txtPanjang.Enter += txtDimensi_Enter;
            txtPanjang.Leave += txtDimensi_Leave;
        }
        private void InitializeDatabase() //mengetes koneksi ke database MySQL dan menampilkan pesan error jika gagal
        {
            try
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi ke database gagal: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormKavling_Load(object sender, EventArgs e)
        {
            cmbBentuk.SelectedIndex = 0;
            if (cmbFilterStatus.Items.Count > 0) cmbFilterStatus.SelectedIndex = 0;
            if (cmbSortBy.Items.Count > 0) cmbSortBy.SelectedIndex = 0;
            dtpTanggal.Value = DateTime.Now;

            LoadData();
        }
        private void LoadData() //menampilkan data tabel
        {
            dtKavling = new DataTable();
            string searchName = txtCariNama.Text.Trim();
            string statusFilter = cmbFilterStatus.SelectedItem?.ToString() ?? "Semua";
            double luasMin = (double)nudLuasMin.Value;
            string sortByRaw = cmbSortBy.SelectedItem?.ToString() ?? "Nama";
            string[] validSortColumns = { "Nama", "Bentuk", "Luas", "Harga", "Status", "Tanggal" };
            string sortBy = validSortColumns.Contains(sortByRaw) ? sortByRaw : "Nama";
            string sortOrder = rbAsc.Checked ? "ASC" : "DESC";
            string whereClause = " WHERE 1=1 ";
            if (!string.IsNullOrEmpty(searchName)) whereClause += " AND Nama LIKE @search ";
            if (statusFilter != "Semua" && !string.IsNullOrEmpty(statusFilter)) whereClause += " AND Status = @status ";
            if (luasMin > 0) whereClause += " AND Luas >= @minLuas ";
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            string countQuery = "SELECT COUNT(*) FROM Kavling" + whereClause;
            using var countCmd = new MySqlCommand(countQuery, connection);
            if (!string.IsNullOrEmpty(searchName)) countCmd.Parameters.AddWithValue("@search", "%" + searchName + "%");
            if (statusFilter != "Semua" && !string.IsNullOrEmpty(statusFilter)) countCmd.Parameters.AddWithValue("@status", statusFilter);
            if (luasMin > 0) countCmd.Parameters.AddWithValue("@minLuas", luasMin);
            int totalRows = Convert.ToInt32(countCmd.ExecuteScalar());
            totalPages = (int)Math.Ceiling((double)totalRows / pageSize);
            if (totalPages == 0) totalPages = 1;
            if (currentPage > totalPages) currentPage = totalPages;
            int offset = (currentPage - 1) * pageSize;
            string query = $@"
            SELECT Id, Nama, Bentuk, Dimensi, Luas, Status, Harga, Tanggal, Deskripsi
            FROM Kavling
            {whereClause}
            ORDER BY {sortBy} {sortOrder}
            LIMIT @limit OFFSET @offset";
            using var cmd = new MySqlCommand(query, connection);
            if (!string.IsNullOrEmpty(searchName)) cmd.Parameters.AddWithValue("@search", "%" + searchName + "%");
            if (statusFilter != "Semua" && !string.IsNullOrEmpty(statusFilter)) cmd.Parameters.AddWithValue("@status", statusFilter);
            if (luasMin > 0) cmd.Parameters.AddWithValue("@minLuas", luasMin);
            cmd.Parameters.AddWithValue("@limit", pageSize);
            cmd.Parameters.AddWithValue("@offset", offset);
            using var reader = cmd.ExecuteReader();
            dtKavling.Load(reader);
            dgvKavling.AutoGenerateColumns = true;
            dgvKavling.DataSource = dtKavling;
            if (dgvKavling.Columns["Id"] != null) dgvKavling.Columns["Id"].Visible = false;
            if (dgvKavling.Columns["Harga"] != null)
            {
                dgvKavling.Columns["Harga"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");
                dgvKavling.Columns["Harga"].DefaultCellStyle.Format = "C0";
            }
            lblPage.Text = $"Page {currentPage} of {totalPages}";
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            UpdateStatistics();
            TampilkanGrafik();
        }
        private void TriggerFilter(object sender, EventArgs e) //mengetik nama, mengubah filter status
        {
            currentPage = 1;
            LoadData();
        }
        private void btnCari_Click(object sender, EventArgs e) => TriggerFilter(sender, e);
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCariNama.Clear();
            if (cmbFilterStatus.Items.Count > 0) cmbFilterStatus.SelectedIndex = 0;
            nudLuasMin.Value = 0;
            if (cmbSortBy.Items.Count > 0) cmbSortBy.SelectedIndex = 0;
            rbAsc.Checked = true;

            currentPage = 1;
            LoadData();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }
        private void btnTambah_Click(object sender, EventArgs e) //CRUD tambah
        {
            if (!ValidateInput()) return;

            string nama = txtNama.Text.Trim();
            string bentuk = cmbBentuk.SelectedItem.ToString();
            string dimensi = GetDimensiInput();
            double luas = HitungLuas();
            string status = cmbStatus.SelectedItem.ToString();
            double harga = double.Parse(txtHarga.Text.Replace("Rp", "").Replace(".", "").Trim());
            string tanggal = dtpTanggal.Value.ToString("yyyy-MM-dd");
            string deskripsi = txtDeskripsi.Text.Trim();
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var cmdCheck = new MySqlCommand("SELECT COUNT(*) FROM Kavling WHERE Nama = @nama", connection);
            cmdCheck.Parameters.AddWithValue("@nama", nama);
            if (Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Nama kavling sudah ada!", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "INSERT INTO Kavling (Nama, Bentuk, Dimensi, Luas, Status, Harga, Tanggal, Deskripsi) VALUES (@nama, @bentuk, @dimensi, @luas, @status, @harga, @tanggal, @deskripsi)";
            using var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@bentuk", bentuk);
            cmd.Parameters.AddWithValue("@dimensi", dimensi);
            cmd.Parameters.AddWithValue("@luas", luas);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@tanggal", tanggal);
            cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
            cmd.ExecuteNonQuery();
            ClearInputs();
            LoadData();
            MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnUpdate_Click(object sender, EventArgs e) //CRUD ubah
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data yang akan diubah dari tabel terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInput()) return;
            string nama = txtNama.Text.Trim();
            string bentuk = cmbBentuk.SelectedItem.ToString();
            string dimensi = GetDimensiInput();
            double luas = HitungLuas();
            string status = cmbStatus.SelectedItem.ToString();
            double harga = double.Parse(txtHarga.Text.Replace("Rp", "").Replace(".", "").Trim());
            string tanggal = dtpTanggal.Value.ToString("yyyy-MM-dd");
            string deskripsi = txtDeskripsi.Text.Trim();
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var cmdCheck = new MySqlCommand("SELECT COUNT(*) FROM Kavling WHERE Nama = @nama AND Id != @id", connection);
            cmdCheck.Parameters.AddWithValue("@nama", nama);
            cmdCheck.Parameters.AddWithValue("@id", selectedId);
            if (Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Nama kavling sudah digunakan oleh data lain!", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "UPDATE Kavling SET Nama=@nama, Bentuk=@bentuk, Dimensi=@dimensi, Luas=@luas, Status=@status, Harga=@harga, Tanggal=@tanggal, Deskripsi=@deskripsi WHERE Id=@id";
            using var cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@bentuk", bentuk);
            cmd.Parameters.AddWithValue("@dimensi", dimensi);
            cmd.Parameters.AddWithValue("@luas", luas);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@tanggal", tanggal);
            cmd.Parameters.AddWithValue("@deskripsi", deskripsi);
            cmd.Parameters.AddWithValue("@id", selectedId);
            cmd.ExecuteNonQuery();
            ClearInputs();
            selectedId = -1; // Reset selection
            LoadData();
            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnHapus_Click(object sender, EventArgs e) //CRUD hapus
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data yang akan dihapus dari tabel.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using var connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "DELETE FROM Kavling WHERE Id=@id";
                using var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.ExecuteNonQuery();
                ClearInputs();
                selectedId = -1;
                LoadData();
            }
        }
        private void dgvKavling_CellClick(object sender, DataGridViewCellEventArgs e) //menampilkan data yang dipilih dari tabel ke form input
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKavling.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtNama.Text = row.Cells["Nama"].Value.ToString();
                cmbBentuk.SelectedItem = row.Cells["Bentuk"].Value.ToString();
                string dimensi = row.Cells["Dimensi"].Value.ToString();
                switch (cmbBentuk.Text)
                {
                    case "Persegi":
                        txtSisi.Text = dimensi;
                        break;
                    case "Persegi Panjang":
                        string[] data = dimensi.Split(',');
                        if (data.Length == 2)
                        {
                            txtPanjang.Text = data[0];
                            txtLebar.Text = data[1];
                        }
                        break;
                    case "Lingkaran":
                        txtJariJari.Text = dimensi;
                        break;
                }
                txtPanjang.ForeColor = Color.Black;
                cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
                double harga = Convert.ToDouble(row.Cells["Harga"].Value);
                txtHarga.Text = "Rp" + harga.ToString("N0").Replace(",", ".");
                object tgl = row.Cells["Tanggal"].Value;
                if (tgl != DBNull.Value && !string.IsNullOrEmpty(tgl.ToString()))
                    dtpTanggal.Value = DateTime.Parse(tgl.ToString());
                else
                    dtpTanggal.Value = DateTime.Now;

                txtDeskripsi.Text = row.Cells["Deskripsi"].Value?.ToString() ?? "";
            }
        }
        private string GetDimensiInput()
        {
            switch (cmbBentuk.Text)
            {
                case "Persegi": return txtSisi.Text;
                case "Persegi Panjang": return txtPanjang.Text + "," + txtLebar.Text;
                case "Lingkaran": return txtJariJari.Text;
                default: return "";
            }
        }
        private double HitungLuas() //menghitung luas
        {
            switch (cmbBentuk.Text)
            {
                case "Persegi":
                    if (double.TryParse(txtSisi.Text, out double sisi)) return sisi * sisi;
                    break;
                case "Persegi Panjang":
                    if (double.TryParse(txtPanjang.Text, out double p) && double.TryParse(txtLebar.Text, out double l)) return p * l;
                    break;
                case "Lingkaran":
                    if (double.TryParse(txtJariJari.Text, out double r)) return Math.PI * r * r;
                    break;
            }
            return 0;
        }
        private void cmbBentuk_SelectedIndexChanged(object sender, EventArgs e) //menyembunyikan dan menampilkan input dimensi sesuai bentuk yang dipilih
        {
            lblSisi.Visible = txtSisi.Visible = false;
            lblPanjang.Visible = txtPanjang.Visible = false;
            lblLebar.Visible = txtLebar.Visible = false;
            lblJariJari.Visible = txtJariJari.Visible = false;
            switch (cmbBentuk.Text)
            {
                case "Persegi":
                    lblSisi.Visible = txtSisi.Visible = true;
                    break;
                case "Persegi Panjang":
                    lblPanjang.Visible = txtPanjang.Visible = true;
                    lblLebar.Visible = txtLebar.Visible = true;
                    break;
                case "Lingkaran":
                    lblJariJari.Visible = txtJariJari.Visible = true;
                    break;
            }
        }
        private bool ValidateInput() //mengecek input
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama Kavling tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbBentuk.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih bentuk lahan terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            switch (cmbBentuk.Text)
            {
                case "Persegi":
                    if (string.IsNullOrWhiteSpace(txtSisi.Text)) { MessageBox.Show("Masukkan nilai sisi."); return false; }
                    break;
                case "Persegi Panjang":
                    if (string.IsNullOrWhiteSpace(txtPanjang.Text) || string.IsNullOrWhiteSpace(txtLebar.Text) || txtPanjang.Text.StartsWith("Contoh:")) { MessageBox.Show("Masukkan nilai panjang dan lebar dengan benar."); return false; }
                    break;
                case "Lingkaran":
                    if (string.IsNullOrWhiteSpace(txtJariJari.Text)) { MessageBox.Show("Masukkan nilai jari-jari."); return false; }
                    break;
            }
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih status lahan.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string hargaText = txtHarga.Text.Replace("Rp", "").Replace(".", "").Trim();
            if (!double.TryParse(hargaText, out double harga) || harga < 0)
            {
                MessageBox.Show("Harga harus berupa angka dan bernilai positif.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void ClearInputs() //membersihkan kotak input
        {
            txtNama.Clear();
            txtSisi.Clear();
            txtPanjang.Clear();
            txtLebar.Clear();
            txtJariJari.Clear();
            txtHarga.Clear();
            txtDeskripsi.Clear();
            cmbBentuk.SelectedIndex = 0;
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = -1;
            dtpTanggal.Value = DateTime.Now;
        }
        private void txtHarga_TextChanged(object sender, EventArgs e) //otomatis format Rp dan titik
        {
            if (formatting) return;
            formatting = true;

            string angka = txtHarga.Text.Replace("Rp", "").Replace(".", "").Replace(",", "").Trim();
            if (decimal.TryParse(angka, out decimal nilai))
            {
                txtHarga.Text = "Rp" + string.Format("{0:N0}", nilai).Replace(",", ".");
                txtHarga.SelectionStart = txtHarga.Text.Length;
            }
            else if (string.IsNullOrEmpty(angka))
            {
                txtHarga.Text = "";
            }
            formatting = false;
        }
        private void txtDimensi_Enter(object sender, EventArgs e) 
        {
            if (txtPanjang.Text.StartsWith("Contoh:"))
            {
                txtPanjang.Text = "";
                txtPanjang.ForeColor = Color.Black;
            }
        }
        private void txtDimensi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPanjang.Text))
            {
                string bentuk = cmbBentuk.SelectedItem?.ToString();
                if (bentuk == "Persegi") txtPanjang.Text = "Contoh: 5 (sisi)";
                else if (bentuk == "Persegi Panjang") txtPanjang.Text = "Contoh: 4,6 (panjang,lebar)";
                else if (bentuk == "Lingkaran") txtPanjang.Text = "Contoh: 3 (jari-jari)";
                txtPanjang.ForeColor = Color.Gray;
            }
        }
        private void UpdateStatistics() //memperbarui statistik luas kavling
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            string queryTersedia = "SELECT SUM(Luas) FROM Kavling WHERE Status = 'Tersedia'";
            string queryTerjual = "SELECT SUM(Luas) FROM Kavling WHERE Status = 'Terjual'";
            string queryTotal = "SELECT SUM(Luas) FROM Kavling";
            using var cmdTersedia = new MySqlCommand(queryTersedia, connection);
            object resultTersedia = cmdTersedia.ExecuteScalar();
            double totalTersedia = (resultTersedia == DBNull.Value) ? 0 : Convert.ToDouble(resultTersedia);
            using var cmdTerjual = new MySqlCommand(queryTerjual, connection);
            object resultTerjual = cmdTerjual.ExecuteScalar();
            double totalTerjual = (resultTerjual == DBNull.Value) ? 0 : Convert.ToDouble(resultTerjual);
            using var cmdTotal = new MySqlCommand(queryTotal, connection);
            object resultTotal = cmdTotal.ExecuteScalar();
            double totalLuas = (resultTotal == DBNull.Value) ? 0 : Convert.ToDouble(resultTotal);
            lblTotalTersedia.Text = $"Total Luas Tersedia: {totalTersedia:F2} m²";
            lblTotalTerjual.Text = $"Total Luas Terjual: {totalTerjual:F2} m²";
            lblTotalLuas.Text = $"Total Luas Keseluruhan: {totalLuas:F2} m²";
        }
        private void TampilkanGrafik() //menampilkan grafik pie chart
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            string queryTersedia = "SELECT SUM(Luas) FROM Kavling WHERE Status = 'Tersedia'";
            string queryTerjual = "SELECT SUM(Luas) FROM Kavling WHERE Status = 'Terjual'";
            using var cmdTersedia = new MySqlCommand(queryTersedia, connection);
            object resultTersedia = cmdTersedia.ExecuteScalar();
            double totalTersedia = (resultTersedia == DBNull.Value) ? 0 : Convert.ToDouble(resultTersedia);
            using var cmdTerjual = new MySqlCommand(queryTerjual, connection);
            object resultTerjual = cmdTerjual.ExecuteScalar();
            double totalTerjual = (resultTerjual == DBNull.Value) ? 0 : Convert.ToDouble(resultTerjual);
            chartStatistik.Series.Clear();
            var series = new Series("Luas")
            {
                ChartType = SeriesChartType.Pie
            };
            series.Points.AddXY("Tersedia", totalTersedia);
            series.Points.AddXY("Terjual", totalTerjual);
            series.Points[0].Color = Color.Green;
            series.Points[1].Color = Color.Red;
            double total = totalTersedia + totalTerjual;
            series.Points[0].Label = $"{totalTersedia:F2} ({(total > 0 ? (totalTersedia / total * 100).ToString("F1") : "0")}%)";
            series.Points[1].Label = $"{totalTerjual:F2} ({(total > 0 ? (totalTerjual / total * 100).ToString("F1") : "0")}%)";
            chartStatistik.Series.Add(series);
            chartStatistik.Titles.Clear();
            chartStatistik.Titles.Add("Perbandingan Luas Tersedia vs Terjual");
            if (chartStatistik.ChartAreas.Count == 0) chartStatistik.ChartAreas.Add(new ChartArea("ChartArea1"));
            if (chartStatistik.Legends.Count == 0) chartStatistik.Legends.Add(new Legend("Legend1"));
            series.ChartArea = chartStatistik.ChartAreas[0].Name;
            series.Legend = chartStatistik.Legends[0].Name;
        }
        private void btnGrafik_Click(object sender, EventArgs e)
        {
            TampilkanGrafik();
        }
    }
}