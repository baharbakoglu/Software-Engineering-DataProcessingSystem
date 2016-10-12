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
    public partial class FormDanismanOgrenciArama : Form
    {
        private Ogrenci ogrenci;
        private Akademisyen akademisyen;
        private Akademisyen danisman;
        private VeriTabani vt;
        private Form anaForm;
        public FormDanismanOgrenciArama(Akademisyen akademisyen,Form anaForm)
        {
            InitializeComponent();
            this.akademisyen = akademisyen;
            labelKullanici.Text = "Giriş Yapan Kullanıcı:" + akademisyen.Adi + " " + akademisyen.Soyadi;
            this.anaForm = anaForm;
        }
        private void btnDanismanKisiselBilgiler_MouseLeave(object sender, EventArgs e)
        {
            btnDanismanKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle_sb;
        }

        private void btnDanismanKisiselBilgiler_MouseEnter(object sender, EventArgs e)
        {
            btnDanismanKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle;
        }

        private void btnDanismanlikBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnDanismanlikBilgileri.BackgroundImage = Resources.danismanlikBilgiler_sb;
        }

        private void btnDanismanlikBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnDanismanlikBilgileri.BackgroundImage = Resources.danismanlikBilgiler;
        }

        private void btnDersListesi_MouseLeave(object sender, EventArgs e)
        {
            btnDersListesi.BackgroundImage = Resources.dersListesi_sb;
        }

        private void btnDersListesi_MouseEnter(object sender, EventArgs e)
        {
            btnDersListesi.BackgroundImage = Resources.dersListesi;
        }

        private void btnOgrenciListesi_MouseLeave(object sender, EventArgs e)
        {
            btnOgrenciListesi.BackgroundImage = Resources.ogrenciListesi_sb;
        }

        private void btnOgrenciListesi_MouseEnter(object sender, EventArgs e)
        {
            btnOgrenciListesi.BackgroundImage = Resources.ogrenciListesi;
        }

        private void btnNotGiris_MouseLeave(object sender, EventArgs e)
        {
            btnNotGiris.BackgroundImage = Resources.notGiris_sb;
        }

        private void btnNotGiris_MouseEnter(object sender, EventArgs e)
        {
            btnNotGiris.BackgroundImage = Resources.notGiris;
        }

        private void buttonCikis_MouseLeave(object sender, EventArgs e)
        {
            buttonCikis.BackgroundImage = Resources.cikis_sb;
        }
        private void buttonCikis_MouseEnter(object sender, EventArgs e)
        {
            buttonCikis.BackgroundImage = Resources.cikis;
        }
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDanismanKarneIzleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }

        private void btnDanismanKisiselBilgiler_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanKisisel(akademisyen, this).ShowDialog();
        }
        private void btnOgrenciArama_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanOgrenciArama(akademisyen, this).ShowDialog();
        }

        private void btnDersLstesi_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanDersListele(akademisyen, this).ShowDialog();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            listBoxTranskript.Visible = false;
            labelMail.Visible = false;
            labelDanisman.Visible = false;
            labelTC.Visible = false;
            vt = VeriTabani.getVt;
            var d = from kayit in vt.listKullanici
                    where kayit.getTur().Equals("ogrenci") && ((Ogrenci)kayit).OgrenciNo.Equals(txtOgrenciNo.Text.ToString())
                    select kayit;
            if (d.Count() == 0)
                ogrenci = null;
            else
                ogrenci = (Ogrenci)d.ToArray()[0];
            if (ogrenci == null)
            {
                labelOgrenciAdi.Text="Öğrenci Bulunamadı.";
                buttonKisiselBilgiler.Visible = false;
                buttonTranskript.Visible = false;
            }
            else
            {
                labelOgrenciAdi.Text = ogrenci.Adi + " " + ogrenci.Soyadi;
                buttonKisiselBilgiler.Visible = true;
                buttonTranskript.Visible = true;
            }            
        }

        private void buttonTranskript_Click(object sender, EventArgs e)
        {
            listBoxTranskript.Visible = true;
            listBoxTranskript.Items.Clear();
            labelMail.Visible = false;
            labelDanisman.Visible = false;
            labelTC.Visible = false;
            List<Ders> dersListesi = ogrenci.DersListesi;

            if (dersListesi.Count == 0)
            {
                 listBoxTranskript.Items.Add("Öğrencinin Ders Bilgisi Bulunmamaktadır!!");
                 return;
            }
            foreach (Ders ders in dersListesi)
            {
                listBoxTranskript.Items.Add(ders.Donem.Aciklama + "     " + ders.Adi + " " + "    " + ders.Kredi.ToString() + "    " + ogrenci.NotHarfBilgisi(ders) + "   =>   " + ogrenci.dersPuani(ders));
            }
            
        }

        private void buttonKisiselBilgiler_Click(object sender, EventArgs e)
        {
            listBoxTranskript.Visible = false;
            listBoxTranskript.Items.Clear();
            labelMail.Visible = true;
            labelDanisman.Visible = true;
            labelTC.Visible = true;
            vt = VeriTabani.getVt;
            var d = from kayit in vt.listKullanici
                    where kayit.getTur().Equals("akademisyen") && ((Akademisyen)kayit).PersonelKod.Equals(ogrenci.DanismanKodu)
                    select kayit;
            if (d.Count() == 0)
                danisman = null;
            else
                danisman = (Akademisyen)d.ToArray()[0];
           
            labelTC.Text = "Tc Kimlik No:  " + ogrenci.TCKimlikNo;
            labelMail.Text = "Mail:  " + ogrenci.Mail;
            if (danisman == null)
                labelDanisman.Text = "Danışman:  Danışman Bilgisi Bulanamadı";
            else
                labelDanisman.Text = "Danışman:  " + danisman.Adi + " " + danisman.Soyadi;
        }

        private void btnDanismanKisiselBilgiler_Click_1(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanKisisel(akademisyen, this).Show();
        }

        private void btnDanismanlikBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanlikBilgileri(akademisyen, this).Show();
        }

        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanDersListele(akademisyen, this).ShowDialog();
        }

        private void btnOgrenciListesi_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanismanDersSecimi secim = new FormDanismanDersSecimi(akademisyen, this);
            secim.ShowDialog();
            Ders secilen = secim.SecilenDers;
            if (secilen != null)
            {
                new FormDanismanOgrenciListesi(akademisyen,secilen, this).ShowDialog();
            }
            else
            {
                Show();
            }
        }

        private void btnNotGiris_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanismanDersSecimi secim = new FormDanismanDersSecimi(akademisyen, VeriTabani.getVt.aktifDonem, this);
            secim.ShowDialog();
            Ders secilen = secim.SecilenDers;
            if (secilen != null)
            {
                new FormDanismanNotGirisi(akademisyen,secilen, this).ShowDialog();
            }
            else
            {
                Show();
            }
        }

    }
}
