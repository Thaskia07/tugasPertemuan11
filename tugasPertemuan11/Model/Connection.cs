using System;
using System.Data;
using MySql.Data.MySqlClient; // Pastikan hanya MySql.Data.MySqlClient yang digunakan
using System.Windows.Forms;

namespace tugasPertemuan11.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public MySqlDataAdapter da;
        public DataSet ds;

        // Membuat method GetConn untuk mengatur koneksi database
        public MySqlConnection GetConn()
        {
            var conn = new MySqlConnection("server=localhost;user=root;database=pt_kai");

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return conn;
        }
    }
}
