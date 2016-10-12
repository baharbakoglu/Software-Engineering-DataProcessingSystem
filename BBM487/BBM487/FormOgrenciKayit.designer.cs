namespace BBM487
{
    partial class FormOgrenciKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgrenciKayit));
            this.logoUst = new System.Windows.Forms.PictureBox();
            this.labelKullanici = new System.Windows.Forms.Label();
            this.labelCikis = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.labelTranskript = new System.Windows.Forms.Label();
            this.btnTranskript = new System.Windows.Forms.Button();
            this.labelKarne = new System.Windows.Forms.Label();
            this.btnKarne = new System.Windows.Forms.Button();
            this.labelKisiselBilgiler = new System.Windows.Forms.Label();
            this.btnKisiselBilgiler = new System.Windows.Forms.Button();
            this.labelKayıt = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.dersAlabilir = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dersAldigi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersAlabilir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersAldigi)).BeginInit();
            this.SuspendLayout();
            // 
            // logoUst
            // 
            this.logoUst.BackColor = System.Drawing.Color.Transparent;
            this.logoUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoUst.Image = global::BBM487.Properties.Resources.baslik;
            this.logoUst.Location = new System.Drawing.Point(0, 0);
            this.logoUst.Name = "logoUst";
            this.logoUst.Size = new System.Drawing.Size(1081, 98);
            this.logoUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoUst.TabIndex = 12;
            this.logoUst.TabStop = false;
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.BackColor = System.Drawing.Color.Transparent;
            this.labelKullanici.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanici.Location = new System.Drawing.Point(12, 9);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(122, 18);
            this.labelKullanici.TabIndex = 13;
            this.labelKullanici.Text = "Kullanıcı : Demo";
            // 
            // labelCikis
            // 
            this.labelCikis.BackColor = System.Drawing.Color.Transparent;
            this.labelCikis.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCikis.Location = new System.Drawing.Point(43, 544);
            this.labelCikis.Name = "labelCikis";
            this.labelCikis.Size = new System.Drawing.Size(66, 37);
            this.labelCikis.TabIndex = 21;
            this.labelCikis.Text = "Oturumu Kapat";
            this.labelCikis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnCikis.Location = new System.Drawing.Point(46, 473);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(64, 55);
            this.btnCikis.TabIndex = 20;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            this.btnCikis.MouseEnter += new System.EventHandler(this.btnCikis_MouseEnter);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            // 
            // labelTranskript
            // 
            this.labelTranskript.BackColor = System.Drawing.Color.Transparent;
            this.labelTranskript.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTranskript.Location = new System.Drawing.Point(8, 441);
            this.labelTranskript.Name = "labelTranskript";
            this.labelTranskript.Size = new System.Drawing.Size(128, 29);
            this.labelTranskript.TabIndex = 19;
            this.labelTranskript.Text = "Transkript";
            this.labelTranskript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnTranskript.Location = new System.Drawing.Point(33, 368);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(77, 70);
            this.btnTranskript.TabIndex = 18;
            this.btnTranskript.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTranskript.UseVisualStyleBackColor = false;
            this.btnTranskript.MouseEnter += new System.EventHandler(this.btnTranskript_MouseEnter);
            this.btnTranskript.MouseLeave += new System.EventHandler(this.btnTranskript_MouseLeave);
            // 
            // labelKarne
            // 
            this.labelKarne.BackColor = System.Drawing.Color.Transparent;
            this.labelKarne.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKarne.Location = new System.Drawing.Point(27, 345);
            this.labelKarne.Name = "labelKarne";
            this.labelKarne.Size = new System.Drawing.Size(96, 20);
            this.labelKarne.TabIndex = 17;
            this.labelKarne.Text = "Karne";
            this.labelKarne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnKarne.Location = new System.Drawing.Point(46, 290);
            this.btnKarne.Name = "btnKarne";
            this.btnKarne.Size = new System.Drawing.Size(60, 52);
            this.btnKarne.TabIndex = 16;
            this.btnKarne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKarne.UseVisualStyleBackColor = false;
            this.btnKarne.Click += new System.EventHandler(this.btnKarne_Click);
            this.btnKarne.MouseEnter += new System.EventHandler(this.btnKarne_MouseEnter);
            this.btnKarne.MouseLeave += new System.EventHandler(this.btnKarne_MouseLeave);
            // 
            // labelKisiselBilgiler
            // 
            this.labelKisiselBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.labelKisiselBilgiler.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKisiselBilgiler.Location = new System.Drawing.Point(27, 260);
            this.labelKisiselBilgiler.Name = "labelKisiselBilgiler";
            this.labelKisiselBilgiler.Size = new System.Drawing.Size(109, 16);
            this.labelKisiselBilgiler.TabIndex = 15;
            this.labelKisiselBilgiler.Text = "Kişisel Bilgiler";
            this.labelKisiselBilgiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKisiselBilgiler
            // 
            this.btnKisiselBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.BackgroundImage = global::BBM487.Properties.Resources.bilgiGuncelle_sb;
            this.btnKisiselBilgiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKisiselBilgiler.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKisiselBilgiler.FlatAppearance.BorderSize = 0;
            this.btnKisiselBilgiler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKisiselBilgiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiselBilgiler.Location = new System.Drawing.Point(42, 193);
            this.btnKisiselBilgiler.Name = "btnKisiselBilgiler";
            this.btnKisiselBilgiler.Size = new System.Drawing.Size(64, 64);
            this.btnKisiselBilgiler.TabIndex = 14;
            this.btnKisiselBilgiler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKisiselBilgiler.UseVisualStyleBackColor = false;
            this.btnKisiselBilgiler.Click += new System.EventHandler(this.btnKisiselBilgiler_Click);
            this.btnKisiselBilgiler.MouseEnter += new System.EventHandler(this.btnKisiselBilgiler_MouseEnter);
            this.btnKisiselBilgiler.MouseLeave += new System.EventHandler(this.btnKisiselBilgiler_MouseEnter);
            // 
            // labelKayıt
            // 
            this.labelKayıt.BackColor = System.Drawing.Color.Transparent;
            this.labelKayıt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKayıt.Location = new System.Drawing.Point(41, 164);
            this.labelKayıt.Name = "labelKayıt";
            this.labelKayıt.Size = new System.Drawing.Size(57, 26);
            this.labelKayıt.TabIndex = 23;
            this.labelKayıt.Text = "Kayıt";
            this.labelKayıt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnKayit.Location = new System.Drawing.Point(41, 104);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(68, 57);
            this.btnKayit.TabIndex = 22;
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKayit.UseVisualStyleBackColor = false;
            // 
            // dersAlabilir
            // 
            this.dersAlabilir.AllowUserToAddRows = false;
            this.dersAlabilir.AllowUserToDeleteRows = false;
            this.dersAlabilir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dersAlabilir.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dersAlabilir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersAlabilir.Location = new System.Drawing.Point(196, 139);
            this.dersAlabilir.Name = "dersAlabilir";
            this.dersAlabilir.RowHeadersVisible = false;
            this.dersAlabilir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dersAlabilir.Size = new System.Drawing.Size(428, 346);
            this.dersAlabilir.TabIndex = 29;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(532, 513);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(92, 30);
            this.btnEkle.TabIndex = 32;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dersAldigi
            // 
            this.dersAldigi.AllowUserToAddRows = false;
            this.dersAldigi.AllowUserToDeleteRows = false;
            this.dersAldigi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dersAldigi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersAldigi.Location = new System.Drawing.Point(657, 137);
            this.dersAldigi.Name = "dersAldigi";
            this.dersAldigi.RowHeadersVisible = false;
            this.dersAldigi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dersAldigi.Size = new System.Drawing.Size(378, 346);
            this.dersAldigi.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tüm Dersler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 14);
            this.label2.TabIndex = 35;
            this.label2.Text = "Eklenen Dersler";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(943, 513);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 30);
            this.btnSil.TabIndex = 36;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FormOgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BBM487.Properties.Resources.arka;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 667);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dersAldigi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dersAlabilir);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOgrenciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacettepe Üniversitesi - Bilgi Gözlem - Ders Kayıt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKayit_FormClosed);
            this.Load += new System.EventHandler(this.FormKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersAlabilir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersAldigi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoUst;
        private System.Windows.Forms.Label labelKullanici;
        private System.Windows.Forms.Label labelCikis;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label labelTranskript;
        private System.Windows.Forms.Button btnTranskript;
        private System.Windows.Forms.Label labelKarne;
        private System.Windows.Forms.Button btnKarne;
        private System.Windows.Forms.Label labelKisiselBilgiler;
        private System.Windows.Forms.Button btnKisiselBilgiler;
        private System.Windows.Forms.Label labelKayıt;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridView dersAlabilir;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dersAldigi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
    }
}