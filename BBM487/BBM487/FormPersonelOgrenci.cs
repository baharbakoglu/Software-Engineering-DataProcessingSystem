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
    public partial class FormPersonelOgrenci : Form
    {
        VeriTabani vt;
        Personel personel;
        Form anaForm;
        public FormPersonelOgrenci(Personel personel, Form anaForm)
        {
            InitializeComponent();
            vt = VeriTabani.getVt;
            this.personel = personel;
            this.anaForm = anaForm;
            labelKullanici.Text = "Kullanıcı:" + personel.KullaniciAdi;
        }
        

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTc.Clear();
            txtOgrNo.Clear();
            txtBolum.Clear();
            txtDanisman.Clear();
            txtIsim.Clear();
            txtSoyisim.Clear();
            txtMail.Clear();
            txtSifre.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci(txtTc.Text, txtOgrNo.Text, txtBolum.Text, txtDanisman.Text, txtIsim.Text, txtSoyisim.Text, txtMail.Text, txtSifre.Text);
            vt.kullaniciEkle(o);
            btnTemizle_Click(sender, e);
            listele();
        }
        private void listele() {
            listOgrenciler.Items.Clear();
            List<Ogrenci> list = vt.ogrenciListesi();
            if (list.Count == 0)
            {
                listOgrenciler.Items.Add("Kayıtlı Hiç Bir Öğrenci Bulunmamaktadır!!");
                return;
            }
            foreach (Ogrenci o in list)
            {
                listOgrenciler.Items.Add(o.TCKimlikNo + "   " + o.OgrenciNo + "   " + o.Adi + "   " + o.Soyadi);

            }
        }
        private void FormPersonelOgrenci_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void FormPersonelOgrenci_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }







        private void buttonCikis_MouseEnter(object sender, EventArgs e)
        {
            buttonCikis.BackgroundImage = Resources.cikis;
        }

        private void buttonCikis_MouseLeave(object sender, EventArgs e)
        {
            buttonCikis.BackgroundImage = Resources.cikis_sb;
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

        private void btnKisiselBilgiler_MouseEnter(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle;
        }

        private void btnKisiselBilgiler_MouseLeave(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle_sb;
        }

        private void btnAkademisyenBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelAkademisyen(personel, this).Show();
        }

        private void btnBolumBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelBolum(personel, this).Show();
        }

        private void btnBolumBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnBolumBilgileri.BackgroundImage = Resources.bolumbilgileri;
        }

        private void btnBolumBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnBolumBilgileri.BackgroundImage = Resources.bolumbilgileri_sb;
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
