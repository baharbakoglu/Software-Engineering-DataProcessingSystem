﻿using BBM487.Properties;
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
    public partial class FormDanismanKisisel : Form
    {
        private Akademisyen akademisyen;
        private VeriTabani vt;
        private Form anaForm;
        public FormDanismanKisisel(Akademisyen akademisyen,Form anaForm)
        {
            InitializeComponent();
            this.akademisyen = akademisyen;
            labelKullanici.Text = "Giriş Yapan Kullanıcı:" + akademisyen.Adi + " " + akademisyen.Soyadi;
            vt = VeriTabani.getVt;
            lblTCNo.Text = "Tc Kimlik No:  " + akademisyen.TCKimlikNo;
            lblPerNo.Text = "Personel No:  " + akademisyen.PersonelKod;
            labelAd.Text = "İsim ve Soyisim:  " + akademisyen.Adi + " " + akademisyen.Soyadi;
            txtDanismanMail.Text = akademisyen.Mail;
            txtDanismanSifre.Text = akademisyen.Sifre;
            this.anaForm = anaForm;
        }

        private void FormDanismanMenuler_Load(object sender, EventArgs e)
        {

        }

        private void labelMail_Click(object sender, EventArgs e)
        {

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

        private void btnOgrenciArama_MouseLeave(object sender, EventArgs e)
        {
            btnOgrenciArama.BackgroundImage = Resources.ogrenciAra_sb;
        }

        private void btnOgrenciArama_MouseEnter(object sender, EventArgs e)
        {
            btnOgrenciArama.BackgroundImage = Resources.ogrenciAra;
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtDanismanSifre.Text.Length == 0)
            {
                MessageBox.Show("Şifre Kısmı Boş Olamaz!!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            akademisyen.Mail = txtDanismanMail.Text;
            akademisyen.Sifre = txtDanismanSifre.Text;
            MessageBox.Show("Değişiklikler Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FormDanismanKisisel_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();

        }



        private void btnDanismanlikBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanlikBilgileri(akademisyen, this).ShowDialog();
        }

        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanDersListele(akademisyen, this).ShowDialog();
        }

        private void btnOgrenciArama_Click_1(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanOgrenciArama(akademisyen, this).ShowDialog();
        }

        private void btnOgrenciListesi_Click_1(object sender, EventArgs e)
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

        private void btnNotGiris_Click_1(object sender, EventArgs e)
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
