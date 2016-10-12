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
    public partial class FormDanismanDersListele : Form
    {
        
        private Akademisyen akademisyen;
        private Form anaForm;
       
        public FormDanismanDersListele(Akademisyen akademisyen, Form anaForm)
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
        private void btnOgrenciArama_MouseLeave(object sender, EventArgs e)
        {
            btnOgrenciArama.BackgroundImage = Resources.ogrenciAra_sb;
        }

        private void btnOgrenciArama_MouseEnter(object sender, EventArgs e)
        {
            btnOgrenciArama.BackgroundImage = Resources.ogrenciAra;
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
        private void FormDanismanDersListele_FormClosed(object sender, FormClosedEventArgs e)
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
    

        private void btnDanismanlikBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanlikBilgileri(akademisyen, this).ShowDialog();
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

        private void FormDanismanDersListele_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();   
            dt.Columns.Add("Ders Kodu", typeof(String));
            dt.Columns.Add("Ders Adı", typeof(String));
            dt.Columns.Add("Ders Kredisi", typeof(String));
            dt.Columns.Add("Ders Dönemi", typeof(String));

            foreach (Ders d in VeriTabani.getVt.listDers)
                if (d.Danisman == this.akademisyen)
                {               
                    
                    dt.Rows.Add(d.DersKodu, d.Adi, d.Kredi,d.Donem.Aciklama);                 
                }
            dataGridView1.DataSource = dt;
        }

        private void FormDanismanDersListele_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
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

      

       

     


    }
}
