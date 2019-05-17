using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kopgit
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris grs = new giris();
            grs.Show();
            this.Hide();

        }

        private void btnhesabim_Click(object sender, EventArgs e)
        {
            hesabim hsbm = new hesabim();
            hsbm.Show();
            this.Hide();

        }

        private void btnuyeol_Click(object sender, EventArgs e)
        {
            uyeol uye = new uyeol();
            uye.Show();
            this.Hide();
        }

        private void btnulas_Click(object sender, EventArgs e)
        {
            bizeulas ulas = new bizeulas();
            ulas.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
