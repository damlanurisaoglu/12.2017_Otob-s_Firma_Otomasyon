using System;
using anaekran;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kopgit
{
    public partial class biletal : Form
    {

        public string müsteriID { get; set; }

        public biletal()
        {
            InitializeComponent();
        }
        public string islemno { get; set; }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tarih.Visible = false;
            tarihtxt.Text = tarih.SelectionStart.ToShortDateString();
        }

   
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            tarih.Visible = true;
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            
            if (  kalkiscbx.Text==""|| variscbx.Text==""|| tarihtxt.Text=="Tarih Seçiniz :")
            {
                uyarilbl.Text = "Boş Alanları Doldurunuz";
                uyarilbl.ForeColor = Color.Red;
            }
            else
            {
                seferler sfr = new seferler();
                sfr.tarih = tarihtxt.Text;
                sfr.kalkis = kalkiscbx.Text;
                sfr.varis = variscbx.Text;
                sfr.müsteriID = müsteriID;
                sfr.islemno = islemno;
                sfr.Show();
                this.Hide();
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            giris grs = new giris();
            grs.Show();
            this.Hide();
        }

        private void kalkiscbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void biletal_Load(object sender, EventArgs e)
        {

        }
    }
}
