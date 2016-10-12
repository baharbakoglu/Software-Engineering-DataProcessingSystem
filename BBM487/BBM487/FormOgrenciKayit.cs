using System;
using System.Collections.Generic;
using BBM487.Properties;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBM487
{
    public partial class FormOgrenciKayit : Form
    {

        private Ogrenci ogrenci;
        private Form anaForm;
        private VeriTabani vt;
        public FormOgrenciKayit(Ogrenci ogrenci, Form anaForm)
        {
            InitializeComponent();
            this.ogrenci = ogrenci;
            vt = VeriTabani.getVt;
            labelKullanici.Text = "Giriş Yapan Kullanıcı: " + ogrenci.Adi + " " + ogrenci.Soyadi;
            this.anaForm = anaForm;

        }


        private void btnKisiselBilgiler_MouseLeave(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle_sb;
        }

        private void btnKisiselBilgiler_MouseEnter(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle;
        }


        private void btnKarne_MouseEnter(object sender, EventArgs e)
        {
            btnKarne.BackgroundImage = Resources.karne;
        }

        private void btnKarne_MouseLeave(object sender, EventArgs e)
        {
            btnKarne.BackgroundImage = Resources.karne_sb;
        }

        private void btnTranskript_MouseEnter(object sender, EventArgs e)
        {
            btnTranskript.BackgroundImage = Resources.transkript;
        }

        private void btnTranskript_MouseLeave(object sender, EventArgs e)
        {
            btnTranskript.BackgroundImage = Resources.transkript_sb;
        }

        private void btnCikis_MouseEnter(object sender, EventArgs e)
        {
            btnCikis.BackgroundImage = Resources.cikis;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.BackgroundImage = Resources.cikis_sb;
        }



        private void btnKisiselBilgiler_Click(object sender, EventArgs e)
        {
            Hide();
            new FormOgrenciKisisel(ogrenci, this).Show();
        }

        private void btnKarne_Click(object sender, EventArgs e)
        {
            Hide();
            new FormOgrenciKarne(ogrenci, this).Show();
        }

        private void btnTranskript_Click(object sender, EventArgs e)
        {
            Hide();
            new FormOgrenciTranskript(ogrenci, this).Show();
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormKayit_Load(object sender, EventArgs e)
        {
            derslerGuncelle();
        }

        private void derslerGuncelle()
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt.Columns.Add("sec", typeof(bool));
            dt.Columns.Add("ders_kodu", typeof(String));
            dt.Columns.Add("ders_adi", typeof(String));
            dt.Columns.Add("kredi", typeof(int));


            dt.Columns["sec"].Caption = "Seç";
            dt2.Columns.Add("sec", typeof(bool));
            dt2.Columns.Add("ders_kodu", typeof(String));
            dt2.Columns.Add("ders_adi", typeof(String));
            dt2.Columns.Add("kredi", typeof(int));
            dt2.Columns["sec"].Caption = "Seç";
            int count = 0;
            foreach (Ders d in ogrenci.DersListesi)
            {
                if (d.Donem == vt.aktifDonem)
                {
                    count = count + d.Kredi;
                    if (count > 25)
                    {
                        MessageBox.Show("25 Kredi sınırını aştın");
                        count = count - d.Kredi;
                    }else
                        dt.Rows.Add(false, d.DersKodu, d.Adi, d.Kredi);                  
                }
              
            }
            dersAldigi.DataSource = dt;
            dersAldigi.Columns[1].ReadOnly = true;
            dersAldigi.Columns[2].ReadOnly = true;
            dersAldigi.Columns[3].ReadOnly = true;
            foreach(Ders ders in vt.listDers){
                if(ders.Donem==vt.aktifDonem && !ogrenci.DersListesi.Contains(ders)){
                    dt2.Rows.Add(false,ders.DersKodu,ders.Adi,ders.Kredi);
                }
            }

            dersAlabilir.DataSource = dt2;
            dersAlabilir.Columns[1].ReadOnly = true;
            dersAlabilir.Columns[2].ReadOnly = true;
            dersAlabilir.Columns[3].ReadOnly = true;

        }

        public void ekleDers()
        {
            
            foreach (DataGridViewRow row in dersAlabilir.Rows)
            {
                if (((bool)row.Cells["sec"].Value))
                {
                    String kodu =(String) row.Cells["ders_kodu"].Value;
                   
                    ogrenci.dersEkle(kodu, VeriTabani.getVt.aktifDonem.DonemKodu, DersNotu.YOK);
                }
            }
            derslerGuncelle();
        }
        public void dersSil() {
            foreach (DataGridViewRow row in dersAldigi.Rows)
            {

                if(((bool)row.Cells["sec"].Value))
                {
                    String kodu = (String)row.Cells["ders_kodu"].Value;
                    ogrenci.dersSil(kodu, VeriTabani.getVt.aktifDonem.DonemKodu);
                }   
               
            }
            derslerGuncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ekleDers();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dersSil();
        }
        private void FormKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }

    }
}
