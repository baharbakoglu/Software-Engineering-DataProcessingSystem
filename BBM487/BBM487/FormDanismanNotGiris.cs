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
    public partial class FormDanismanNotGirisi : Form
    {
        private Akademisyen akademisyen;
        private Ders ders;
        private VeriTabani vt;
        private Form anaForm;
        List<Ogrenci> ogrenciler;
        List<OgrenciNotGiris> notlar;
        public FormDanismanNotGirisi(Akademisyen akademisyen,Ders ders, Form anaForm)
        {
            InitializeComponent();
            this.akademisyen = akademisyen;
            this.ders = ders;
            txtAciklama.Text = ders.Donem.Aciklama + "  " + ders.Adi + " Dersi Öğrenci Not Girişi:";
            vt = VeriTabani.getVt;
            this.anaForm = anaForm;
            ogrenciler = vt.ogrenciListesi(ders);
            notlar = new List<OgrenciNotGiris>();
            if (ogrenciler.Count <= 0) {
                txtAciklama.Text += "\nÖğrenci Kaydı Bulunamadı!";
                btnGuncelle.Visible = false;
                return;
            }
            foreach(Ogrenci o in ogrenciler){
                OgrenciNotGiris item = new OgrenciNotGiris(o,ders);
                item.Dock=DockStyle.Top;
                panelOgrenci.Controls.Add(item);
                notlar.Add(item);
            }
            


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

        private void FormDanismanNotGirisi_Load(object sender, EventArgs e)
        {

        }

        private void FormDanismanNotGirisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }

        private void logoUst_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            foreach(OgrenciNotGiris ogrNot in notlar){
                Ogrenci ogr = ogrNot.Ogrenci;
                ogr.dersNotuGuncelle(ders, ogrNot.Notu);
            }
        }

        private void btnDanismanlikBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnDanismanlikBilgileri.BackgroundImage = Resources.danismanlikBilgiler;
        }

        private void btnDanismanlikBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnDanismanlikBilgileri.BackgroundImage = Resources.danismanlikBilgiler_sb;
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

        private void buttonOgrenciArama_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanOgrenciArama(akademisyen,this).ShowDialog();
        }

    }
}
