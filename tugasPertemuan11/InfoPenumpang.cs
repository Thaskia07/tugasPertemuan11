using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tugasPertemuan11.Controller;

namespace tugasPertemuan11
{
    public partial class InfoPenumpang : Form
    {
        private StasiunController stasiunController;
        public InfoPenumpang()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StasiunController = new StasiunController();    
            StasiunController.tambahPenumpang(txtIdPenumpang.Text, txtNama.Text, txtTanggal.Text, txtAlamat.Text, txtJenisKelamin.Text, txtNoHp.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtNama.Focus();

            MessageBox.Show("penumpang berhasil ditambahkan");

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
