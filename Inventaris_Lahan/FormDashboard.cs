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
    public partial class FormDashboard : Form
    {
        private string connectionString = "server=localhost;port=3306;database=inventaris_lahan;uid=root;pwd=;"; //menyambungkan ke database
        public FormDashboard()
        {
            InitializeComponent();
            this.Load += FormDashboard_Load;
        }
        private void FormDashboard_Load(object sender, EventArgs e) //memerintahkan mengambil data
        {
            LoadStatistik();
        }
        private void LoadStatistik() //mengambil data dari database MySQL dan menampilkannya di form dashboard
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM Kavling";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            TampilkanStatistik(dt);
        }
        private void TampilkanStatistik(DataTable dt) //menghitung jumlah kavling, kavling tersedia, kavling terjual, dan total luas kavling, kemudian menampilkannya di label dan grafik
        {
            int totalKavling = dt.Rows.Count;
            int tersedia = 0;
            int terjual = 0;
            double totalLuas = 0;
            foreach (DataRow row in dt.Rows)
            {
                string status = row["Status"] != DBNull.Value ? row["Status"].ToString() : "";
                if (status == "Tersedia")
                    tersedia++;
                else
                    terjual++;
                if (row["Luas"] != DBNull.Value)
                {
                    totalLuas += Convert.ToDouble(row["Luas"]);
                }
            }
            lblTotalKavling.Text = "Total Kavling : " + totalKavling;
            lblTersedia.Text = "Kavling Tersedia : " + tersedia;
            lblTerjual.Text = "Kavling Terjual : " + terjual;
            lblTotalLuas.Text = "Total Luas Kavling : " +
                                totalLuas.ToString("N2") + " m²";
            TampilkanGrafik(tersedia, terjual);
        }
        private void TampilkanGrafik(int tersedia, int terjual) //menampilkan grafik pie chart yang menunjukkan persentase kavling tersedia dan terjual
        {
            chartDashboard.Series.Clear();
            Series s = new Series("Status");
            s.ChartType = SeriesChartType.Pie;
            s.Points.AddXY("Tersedia", tersedia);
            s.Points.AddXY("Terjual", terjual);
            s.Points[0].Color = Color.Green;
            s.Points[1].Color = Color.Red;
            chartDashboard.Series.Add(s);
            chartDashboard.Titles.Clear();
            chartDashboard.Titles.Add("Statistik Status Kavling");
        }
    }
}