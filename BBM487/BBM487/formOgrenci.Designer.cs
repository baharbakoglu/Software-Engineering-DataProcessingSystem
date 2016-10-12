namespace BBM487
{
    partial class formOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOgrenci));
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
            this.btnKayit = new System.Windows.Forms.Button();
            this.labelKayıt = new System.Windows.Forms.Label();
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
            this.btnKisiselBilgiler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKisiselBilgiler.BackgroundImage")));
            this.btnKisiselBilgiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKisiselBilgiler.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKisiselBilgiler.FlatAppearance.BorderSize = 0;
            this.btnKisiselBilgiler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiselBilgiler.Location = new System.Drawing.Point(359, 187);
            this.btnKisiselBilgiler.Name = "btnKisiselBilgiler";
            this.btnKisiselBilgiler.Size = new System.Drawing.Size(128, 128);
            this.btnKisiselBilgiler.TabIndex = 3;
            this.btnKisiselBilgiler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKisiselBilgiler.UseVisualStyleBackColor = false;
            this.btnKisiselBilgiler.Click += new System.EventHandler(this.btnKisiselBilgiler_Click);
            this.btnKisiselBilgiler.MouseEnter += new System.EventHandler(this.btnKisiselBilgiler_MouseEnter);
            this.btnKisiselBilgiler.MouseLeave += new System.EventHandler(this.btnKisiselBilgiler_MouseLeave);
            // 
            // labelKisiselBilgiler
            // 
            this.labelKisiselBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.labelKisiselBilgiler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKisiselBilgiler.Location = new System.Drawing.Point(355, 309);
            this.labelKisiselBilgiler.Name = "labelKisiselBilgiler";
            this.labelKisiselBilgiler.Size = new System.Drawing.Size(128, 29);
            this.labelKisiselBilgiler.TabIndex = 4;
            this.labelKisiselBilgiler.Text = "Kişisel Bilgiler";
            this.labelKisiselBilgiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKarne
            // 
            this.btnKarne.BackColor = System.Drawing.Color.Transparent;
            this.btnKarne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKarne.BackgroundImage")));
            this.btnKarne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKarne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKarne.FlatAppearance.BorderSize = 0;
            this.btnKarne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKarne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarne.Location = new System.Drawing.Point(699, 209);
            this.btnKarne.Name = "btnKarne";
            this.btnKarne.Size = new System.Drawing.Size(160, 106);
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
            this.labelKarne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKarne.Location = new System.Drawing.Point(715, 309);
            this.labelKarne.Name = "labelKarne";
            this.labelKarne.Size = new System.Drawing.Size(128, 29);
            this.labelKarne.TabIndex = 6;
            this.labelKarne.Text = "Karne";
            this.labelKarne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTranskript
            // 
            this.btnTranskript.BackColor = System.Drawing.Color.Transparent;
            this.btnTranskript.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTranskript.BackgroundImage")));
            this.btnTranskript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTranskript.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTranskript.FlatAppearance.BorderSize = 0;
            this.btnTranskript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTranskript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTranskript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranskript.Location = new System.Drawing.Point(355, 391);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(128, 128);
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
            this.labelTranskript.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTranskript.Location = new System.Drawing.Point(355, 522);
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
            this.btnCikis.Location = new System.Drawing.Point(1199, 563);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(66, 77);
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
            this.labelCikis.Location = new System.Drawing.Point(1199, 643);
            this.labelCikis.Name = "labelCikis";
            this.labelCikis.Size = new System.Drawing.Size(66, 37);
            this.labelCikis.TabIndex = 10;
            this.labelCikis.Text = "Oturumu Kapat";
            this.labelCikis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Transparent;
            this.btnKayit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKayit.BackgroundImage")));
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKayit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKayit.FlatAppearance.BorderSize = 0;
            this.btnKayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Location = new System.Drawing.Point(719, 391);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(140, 114);
            this.btnKayit.TabIndex = 12;
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            this.btnKayit.MouseEnter += new System.EventHandler(this.btnKayit_MouseEnter);
            this.btnKayit.MouseLeave += new System.EventHandler(this.btnKayit_MouseLeave);
            // 
            // labelKayıt
            // 
            this.labelKayıt.BackColor = System.Drawing.Color.Transparent;
            this.labelKayıt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKayıt.Location = new System.Drawing.Point(719, 522);
            this.labelKayıt.Name = "labelKayıt";
            this.labelKayıt.Size = new System.Drawing.Size(128, 29);
            this.labelKayıt.TabIndex = 13;
            this.labelKayıt.Text = "Kayıt";
            this.labelKayıt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BBM487.Properties.Resources.arka;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelKayıt);
            this.Controls.Add(this.btnKayit);
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
            this.Name = "formOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacettepe Üniversitesi - Bilgi Gözlem - Öğrenci Ekranı";
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
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label labelKayıt;

    }
}