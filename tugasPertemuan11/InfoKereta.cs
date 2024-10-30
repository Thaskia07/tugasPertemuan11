using tugasPertemuan11.Controller;
using System;
using System.Windows.Forms;

namespace tugasPertemuan11.View
{
    public partial class InfoKereta : Form
    {
        private StasiunController stasiunController;

        public InfoKereta()
        {
            InitializeComponent();
            stasiunController = new StasiunController();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Kosongkan jika tidak ada fungsi khusus pada label
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string kodeKereta = txtKodeKereta.Text;
            string namaKereta = txtNamaKereta.Text;
            int kapasitas;
            string kodeKelas = txtKodeKelas.Text;
            decimal harga;

            // Validasi input kapasitas dan harga agar dapat dikonversi
            if (!int.TryParse(txtKapasitas.Text, out kapasitas) || !decimal.TryParse(txtHarga.Text, out harga))
            {
                MessageBox.Show("Pastikan kapasitas dan harga valid.");
                return;
            }

            try
            {
                // Panggil method tambahKereta pada controller
                stasiunController.tambahKereta(kodeKereta, namaKereta, kapasitas, kodeKelas, harga);
                MessageBox.Show("Kereta berhasil ditambahkan!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
