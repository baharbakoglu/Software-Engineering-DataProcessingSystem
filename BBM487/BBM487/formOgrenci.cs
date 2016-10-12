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
    public partial class formOgrenci : Form
    {
        private Ogrenci ogrenci;
        public formOgrenci(Ogrenci ogrenci)
        {
            InitializeComponent();
            this.ogrenci = ogrenci;
            labelKullanici.Text ="Giriş Yapan Kullanıcı:" + ogrenci.Adi + " " + ogrenci.Soyadi;
        }


        private void btnKisiselBilgiler_MouseLeave(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle_sb;
        }

        private void btnKisiselBilgiler_MouseEnter(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle;
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

        private void btnKayit_MouseEnter(object sender, EventArgs e)
        {
            btnKayit.BackgroundImage = Resources.dersEkleOgrenci;
        }

        private void btnKayit_MouseLeave(object sender, EventArgs e)
        {
            btnKayit.BackgroundImage = Resources.dersEkleOgrenci_sb;
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

        private void btnKisiselBilgiler_Click(object sender, EventArgs e)
        {
            Hide();
            new FormOgrenciKisisel(ogrenci, this).Show();
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
        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (VeriTabani.getVt.dersEklemeAktif)
            {
                Hide();
                new FormOgrenciKayit(ogrenci, this).Show();
            }
            else {
                MessageBox.Show("Ders Ekleme Dönemi Aktif Değil!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    

      


    }
}
