using anaekran;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kopgit
{
   

    public partial class hesabim : Form
    {
        DataTable dt = new DataTable();

        public hesabim()
        {
            InitializeComponent();
        }
        

        private void btnuyeol_Click(object sender, EventArgs e)
        {
            uyeol uye = new uyeol();
            uye.Show();
            this.Hide();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            
            Service_Eu Service_Eu_ = new Service_Eu();
            dt = Service_Eu_.Login_DataTable(kullaniciaditxt.Text, sifretxt.Text);
            if (dt.Rows.Count == 1)
            {
                if (kullaniciaditxt.Text=="Admin")

                {
                    admin admin = new admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    hesabim2 hsbm2 = new hesabim2();

                    hsbm2.MüsteriID = dt.Rows[0][0].ToString();
                    hsbm2.Show();
                    this.Hide();
                }
               
            }
            else
                uyarıtxt.Text = "Yanlış Şifre!!!";
            uyarıtxt.ForeColor = Color.Red;
            
        }

        private void hesabim_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            login lgn = new login();
            lgn.Show();
            this.Hide();
        }

        private void kullaniciaditxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
