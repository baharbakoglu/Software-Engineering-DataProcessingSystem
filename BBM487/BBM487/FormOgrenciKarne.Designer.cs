namespace BBM487
{
    partial class FormOgrenciKarne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgrenciKarne));
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
            this.labelDonem = new System.Windows.Forms.Label();
            this.listKarne = new System.Windows.Forms.ListBox();
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
            this.logoUst.TabIndex = 0;
            this.logoUst.TabStop = false;
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.BackColor = System.Drawing.Color.Transparent;
            this.labelKullanici.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanici.Location = new System.Drawing.Point(12, 9);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(102, 22);
            this.labelKullanici.TabIndex = 3;
            this.labelKullanici.Text = "Kullanıcı :";
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
            this.btnKisiselBilgiler.Location = new System.Drawing.Point(33, 117);
            this.btnKisiselBilgiler.Name = "btnKisiselBilgiler";
            this.btnKisiselBilgiler.Size = new System.Drawing.Size(64, 64);
            this.btnKisiselBilgiler.TabIndex = 4;
            this.btnKisiselBilgiler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKisiselBilgiler.UseVisualStyleBackColor = false;
            this.btnKisiselBilgiler.Click += new System.EventHandler(this.btnKisiselBilgiler_Click);
            this.btnKisiselBilgiler.MouseEnter += new System.EventHandler(this.btnKisiselBilgiler_MouseEnter);
            this.btnKisiselBilgiler.MouseLeave += new System.EventHandler(this.btnKisiselBilgiler_MouseLeave);
            // 
            // labelKisiselBilgiler
            // 
            this.labelKisiselBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.labelKisiselBilgiler.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKisiselBilgiler.Location = new System.Drawing.Point(15, 184);
            this.labelKisiselBilgiler.Name = "labelKisiselBilgiler";
            this.labelKisiselBilgiler.Size = new System.Drawing.Size(109, 16);
            this.labelKisiselBilgiler.TabIndex = 5;
            this.labelKisiselBilgiler.Text = "Kişisel Bilgiler";
            this.labelKisiselBilgiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKarne
            // 
            this.btnKarne.BackColor = System.Drawing.Color.Transparent;
            this.btnKarne.BackgroundImage = global::BBM487.Properties.Resources.karne;
            this.btnKarne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKarne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKarne.FlatAppearance.BorderSize = 0;
            this.btnKarne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKarne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarne.Location = new System.Drawing.Point(38, 217);
            this.btnKarne.Name = "btnKarne";
            this.btnKarne.Size = new System.Drawing.Size(48, 48);
            this.btnKarne.TabIndex = 6;
            this.btnKarne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKarne.UseVisualStyleBackColor = false;
            // 
            // labelKarne
            // 
            this.labelKarne.BackColor = System.Drawing.Color.Transparent;
            this.labelKarne.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKarne.Location = new System.Drawing.Point(15, 277);
            this.labelKarne.Name = "labelKarne";
            this.labelKarne.Size = new System.Drawing.Size(97, 17);
            this.labelKarne.TabIndex = 7;
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
            this.btnTranskript.TabIndex = 8;
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
            this.labelTranskript.TabIndex = 9;
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
            this.btnCikis.TabIndex = 10;
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
            this.labelCikis.TabIndex = 11;
            this.labelCikis.Text = "Oturumu Kapat";
            this.labelCikis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDonem
            // 
            this.labelDonem.AutoSize = true;
            this.labelDonem.BackColor = System.Drawing.Color.Transparent;
            this.labelDonem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDonem.Location = new System.Drawing.Point(342, 137);
            this.labelDonem.Name = "labelDonem";
            this.labelDonem.Size = new System.Drawing.Size(0, 19);
            this.labelDonem.TabIndex = 12;
            // 
            // listKarne
            // 
            this.listKarne.BackColor = System.Drawing.SystemColors.Window;
            this.listKarne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listKarne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listKarne.FormattingEnabled = true;
            this.listKarne.ItemHeight = 19;
            this.listKarne.Location = new System.Drawing.Point(345, 185);
            this.listKarne.Name = "listKarne";
            this.listKarne.Size = new System.Drawing.Size(604, 323);
            this.listKarne.TabIndex = 13;
            // 
            // FormOgrenciKarne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BBM487.Properties.Resources.arka;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.listKarne);
            this.Controls.Add(this.labelDonem);
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
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormOgrenciKarne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacettepe Üniversitesi - Bilgi Gözlem - Karne Görüntüleme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOgrenciKarne_FormClosed);
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
        private System.Windows.Forms.Label labelDonem;
        private System.Windows.Forms.ListBox listKarne;
    }
}