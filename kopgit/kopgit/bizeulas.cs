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
    public partial class bizeulas : Form
    {
        public bizeulas()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            login lgn = new login();
            lgn.Show();
            this.Hide();
        }

        private void bizeulas_Load(object sender, EventArgs e)
        {

        }
    }
}
