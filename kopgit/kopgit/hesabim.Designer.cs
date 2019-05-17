namespace kopgit
{
    partial class hesabim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hesabim));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kullanıcılbl = new System.Windows.Forms.Label();
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.sifrelbl = new System.Windows.Forms.Label();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.btnuyeol = new System.Windows.Forms.Button();
            this.btngiris = new System.Windows.Forms.Button();
            this.uyarıtxt = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.kullanıcılbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.kullaniciaditxt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sifrelbl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.sifretxt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnuyeol, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btngiris, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.uyarıtxt, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.backbtn, 3, 7);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 477);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kullanıcılbl
            // 
            this.kullanıcılbl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.kullanıcılbl, 2);
            this.kullanıcılbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kullanıcılbl.Location = new System.Drawing.Point(285, 73);
            this.kullanıcılbl.Name = "kullanıcılbl";
            this.kullanıcılbl.Size = new System.Drawing.Size(234, 55);
            this.kullanıcılbl.TabIndex = 0;
            this.kullanıcılbl.Text = "Kullanıcı Adı :";
            this.kullanıcılbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kullaniciaditxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.kullaniciaditxt, 2);
            this.kullaniciaditxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kullaniciaditxt.Location = new System.Drawing.Point(285, 131);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.Size = new System.Drawing.Size(234, 20);
            this.kullaniciaditxt.TabIndex = 1;
            this.kullaniciaditxt.TextChanged += new System.EventHandler(this.kullaniciaditxt_TextChanged);
            // 
            // sifrelbl
            // 
            this.sifrelbl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.sifrelbl, 2);
            this.sifrelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sifrelbl.Location = new System.Drawing.Point(285, 183);
            this.sifrelbl.Name = "sifrelbl";
            this.sifrelbl.Size = new System.Drawing.Size(234, 55);
            this.sifrelbl.TabIndex = 2;
            this.sifrelbl.Text = "Şifre :";
            this.sifrelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sifretxt
            // 
            this.sifretxt.AcceptsReturn = true;
            this.tableLayoutPanel1.SetColumnSpan(this.sifretxt, 2);
            this.sifretxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sifretxt.Location = new System.Drawing.Point(285, 241);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '*';
            this.sifretxt.Size = new System.Drawing.Size(234, 20);
            this.sifretxt.TabIndex = 3;
            this.sifretxt.UseWaitCursor = true;
            // 
            // btnuyeol
            // 
            this.btnuyeol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnuyeol.Location = new System.Drawing.Point(285, 296);
            this.btnuyeol.Name = "btnuyeol";
            this.btnuyeol.Size = new System.Drawing.Size(114, 49);
            this.btnuyeol.TabIndex = 4;
            this.btnuyeol.Text = "Üye Ol ";
            this.btnuyeol.UseVisualStyleBackColor = true;
            this.btnuyeol.Click += new System.EventHandler(this.btnuyeol_Click);
            // 
            // btngiris
            // 
            this.btngiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btngiris.Location = new System.Drawing.Point(405, 296);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(114, 49);
            this.btngiris.TabIndex = 6;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // uyarıtxt
            // 
            this.uyarıtxt.AutoSize = true;
            this.uyarıtxt.Location = new System.Drawing.Point(525, 293);
            this.uyarıtxt.Name = "uyarıtxt";
            this.uyarıtxt.Size = new System.Drawing.Size(0, 13);
            this.uyarıtxt.TabIndex = 7;
            this.uyarıtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backbtn
            // 
            this.backbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backbtn.Image = ((System.Drawing.Image)(resources.GetObject("backbtn.Image")));
            this.backbtn.Location = new System.Drawing.Point(743, 417);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(58, 57);
            this.backbtn.TabIndex = 15;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // hesabim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 477);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "hesabim";
            this.Text = "hesabim";
            this.Load += new System.EventHandler(this.hesabim_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label kullanıcılbl;
        private System.Windows.Forms.TextBox kullaniciaditxt;
        private System.Windows.Forms.Label sifrelbl;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Button btnuyeol;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label uyarıtxt;
        private System.Windows.Forms.Button backbtn;
    }
}