using BBM487.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBM487
{
    public partial class FormPersonelAkademisyen : Form
    {
        Personel personel;
        Form anaForm;
        VeriTabani vt;
        public FormPersonelAkademisyen(Personel personel , Form anaForm)
        {
            InitializeComponent();
            this.personel = personel;
            this.anaForm = anaForm;
            vt = VeriTabani.getVt;
            labelKullanici.Text = "Kullanıcı : " + personel.KullaniciAdi;
        }

        private void FormPersonelAkademisyen_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTc.Clear();
            txtPerNo.Clear();
            txtBolum.Clear();
            txtIsim.Clear();
            txtSoyisim.Clear();
            txtMail.Clear();
            txtSifre.Clear();
        }
        private void listele() {
            listAkademisyen.Items.Clear();
            if (vt.akademisyenListesi().Count == 0)
            {
                listAkademisyen.Items.Add("Akademisyen Bilgisi Bulunmamaktadır!!");
                return;
            }
            foreach(Akademisyen a in vt.akademisyenListesi()){
                listAkademisyen.Items.Add(a.PersonelKod+"   "+a.BolumKodu+"   "+a.Adi+"   "+a.Soyadi);
            }
        
        }
        private void FormPersonelAkademisyen_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Akademisyen a = new Akademisyen(txtTc.Text, txtPerNo.Text, txtBolum.Text, txtIsim.Text, txtSoyisim.Text, txtMail.Text, txtSifre.Text);
            vt.kullaniciEkle(a);
            btnTemizle_Click(sender, e);
            listele();
        }

        private void btnKisiselBilgiler_MouseEnter(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle;
        }

        private void btnKisiselBilgiler_MouseLeave(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle_sb;
        }

        private void btnOgrenciBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnOgrenciBilgileri.BackgroundImage = Resources.ogrenciListesi;
        }

        private void btnOgrenciBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnOgrenciBilgileri.BackgroundImage = Resources.ogrenciListesi_sb;
        }

        private void btnDonemBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnDonemBilgileri.BackgroundImage = Resources.donembilgileri;
        }

        private void btnDonemBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnDonemBilgileri.BackgroundImage = Resources.donembilgileri_sb;
        }

        private void btnBolumBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnBolumBilgileri.BackgroundImage = Resources.bolumbilgileri;
        }

        private void btnBolumBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnBolumBilgileri.BackgroundImage = Resources.bolumbilgileri_sb;
        }

        private void btnKayıtAc_MouseEnter(object sender, EventArgs e)
        {
            btnKayıtAc.BackgroundImage = Resources.kayitac;
        }

        private void btnKayıtAc_MouseLeave(object sender, EventArgs e)
        {
            btnKayıtAc.BackgroundImage = Resources.kayitac_sb;
        }

        private void btnKisiselBilgiler_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelKisisel(personel, this).Show();
        }

        private void btnOgrenciBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelOgrenci(personel, this).Show();
        }

        private void btnDonemBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelDonem(personel, this).Show();
        }

        private void btnBolumBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelBolum(personel, this).Show();
        }

        private void btnKayıtAc_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelDers(personel, this).Show();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCikis_MouseEnter(object sender, EventArgs e)
        {
            buttonCikis.BackgroundImage = Resources.cikis;
        }

        private void buttonCikis_MouseLeave(object sender, EventArgs e)
        {
            buttonCikis.BackgroundImage = Resources.cikis_sb;
        }





    }
}
