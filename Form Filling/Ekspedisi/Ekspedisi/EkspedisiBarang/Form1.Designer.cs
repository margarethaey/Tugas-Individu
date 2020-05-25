namespace EkspedisiBarang
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ContactUs = new System.Windows.Forms.Button();
            this.LokasiTerdekat = new System.Windows.Forms.Button();
            this.CekTarif = new System.Windows.Forms.Button();
            this.Pesanan = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lonceng = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lokasiScreen1 = new EkspedisiBarang.LokasiScreen();
            this.cekTarifScreen1 = new EkspedisiBarang.CekTarifScreen();
            this.pesanankuScreen1 = new EkspedisiBarang.PesananScreen1();
            this.homeScreen1 = new EkspedisiBarang.homeScreen1();
            this.aboutUsScreen1 = new EkspedisiBarang.ContactUsScreen();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.ContactUs);
            this.panel1.Controls.Add(this.LokasiTerdekat);
            this.panel1.Controls.Add(this.CekTarif);
            this.panel1.Controls.Add(this.Pesanan);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 551);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 404);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 58);
            this.label4.TabIndex = 10;
            this.label4.Text = "EXPRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 58);
            this.label3.TabIndex = 9;
            this.label3.Text = "MEY";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SidePanel.Location = new System.Drawing.Point(0, 159);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 55);
            this.SidePanel.TabIndex = 2;
            // 
            // ContactUs
            // 
            this.ContactUs.FlatAppearance.BorderSize = 0;
            this.ContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactUs.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactUs.ForeColor = System.Drawing.Color.Black;
            this.ContactUs.Image = ((System.Drawing.Image)(resources.GetObject("ContactUs.Image")));
            this.ContactUs.Location = new System.Drawing.Point(12, 209);
            this.ContactUs.Name = "ContactUs";
            this.ContactUs.Size = new System.Drawing.Size(271, 55);
            this.ContactUs.TabIndex = 7;
            this.ContactUs.Text = "          CONTACT US";
            this.ContactUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ContactUs.UseVisualStyleBackColor = true;
            this.ContactUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // LokasiTerdekat
            // 
            this.LokasiTerdekat.FlatAppearance.BorderSize = 0;
            this.LokasiTerdekat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LokasiTerdekat.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LokasiTerdekat.ForeColor = System.Drawing.Color.Black;
            this.LokasiTerdekat.Image = ((System.Drawing.Image)(resources.GetObject("LokasiTerdekat.Image")));
            this.LokasiTerdekat.Location = new System.Drawing.Point(12, 353);
            this.LokasiTerdekat.Name = "LokasiTerdekat";
            this.LokasiTerdekat.Size = new System.Drawing.Size(271, 55);
            this.LokasiTerdekat.TabIndex = 6;
            this.LokasiTerdekat.Text = "    CEK LOKASI";
            this.LokasiTerdekat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LokasiTerdekat.UseVisualStyleBackColor = true;
            this.LokasiTerdekat.Click += new System.EventHandler(this.LokasiTerdekat_Click);
            // 
            // CekTarif
            // 
            this.CekTarif.FlatAppearance.BorderSize = 0;
            this.CekTarif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CekTarif.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CekTarif.ForeColor = System.Drawing.Color.Black;
            this.CekTarif.Image = ((System.Drawing.Image)(resources.GetObject("CekTarif.Image")));
            this.CekTarif.Location = new System.Drawing.Point(12, 259);
            this.CekTarif.Name = "CekTarif";
            this.CekTarif.Size = new System.Drawing.Size(271, 55);
            this.CekTarif.TabIndex = 5;
            this.CekTarif.Text = "      CEK TARIF";
            this.CekTarif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CekTarif.UseVisualStyleBackColor = true;
            this.CekTarif.Click += new System.EventHandler(this.CekTarif_Click);
            // 
            // Pesanan
            // 
            this.Pesanan.FlatAppearance.BorderSize = 0;
            this.Pesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pesanan.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesanan.ForeColor = System.Drawing.Color.Black;
            this.Pesanan.Image = ((System.Drawing.Image)(resources.GetObject("Pesanan.Image")));
            this.Pesanan.Location = new System.Drawing.Point(12, 300);
            this.Pesanan.Name = "Pesanan";
            this.Pesanan.Size = new System.Drawing.Size(271, 66);
            this.Pesanan.TabIndex = 4;
            this.Pesanan.Text = "       PESANAN";
            this.Pesanan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Pesanan.UseVisualStyleBackColor = true;
            this.Pesanan.Click += new System.EventHandler(this.Pesananku_Click);
            // 
            // Home
            // 
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.Black;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(12, 159);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(271, 55);
            this.Home.TabIndex = 2;
            this.Home.Text = "           HOME";
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Lonceng);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(283, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 47);
            this.panel2.TabIndex = 1;
            // 
            // Lonceng
            // 
            this.Lonceng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Lonceng.BackgroundImage")));
            this.Lonceng.FlatAppearance.BorderSize = 0;
            this.Lonceng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lonceng.Location = new System.Drawing.Point(579, 5);
            this.Lonceng.Name = "Lonceng";
            this.Lonceng.Size = new System.Drawing.Size(35, 32);
            this.Lonceng.TabIndex = 6;
            this.Lonceng.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(620, 7);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(28, 28);
            this.Exit.TabIndex = 5;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pemograman Visual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "MEY EXPRESS";
            // 
            // lokasiScreen1
            // 
            this.lokasiScreen1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lokasiScreen1.Location = new System.Drawing.Point(282, 49);
            this.lokasiScreen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lokasiScreen1.Name = "lokasiScreen1";
            this.lokasiScreen1.Size = new System.Drawing.Size(667, 504);
            this.lokasiScreen1.TabIndex = 10;
            // 
            // cekTarifScreen1
            // 
            this.cekTarifScreen1.BackColor = System.Drawing.Color.White;
            this.cekTarifScreen1.Location = new System.Drawing.Point(282, 49);
            this.cekTarifScreen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cekTarifScreen1.Name = "cekTarifScreen1";
            this.cekTarifScreen1.Size = new System.Drawing.Size(668, 504);
            this.cekTarifScreen1.TabIndex = 9;
            // 
            // pesanankuScreen1
            // 
            this.pesanankuScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(150)))), ((int)(((byte)(125)))));
            this.pesanankuScreen1.Location = new System.Drawing.Point(282, 49);
            this.pesanankuScreen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pesanankuScreen1.Name = "pesanankuScreen1";
            this.pesanankuScreen1.Size = new System.Drawing.Size(668, 501);
            this.pesanankuScreen1.TabIndex = 8;
            // 
            // homeScreen1
            // 
            this.homeScreen1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.homeScreen1.Location = new System.Drawing.Point(282, 49);
            this.homeScreen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeScreen1.Name = "homeScreen1";
            this.homeScreen1.Size = new System.Drawing.Size(667, 498);
            this.homeScreen1.TabIndex = 7;
            // 
            // aboutUsScreen1
            // 
            this.aboutUsScreen1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.aboutUsScreen1.Location = new System.Drawing.Point(282, 48);
            this.aboutUsScreen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aboutUsScreen1.Name = "aboutUsScreen1";
            this.aboutUsScreen1.Size = new System.Drawing.Size(668, 505);
            this.aboutUsScreen1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 551);
            this.Controls.Add(this.aboutUsScreen1);
            this.Controls.Add(this.lokasiScreen1);
            this.Controls.Add(this.cekTarifScreen1);
            this.Controls.Add(this.pesanankuScreen1);
            this.Controls.Add(this.homeScreen1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button ContactUs;
        private System.Windows.Forms.Button LokasiTerdekat;
        private System.Windows.Forms.Button CekTarif;
        private System.Windows.Forms.Button Pesanan;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Lonceng;
        private System.Windows.Forms.Button Exit;
        private homeScreen1 homeScreen1;
        private PesananScreen1 pesanankuScreen1;
        private CekTarifScreen cekTarifScreen1;
        private LokasiScreen lokasiScreen1;
        private ContactUsScreen aboutUsScreen1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

