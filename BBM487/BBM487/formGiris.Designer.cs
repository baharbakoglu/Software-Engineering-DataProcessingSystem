namespace BBM487
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.label_kullanici = new System.Windows.Forms.Label();
            this.label_sifre = new System.Windows.Forms.Label();
            this.txtKa = new System.Windows.Forms.TextBox();
            this.txtSfr = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDonem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_kullanici
            // 
            this.label_kullanici.AutoSize = true;
            this.label_kullanici.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kullanici.Location = new System.Drawing.Point(403, 209);
            this.label_kullanici.Name = "label_kullanici";
            this.label_kullanici.Size = new System.Drawing.Size(109, 19);
            this.label_kullanici.TabIndex = 0;
            this.label_kullanici.Text = "Kullanıcı Adı:";
            // 
            // label_sifre
            // 
            this.label_sifre.AutoSize = true;
            this.label_sifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sifre.Location = new System.Drawing.Point(462, 252);
            this.label_sifre.Name = "label_sifre";
            this.label_sifre.Size = new System.Drawing.Size(50, 19);
            this.label_sifre.TabIndex = 1;
            this.label_sifre.Text = "Şifre:";
            // 
            // txtKa
            // 
            this.txtKa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKa.Location = new System.Drawing.Point(518, 206);
            this.txtKa.Name = "txtKa";
            this.txtKa.Size = new System.Drawing.Size(185, 26);
            this.txtKa.TabIndex = 2;
            // 
            // txtSfr
            // 
            this.txtSfr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSfr.Location = new System.Drawing.Point(518, 249);
            this.txtSfr.Name = "txtSfr";
            this.txtSfr.PasswordChar = '*';
            this.txtSfr.Size = new System.Drawing.Size(185, 26);
            this.txtSfr.TabIndex = 3;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(518, 290);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(185, 39);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "Giriş Yap";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::BBM487.Properties.Resources.baslik;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1184, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtDonem
            // 
            this.txtDonem.AutoSize = true;
            this.txtDonem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDonem.Location = new System.Drawing.Point(506, 169);
            this.txtDonem.Name = "txtDonem";
            this.txtDonem.Size = new System.Drawing.Size(301, 19);
            this.txtDonem.TabIndex = 6;
            this.txtDonem.Text = "Ders Dönemi Bilgisi Burada Yer Alacak";
            this.txtDonem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 331);
            this.Controls.Add(this.txtDonem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtSfr);
            this.Controls.Add(this.txtKa);
            this.Controls.Add(this.label_sifre);
            this.Controls.Add(this.label_kullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 370);
            this.Name = "FormGiris";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hacettepe Üniversitesi - Bilgi Gözlem";
            this.Load += new System.EventHandler(this.formGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_kullanici;
        private System.Windows.Forms.Label label_sifre;
        private System.Windows.Forms.TextBox txtKa;
        private System.Windows.Forms.TextBox txtSfr;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtDonem;
    }
}