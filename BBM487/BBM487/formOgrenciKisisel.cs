using BBM487.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBM487
{
    public partial class FormOgrenciKisisel : Form
    {
        private Ogrenci ogrenci;
        private Akademisyen danisman;
        private VeriTabani vt;
        private Form anaForm;
        public FormOgrenciKisisel(Ogrenci ogrenci,Form anaForm)
        {
            InitializeComponent();
            this.ogrenci = ogrenci;
            labelKullanici.Text ="Giriş Yapan Kullanıcı:" + ogrenci.Adi + " " + ogrenci.Soyadi;
            vt=VeriTabani.getVt;
            var d = from kayit in vt.listKullanici
                    where kayit.getTur().Equals("akademisyen") && ((Akademisyen)kayit).PersonelKod.Equals(ogrenci.DanismanKodu)
                    select kayit;
            if (d.Count() == 0)
                danisman = null;
            else
                danisman = (Akademisyen)d.ToArray()[0];
            if (danisman == null)
                labelDanisman.Text = "Danışman:  Danışman Bilgisi Bulanamadı";
            else
                labelDanisman.Text = "Danışman:  " + danisman.Adi + " " + danisman.Soyadi;

            labelTc.Text = "Tc Kimlik No:  " + ogrenci.TCKimlikNo;
            labelOgrNo.Text = "Öğrenci No:  " + ogrenci.OgrenciNo;
            labelAd.Text = "İsim ve Soyisim:  " + ogrenci.Adi + " " + ogrenci.Soyadi;
            txtMail.Text = ogrenci.Mail;
            txtSifre.Text = ogrenci.Sifre;
            this.anaForm = anaForm;
        }


        private void btnKarne_MouseEnter(object sender, EventArgs e)
        {
            btnKarne.BackgroundImage = Resources.karne;
        }

        private void btnKarne_MouseLeave(object sender, EventArgs e)
        {
            btnKarne.BackgroundImage = Resources.karne_sb;
        }

        private void btnTranskript_MouseEnter(object sender, EventArgs e)
        {
            btnTranskript.BackgroundImage = Resources.transkript;
        }

        private void btnTranskript_MouseLeave(object sender, EventArgs e)
        {
            btnTranskript.BackgroundImage = Resources.transkript_sb;
        }

        private void btnCikis_MouseEnter(object sender, EventArgs e)
        {
            btnCikis.BackgroundImage = Resources.cikis;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.BackgroundImage = Resources.cikis_sb;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text.Length == 0) {
                MessageBox.Show("Şifre Kısmı Boş Olamaz!!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ogrenci.Mail = txtMail.Text;
            ogrenci.Sifre = txtSifre.Text;
            MessageBox.Show("Değişiklikler Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void formOgrenciKisisel_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }

      
        private void btnKarne_Click(object sender, EventArgs e)
        {
            Hide();
            new FormOgrenciKarne(ogrenci, this).Show();
        }

        private void btnTranskript_Click(object sender, EventArgs e)
        {
            Hide();
            new FormOgrenciTranskript(ogrenci, this).Show();
        }

    }
}
