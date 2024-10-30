using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using tugasPertemuan11.Model;

namespace tugasPertemuan11.Controller
{
    internal class StasiunController : Connection
    {
        public DataTable tampilKereta()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = GetConn())
                {
                    conn.Open();
                    string query = "SELECT * FROM Kereta";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data kereta: " + ex.Message);
            }
            return dt;
        }

        public void tambahUser(string id, string username, string password)
        {
            try
            {
                using (var conn = GetConn())
                {
                    conn.Open();
                    string query = "INSERT INTO ADMIN (id, username, password) VALUES (@id, @username, @password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data user berhasil ditambahkan");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool SignInUser(string username, string password)
        {
            bool isUserExist = false;
            try
            {
                using (var conn = GetConn())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM ADMIN WHERE username = @username AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                        isUserExist = userCount > 0;
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Login gagal: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isUserExist;
        }

        public void tambahKereta(string kodeKereta, string namaKereta, int kapasitas, string kodeKelas, decimal harga)
        {
            try
            {
                using (var conn = GetConn())
                {
                    conn.Open();
                    string query = "INSERT INTO Kereta (kode_kereta, nama_kereta, kapasitas, kode_kelas, harga) VALUES (@kodeKereta, @namaKereta, @kapasitas, @kodeKelas, @harga)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kodeKereta", kodeKereta);
                        cmd.Parameters.AddWithValue("@namaKereta", namaKereta);
                        cmd.Parameters.AddWithValue("@kapasitas", kapasitas);
                        cmd.Parameters.AddWithValue("@kodeKelas", kodeKelas);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data kereta berhasil ditambahkan.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data kereta: " + ex.Message);
            }
        }

        public DataTable tampilStasiun()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = GetConn())
                {
                    conn.Open();
                    string tampil = "SELECT * FROM Stasiun";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(tampil, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data stasiun: " + ex.Message);
            }
            return dt;
        }

        public void tambahStasiun(string kode, string nama, string kota)
        {
            string query = "INSERT INTO Stasiun (kode_stasiun, nama_stasiun, kota) VALUES (@kode_stasiun, @nama_stasiun, @kota)";
            try
            {
                using (var conn = GetConn())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode_stasiun", kode);
                        cmd.Parameters.AddWithValue("@nama_stasiun", nama);
                        cmd.Parameters.AddWithValue("@kota", kota);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data stasiun berhasil ditambahkan.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah stasiun gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable tampilPenumpang()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = GetConn())
                {
                    conn.Open();
                    string tampil = "SELECT * FROM Penumpang";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(tampil, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data penumpang: " + ex.Message);
            }
            return dt;
        }

        public void tambahPenumpang(string nama, string ttl, string alamat, string jenis_kelamin, string no_hp)
        {
            string tambah = "INSERT INTO Penumpang (nama, tgl_lahir, alamat, jenis_kelamin, no_hp) VALUES (@nama, @tgl_lahir, @alamat, @jenis_kelamin, @no_hp)";
            try
            {
                using (var conn = GetConn())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(tambah, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@tgl_lahir", ttl);
                        cmd.Parameters.AddWithValue("@alamat", alamat);
                        cmd.Parameters.AddWithValue("@jenis_kelamin", jenis_kelamin);
                        cmd.Parameters.AddWithValue("@no_hp", no_hp);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tambah penumpang berhasil!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah penumpang gagal: " + ex.Message);
            }
        }
    }
}
