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
    public partial class FormDanismanlikBilgileri : Form
    {
        private Ogrenci ogrenci;
        private Akademisyen akademisyen;
        private VeriTabani vt;
        private Form anaForm;

        public FormDanismanlikBilgileri(Akademisyen akademisyen, Form anaForm)
        {
            InitializeComponent();
            this.akademisyen = akademisyen;
            labelKullanici.Text = "Giriş Yapan Kullanıcı:" + akademisyen.Adi + " " + akademisyen.Soyadi;
            listBoxOgr.Visible = true;
            vt = VeriTabani.getVt;
            var d = from kayit in vt.listKullanici
                    where kayit.getTur().Equals("ogrenci") && ((Ogrenci)kayit).DanismanKodu.Equals(akademisyen.PersonelKod)
                    select kayit;


            if (d.Count() == 0)
                ogrenci = null;
            else
                ogrenci = (Ogrenci)d.ToArray()[0];
            if (ogrenci == null)
            {
                MessageBox.Show("danismanligini yaptigim ogrenci yok!");
            }
            else
            {
                foreach (Ogrenci ogr in d)
                    listBoxOgr.Items.Add(ogr.OgrenciNo + " "+ ogr.Adi + " " + ogr.Soyadi);
            }   
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

        private void buttonOgrenciArama_MouseLeave(object sender, EventArgs e)
        {
            buttonOgrenciArama.BackgroundImage = Resources.ogrenciAra_sb;
        }

        private void buttonOgrenciArama_MouseEnter(object sender, EventArgs e)
        {
            buttonOgrenciArama.BackgroundImage = Resources.ogrenciAra;
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
        private void DanismaniOlduguOgrencilerListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDanismanlikBilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }

        private void btnDanismanKisiselBilgiler_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanKisisel(akademisyen, this).ShowDialog();
        }

        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanDersListele(akademisyen, this).ShowDialog();
        }

        private void buttonOgrenciArama_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanOgrenciArama(akademisyen, this).ShowDialog();
        }

        private void btnOgrenciListesi_Click(object sender, EventArgs e)
        {
            Hide();
            FormDanismanDersSecimi secim = new FormDanismanDersSecimi(akademisyen, this);
            secim.ShowDialog();
            Ders secilen = secim.SecilenDers;
            if (secilen != null)
            {
                new FormDanismanOgrenciListesi(akademisyen, secilen, this).ShowDialog();
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
                new FormDanismanNotGirisi(akademisyen, secilen, this).ShowDialog();
            }
            else
            {
                Show();
            }
        }
    }
}
