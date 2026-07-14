using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventaris_Lahan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            lblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lblJam.Text = DateTime.Now.ToString("HH:mm:ss");
            timerJam.Start();
            timerJam.Tick += timerJam_Tick;
            Button[] tombols = { btnDataKavling, btnDashboard, btnPeta, btnKeluar };
            foreach (Button btn in tombols)
            {
                btn.Width = 200;
                btn.Location = new Point(311, btn.Location.Y);
            }
            Label[] labels = { lblTanggal, lblJam };
            foreach (Label lbl in labels)
            {
                lbl.AutoSize = false;
                lbl.Width = 300;
                lbl.Height = 35;
                lbl.Location = new Point(261, lbl.Location.Y);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            using (FormDashboard dashboard = new FormDashboard())
            {
                dashboard.ShowDialog();
            }
        }
        private void btnDataKavling_Click(object sender, EventArgs e)
        {
            using (FormKavling frm = new FormKavling())
            {
                frm.ShowDialog();
            }
        }
        private void btnPeta_Click(object sender, EventArgs e)
        {
            using (FormPetaKavling frm = new FormPetaKavling())
            {
                frm.ShowDialog();
            }
        }
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
                "Apakah Anda yakin ingin keluar?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void timerJam_Tick(object sender, EventArgs e)
        {
            lblJam.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}