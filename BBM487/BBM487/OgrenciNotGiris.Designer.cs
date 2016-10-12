namespace BBM487
{
    partial class OgrenciNotGiris
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dersNotu = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dersNotu
            // 
            this.dersNotu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dersNotu.FormattingEnabled = true;
            this.dersNotu.Items.AddRange(new object[] {
            "F3",
            "F2",
            "F1",
            "D",
            "C3",
            "C2",
            "C1",
            "B3",
            "B2",
            "B1",
            "A3",
            "A2",
            "A1"});
            this.dersNotu.Location = new System.Drawing.Point(880, 14);
            this.dersNotu.Name = "dersNotu";
            this.dersNotu.Size = new System.Drawing.Size(47, 28);
            this.dersNotu.TabIndex = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.AutoSize = true;
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAciklama.Location = new System.Drawing.Point(0, 0);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(66, 20);
            this.txtAciklama.TabIndex = 1;
            this.txtAciklama.Text = "Açıklama";
            this.txtAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Location = new System.Drawing.Point(7, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 28);
            this.panel1.TabIndex = 2;
            // 
            // OgrenciNotGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dersNotu);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OgrenciNotGiris";
            this.Size = new System.Drawing.Size(930, 50);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox dersNotu;
        private System.Windows.Forms.Label txtAciklama;
        private System.Windows.Forms.Panel panel1;
    }
}
