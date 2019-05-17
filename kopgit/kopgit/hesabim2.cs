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
    
    public partial class hesabim2 : Form
    {
        DataTable dt = new DataTable();
        public string MüsteriID { get; set; }
        public hesabim2()
        {
            InitializeComponent();
        }

     

        private void hesabim2_Load(object sender, EventArgs e)
        {
            Service_Eu servis = new Service_Eu();
            dt = servis.select_müsteri_kayitlar(int.Parse(MüsteriID));
            dataGridView1.DataSource = dt;
        }
        DataTable dt2 = new DataTable();
        DataTable dt4 = new DataTable();
        int seferno, koltukno;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tableLayoutPanel3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
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
            
            seferno = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            koltukno = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            Service_Eu servis = new Service_Eu();
            dt2 = servis.select_koltuklar(seferno);
            
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
            dt4 = servis.rezerve_select(seferno);
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
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Biletinizi iptal etmek istiyor musunuz?", "Önemli..!!", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                Service_Eu servis = new Service_Eu();
                servis.kayitlar_delete(seferno, koltukno);
                button1.Visible = false;
                button2.Visible = false;
                hesabim2_Load(null, null);
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Visible = true;
           
        }
        int yenikoltukno;
        private void btn1_Click(object sender, EventArgs e)
        {
            yenikoltukno = 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            yenikoltukno = 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            yenikoltukno = 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            yenikoltukno = 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            yenikoltukno = 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            yenikoltukno = 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            yenikoltukno = 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            yenikoltukno = 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            yenikoltukno = 9;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            yenikoltukno = 10;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            yenikoltukno = 11;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            yenikoltukno = 12;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Koltuğunuzu değiştirmek istiyor musunuz?", "Önemli..!!", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                button1.Visible = false;
                button2.Visible = false;
                Service_Eu servis = new Service_Eu();
                servis.koltuk_update(koltukno, yenikoltukno, seferno);
                tableLayoutPanel3.Visible = false;
                hesabim2_Load(null, null);
            }
           
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            hesabim hsbm = new hesabim();
            hsbm.Show();
            this.Hide();
        }

     
    }
}
