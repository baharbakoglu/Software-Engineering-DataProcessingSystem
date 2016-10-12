namespace BBM487
{
    partial class FormPersonelDers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelDers));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDanisman = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listDersler = new System.Windows.Forms.ListBox();
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
            this.labelKullanici = new System.Windows.Forms.Label();
            this.logoUst = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoUst)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(775, 437);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 50);
            this.btnKaydet.TabIndex = 112;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(1052, 437);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 50);
            this.btnTemizle.TabIndex = 111;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtKredi
            // 
            this.txtKredi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKredi.Location = new System.Drawing.Point(961, 374);
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(255, 26);
            this.txtKredi.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(785, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 105;
            this.label6.Text = "Kredisi";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(961, 330);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(255, 26);
            this.txtAd.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(785, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 103;
            this.label5.Text = "Ders Adı:";
            // 
            // txtDanisman
            // 
            this.txtDanisman.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDanisman.Location = new System.Drawing.Point(961, 279);
            this.txtDanisman.Name = "txtDanisman";
            this.txtDanisman.Size = new System.Drawing.Size(255, 26);
            this.txtDanisman.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(785, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 101;
            this.label4.Text = "Danışman Kodu:";
            // 
            // txtBolum
            // 
            this.txtBolum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolum.Location = new System.Drawing.Point(961, 223);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(255, 26);
            this.txtBolum.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(785, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 99;
            this.label3.Text = "Bölüm Kodu:";
            // 
            // txtDonem
            // 
            this.txtDonem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDonem.Location = new System.Drawing.Point(961, 166);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.Size = new System.Drawing.Size(255, 26);
            this.txtDonem.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(785, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 97;
            this.label2.Text = "Ders Dönemi";
            // 
            // txtKodu
            // 
            this.txtKodu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKodu.Location = new System.Drawing.Point(961, 122);
            this.txtKodu.Name = "txtKodu";
            this.txtKodu.Size = new System.Drawing.Size(255, 26);
            this.txtKodu.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(785, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 95;
            this.label1.Text = "Ders Kodu:";
            // 
            // listDersler
            // 
            this.listDersler.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listDersler.FormattingEnabled = true;
            this.listDersler.ItemHeight = 16;
            this.listDersler.Location = new System.Drawing.Point(198, 118);
            this.listDersler.Name = "listDersler";
            this.listDersler.Size = new System.Drawing.Size(527, 532);
            this.listDersler.TabIndex = 94;
            // 
            // labelKayıtAc
            // 
            this.labelKayıtAc.BackColor = System.Drawing.Color.Transparent;
            this.labelKayıtAc.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKayıtAc.Location = new System.Drawing.Point(20, 647);
            this.labelKayıtAc.Name = "labelKayıtAc";
            this.labelKayıtAc.Size = new System.Drawing.Size(92, 22);
            this.labelKayıtAc.TabIndex = 88;
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
            this.labelBolumBilgileri.TabIndex = 89;
            this.labelBolumBilgileri.Text = "Bölüm Bilgileri";
            this.labelBolumBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKayıtAc
            // 
            this.btnKayıtAc.BackColor = System.Drawing.Color.Transparent;
            this.btnKayıtAc.BackgroundImage = global::BBM487.Properties.Resources.kayitac;
            this.btnKayıtAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKayıtAc.FlatAppearance.BorderSize = 0;
            this.btnKayıtAc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKayıtAc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKayıtAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtAc.Location = new System.Drawing.Point(26, 584);
            this.btnKayıtAc.Name = "btnKayıtAc";
            this.btnKayıtAc.Size = new System.Drawing.Size(89, 60);
            this.btnKayıtAc.TabIndex = 82;
            this.btnKayıtAc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKayıtAc.UseVisualStyleBackColor = false;
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
            this.btnBolumBilgileri.TabIndex = 83;
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
            this.labelDönemBilgileri.TabIndex = 90;
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
            this.btnDonemBilgileri.TabIndex = 84;
            this.btnDonemBilgileri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDonemBilgileri.UseVisualStyleBackColor = false;
            this.btnDonemBilgileri.Click += new System.EventHandler(this.btnDonemBilgileri_Click);
            this.btnDonemBilgileri.MouseEnter += new System.EventHandler(this.btnDonemBilgileri_MouseEnter);
            this.btnDonemBilgileri.MouseLeave += new System.EventHandler(this.btnOgrenciBilgileri_MouseLeave);
            // 
            // labelOgrenciBilgileri
            // 
            this.labelOgrenciBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.labelOgrenciBilgileri.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrenciBilgileri.Location = new System.Drawing.Point(23, 370);
            this.labelOgrenciBilgileri.Name = "labelOgrenciBilgileri";
            this.labelOgrenciBilgileri.Size = new System.Drawing.Size(108, 19);
            this.labelOgrenciBilgileri.TabIndex = 91;
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
            this.labelAkademisyenBilgileri.TabIndex = 92;
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
            this.labelKisileBilgiler.TabIndex = 93;
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
            this.btnOgrenciBilgileri.Location = new System.Drawing.Point(26, 301);
            this.btnOgrenciBilgileri.Name = "btnOgrenciBilgileri";
            this.btnOgrenciBilgileri.Size = new System.Drawing.Size(103, 66);
            this.btnOgrenciBilgileri.TabIndex = 85;
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
            this.btnAkademisyenBilgileri.TabIndex = 86;
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
            this.btnKisiselBilgiler.Location = new System.Drawing.Point(26, 106);
            this.btnKisiselBilgiler.Name = "btnKisiselBilgiler";
            this.btnKisiselBilgiler.Size = new System.Drawing.Size(103, 78);
            this.btnKisiselBilgiler.TabIndex = 87;
            this.btnKisiselBilgiler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKisiselBilgiler.UseVisualStyleBackColor = false;
            this.btnKisiselBilgiler.Click += new System.EventHandler(this.btnKisiselBilgiler_Click);
            this.btnKisiselBilgiler.MouseEnter += new System.EventHandler(this.btnKisiselBilgiler_MouseEnter);
            this.btnKisiselBilgiler.MouseLeave += new System.EventHandler(this.btnKisiselBilgiler_MouseLeave);
            // 
            // labelCikisPersonel
            // 
            this.labelCikisPersonel.BackColor = System.Drawing.Color.Transparent;
            this.labelCikisPersonel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCikisPersonel.Location = new System.Drawing.Point(1185, 637);
            this.labelCikisPersonel.Name = "labelCikisPersonel";
            this.labelCikisPersonel.Size = new System.Drawing.Size(63, 44);
            this.labelCikisPersonel.TabIndex = 81;
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
            this.buttonCikis.TabIndex = 80;
            this.buttonCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            this.buttonCikis.MouseEnter += new System.EventHandler(this.buttonCikis_MouseEnter);
            this.buttonCikis.MouseLeave += new System.EventHandler(this.buttonCikis_MouseLeave);
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.BackColor = System.Drawing.Color.Transparent;
            this.labelKullanici.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanici.Location = new System.Drawing.Point(12, 9);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(89, 19);
            this.labelKullanici.TabIndex = 79;
            this.labelKullanici.Text = "Kullanıcı : ";
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
            this.logoUst.TabIndex = 78;
            this.logoUst.TabStop = false;
            // 
            // FormPersonelDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BBM487.Properties.Resources.arka;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtKredi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDanisman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDonem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDersler);
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
            this.Name = "FormPersonelDers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacettepe Üniversitesi - Bilgi Gözlem - Ders Bilgileri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPersonelDers_FormClosed);
            this.Load += new System.EventHandler(this.FormPersonelDers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoUst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtKredi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDanisman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listDersler;
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
        private System.Windows.Forms.Label labelCikisPersonel;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Label labelKullanici;
        private System.Windows.Forms.PictureBox logoUst;
    }
}