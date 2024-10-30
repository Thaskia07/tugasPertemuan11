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
    public partial class Penumpang : Form
    {
        private StasiunController stasiunController;
        
        public Penumpang()
        {
            stasiunController = new StasiunController();
            InitializeComponent();
        }


        private void Penumpang_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void tampil()
        {
            tampilPenumpang.DataSource = stasiunController.tampilPenumpang();
            tampilPenumpang.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InfoPenumpang infoPenumpang = new InfoPenumpang();
            infoPenumpang.Show();
            this.Hide();
        }
    }
}
