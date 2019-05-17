namespace kopgit
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kullaniciadilbl = new System.Windows.Forms.Label();
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.sifrelbl = new System.Windows.Forms.Label();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.btnuyeol = new System.Windows.Forms.Button();
            this.btngiris = new System.Windows.Forms.Button();
            this.btndevamet = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.uyarilbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.kullaniciadilbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.kullaniciaditxt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sifrelbl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.sifretxt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnuyeol, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btngiris, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btndevamet, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.backbtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.uyarilbl, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kullaniciadilbl
            // 
            this.kullaniciadilbl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.kullaniciadilbl, 2);
            this.kullaniciadilbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kullaniciadilbl.Location = new System.Drawing.Point(173, 70);
            this.kullaniciadilbl.Name = "kullaniciadilbl";
            this.kullaniciadilbl.Size = new System.Drawing.Size(234, 55);
            this.kullaniciadilbl.TabIndex = 0;
            this.kullaniciadilbl.Text = "Kullanıcı Adı :";
            this.kullaniciadilbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kullaniciaditxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.kullaniciaditxt, 2);
            this.kullaniciaditxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kullaniciaditxt.Location = new System.Drawing.Point(173, 128);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.Size = new System.Drawing.Size(234, 20);
            this.kullaniciaditxt.TabIndex = 1;
            // 
            // sifrelbl
            // 
            this.sifrelbl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.sifrelbl, 2);
            this.sifrelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sifrelbl.Location = new System.Drawing.Point(173, 180);
            this.sifrelbl.Name = "sifrelbl";
            this.sifrelbl.Size = new System.Drawing.Size(234, 55);
            this.sifrelbl.TabIndex = 2;
            this.sifrelbl.Text = "Şifre :";
            this.sifrelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sifretxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.sifretxt, 2);
            this.sifretxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sifretxt.Location = new System.Drawing.Point(173, 238);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '*';
            this.sifretxt.Size = new System.Drawing.Size(234, 20);
            this.sifretxt.TabIndex = 3;
            // 
            // btnuyeol
            // 
            this.btnuyeol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnuyeol.Location = new System.Drawing.Point(173, 293);
            this.btnuyeol.Name = "btnuyeol";
            this.btnuyeol.Size = new System.Drawing.Size(114, 49);
            this.btnuyeol.TabIndex = 4;
            this.btnuyeol.Text = "Üye Ol";
            this.btnuyeol.UseVisualStyleBackColor = true;
            this.btnuyeol.Click += new System.EventHandler(this.btnuyeol_Click);
            // 
            // btngiris
            // 
            this.btngiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btngiris.Location = new System.Drawing.Point(293, 293);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(114, 49);
            this.btngiris.TabIndex = 5;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // btndevamet
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btndevamet, 2);
            this.btndevamet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btndevamet.Location = new System.Drawing.Point(173, 348);
            this.btndevamet.Name = "btndevamet";
            this.btndevamet.Size = new System.Drawing.Size(234, 49);
            this.btndevamet.TabIndex = 6;
            this.btndevamet.Text = "Üye Olmadan Devam Et";
            this.btndevamet.UseVisualStyleBackColor = true;
            this.btndevamet.Click += new System.EventHandler(this.btndevamet_Click);
            // 
            // backbtn
            // 
            this.backbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(520, 3);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(58, 57);
            this.backbtn.TabIndex = 15;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // uyarilbl
            // 
            this.uyarilbl.AutoSize = true;
            this.uyarilbl.Location = new System.Drawing.Point(413, 290);
            this.uyarilbl.Name = "uyarilbl";
            this.uyarilbl.Size = new System.Drawing.Size(0, 13);
            this.uyarilbl.TabIndex = 16;
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "giris";
            this.Text = "giris";
            this.Load += new System.EventHandler(this.giris_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label kullaniciadilbl;
        private System.Windows.Forms.TextBox kullaniciaditxt;
        private System.Windows.Forms.Label sifrelbl;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Button btnuyeol;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button btndevamet;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label uyarilbl;
    }
}