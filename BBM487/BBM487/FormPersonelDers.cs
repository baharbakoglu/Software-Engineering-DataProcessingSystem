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
    public partial class FormPersonelDers : Form
    {
        Personel personel;
        Form anaForm;
        VeriTabani vt;
        public FormPersonelDers(Personel personel , Form anaForm)
        {
            InitializeComponent();
            this.personel = personel;
            this.anaForm = anaForm;
            vt = VeriTabani.getVt;
            labelKullanici.Text = "Kullanıcı :" + personel.KullaniciAdi;
        }

        private void FormPersonelDers_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void listele() {
            listDersler.Items.Clear();
            if(vt.listDers.Count==0){
            listDersler.Items.Add("Ders Bilgisi Bulunmamaktadır!!");
                return;
            }
            foreach(Ders d in vt.listDers){
                listDersler.Items.Add(d.DersKodu+"   "+d.Donem.DonemKodu+"   "+d.Adi+"   "+d.Kredi);
            
            }        

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Ders d = Ders.createDers(txtKodu.Text, txtDonem.Text, txtBolum.Text, txtDanisman.Text, txtAd.Text, Int32.Parse(txtKredi.Text));
                vt.listDers.Add(d);
                btnTemizle_Click(sender, e);
                listele();
            }
            catch {
                MessageBox.Show("Girilen Bilgileri Kontrol Ediniz!!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKodu.Clear();
            txtDonem.Clear();
            txtBolum.Clear();
            txtDanisman.Clear();
            txtAd.Clear();
            txtKredi.Clear();
        }

        private void FormPersonelDers_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
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












    }
}
