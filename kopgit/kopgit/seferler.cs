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
    public partial class seferler : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();

        public seferler()
        {
            InitializeComponent();
            this.Text = "Seferler";
        }
        public string islemno { get; set; }
        public string tarih { get; set; }
        public string kalkis { get; set; }
        public string varis { get; set; }
        public string müsteriID { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        DataTable dt3 = new DataTable();
        private void koltukkontrol()
        {
            Service_Eu servis = new Service_Eu();
            
            dt3 =servis.kayitlar_select(int.Parse(seferlbl.Text), int.Parse(koltuklbl.Text));
        }
        
        private void buttonkontrol()
        {
            if (islemno == "1")
            {
                btnbiletal.Text = "Rezervasyon Yap";
            }
            else if (islemno == "2")
            {
                btnbiletal.Text = "Bilet İptal";
            }

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            
            buttonkontrol();
            tableLayoutPanel3.Visible = true;
            koltuklbl.Text = "1";
            if (btn1.ForeColor == Color.Yellow)
            {
                Service_Eu servis = new Service_Eu();
                DataTable dt = new DataTable();
                dt = servis.select_rezerve_tc(int.Parse(seferlbl.Text.ToString()), int.Parse(koltuklbl.Text.ToString()));
                tctxt.Text = dt.Rows[0][0].ToString();
                tctxt.ReadOnly = true;
            }
            try
            {
                koltukkontrol();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tctxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (btn1.ForeColor == Color.Yellow)
            {
                Service_Eu servis = new Service_Eu();
                DataTable dt = new DataTable();
                dt = servis.select_rezerve_tc(int.Parse(seferlbl.Text.ToString()), int.Parse(koltuklbl.Text.ToString()));
                tctxt.Text = dt.Rows[0][0].ToString();
                tctxt.ReadOnly = true;
            }
            buttonkontrol();
            tableLayoutPanel3.Visible = true;
            koltuklbl.Text = "11";
            try
            {
                koltukkontrol();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void seferler_Load(object sender, EventArgs e)
        {
            Service_Eu servis = new Service_Eu();
            dt = servis.select_seferler(tarih,kalkis,varis);
            dataGridView1.DataSource = dt;
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tctxt.ReadOnly = false;
            tableLayoutPanel2.Visible = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            saatlbl.Text = "";
            seferlbl.Text = "";
            koltuklbl.Text = "";
            btn1.ForeColor = Color.Black;
            btn2.ForeColor = Color.Black;
            btn3.ForeColor = Color.Black;
            btn4.ForeColor = Color.Black;
            btn5.ForeColor = Color.Black;
            btn6.ForeColor = Color.Black;
            btn7.ForeColor = Color.Black;
            btn8.ForeColor = Color.Black;
            btn9.ForeColor = Color.Black;
            btn10.ForeColor = Color.Black;
            btn11.ForeColor = Color.Black;
            btn12.ForeColor = Color.Black;

            saatlbl.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()).Substring(0, 5);
            kalkıslbl.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            varislbl.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            seferlbl.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tarihlbl.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).Substring(0,10);
           

            Service_Eu servis = new Service_Eu();
            try
            {
                dt2 = servis.select_koltuklar(int.Parse(seferlbl.Text));
                dt5 = servis.admin_koltuk(int.Parse(seferlbl.Text));
            }
            catch (Exception)
            {

                throw;
            }
           

            if (islemno == "2")
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    string koltukno = dt2.Rows[i][0].ToString();
                    if (btn1.Text == koltukno)
                    {
                        btn1.Enabled = true;

                    }
                    else if (btn2.Text == koltukno)
                    {
                        btn2.Enabled = true;
                    }
                    else if (btn3.Text == koltukno)
                    {
                        btn3.Enabled = true;
                    }
                    else if (btn4.Text == koltukno)
                    {
                        btn4.Enabled = true;
                    }
                    else if (btn5.Text == koltukno)
                    {
                        btn5.Enabled = true;
                    }
                    else if (btn6.Text == koltukno)
                    {
                        btn6.Enabled = true;
                    }
                    else if (btn7.Text == koltukno)
                    {
                        btn7.Enabled = true;
                    }
                    else if (btn8.Text == koltukno)
                    {
                        btn8.Enabled = true;
                    }
                    else if (btn9.Text == koltukno)
                    {
                        btn9.Enabled = true;
                    }
                    else if (btn10.Text == koltukno)
                    {
                        btn10.Enabled = true;
                    }
                    else if (btn11.Text == koltukno)
                    {
                        btn11.Enabled = true;
                    }
                    else if (btn12.Text == koltukno)
                    {
                        btn12.Enabled = true;
                    }
                }

            }

            else if (islemno=="1" || islemno=="3")
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    string koltukno = dt2.Rows[i][0].ToString();
                    if (btn1.Text == koltukno)
                    {
                        btn1.Enabled = false;

                    }
                    else if (btn2.Text == koltukno)
                    {
                        btn2.Enabled = false;
                    }
                    else if (btn3.Text == koltukno)
                    {
                        btn3.Enabled = false;
                    }
                    else if (btn4.Text == koltukno)
                    {
                        btn4.Enabled = false;
                    }
                    else if (btn5.Text == koltukno)
                    {
                        btn5.Enabled = false;
                    }
                    else if (btn6.Text == koltukno)
                    {
                        btn6.Enabled = false;
                    }
                    else if (btn7.Text == koltukno)
                    {
                        btn7.Enabled = false;
                    }
                    else if (btn8.Text == koltukno)
                    {
                        btn8.Enabled = false;
                    }
                    else if (btn9.Text == koltukno)
                    {
                        btn9.Enabled = false;
                    }
                    else if (btn10.Text == koltukno)
                    {
                        btn10.Enabled = false;
                    }
                    else if (btn11.Text == koltukno)
                    {
                        btn11.Enabled = false;
                    }
                    else if (btn12.Text == koltukno)
                    {
                        btn12.Enabled = false;
                    }
                }
                for (int i = 0; i < dt5.Rows.Count; i++)
                {
                    string koltukno = dt5.Rows[i][0].ToString();
                    if (btn1.Text == koltukno)
                    {
                        btn1.Enabled = true;
                        btn1.ForeColor = Color.Yellow;

                    }
                    else if (btn2.Text == koltukno)
                    {
                        btn2.Enabled = true;
                        btn2.ForeColor = Color.Yellow;
                    }
                    else if (btn3.Text == koltukno)
                    {
                        btn3.Enabled = true;
                        btn3.ForeColor = Color.Yellow;
                    }
                    else if (btn4.Text == koltukno)
                    {
                        btn4.Enabled = true;
                        btn4.ForeColor = Color.Yellow;
                    }
                    else if (btn5.Text == koltukno)
                    {
                        btn5.Enabled = true;
                        btn5.ForeColor = Color.Yellow;
                    }
                    else if (btn6.Text == koltukno)
                    {
                        btn6.Enabled = true;
                        btn6.ForeColor = Color.Yellow;
                    }
                    else if (btn7.Text == koltukno)
                    {
                        btn7.Enabled = true;
                        btn7.ForeColor = Color.Yellow;
                    }
                    else if (btn8.Text == koltukno)
                    {
                        btn8.Enabled = true;
                        btn8.ForeColor = Color.Yellow;
                    }
                    else if (btn9.Text == koltukno)
                    {
                        btn9.Enabled = true;
                        btn9.ForeColor = Color.Yellow;
                    }
                    else if (btn10.Text == koltukno)
                    {
                        btn10.Enabled = true;
                        btn10.ForeColor = Color.Yellow;
                    }
                    else if (btn11.Text == koltukno)
                    {
                        btn11.Enabled = true;
                        btn11.ForeColor = Color.Yellow;
                    }
                    else if (btn12.Text == koltukno)
                    {
                        btn12.Enabled = true;
                        btn12.ForeColor = Color.Yellow;
                    }
                }
                try
                {
                    dt4 = servis.rezerve_select(int.Parse(seferlbl.Text));
                }
                catch (Exception)
                {

                    throw;
                }
                
                for (int i = 0; i < dt4.Rows.Count; i++)
                {
                    string koltukno = dt4.Rows[i][0].ToString();
                    if (btn1.Text == koltukno)
                    {
                        btn1.Enabled = true;

                    }
                    else if (btn2.Text == koltukno)
                    {
                        btn2.Enabled = true;
                    }
                    else if (btn3.Text == koltukno)
                    {
                        btn3.Enabled = true;
                    }
                    else if (btn4.Text == koltukno)
                    {
                        btn4.Enabled = true;
                    }
                    else if (btn5.Text == koltukno)
                    {
                        btn5.Enabled = true;
                    }
                    else if (btn6.Text == koltukno)
                    {
                        btn6.Enabled = true;
                    }
                    else if (btn7.Text == koltukno)
                    {
                        btn7.Enabled = true;
                    }
                    else if (btn8.Text == koltukno)
                    {
                        btn8.Enabled = true;
                    }
                    else if (btn9.Text == koltukno)
                    {
                        btn9.Enabled = true;
                    }
                    else if (btn10.Text == koltukno)
                    {
                        btn10.Enabled = true;
                    }
                    else if (btn11.Text == koltukno)
                    {
                        btn11.Enabled = true;
                    }
                    else if (btn12.Text == koltukno)
                    {
                        btn12.Enabled = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    string koltukno = dt2.Rows[i][0].ToString();
                    if (btn1.Text == koltukno)
                    {
                        btn1.Enabled = false;

                    }
                    else if (btn2.Text == koltukno)
                    {
                        btn2.Enabled = false;
                    }
                    else if (btn3.Text == koltukno)
                    {
                        btn3.Enabled = false;
                    }
                    else if (btn4.Text == koltukno)
                    {
                        btn4.Enabled = false;
                    }
                    else if (btn5.Text == koltukno)
                    {
                        btn5.Enabled = false;
                    }
                    else if (btn6.Text == koltukno)
                    {
                        btn6.Enabled = false;
                    }
                    else if (btn7.Text == koltukno)
                    {
                        btn7.Enabled = false;
                    }
                    else if (btn8.Text == koltukno)
                    {
                        btn8.Enabled = false;
                    }
                    else if (btn9.Text == koltukno)
                    {
                        btn9.Enabled = false;
                    }
                    else if (btn10.Text == koltukno)
                    {
                        btn10.Enabled = false;
                    }
                    else if (btn11.Text == koltukno)
                    {
                        btn11.Enabled = false;
                    }
                    else if (btn12.Text == koltukno)
                    {
                        btn12.Enabled = false;
                    }
                }
                dt4 = servis.rezerve_select(int.Parse(seferlbl.Text));
                for (int i = 0; i < dt4.Rows.Count; i++)
                {
                    string koltukno = dt4.Rows[i][0].ToString();
                    if (btn1.Text == koltukno)
                    {
                        btn1.Enabled = true;

                    }
                    else if (btn2.Text == koltukno)
                    {
                        btn2.Enabled = true;
                    }
                    else if (btn3.Text == koltukno)
                    {
                        btn3.Enabled = true;
                    }
                    else if (btn4.Text == koltukno)
                    {
                        btn4.Enabled = true;
                    }
                    else if (btn5.Text == koltukno)
                    {
                        btn5.Enabled = true;
                    }
                    else if (btn6.Text == koltukno)
                    {
                        btn6.Enabled = true;
                    }
                    else if (btn7.Text == koltukno)
                    {
                        btn7.Enabled = true;
                    }
                    else if (btn8.Text == koltukno)
                    {
                        btn8.Enabled = true;
                    }
                    else if (btn9.Text == koltukno)
                    {
                        btn9.Enabled = true;
                    }
                    else if (btn10.Text == koltukno)
                    {
                        btn10.Enabled = true;
                    }
                    else if (btn11.Text == koltukno)
                    {
                        btn11.Enabled = true;
                    }
                    else if (btn12.Text == koltukno)
                    {
                        btn12.Enabled = true;
                    }
                }

            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn1.ForeColor == Color.Yellow)
            {
                Service_Eu servis = new Service_Eu();
                DataTable dt = new DataTable();
                dt = servis.select_rezerve_tc(int.Parse(seferlbl.Text.ToString()), int.Parse(koltuklbl.Text.ToString()));
                tctxt.Text = dt.Rows[0][0].ToString();
                tctxt.ReadOnly = true;
            }
            buttonkontrol();
            tableLayoutPanel3.Visible = true;
            koltuklbl.Text = "2";
            try
            {
                koltukkontrol();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn1.ForeColor == Color.Yellow)
            {
                Service_Eu servis = new Service_Eu();
                DataTable dt = new DataTable();
                dt = servis.select_rezerve_tc(int.Parse(seferlbl.Text.ToString()), int.Parse(koltuklbl.Text.ToString()));
                tctxt.Text = dt.Rows[0][0].ToString();
                tctxt.ReadOnly = true;
            }
            buttonkontrol();
            tableLayoutPanel3.Visible = true;
            koltuklbl.Text = "3";
            try
            {
                koltukkontrol();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn1.ForeColor == Color.Yellow)
            {
                Service_Eu servis = new Service_Eu();
                DataTable dt = new DataTable();
                dt = servis.select_rezerve_tc(int.Parse(seferlbl.Text.ToString()), int.Parse(koltuklbl.Text.ToString()));
                tctxt.Text = dt.Rows[0][0].ToString();
                tctxt.ReadOnly = true;
            }
            buttonkontrol();
            tableLayoutPanel3.Visible = true;
            koltuklbl.Text = "4";
            try
            {
                koltukkontrol();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn1.ForeColor == Color.Yellow)
            {
                Service_Eu servis = new Service_Eu();
                DataTable dt = new DataTable();
                dt = servis.select_rezerve_tc(int.Parse(seferlbl.Text.ToString()), int.Parse(koltuklbl.Text.ToString()));
                tctxt.Text = dt.Rows[0][0].ToString();
                tctxt.ReadOnly = true;
            }
            buttonkontrol();
            tableLayoutPanel3.Visible = true;
            koltuklbl.Text = "5";
            try
            {
                koltukkontrol();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btrn6_Click(object sender, EventArgs e)
        {
            if (btn1.ForeColor == Color.Yellow)
            {
                Service_Eu servis = new Service_Eu();
                DataTable dt = new DataTable();
                dt = servis.select_rezerve_tc(int.Parse(seferlbl.Text.ToString()), int.Parse(koltuklbl.Text.ToString()));
                tctxt.Text = dt.Rows[0][0].ToString();
                tctxt.ReadOnly = true;
            }
            buttonkontrol();
            tableLayoutPanel3.Visible = true;
            koltuklbl.Text = "6";
            try
            {
                koltukkontrol();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn1.ForeColor == Color.Yellow)
            {
                Service_Eu servis = new Service_Eu();
                DataTable dt = new DataTable();
                dt = servis.select_rezerve_tc(int.Parse(seferlbl.Text.ToString()), int.Parse(koltuklbl.Text.ToString()));
                tctxt.Text = dt.Rows[0][0].ToString();
                tctxt.ReadOnly = true;
            }
            buttonkontrol();
            tableLayoutPanel3.Visible = true;
            koltuklbl.Text = "7";
            try
            {
                koltukkontrol();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn1.ForeColor == Color.Yellow)
            {
                Service_Eu servis = new Service_Eu();
                DataTable dt = new DataTable();
                dt = servis.select_rezerve_tc(int.Parse(seferlbl.Text.ToString()), int.Parse(koltuklbl.Text.ToString()));
                tctxt.Text = dt.Rows[0][0].ToString();
                tctxt.ReadOnly = true;
            }
            buttonkontrol();
            tableLayoutPanel3.Visible = true;
            koltuklbl.Text = "8";
            try
            {
                koltukkontrol();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn1.ForeColor == Color.Yellow)
            {
                Service_Eu servis = new Service_Eu();
                DataTable dt = new DataTable();
                dt = servis.select_rezerve_tc(int.Parse(seferlbl.Text.ToString()), int.Parse(koltuklbl.Text.ToString()));
                tctxt.Text = dt.Rows[0][0].ToString();
                tctxt.ReadOnly = true;
            }
            buttonkontrol();
            tableLayoutPanel3.Visible = true;
            koltuklbl.Text = "9";
            try
            {
                koltukkontrol();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (btn1.ForeColor == Color.Yellow)
            {
                Service_Eu servis = new Service_Eu();
                DataTable dt = new DataTable();
                dt = servis.select_rezerve_tc(int.Parse(seferlbl.Text.ToString()), int.Parse(koltuklbl.Text.ToString()));
                tctxt.Text = dt.Rows[0][0].ToString();
                tctxt.ReadOnly = true;
            }
            buttonkontrol();
            tableLayoutPanel3.Visible = true;
            koltuklbl.Text = "10";
            try
            {
                koltukkontrol();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (btn1.ForeColor == Color.Yellow)
            {
                Service_Eu servis = new Service_Eu();
                DataTable dt = new DataTable();
                dt = servis.select_rezerve_tc(int.Parse(seferlbl.Text.ToString()), int.Parse(koltuklbl.Text.ToString()));
                tctxt.Text = dt.Rows[0][0].ToString();
                tctxt.ReadOnly = true;
            }
            buttonkontrol();
            tableLayoutPanel3.Visible = true;
            koltuklbl.Text = "12";
            try
            {
                koltukkontrol();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnbiletal_Click(object sender, EventArgs e)
        {
            Service_Eu servis = new Service_Eu();
            if (btnbiletal.Text== "Bilet İptal")
            {

                servis.kayitlar_delete(int.Parse(seferlbl.Text), int.Parse(koltuklbl.Text));
            }
            if (btnbiletal.Text== "Rezervasyon Yap")
            {
                
                servis.kayırlar_rezerve_insert(Int32.Parse(tctxt.Text), adtxt.Text + " " + soyadtxt.Text, int.Parse(koltuklbl.Text), tarihlbl.Text, saatlbl.Text, int.Parse(seferlbl.Text), kalkıslbl.Text, varislbl.Text, 0, "Rezerve");
            }
            else
            {
                if (müsteriID==null)
                {
                    müsteriID = "0";
                }
                servis.kayitlar_insert(Int32.Parse(tctxt.Text), adtxt.Text+ " "+ soyadtxt.Text, int.Parse(koltuklbl.Text), tarihlbl.Text, saatlbl.Text, int.Parse(seferlbl.Text), kalkıslbl.Text, varislbl.Text, int.Parse(müsteriID));

            }
            login lgn = new login();
            lgn.Show();
            this.Hide();
        }

        private void tctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            biletal bltal = new biletal();
            bltal.Show();
            this.Hide();
        }
    }
}
