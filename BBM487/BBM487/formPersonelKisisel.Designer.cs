namespace BBM487
{
    partial class FormPersonelKisisel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelKisisel));
            this.logoUst = new System.Windows.Forms.PictureBox();
            this.labelKullanici = new System.Windows.Forms.Label();
            this.labelCikisPersonel = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.labelKayıtAc = new System.Windows.Forms.Label();
            this.labelBolumBilgileri = new System.Windows.Forms.Label();
            this.btnKayıtAc = new System.Windows.Forms.Button();
            this.btnBolumBilgileri = new System.Windows.Forms.Button();
            this.labelDönemBilgileri = new System.Windows.Forms.Label();
            this.btnDonemBilgileri = new System.Windows.Forms.Button();
            this.labelOgrenciBilgileri = new System.Windows.Forms.Label();
            this.labelAkademisyenBilgileri = new System.Windows.Forms.Label();
            this.labelKisileBilgiler = new System.Windows.Forms.Label();
            this.btnOgrenciBilgileri = new System.Windows.Forms.Button();
            this.btnAkademisyenBilgileri = new System.Windows.Forms.Button();
            this.btnKisiselBilgiler = new System.Windows.Forms.Button();
            this.labelKa = new System.Windows.Forms.Label();
            this.labelPersonelSifre = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoUst)).BeginInit();
            this.SuspendLayout();
            // 
            // logoUst
            // 
            this.logoUst.BackColor = System.Drawing.Color.Transparent;
            this.logoUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoUst.Image = global::BBM487.Properties.Resources.baslik;
            this.logoUst.Location = new System.Drawing.Point(0, 0);
            this.logoUst.Name = "logoUst";
            this.logoUst.Size = new System.Drawing.Size(1264, 100);
            this.logoUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoUst.TabIndex = 2;
            this.logoUst.TabStop = false;
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.BackColor = System.Drawing.Color.Transparent;
            this.labelKullanici.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanici.Location = new System.Drawing.Point(12, 9);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(89, 19);
            this.labelKullanici.TabIndex = 3;
            this.labelKullanici.Text = "Kullanıcı : ";
            // 
            // labelCikisPersonel
            // 
            this.labelCikisPersonel.BackColor = System.Drawing.Color.Transparent;
            this.labelCikisPersonel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCikisPersonel.Location = new System.Drawing.Point(1185, 637);
            this.labelCikisPersonel.Name = "labelCikisPersonel";
            this.labelCikisPersonel.Size = new System.Drawing.Size(63, 44);
            this.labelCikisPersonel.TabIndex = 20;
            this.labelCikisPersonel.Text = "Oturumu Kapat";
            this.labelCikisPersonel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.BackgroundImage = global::BBM487.Properties.Resources.cikis_sb;
            this.buttonCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCikis.Location = new System.Drawing.Point(1173, 573);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(91, 61);
            this.buttonCikis.TabIndex = 19;
            this.buttonCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            this.buttonCikis.MouseEnter += new System.EventHandler(this.buttonCikis_MouseEnter);
            this.buttonCikis.MouseLeave += new System.EventHandler(this.buttonCikis_MouseLeave);
            // 
            // labelKayıtAc
            // 
            this.labelKayıtAc.BackColor = System.Drawing.Color.Transparent;
            this.labelKayıtAc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKayıtAc.Location = new System.Drawing.Point(20, 647);
            this.labelKayıtAc.Name = "labelKayıtAc";
            this.labelKayıtAc.Size = new System.Drawing.Size(92, 22);
            this.labelKayıtAc.TabIndex = 27;
            this.labelKayıtAc.Text = "Ders Bilgileri";
            this.labelKayıtAc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBolumBilgileri
            // 
            this.labelBolumBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.labelBolumBilgileri.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBolumBilgileri.Location = new System.Drawing.Point(23, 559);
            this.labelBolumBilgileri.Name = "labelBolumBilgileri";
            this.labelBolumBilgileri.Size = new System.Drawing.Size(107, 19);
            this.labelBolumBilgileri.TabIndex = 28;
            this.labelBolumBilgileri.Text = "Bölüm Bilgileri";
            this.labelBolumBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKayıtAc
            // 
            this.btnKayıtAc.BackColor = System.Drawing.Color.Transparent;
            this.btnKayıtAc.BackgroundImage = global::BBM487.Properties.Resources.kayitac_sb;
            this.btnKayıtAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKayıtAc.FlatAppearance.BorderSize = 0;
            this.btnKayıtAc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKayıtAc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKayıtAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtAc.Location = new System.Drawing.Point(26, 584);
            this.btnKayıtAc.Name = "btnKayıtAc";
            this.btnKayıtAc.Size = new System.Drawing.Size(89, 60);
            this.btnKayıtAc.TabIndex = 21;
            this.btnKayıtAc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKayıtAc.UseVisualStyleBackColor = false;
            this.btnKayıtAc.Click += new System.EventHandler(this.btnKayıtAc_Click);
            this.btnKayıtAc.MouseEnter += new System.EventHandler(this.btnKayıtAc_MouseEnter);
            this.btnKayıtAc.MouseLeave += new System.EventHandler(this.btnKayıtAc_MouseLeave);
            // 
            // btnBolumBilgileri
            // 
            this.btnBolumBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.btnBolumBilgileri.BackgroundImage = global::BBM487.Properties.Resources.bolumbilgileri_sb;
            this.btnBolumBilgileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBolumBilgileri.FlatAppearance.BorderSize = 0;
            this.btnBolumBilgileri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBolumBilgileri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBolumBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBolumBilgileri.Location = new System.Drawing.Point(34, 490);
            this.btnBolumBilgileri.Name = "btnBolumBilgileri";
            this.btnBolumBilgileri.Size = new System.Drawing.Size(81, 67);
            this.btnBolumBilgileri.TabIndex = 22;
            this.btnBolumBilgileri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBolumBilgileri.UseVisualStyleBackColor = false;
            this.btnBolumBilgileri.Click += new System.EventHandler(this.btnBolumBilgileri_Click);
            this.btnBolumBilgileri.MouseEnter += new System.EventHandler(this.btnBolumBilgileri_MouseEnter);
            this.btnBolumBilgileri.MouseLeave += new System.EventHandler(this.btnBolumBilgileri_MouseLeave);
            // 
            // labelDönemBilgileri
            // 
            this.labelDönemBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.labelDönemBilgileri.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDönemBilgileri.Location = new System.Drawing.Point(20, 467);
            this.labelDönemBilgileri.Name = "labelDönemBilgileri";
            this.labelDönemBilgileri.Size = new System.Drawing.Size(118, 20);
            this.labelDönemBilgileri.TabIndex = 29;
            this.labelDönemBilgileri.Text = "Dönem Bilgileri";
            this.labelDönemBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDonemBilgileri
            // 
            this.btnDonemBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.btnDonemBilgileri.BackgroundImage = global::BBM487.Properties.Resources.donembilgileri_sb;
            this.btnDonemBilgileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDonemBilgileri.FlatAppearance.BorderSize = 0;
            this.btnDonemBilgileri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDonemBilgileri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDonemBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonemBilgileri.Location = new System.Drawing.Point(23, 392);
            this.btnDonemBilgileri.Name = "btnDonemBilgileri";
            this.btnDonemBilgileri.Size = new System.Drawing.Size(106, 72);
            this.btnDonemBilgileri.TabIndex = 23;
            this.btnDonemBilgileri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDonemBilgileri.UseVisualStyleBackColor = false;
            this.btnDonemBilgileri.Click += new System.EventHandler(this.btnDonemBilgileri_Click);
            this.btnDonemBilgileri.MouseEnter += new System.EventHandler(this.btnDonemBilgileri_MouseEnter);
            this.btnDonemBilgileri.MouseLeave += new System.EventHandler(this.btnDonemBilgileri_MouseLeave);
            // 
            // labelOgrenciBilgileri
            // 
            this.labelOgrenciBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.labelOgrenciBilgileri.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrenciBilgileri.Location = new System.Drawing.Point(23, 370);
            this.labelOgrenciBilgileri.Name = "labelOgrenciBilgileri";
            this.labelOgrenciBilgileri.Size = new System.Drawing.Size(108, 19);
            this.labelOgrenciBilgileri.TabIndex = 30;
            this.labelOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            this.labelOgrenciBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAkademisyenBilgileri
            // 
            this.labelAkademisyenBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.labelAkademisyenBilgileri.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAkademisyenBilgileri.Location = new System.Drawing.Point(13, 279);
            this.labelAkademisyenBilgileri.Name = "labelAkademisyenBilgileri";
            this.labelAkademisyenBilgileri.Size = new System.Drawing.Size(137, 19);
            this.labelAkademisyenBilgileri.TabIndex = 31;
            this.labelAkademisyenBilgileri.Text = "Akademisyen Bilgileri";
            this.labelAkademisyenBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKisileBilgiler
            // 
            this.labelKisileBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.labelKisileBilgiler.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKisileBilgiler.Location = new System.Drawing.Point(30, 187);
            this.labelKisileBilgiler.Name = "labelKisileBilgiler";
            this.labelKisileBilgiler.Size = new System.Drawing.Size(99, 26);
            this.labelKisileBilgiler.TabIndex = 32;
            this.labelKisileBilgiler.Text = "Kişisel Bilgiler";
            this.labelKisileBilgiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKisileBilgiler.Click += new System.EventHandler(this.labelKisileBilgiler_Click);
            // 
            // btnOgrenciBilgileri
            // 
            this.btnOgrenciBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.btnOgrenciBilgileri.BackgroundImage = global::BBM487.Properties.Resources.ogrenciListesi_sb;
            this.btnOgrenciBilgileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOgrenciBilgileri.FlatAppearance.BorderSize = 0;
            this.btnOgrenciBilgileri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOgrenciBilgileri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOgrenciBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciBilgileri.Location = new System.Drawing.Point(26, 301);
            this.btnOgrenciBilgileri.Name = "btnOgrenciBilgileri";
            this.btnOgrenciBilgileri.Size = new System.Drawing.Size(103, 66);
            this.btnOgrenciBilgileri.TabIndex = 24;
            this.btnOgrenciBilgileri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrenciBilgileri.UseVisualStyleBackColor = false;
            this.btnOgrenciBilgileri.Click += new System.EventHandler(this.btnOgrenciBilgileri_Click);
            this.btnOgrenciBilgileri.MouseEnter += new System.EventHandler(this.btnOgrenciBilgileri_MouseEnter);
            this.btnOgrenciBilgileri.MouseLeave += new System.EventHandler(this.btnOgrenciBilgileri_MouseLeave);
            // 
            // btnAkademisyenBilgileri
            // 
            this.btnAkademisyenBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.btnAkademisyenBilgileri.BackgroundImage = global::BBM487.Properties.Resources.akademisyenbilgileri_sb;
            this.btnAkademisyenBilgileri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAkademisyenBilgileri.FlatAppearance.BorderSize = 0;
            this.btnAkademisyenBilgileri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAkademisyenBilgileri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAkademisyenBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAkademisyenBilgileri.Location = new System.Drawing.Point(23, 216);
            this.btnAkademisyenBilgileri.Name = "btnAkademisyenBilgileri";
            this.btnAkademisyenBilgileri.Size = new System.Drawing.Size(106, 64);
            this.btnAkademisyenBilgileri.TabIndex = 25;
            this.btnAkademisyenBilgileri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAkademisyenBilgileri.UseVisualStyleBackColor = false;
            this.btnAkademisyenBilgileri.Click += new System.EventHandler(this.btnAkademisyenBilgileri_Click);
            this.btnAkademisyenBilgileri.MouseEnter += new System.EventHandler(this.btnAkademisyenBilgileri_MouseEnter);
            this.btnAkademisyenBilgileri.MouseLeave += new System.EventHandler(this.btnAkademisyenBilgileri_MouseLeave);
            // 
            // btnKisiselBilgiler
            // 
            this.btnKisiselBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.BackgroundImage = global::BBM487.Properties.Resources.bilgiGuncelle;
            this.btnKisiselBilgiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKisiselBilgiler.FlatAppearance.BorderSize = 0;
            this.btnKisiselBilgiler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiselBilgiler.Location = new System.Drawing.Point(26, 106);
            this.btnKisiselBilgiler.Name = "btnKisiselBilgiler";
            this.btnKisiselBilgiler.Size = new System.Drawing.Size(103, 78);
            this.btnKisiselBilgiler.TabIndex = 26;
            this.btnKisiselBilgiler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKisiselBilgiler.UseVisualStyleBackColor = false;
            this.btnKisiselBilgiler.Click += new System.EventHandler(this.btnKisiselBilgiler_Click);
            // 
            // labelKa
            // 
            this.labelKa.AutoSize = true;
            this.labelKa.BackColor = System.Drawing.Color.Transparent;
            this.labelKa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKa.Location = new System.Drawing.Point(330, 340);
            this.labelKa.Name = "labelKa";
            this.labelKa.Size = new System.Drawing.Size(109, 19);
            this.labelKa.TabIndex = 34;
            this.labelKa.Text = "Kullanıcı Adı:";
            // 
            // labelPersonelSifre
            // 
            this.labelPersonelSifre.AutoSize = true;
            this.labelPersonelSifre.BackColor = System.Drawing.Color.Transparent;
            this.labelPersonelSifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonelSifre.Location = new System.Drawing.Point(381, 372);
            this.labelPersonelSifre.Name = "labelPersonelSifre";
            this.labelPersonelSifre.Size = new System.Drawing.Size(58, 19);
            this.labelPersonelSifre.TabIndex = 37;
            this.labelPersonelSifre.Text = "Şifre : ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(458, 401);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(255, 64);
            this.btnKaydet.TabIndex = 41;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelSifre.Location = new System.Drawing.Point(458, 365);
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.PasswordChar = '*';
            this.txtPersonelSifre.Size = new System.Drawing.Size(255, 26);
            this.txtPersonelSifre.TabIndex = 42;
            // 
            // FormPersonelKisisel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BBM487.Properties.Resources.arka;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txtPersonelSifre);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.labelPersonelSifre);
            this.Controls.Add(this.labelKa);
            this.Controls.Add(this.labelKayıtAc);
            this.Controls.Add(this.labelBolumBilgileri);
            this.Controls.Add(this.btnKayıtAc);
            this.Controls.Add(this.btnBolumBilgileri);
            this.Controls.Add(this.labelDönemBilgileri);
            this.Controls.Add(this.btnDonemBilgileri);
            this.Controls.Add(this.labelOgrenciBilgileri);
            this.Controls.Add(this.labelAkademisyenBilgileri);
            this.Controls.Add(this.labelKisileBilgiler);
            this.Controls.Add(this.btnOgrenciBilgileri);
            this.Controls.Add(this.btnAkademisyenBilgileri);
            this.Controls.Add(this.btnKisiselBilgiler);
            this.Controls.Add(this.labelCikisPersonel);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.labelKullanici);
            this.Controls.Add(this.logoUst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormPersonelKisisel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacettepe Üniversitesi - Bilgi Gözlem - Kişisel Bilgiler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPersonelMenuler_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.logoUst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoUst;
        private System.Windows.Forms.Label labelKullanici;
        private System.Windows.Forms.Label labelCikisPersonel;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Label labelKayıtAc;
        private System.Windows.Forms.Label labelBolumBilgileri;
        private System.Windows.Forms.Button btnKayıtAc;
        private System.Windows.Forms.Button btnBolumBilgileri;
        private System.Windows.Forms.Label labelDönemBilgileri;
        private System.Windows.Forms.Button btnDonemBilgileri;
        private System.Windows.Forms.Label labelOgrenciBilgileri;
        private System.Windows.Forms.Label labelAkademisyenBilgileri;
        private System.Windows.Forms.Label labelKisileBilgiler;
        private System.Windows.Forms.Button btnOgrenciBilgileri;
        private System.Windows.Forms.Button btnAkademisyenBilgileri;
        private System.Windows.Forms.Button btnKisiselBilgiler;
        private System.Windows.Forms.Label labelKa;
        private System.Windows.Forms.Label labelPersonelSifre;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtPersonelSifre;

    }
}