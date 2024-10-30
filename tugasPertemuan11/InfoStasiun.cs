using tugasPertemuan11.Controller;
using System;
using System.Windows.Forms;

namespace tugasPertemuan11.View
{
    public partial class InfoStasiun : Form
    {
        private StasiunController stasiunController;

        public InfoStasiun()
        {
            InitializeComponent();
            stasiunController = new StasiunController(); // Inisialisasi controller di constructor
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validasi input sebelum disimpan
            if (string.IsNullOrWhiteSpace(txtKodeStasiun.Text) ||
                string.IsNullOrWhiteSpace(txtNamaStasiun.Text) ||
                string.IsNullOrWhiteSpace(txtKota.Text))
            {
                MessageBox.Show("Harap lengkapi semua data stasiun.");
                return;
            }

            // Menyimpan data stasiun baru
            stasiunController.tambahStasiun(txtKodeStasiun.Text, txtNamaStasiun.Text, txtKota.Text);

            // Membersihkan input field setelah berhasil disimpan
            txtKodeStasiun.Clear();
            txtNamaStasiun.Clear();
            txtKota.Clear();
            txtKodeStasiun.Focus(); // Fokus kembali ke input pertama

            MessageBox.Show("Stasiun berhasil ditambahkan");

            // Navigasi kembali ke form utama jika diperlukan
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
