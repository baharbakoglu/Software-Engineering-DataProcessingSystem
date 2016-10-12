namespace BBM487
{
    partial class FormOgrenciTranskript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgrenciTranskript));
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
            this.listNot = new System.Windows.Forms.ListBox();
            this.lblGenelAOrt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoUst)).BeginInit();
            this.SuspendLayout();
            // 
            // logoUst
            // 
            this.logoUst.BackColor = System.Drawing.Color.Transparent;
            this.logoUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoUst.ErrorImage = null;
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
            this.labelKullanici.TabIndex = 2;
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
            this.btnKisiselBilgiler.TabIndex = 5;
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
            this.labelKisiselBilgiler.TabIndex = 6;
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
            this.btnKarne.TabIndex = 7;
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
            this.labelKarne.TabIndex = 8;
            this.labelKarne.Text = "Karne";
            this.labelKarne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTranskript
            // 
            this.btnTranskript.BackColor = System.Drawing.Color.Transparent;
            this.btnTranskript.BackgroundImage = global::BBM487.Properties.Resources.transkript;
            this.btnTranskript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTranskript.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTranskript.FlatAppearance.BorderSize = 0;
            this.btnTranskript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTranskript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTranskript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranskript.Location = new System.Drawing.Point(33, 306);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(60, 60);
            this.btnTranskript.TabIndex = 9;
            this.btnTranskript.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTranskript.UseVisualStyleBackColor = false;
            // 
            // labelTranskript
            // 
            this.labelTranskript.BackColor = System.Drawing.Color.Transparent;
            this.labelTranskript.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTranskript.Location = new System.Drawing.Point(0, 369);
            this.labelTranskript.Name = "labelTranskript";
            this.labelTranskript.Size = new System.Drawing.Size(128, 29);
            this.labelTranskript.TabIndex = 10;
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
            this.btnCikis.TabIndex = 11;
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
            this.labelCikis.TabIndex = 12;
            this.labelCikis.Text = "Oturumu Kapat";
            this.labelCikis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listNot
            // 
            this.listNot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listNot.FormattingEnabled = true;
            this.listNot.ItemHeight = 19;
            this.listNot.Location = new System.Drawing.Point(277, 186);
            this.listNot.Name = "listNot";
            this.listNot.Size = new System.Drawing.Size(730, 403);
            this.listNot.TabIndex = 13;
            // 
            // lblGenelAOrt
            // 
            this.lblGenelAOrt.AutoSize = true;
            this.lblGenelAOrt.BackColor = System.Drawing.Color.White;
            this.lblGenelAOrt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelAOrt.Location = new System.Drawing.Point(273, 159);
            this.lblGenelAOrt.Name = "lblGenelAOrt";
            this.lblGenelAOrt.Size = new System.Drawing.Size(0, 19);
            this.lblGenelAOrt.TabIndex = 12;
            this.lblGenelAOrt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormOgrenciTranskript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BBM487.Properties.Resources.arka;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblGenelAOrt);
            this.Controls.Add(this.listNot);
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
            this.Name = "FormOgrenciTranskript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacettepe Üniversitesi - Bilgi Gözlem - Transkript";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOgrenciTranskript_FormClosed);
            this.Load += new System.EventHandler(this.FormOgrenciTranskript_Load);
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
        private System.Windows.Forms.ListBox listNot;
        private System.Windows.Forms.Label lblGenelAOrt;
    }
}