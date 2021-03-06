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
    public partial class Login : Form
    {
         
        public Login()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == ""  && tbPassword.Text == "pbo123")
            {
                MessageBox.Show("Kamu Berhasil Login!");
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();



            }
            else if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Kamu belum mengisi form login");
            }
            else
            {
                MessageBox.Show("Username atau Password Salah ");
            }
            
        }
    }
}
