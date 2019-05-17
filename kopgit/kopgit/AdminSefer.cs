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
    public partial class AdminSefer : Form
    {
        public AdminSefer()
        {
            InitializeComponent();
        }

        private void AdminSefer_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Service_Eu servis = new Service_Eu();
            DataTable dt2 = new DataTable();
            dt2 = servis.adminsilinmissefer_select();
            dataGridView2.DataSource = dt2;
            dt = servis.adminsefer_select();
            dataGridView1.DataSource = dt;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            kalkistxt.Visible = true;
            varistxt.Visible = true;
            tarihtxt.Visible = true;
            saattxt.Visible = true;
            btnekle.Visible = true;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Service_Eu servis = new Service_Eu();
            servis.sefer_insert(kalkistxt.Text,varistxt.Text,tarihtxt.Text,saattxt.Text);
            AdminSefer_Load(null,null);
            kalkistxt.Text = "";
            varistxt.Text = "";
            tarihtxt.Text = "";
            saattxt.Text = "";
            kalkistxt.Visible = false;
            varistxt.Visible = false;
            tarihtxt.Visible = false;
            saattxt.Visible = false;
            btnekle.Visible = false;
        }
        int seferno;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seferno = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Seferi silmek istiyor musunuz?", "Dikkat..!", MessageBoxButtons.YesNo);
            if (secenek==DialogResult.Yes)
            {
                Service_Eu servis = new Service_Eu();
                servis.sefer_delete(seferno);
                AdminSefer_Load(null,null);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int roow = e.RowIndex;
            seferno = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Seferi aktif yapmak istiyor musunuz?", "Dikkat..!", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                Service_Eu servis = new Service_Eu();
                servis.silinmissefer_delete(seferno);
                AdminSefer_Load(null, null);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView1, "Seferler");
        }
        public void ExportToExcel(DataGridView gridviewID, string excelFilename)
        {
            Microsoft.Office.Interop.Excel.Application objexcelapp = new Microsoft.Office.Interop.Excel.Application();
            objexcelapp.Application.Workbooks.Add(Type.Missing);
            objexcelapp.Columns.ColumnWidth = 25;
            for (int i = 1; i < gridviewID.Columns.Count + 1; i++)
            {
                objexcelapp.Cells[1, i] = gridviewID.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < gridviewID.Rows.Count; i++)
            {
                for (int j = 0; j < gridviewID.Columns.Count; j++)
                {
                    if (gridviewID.Rows[i].Cells[j].Value != null)
                    {
                        objexcelapp.Cells[i + 2, j + 1] = gridviewID.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            MessageBox.Show("Çıktı Başarıyla Alındı C:\\YEDEK/" + excelFilename + ".xlsx");
            objexcelapp.ActiveWorkbook.SaveCopyAs("C:\\YEDEK/" + excelFilename + ".xlsx");
            objexcelapp.ActiveWorkbook.Saved = true;

        }
    }
}
