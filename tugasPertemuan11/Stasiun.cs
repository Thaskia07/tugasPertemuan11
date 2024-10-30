using tugasPertemuan11.Controller;
using tugasPertemuan11.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasPertemuan11
{
    public partial class Stasiun : Form
    {
        private StasiunController stasiunController;

        public Stasiun()
        {
            stasiunController = new StasiunController();
            InitializeComponent();
        }

        private void Stasiun_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void tampil()
        {
            tampilStasiun.DataSource = stasiunController.tampilStasiun();
            tampilStasiun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InfoStasiun infoStasiun = new InfoStasiun();

            // Gunakan ShowDialog agar form Stasiun tetap berada di belakang dan form InfoStasiun tampil di depan
            infoStasiun.ShowDialog();

            // Refresh data di form Stasiun setelah form InfoStasiun ditutup
            tampil();
        }
    }
}
