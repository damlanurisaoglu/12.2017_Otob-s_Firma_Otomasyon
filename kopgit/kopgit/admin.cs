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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        
        private void btnbltal_Click(object sender, EventArgs e)
        {
            biletal blt = new biletal();
            blt.Show();

            blt.islemno = "3";
            this.Hide();
        }

        private void btnrzrvsyn_Click(object sender, EventArgs e)
        {
            biletal blt = new biletal();
            blt.Show();
            blt.islemno = "1";
            this.Hide();
            
        }

        private void btnbltiptl_Click(object sender, EventArgs e)
        {
            biletal blt = new biletal();
            blt.Show();
            blt.islemno = "2";
            this.Hide();
        }

        private void btnsefer_Click(object sender, EventArgs e)
        {
            AdminSefer asfr = new AdminSefer();
            asfr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service_Eu servis = new Service_Eu();
            servis.SP_BACKUP();
            MessageBox.Show("Veri Tabanı Başarıyla Yedeklendi..!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service_Eu servis = new Service_Eu();
            servis.SP_RESTORE();
            MessageBox.Show("İşlem Başarıyla Gerçekleştirildi..!");
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
