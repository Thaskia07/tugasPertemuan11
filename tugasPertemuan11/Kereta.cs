using System;
using System.Windows.Forms;
using tugasPertemuan11.Controller;

namespace tugasPertemuan11.View
{
    public partial class Kereta : Form
    {
        private StasiunController stasiunController;

        public Kereta()
        {
            InitializeComponent();
            stasiunController = new StasiunController();
        }

        private void Kereta_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void tampil()
        {
            try
            {
                tampilKereta.DataSource = stasiunController.tampilKereta(); // Mendapatkan data kereta dari controller
                tampilKereta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Menyesuaikan lebar kolom
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data kereta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoKereta infoKereta = new InfoKereta();
            if (infoKereta.ShowDialog() == DialogResult.OK) // Menggunakan ShowDialog agar form ini tidak ditutup
            {
                tampil(); // Menampilkan kembali data setelah menambahkan kereta
            }
        }
    }
}
