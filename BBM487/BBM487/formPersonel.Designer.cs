namespace BBM487
{
    partial class FormPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonel));
            this.logoUst = new System.Windows.Forms.PictureBox();
            this.labelPersonel = new System.Windows.Forms.Label();
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
            this.labelCikisPersonel = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
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
            this.logoUst.Size = new System.Drawing.Size(1264, 172);
            this.logoUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoUst.TabIndex = 1;
            this.logoUst.TabStop = false;
            // 
            // labelPersonel
            // 
            this.labelPersonel.AutoSize = true;
            this.labelPersonel.BackColor = System.Drawing.Color.Transparent;
            this.labelPersonel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonel.Location = new System.Drawing.Point(12, 9);
            this.labelPersonel.Name = "labelPersonel";
            this.labelPersonel.Size = new System.Drawing.Size(89, 19);
            this.labelPersonel.TabIndex = 2;
            this.labelPersonel.Text = "Kullanıcı : ";
           
            // 
            // labelKayıtAc
            // 
            this.labelKayıtAc.BackColor = System.Drawing.Color.Transparent;
            this.labelKayıtAc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKayıtAc.Location = new System.Drawing.Point(812, 548);
            this.labelKayıtAc.Name = "labelKayıtAc";
            this.labelKayıtAc.Size = new System.Drawing.Size(105, 55);
            this.labelKayıtAc.TabIndex = 11;
            this.labelKayıtAc.Text = "Ders Bilgileri";
            this.labelKayıtAc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBolumBilgileri
            // 
            this.labelBolumBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.labelBolumBilgileri.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBolumBilgileri.Location = new System.Drawing.Point(560, 548);
            this.labelBolumBilgileri.Name = "labelBolumBilgileri";
            this.labelBolumBilgileri.Size = new System.Drawing.Size(128, 29);
            this.labelBolumBilgileri.TabIndex = 12;
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
            this.btnKayıtAc.Location = new System.Drawing.Point(800, 417);
            this.btnKayıtAc.Name = "btnKayıtAc";
            this.btnKayıtAc.Size = new System.Drawing.Size(128, 128);
            this.btnKayıtAc.TabIndex = 5;
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
            this.btnBolumBilgileri.Location = new System.Drawing.Point(560, 417);
            this.btnBolumBilgileri.Name = "btnBolumBilgileri";
            this.btnBolumBilgileri.Size = new System.Drawing.Size(128, 128);
            this.btnBolumBilgileri.TabIndex = 6;
            this.btnBolumBilgileri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBolumBilgileri.UseVisualStyleBackColor = false;
            this.btnBolumBilgileri.Click += new System.EventHandler(this.btnBolumBilgileri_Click);
            this.btnBolumBilgileri.MouseEnter += new System.EventHandler(this.btnBolumBilgileri_MouseEnter);
            this.btnBolumBilgileri.MouseLeave += new System.EventHandler(this.btnBolumBilgileri_MouseLeave);
            // 
            // labelDönemBilgileri
            // 
            this.labelDönemBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.labelDönemBilgileri.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDönemBilgileri.Location = new System.Drawing.Point(320, 548);
            this.labelDönemBilgileri.Name = "labelDönemBilgileri";
            this.labelDönemBilgileri.Size = new System.Drawing.Size(128, 29);
            this.labelDönemBilgileri.TabIndex = 13;
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
            this.btnDonemBilgileri.Location = new System.Drawing.Point(320, 416);
            this.btnDonemBilgileri.Name = "btnDonemBilgileri";
            this.btnDonemBilgileri.Size = new System.Drawing.Size(128, 128);
            this.btnDonemBilgileri.TabIndex = 7;
            this.btnDonemBilgileri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDonemBilgileri.UseVisualStyleBackColor = false;
            this.btnDonemBilgileri.Click += new System.EventHandler(this.btnDonemBilgileri_Click);
            this.btnDonemBilgileri.MouseEnter += new System.EventHandler(this.btnDonemBilgileri_MouseEnter);
            this.btnDonemBilgileri.MouseLeave += new System.EventHandler(this.btnDonemBilgileri_MouseLeave);
            // 
            // labelOgrenciBilgileri
            // 
            this.labelOgrenciBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.labelOgrenciBilgileri.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrenciBilgileri.Location = new System.Drawing.Point(784, 340);
            this.labelOgrenciBilgileri.Name = "labelOgrenciBilgileri";
            this.labelOgrenciBilgileri.Size = new System.Drawing.Size(159, 29);
            this.labelOgrenciBilgileri.TabIndex = 14;
            this.labelOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            this.labelOgrenciBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAkademisyenBilgileri
            // 
            this.labelAkademisyenBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.labelAkademisyenBilgileri.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAkademisyenBilgileri.Location = new System.Drawing.Point(537, 335);
            this.labelAkademisyenBilgileri.Name = "labelAkademisyenBilgileri";
            this.labelAkademisyenBilgileri.Size = new System.Drawing.Size(173, 39);
            this.labelAkademisyenBilgileri.TabIndex = 15;
            this.labelAkademisyenBilgileri.Text = "Akademisyen Bilgileri";
            this.labelAkademisyenBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKisileBilgiler
            // 
            this.labelKisileBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.labelKisileBilgiler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKisileBilgiler.Location = new System.Drawing.Point(320, 335);
            this.labelKisileBilgiler.Name = "labelKisileBilgiler";
            this.labelKisileBilgiler.Size = new System.Drawing.Size(128, 29);
            this.labelKisileBilgiler.TabIndex = 16;
            this.labelKisileBilgiler.Text = "Kişisel Bilgiler";
            this.labelKisileBilgiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnOgrenciBilgileri.Location = new System.Drawing.Point(800, 204);
            this.btnOgrenciBilgileri.Name = "btnOgrenciBilgileri";
            this.btnOgrenciBilgileri.Size = new System.Drawing.Size(128, 128);
            this.btnOgrenciBilgileri.TabIndex = 8;
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
            this.btnAkademisyenBilgileri.Location = new System.Drawing.Point(560, 204);
            this.btnAkademisyenBilgileri.Name = "btnAkademisyenBilgileri";
            this.btnAkademisyenBilgileri.Size = new System.Drawing.Size(128, 128);
            this.btnAkademisyenBilgileri.TabIndex = 9;
            this.btnAkademisyenBilgileri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAkademisyenBilgileri.UseVisualStyleBackColor = false;
            this.btnAkademisyenBilgileri.Click += new System.EventHandler(this.btnAkademisyenBilgileri_Click);
            this.btnAkademisyenBilgileri.MouseEnter += new System.EventHandler(this.btnAkademisyenBilgileri_MouseEnter);
            this.btnAkademisyenBilgileri.MouseLeave += new System.EventHandler(this.btnAkademisyenBilgileri_MouseLeave);
            // 
            // btnKisiselBilgiler
            // 
            this.btnKisiselBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.BackgroundImage = global::BBM487.Properties.Resources.bilgiGuncelle_sb;
            this.btnKisiselBilgiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKisiselBilgiler.FlatAppearance.BorderSize = 0;
            this.btnKisiselBilgiler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiselBilgiler.Location = new System.Drawing.Point(320, 204);
            this.btnKisiselBilgiler.Name = "btnKisiselBilgiler";
            this.btnKisiselBilgiler.Size = new System.Drawing.Size(128, 128);
            this.btnKisiselBilgiler.TabIndex = 10;
            this.btnKisiselBilgiler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKisiselBilgiler.UseVisualStyleBackColor = false;
            this.btnKisiselBilgiler.Click += new System.EventHandler(this.btnKisiselBilgiler_Click);
            this.btnKisiselBilgiler.MouseEnter += new System.EventHandler(this.btnKisiselBilgiler_MouseEnter);
            this.btnKisiselBilgiler.MouseLeave += new System.EventHandler(this.btnKisiselBilgiler_MouseLeave);
            // 
            // labelCikisPersonel
            // 
            this.labelCikisPersonel.BackColor = System.Drawing.Color.Transparent;
            this.labelCikisPersonel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCikisPersonel.Location = new System.Drawing.Point(1183, 643);
            this.labelCikisPersonel.Name = "labelCikisPersonel";
            this.labelCikisPersonel.Size = new System.Drawing.Size(66, 37);
            this.labelCikisPersonel.TabIndex = 18;
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
            this.buttonCikis.Location = new System.Drawing.Point(1186, 563);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(66, 77);
            this.buttonCikis.TabIndex = 17;
            this.buttonCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            this.buttonCikis.MouseEnter += new System.EventHandler(this.buttonCikis_MouseEnter);
            this.buttonCikis.MouseLeave += new System.EventHandler(this.buttonCikis_MouseLeave);
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BBM487.Properties.Resources.arka;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelCikisPersonel);
            this.Controls.Add(this.buttonCikis);
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
            this.Controls.Add(this.labelPersonel);
            this.Controls.Add(this.logoUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ana Sayfa";
            this.Load += new System.EventHandler(this.PersonelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoUst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoUst;
        private System.Windows.Forms.Label labelPersonel;

        private System.Windows.Forms.Label labelKayıtAc;
        private System.Windows.Forms.Button btnKayıtAc;

        private System.Windows.Forms.Label labelBolumBilgileri;
        private System.Windows.Forms.Button btnBolumBilgileri;

        private System.Windows.Forms.Label labelDönemBilgileri;
        private System.Windows.Forms.Button btnDonemBilgileri;

        private System.Windows.Forms.Label labelOgrenciBilgileri;
        private System.Windows.Forms.Button btnOgrenciBilgileri;

        private System.Windows.Forms.Label labelKisileBilgiler;
        private System.Windows.Forms.Button btnKisiselBilgiler;

        private System.Windows.Forms.Button btnAkademisyenBilgileri;
        private System.Windows.Forms.Label labelAkademisyenBilgileri;

        private System.Windows.Forms.Label labelCikisPersonel;
        private System.Windows.Forms.Button buttonCikis;

    }
}