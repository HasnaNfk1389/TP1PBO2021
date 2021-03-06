using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPraktikum_1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNamaBarang_Click(object sender, EventArgs e)
        {

        }

        private void tbNamaBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTanggal_Click(object sender, EventArgs e)
        {

        }

        private void tbTanggal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHarga_Click(object sender, EventArgs e)
        {

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            tbNama.Clear();
            tbNamaBarang.Clear();
            tbTanggal.Clear();
            tbHarga.Clear();
            lblJumlahBayar.Text = "Rp."; 
        }

        private void tbHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            menuUtama menuUtama = new menuUtama();
            menuUtama.nama = Convert.ToString(tbNama.Text);
            menuUtama.namaBarang = Convert.ToString(tbNamaBarang.Text);
            menuUtama.tanggal = Convert.ToString(tbTanggal.Text);
            menuUtama.harga = Convert.ToString(tbHarga.Text);

            pembayaran pembayaran = new pembayaran();
            menuUtama.totalBayar = pembayaran.HitungBayar(menuUtama);

            lblJumlahBayar.Text = "Rp." + Convert.ToString(menuUtama.harga);

        }

        private void lblJumlahBayar_Click(object sender, EventArgs e)
        {

        }

        private void tbjmlBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            string message = "Terimakasih " + tbNama.Text + " telah membayar sebanyak " + lblJumlahBayar.Text;
            MessageBox.Show(message);
            tbNama.Enabled = false;
            tbNamaBarang.Enabled = false;
            tbTanggal.Enabled = false;
            tbHarga.Enabled = false;
            btnHitung.Enabled = false;
            btnBayar.Enabled = false;
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            tbNama.Clear();
            tbNamaBarang.Clear();
            tbTanggal.Clear();
            tbHarga.Clear();
            lblJumlahBayar.Text = "Rp.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
