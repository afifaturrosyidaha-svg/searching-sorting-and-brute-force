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

namespace Inventaris_Lahan
{
    public partial class FormPetaKavling : Form
    {
        private string connectionString = "server=localhost;port=3306;database=inventaris_lahan;uid=root;pwd=;";
        private int selectedId = -1;
        private DataTable dt;
        public FormPetaKavling()
        {
            InitializeComponent();
            AttachEvents();
        }
        private void AttachEvents()
        {
            this.Load += FormPetaKavling_Load;
            btnTambah.Click += btnTambah_Click;
            btnEdit.Click += btnEdit_Click;
            btnHapus.Click += btnHapus_Click;
            btnRefresh.Click += btnRefresh_Click;
        }
        private void FormPetaKavling_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData() 
        {
            dt = new DataTable();
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = @"SELECT Id, Nama, Bentuk, Luas, Status, Harga FROM Kavling"; //mengambil data MySQL
            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            if (dgvKavling != null) //menampilkan data di DataGridView
            {
                dgvKavling.DataSource = dt;
                if (dgvKavling.Columns["Id"] != null)
                    dgvKavling.Columns["Id"].Visible = false;
            }

            GambarPeta();
        }
        private void GambarPeta()
        {
            while (panelPeta.Controls.Count > 0) //membersihkan panelPeta
            {
                panelPeta.Controls[0].Dispose();
            }
            panelPeta.Controls.Clear();
            int x = 10; //atur ukuran dan posisi
            int y = 10;
            int width = 80;
            int height = 60;
            int kolom = 4;
            for (int i = 0; i < dt.Rows.Count; i++) //menggambar kotak (looping)
            {
                DataRow row = dt.Rows[i]; //tombol baru
                Button btn = new Button
                {
                    Width = width,
                    Height = height,
                    Left = x,
                    Top = y,
                    Text = row["Nama"].ToString(),
                    Tag = row,
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat
                };
                string status = row["Status"].ToString(); //warnai
                if (status == "Tersedia")
                    btn.BackColor = Color.LightGreen;
                else if (status == "Terjual")
                    btn.BackColor = Color.IndianRed;
                else
                    btn.BackColor = Color.Khaki;
                btn.Click += Btn_Click; //pasang fungsi klik dan tampilkan
                panelPeta.Controls.Add(btn);
                x += width + 10;
                if ((i + 1) % kolom == 0)
                {
                    x = 10;
                    y += height + 10;
                }
            }
        }
        private void Btn_Click(object sender, EventArgs e) //klik salah satu kotak lahan dan tampilkan detailnya di MessageBox
        {
            Button btn = sender as Button;
            DataRow row = (DataRow)btn.Tag;
            selectedId = Convert.ToInt32(row["Id"]);
            txtNama.Text = row["Nama"].ToString();
            cmbBentuk.Text = row["Bentuk"].ToString();
            MessageBox.Show(
                $"Nama Kavling: {row["Nama"]}\nBentuk: {row["Bentuk"]}\nStatus: {row["Status"]}\nLuas: {row["Luas"]} m²",
                "Detail Lahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnTambah_Click(object sender, EventArgs e) //menyimpan data baru ke database MySQL
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = @"INSERT INTO Kavling (Nama, Bentuk, Dimensi, Luas, Status, Harga, Tanggal) 
                           VALUES (@nama, @bentuk, @dimensi, @luas, @status, @harga, @tanggal)";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@bentuk", cmbBentuk.Text);
            cmd.Parameters.AddWithValue("@dimensi", "manual");
            cmd.Parameters.AddWithValue("@luas", 0);
            cmd.Parameters.AddWithValue("@status", "Tersedia");
            cmd.Parameters.AddWithValue("@harga", 0);
            cmd.Parameters.AddWithValue("@tanggal", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.ExecuteNonQuery();
            txtNama.Clear();
            LoadData();
        }
        private void btnEdit_Click(object sender, EventArgs e) //mengubah data yang sudah ada di database MySQL
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih kavling dari peta terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = @"UPDATE Kavling SET Nama = @nama, Bentuk = @bentuk WHERE Id = @id";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@bentuk", cmbBentuk.Text);
            cmd.Parameters.AddWithValue("@id", selectedId);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNama.Clear();
            selectedId = -1;
            LoadData();
        }
        private void btnHapus_Click(object sender, EventArgs e) //menghapus data dari database MySQL
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih kavling dari peta terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Yakin ingin menghapus kavling ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using var conn = new MySqlConnection(connectionString);
                conn.Open();
                string sql = "DELETE FROM Kavling WHERE Id=@id";
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.ExecuteNonQuery();
                txtNama.Clear();
                selectedId = -1;
                LoadData();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNama.Clear();
            selectedId = -1;
            LoadData();
        }
    }
}