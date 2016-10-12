namespace BBM487
{
    partial class FormOgrenciKisisel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgrenciKisisel));
            this.logoUst = new System.Windows.Forms.PictureBox();
            this.labelKullanici = new System.Windows.Forms.Label();
            this.btnKisiselBilgiler = new System.Windows.Forms.Button();
            this.labelKisiselBilgiler = new System.Windows.Forms.Label();
            this.btnKarne = new System.Windows.Forms.Button();
            this.labelKarne = new System.Windows.Forms.Label();
            this.btnTranskript = new System.Windows.Forms.Button();
            this.labelTranskript = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.labelCikis = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.labelOgrNo = new System.Windows.Forms.Label();
            this.labelDanisman = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
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
            this.logoUst.TabIndex = 11;
            this.logoUst.TabStop = false;
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanici.Location = new System.Drawing.Point(12, 9);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(161, 22);
            this.labelKullanici.TabIndex = 1;
            this.labelKullanici.Text = "Kullanıcı : Demo";
            // 
            // btnKisiselBilgiler
            // 
            this.btnKisiselBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.BackgroundImage = global::BBM487.Properties.Resources.bilgiGuncelle;
            this.btnKisiselBilgiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKisiselBilgiler.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKisiselBilgiler.FlatAppearance.BorderSize = 0;
            this.btnKisiselBilgiler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiselBilgiler.Location = new System.Drawing.Point(33, 117);
            this.btnKisiselBilgiler.Name = "btnKisiselBilgiler";
            this.btnKisiselBilgiler.Size = new System.Drawing.Size(64, 64);
            this.btnKisiselBilgiler.TabIndex = 3;
            this.btnKisiselBilgiler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKisiselBilgiler.UseVisualStyleBackColor = false;
            // 
            // labelKisiselBilgiler
            // 
            this.labelKisiselBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.labelKisiselBilgiler.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKisiselBilgiler.Location = new System.Drawing.Point(15, 184);
            this.labelKisiselBilgiler.Name = "labelKisiselBilgiler";
            this.labelKisiselBilgiler.Size = new System.Drawing.Size(109, 16);
            this.labelKisiselBilgiler.TabIndex = 4;
            this.labelKisiselBilgiler.Text = "Kişisel Bilgiler";
            this.labelKisiselBilgiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKarne
            // 
            this.btnKarne.BackColor = System.Drawing.Color.Transparent;
            this.btnKarne.BackgroundImage = global::BBM487.Properties.Resources.karne_sb;
            this.btnKarne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKarne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKarne.FlatAppearance.BorderSize = 0;
            this.btnKarne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKarne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarne.Location = new System.Drawing.Point(38, 217);
            this.btnKarne.Name = "btnKarne";
            this.btnKarne.Size = new System.Drawing.Size(48, 48);
            this.btnKarne.TabIndex = 5;
            this.btnKarne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKarne.UseVisualStyleBackColor = false;
            this.btnKarne.Click += new System.EventHandler(this.btnKarne_Click);
            this.btnKarne.MouseEnter += new System.EventHandler(this.btnKarne_MouseEnter);
            this.btnKarne.MouseLeave += new System.EventHandler(this.btnKarne_MouseLeave);
            // 
            // labelKarne
            // 
            this.labelKarne.BackColor = System.Drawing.Color.Transparent;
            this.labelKarne.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKarne.Location = new System.Drawing.Point(15, 277);
            this.labelKarne.Name = "labelKarne";
            this.labelKarne.Size = new System.Drawing.Size(97, 17);
            this.labelKarne.TabIndex = 6;
            this.labelKarne.Text = "Karne";
            this.labelKarne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTranskript
            // 
            this.btnTranskript.BackColor = System.Drawing.Color.Transparent;
            this.btnTranskript.BackgroundImage = global::BBM487.Properties.Resources.transkript_sb;
            this.btnTranskript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTranskript.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTranskript.FlatAppearance.BorderSize = 0;
            this.btnTranskript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTranskript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTranskript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranskript.Location = new System.Drawing.Point(33, 306);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(60, 60);
            this.btnTranskript.TabIndex = 7;
            this.btnTranskript.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTranskript.UseVisualStyleBackColor = false;
            this.btnTranskript.Click += new System.EventHandler(this.btnTranskript_Click);
            this.btnTranskript.MouseEnter += new System.EventHandler(this.btnTranskript_MouseEnter);
            this.btnTranskript.MouseLeave += new System.EventHandler(this.btnTranskript_MouseLeave);
            // 
            // labelTranskript
            // 
            this.labelTranskript.BackColor = System.Drawing.Color.Transparent;
            this.labelTranskript.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTranskript.Location = new System.Drawing.Point(0, 369);
            this.labelTranskript.Name = "labelTranskript";
            this.labelTranskript.Size = new System.Drawing.Size(128, 29);
            this.labelTranskript.TabIndex = 8;
            this.labelTranskript.Text = "Transkript";
            this.labelTranskript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(42, 414);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(44, 55);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            this.btnCikis.MouseEnter += new System.EventHandler(this.btnCikis_MouseEnter);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            // 
            // labelCikis
            // 
            this.labelCikis.BackColor = System.Drawing.Color.Transparent;
            this.labelCikis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCikis.Location = new System.Drawing.Point(27, 472);
            this.labelCikis.Name = "labelCikis";
            this.labelCikis.Size = new System.Drawing.Size(66, 37);
            this.labelCikis.TabIndex = 10;
            this.labelCikis.Text = "Oturumu Kapat";
            this.labelCikis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTc.Location = new System.Drawing.Point(356, 159);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(110, 19);
            this.labelTc.TabIndex = 12;
            this.labelTc.Text = "Tc Kimlik No:";
            this.labelTc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOgrNo
            // 
            this.labelOgrNo.AutoSize = true;
            this.labelOgrNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOgrNo.Location = new System.Drawing.Point(365, 198);
            this.labelOgrNo.Name = "labelOgrNo";
            this.labelOgrNo.Size = new System.Drawing.Size(101, 19);
            this.labelOgrNo.TabIndex = 13;
            this.labelOgrNo.Text = "Öğrenci No:";
            this.labelOgrNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDanisman
            // 
            this.labelDanisman.AutoSize = true;
            this.labelDanisman.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDanisman.Location = new System.Drawing.Point(374, 233);
            this.labelDanisman.Name = "labelDanisman";
            this.labelDanisman.Size = new System.Drawing.Size(92, 19);
            this.labelDanisman.TabIndex = 14;
            this.labelDanisman.Text = "Danışman:";
            this.labelDanisman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAd.Location = new System.Drawing.Point(332, 268);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(133, 19);
            this.labelAd.TabIndex = 15;
            this.labelAd.Text = "İsim ve Soyisim:";
            this.labelAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMail.Location = new System.Drawing.Point(421, 306);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(45, 19);
            this.labelMail.TabIndex = 16;
            this.labelMail.Text = "Mail:";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.Location = new System.Drawing.Point(416, 348);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(50, 19);
            this.labelSifre.TabIndex = 17;
            this.labelSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(472, 345);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(255, 26);
            this.txtSifre.TabIndex = 18;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(472, 303);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(255, 26);
            this.txtMail.TabIndex = 19;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = global::BBM487.Properties.Resources.disket;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(472, 414);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(255, 64);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormOgrenciKisisel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BBM487.Properties.Resources.arka;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.labelDanisman);
            this.Controls.Add(this.labelOgrNo);
            this.Controls.Add(this.labelTc);
            this.Controls.Add(this.labelCikis);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.labelTranskript);
            this.Controls.Add(this.btnTranskript);
            this.Controls.Add(this.labelKarne);
            this.Controls.Add(this.btnKarne);
            this.Controls.Add(this.labelKisiselBilgiler);
            this.Controls.Add(this.btnKisiselBilgiler);
            this.Controls.Add(this.labelKullanici);
            this.Controls.Add(this.logoUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormOgrenciKisisel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacettepe Üniversitesi - Bilgi Gözlem - Kişisel Bilgiler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formOgrenciKisisel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.logoUst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoUst;
        private System.Windows.Forms.Label labelKullanici;
        private System.Windows.Forms.Button btnKisiselBilgiler;
        private System.Windows.Forms.Label labelKisiselBilgiler;
        private System.Windows.Forms.Button btnKarne;
        private System.Windows.Forms.Label labelKarne;
        private System.Windows.Forms.Button btnTranskript;
        private System.Windows.Forms.Label labelTranskript;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label labelCikis;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label labelOgrNo;
        private System.Windows.Forms.Label labelDanisman;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnKaydet;

    }
}