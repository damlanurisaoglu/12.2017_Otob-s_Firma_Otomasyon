using anaekran;
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
    public partial class giris : Form
    {
        DataTable dt = new DataTable();
        public giris()
        {
            InitializeComponent();
        }

        private void btnuyeol_Click(object sender, EventArgs e)
        {
            uyeol uye = new uyeol();
            uye.Show();
            this.Hide();
        }

        private void btndevamet_Click(object sender, EventArgs e)
        {

            biletal bltal = new biletal();
            bltal.müsteriID = "0";
            bltal.Show();
            this.Hide();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            Service_Eu Service_Eu_ = new Service_Eu();
            dt = Service_Eu_.Login_DataTable(kullaniciaditxt.Text, sifretxt.Text);
            if (dt.Rows.Count==1)
            {
                biletal bltal = new biletal();
                bltal.müsteriID = dt.Rows[0][0].ToString();
                bltal.Show();
                this.Hide();
            }
            else
            {
                uyarilbl.Text = "Yanlış Şifre..!!";
                uyarilbl.ForeColor = Color.Red;
                kullaniciaditxt.Text = "";
                sifretxt.Text = "";
            }
       
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            login lgn = new login();
            lgn.Show();
            this.Hide();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}
