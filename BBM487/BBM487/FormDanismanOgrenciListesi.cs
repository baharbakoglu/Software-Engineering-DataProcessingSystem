using BBM487.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBM487
{
    public partial class FormDanismanOgrenciListesi : Form
    {
        private Akademisyen akademisyen;
        private Ders ders;
        private VeriTabani vt;
        private Form anaForm;
        private List<Ogrenci> ogrenciler;

        public FormDanismanOgrenciListesi(Akademisyen akademisyen,Ders ders , Form anaForm)
        {
            InitializeComponent();
            this.akademisyen=akademisyen;
            this.ders = ders;
            txtAciklama.Text = ders.Donem.Aciklama + " " + ders.Adi + " Dersi Öğrenci Listesi"; 
            vt=VeriTabani.getVt;
            ogrenciler = vt.ogrenciListesi(ders);
            if (ogrenciler.Count <= 0)
            {
                listOgrenci.Items.Add("Dersi Alan Öğrenci Bulunmamakta!!");
            }
            else { 
                foreach(Ogrenci o in ogrenciler){
                    listOgrenci.Items.Add(o.OgrenciNo+" "+o.Adi+" "+o.Soyadi);
                }
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

        private void FormDanismanOgrenciListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Dosya Yeri Seçiniz";
            dlg.Filter = ".csv File |*.csv";
            DialogResult res = dlg.ShowDialog();
            if (res != DialogResult.OK || dlg.FileName == null)
                return;
            StreamWriter writer;
            try
            {
                writer = new StreamWriter(dlg.FileName, false, Encoding.UTF8);
            }catch{
                MessageBox.Show("Dosya Açılamadı!!!","Dosya Yazma Hatası!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            writer.WriteLine("\""+ders.Donem.Aciklama+" "+ders.Adi+" Dersini Alan Öğrenci Listesi:\"");
            if (ogrenciler.Count <= 0) {
                writer.WriteLine("\"Dersi Alan Öğrenci Bulunmamaktadır.\"");
                return;
            }
            writer.WriteLine("\"Öğrenci No:\";\"Öğrenci Adı:\";\"Öğrenci Soyadı:\"");
            foreach(Ogrenci o in ogrenciler){
                writer.WriteLine("\""+o.OgrenciNo+"\";"+"\""+o.Adi+"\";\""+o.Soyadi+"\"");
            }
            writer.Flush();
            writer.Close();
            MessageBox.Show("İşlem Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormDanismanOgrenciListesi_Load(object sender, EventArgs e)
        {

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

        private void buttonOgrenciArama_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDanismanOgrenciArama(akademisyen,this).ShowDialog();
        }

    }
}
