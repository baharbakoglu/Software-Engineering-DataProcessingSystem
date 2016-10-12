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
    public partial class FormPersonelBolum : Form
    {
        Personel personel;
        Form anaForm;
        VeriTabani vt;
        public FormPersonelBolum(Personel personel , Form anaForm)
        {
            InitializeComponent();
            this.personel = personel;
            this.anaForm = anaForm;
            vt = VeriTabani.getVt;
            labelKullanici.Text = "Kullanıcı:" + personel.KullaniciAdi;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKod.Clear();
            txtAdi.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Bolum b = new Bolum(txtKod.Text, txtAdi.Text);
            vt.listBolum.Add(b);
            btnTemizle_Click(sender, e);
            listele();
        }
        private void listele() {
            listBolumler.Items.Clear();
            if(vt.listBolum.Count==0){
            listBolumler.Items.Add("Bölüm bilgileri bulunmamaktadır!!");
                return;
            }
            foreach (Bolum b in vt.listBolum){
                listBolumler.Items.Add(b.BolumKodu+"   "+b.Aciklama);
            }
        
        }

        private void FormPersonelBolum_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }

        private void FormPersonelBolum_Load(object sender, EventArgs e)
        {
            listele();
        }


        private void btnDonemBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnDonemBilgileri.BackgroundImage = Resources.donembilgileri_sb;
        }
        private void btnDonemBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnDonemBilgileri.BackgroundImage = Resources.donembilgileri;
        }
        private void btnOgrenciBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnOgrenciBilgileri.BackgroundImage = Resources.ogrenciListesi_sb;
        }
        private void btnOgrenciBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnOgrenciBilgileri.BackgroundImage = Resources.ogrenciListesi;
        }

        private void btnAkademisyenBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnAkademisyenBilgileri.BackgroundImage = Resources.akademisyenbilgileri;
        }

        private void btnAkademisyenBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnAkademisyenBilgileri.BackgroundImage = Resources.akademisyenbilgileri_sb;
        }

        private void btnKayıtAc_MouseLeave(object sender, EventArgs e)
        {
            btnKayıtAc.BackgroundImage = Resources.kayitac_sb;
        }
        private void btnKayıtAc_MouseEnter(object sender, EventArgs e)
        {
            btnKayıtAc.BackgroundImage = Resources.kayitac;
        }


        private void buttonCikis_MouseLeave(object sender, EventArgs e)
        {
            buttonCikis.BackgroundImage = Resources.cikis_sb;
        }

        private void buttonCikis_MouseEnter(object sender, EventArgs e)
        {
            buttonCikis.BackgroundImage = Resources.cikis;
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


        private void btnKayıtAc_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelDers(personel, this).Show();
        }


        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAkademisyenBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelAkademisyen(personel, this).Show();
        }

        private void btnKisiselBilgiler_MouseEnter(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle;
        }

        private void btnKisiselBilgiler_MouseLeave(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle_sb;
        }


    }
}
