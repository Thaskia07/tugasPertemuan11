using System;
using System.Windows.Forms;
using tugasPertemuan11.View;

namespace tugasPertemuan11
{
    public partial class Informasi : Form
    {
        public Informasi()
        {
            InitializeComponent();
        }

        private void btnKereta_Click(object sender, EventArgs e)
        {
            // Membuka form Kereta dan menyembunyikan form Informasi
            InfoKereta kereta = new InfoKereta(); // Pastikan kelasnya bernama `InfoKereta`
            kereta.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Membuka form Penumpang
            InfoPenumpang penumpang = new InfoPenumpang(); // Pastikan kelasnya bernama `InfoPenumpang`
            penumpang.ShowDialog();
        }

        private void btnStasiun_Click(object sender, EventArgs e)
        {
            // Membuka form Stasiun
            InfoStasiun stasiun = new InfoStasiun(); // Pastikan kelasnya bernama `InfoStasiun`
            stasiun.ShowDialog();
        }
    }
}
