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
    public partial class FormKayit : Form
    {

        private Ogrenci ogrenci;
        private Form anaForm;
        private VeriTabani vt;
        public FormKayit(Ogrenci ogrenci, Form anaForm)
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
            listele();
            aldigiListele();

        }
        private void aldigiListele() {
            DataTable dt = new DataTable();

            dt.Columns.Add("sec", typeof(bool));
            dt.Columns.Add("ders_kodu", typeof(String));
            dt.Columns.Add("ders_adi", typeof(String));
            dt.Columns.Add("kredi", typeof(int));
            dt.Columns["sec"].Caption = "Seç";
            int count = 0;
            foreach (Ders d in ogrenci.DersListesi)
            {
                if (count<10 && d.Donem == vt.aktifDonem)
                {
                    count = count + d.Kredi;
                    if (count > 10)
                    {
                        MessageBox.Show("25 Kredi sınırını aştın");
                        count = count - d.Kredi;
                    }else
                        dt.Rows.Add(false, d.DersKodu, d.Adi, d.Kredi);
                    
                }
              
            }
            dataGridView2.DataSource = dt;
        }
        private void listele()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("sec", typeof(bool));
            dt.Columns.Add("ders_kodu", typeof(String));
            dt.Columns.Add("ders_adi", typeof(String));
            dt.Columns.Add("kredi", typeof(int));
            dt.Columns["sec"].Caption = "Seç";
            foreach (Ders d in vt.listDers)
            {
                if (d.Donem == vt.aktifDonem)
                {
                    dt.Rows.Add(false, d.DersKodu, d.Adi, d.Kredi);
                }
            }

            dataGridView1.DataSource = dt;

        }
        public void ekleDers()
        {
           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (((bool)row.Cells["sec"].Value))
                {
                    String kodu =(String) row.Cells["ders_kodu"].Value;
                   
                    ogrenci.dersEkle(kodu, VeriTabani.getVt.aktifDonem.DonemKodu, DersNotu.F1);
                }
            }

            aldigiListele();
            
        }
        public void dersSil() { 
            
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                if(((bool)row.Cells["sec"].Value))
                {
                    String kodu = (String)row.Cells["ders_kodu"].Value;
                    ogrenci.dersSil(kodu, VeriTabani.getVt.aktifDonem.DonemKodu);
                    dataGridView2.Rows.RemoveAt(row.Index);                                     
                    dataGridView2.Refresh();
                    continue;
                }   
                else{                    
                    dataGridView2.Refresh();          
                    break;
                }
               
            }
           
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
