using System;
using System.Windows.Forms;
using tugasPertemuan11.Controller;

namespace tugasPertemuan11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            StasiunController adminController = new StasiunController();
            try
            {
                adminController.tambahUser(txtId.Text, txtUser.Text, txtPass.Text);
                MessageBox.Show("Pengguna baru berhasil ditambahkan", "Tambah Pengguna",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtId.Clear(); 
                txtUser.Clear();
                txtPass.Clear();
                txtId.Focus();
                Informasi informasi = new Informasi();
                informasi.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah pengguna gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            StasiunController adminController = new StasiunController();
            string username = txtUser.Text;
            string password = txtPass.Text;

            try
            {
                bool isAuthenticated = adminController.SignInUser(username, password);

                if (isAuthenticated)
                {
                    MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Informasi formInformasi = new Informasi();
                    formInformasi.ShowDialog();
                    Informasi informasi = new Informasi();
                    informasi.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
