using anaekran;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kopgit
{
    public partial class uyeol : Form
    {
        public uyeol()
        {
            InitializeComponent();
        }
      
        private void sifrelbl_Click(object sender, EventArgs e)
        {

        }

        private void btndevam_Click(object sender, EventArgs e)
        {
            Service_Eu Service_Eu_ = new Service_Eu();

            if (aditxt.Text=="" || tctxt.Text=="" || kullaniciaditxt.Text=="" || sifretxt.Text=="" || telnotxt.Text=="" || epostatxt.Text=="" || sehirtxt.Text=="")

            {
                uyarilbl.Text = "Boş Alanları Doldurunuz!!!";
                uyarilbl.ForeColor = Color.Red;

            }
            else
            {
                Service_Eu_.Login_insert_DataReader(aditxt.Text, int.Parse(tctxt.Text), kullaniciaditxt.Text, sifretxt.Text, int.Parse(telnotxt.Text), epostatxt.Text, sehirtxt.Text);

                DialogResult secenek = MessageBox.Show("Kayıt İşleminiz Başarıyla Gerçekleşmiştir.","Tebrikler..!!",MessageBoxButtons.OK);
                if (secenek==DialogResult.OK)
                {
                    login lgn = new login();
                    lgn.Show();
                    this.Hide();
                }
            }
           
           
        }

        private void uyeol_Load(object sender, EventArgs e)
        {
        
        }

        private void sifreonaytxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (sifretxt.Text == sifreonaytxt.Text)
            {
                sifreuyarilbl.Text = "Şifreler Eşleşti";
                sifreuyarilbl.ForeColor = Color.Green;
            }
            else
            {
                sifreuyarilbl.Text = "Şifreler Eşleşmedi";
                sifreuyarilbl.ForeColor = Color.Red;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            login lgn = new login();
            lgn.Show();
            this.Hide();
        }

        private void tctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kayıt_girdisi = new string[8]; int i = 0;
            StreamReader oku = new StreamReader("kayıtgirdisi.txt");    //dosyamızı okumak için açıyor           
            while (!oku.EndOfStream)//while döngüsü kullanıyoruz
            {
                kayıt_girdisi[i] = oku.ReadLine();// okunan değeri kayıt_girdisine aktarıyoruz.
                i++;
            }

            aditxt.Text = kayıt_girdisi[0];
            tctxt.Text = kayıt_girdisi[1];
            kullaniciaditxt.Text = kayıt_girdisi[2];
            sifretxt.Text = kayıt_girdisi[3];
            sifreonaytxt.Text = kayıt_girdisi[4];
            telnotxt.Text = kayıt_girdisi[5];

            epostatxt.Text = kayıt_girdisi[6];
            sehirtxt.Text = kayıt_girdisi[7];
         

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
