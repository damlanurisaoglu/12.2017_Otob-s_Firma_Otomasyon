namespace kopgit
{
    partial class biletal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(biletal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tarihlbl = new System.Windows.Forms.Label();
            this.kalkislbl = new System.Windows.Forms.Label();
            this.varislbl = new System.Windows.Forms.Label();
            this.btngoster = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.kalkiscbx = new System.Windows.Forms.ComboBox();
            this.variscbx = new System.Windows.Forms.ComboBox();
            this.tarih = new System.Windows.Forms.MonthCalendar();
            this.tarihtxt = new System.Windows.Forms.TextBox();
            this.uyarilbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.tarihlbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.kalkislbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.varislbl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btngoster, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kalkiscbx, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.variscbx, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tarih, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tarihtxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.uyarilbl, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.backbtn, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(712, 467);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tarihlbl
            // 
            this.tarihlbl.AutoSize = true;
            this.tarihlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarihlbl.Location = new System.Drawing.Point(65, 123);
            this.tarihlbl.Name = "tarihlbl";
            this.tarihlbl.Size = new System.Drawing.Size(194, 55);
            this.tarihlbl.TabIndex = 0;
            this.tarihlbl.Text = "Tarih Seçiniz :";
            // 
            // kalkislbl
            // 
            this.kalkislbl.AutoSize = true;
            this.kalkislbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kalkislbl.Location = new System.Drawing.Point(65, 178);
            this.kalkislbl.Name = "kalkislbl";
            this.kalkislbl.Size = new System.Drawing.Size(194, 55);
            this.kalkislbl.TabIndex = 1;
            this.kalkislbl.Text = "Kalkış :";
            // 
            // varislbl
            // 
            this.varislbl.AutoSize = true;
            this.varislbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.varislbl.Location = new System.Drawing.Point(65, 233);
            this.varislbl.Name = "varislbl";
            this.varislbl.Size = new System.Drawing.Size(194, 55);
            this.varislbl.TabIndex = 2;
            this.varislbl.Text = "Varış :";
            // 
            // btngoster
            // 
            this.btngoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btngoster.Location = new System.Drawing.Point(384, 291);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(75, 23);
            this.btngoster.TabIndex = 3;
            this.btngoster.Text = "GÖSTER";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // kalkiscbx
            // 
            this.kalkiscbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kalkiscbx.FormattingEnabled = true;
            this.kalkiscbx.Items.AddRange(new object[] {
            "Ankara",
            "Artvin",
            "Bolu",
            "Bursa",
            "Düzce",
            "Gümüşhane",
            "İstanbul",
            "İzmir",
            "Muğla",
            "Tokat"});
            this.kalkiscbx.Location = new System.Drawing.Point(265, 181);
            this.kalkiscbx.Name = "kalkiscbx";
            this.kalkiscbx.Size = new System.Drawing.Size(194, 21);
            this.kalkiscbx.Sorted = true;
            this.kalkiscbx.TabIndex = 8;
            this.kalkiscbx.SelectedIndexChanged += new System.EventHandler(this.kalkiscbx_SelectedIndexChanged);
            // 
            // variscbx
            // 
            this.variscbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variscbx.FormattingEnabled = true;
            this.variscbx.Items.AddRange(new object[] {
            "Düzce",
            "İstanbul",
            "Bursa",
            "İzmir",
            "Ankara",
            "Artvin",
            "Gümüşhane",
            "Tokat",
            "Muğla",
            "Bolu"});
            this.variscbx.Location = new System.Drawing.Point(265, 236);
            this.variscbx.Name = "variscbx";
            this.variscbx.Size = new System.Drawing.Size(194, 21);
            this.variscbx.TabIndex = 9;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(471, 132);
            this.tarih.Name = "tarih";
            this.tarih.TabIndex = 4;
            this.tarih.Visible = false;
            this.tarih.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tarihtxt
            // 
            this.tarihtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarihtxt.Location = new System.Drawing.Point(265, 126);
            this.tarihtxt.Name = "tarihtxt";
            this.tarihtxt.ReadOnly = true;
            this.tarihtxt.Size = new System.Drawing.Size(194, 20);
            this.tarihtxt.TabIndex = 10;
            this.tarihtxt.Text = "Tarih Seçiniz :";
            this.tarihtxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.tarihtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // uyarilbl
            // 
            this.uyarilbl.AutoSize = true;
            this.uyarilbl.Location = new System.Drawing.Point(465, 288);
            this.uyarilbl.Name = "uyarilbl";
            this.uyarilbl.Size = new System.Drawing.Size(0, 13);
            this.uyarilbl.TabIndex = 11;
            // 
            // backbtn
            // 
            this.backbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(651, 3);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(58, 57);
            this.backbtn.TabIndex = 15;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // biletal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "biletal";
            this.Text = "biletal";
            this.Load += new System.EventHandler(this.biletal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tarihlbl;
        private System.Windows.Forms.Label kalkislbl;
        private System.Windows.Forms.Label varislbl;
        private System.Windows.Forms.Button btngoster;
        private System.Windows.Forms.MonthCalendar tarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox kalkiscbx;
        private System.Windows.Forms.ComboBox variscbx;
        private System.Windows.Forms.TextBox tarihtxt;
        private System.Windows.Forms.Label uyarilbl;
        private System.Windows.Forms.Button backbtn;
    }
}