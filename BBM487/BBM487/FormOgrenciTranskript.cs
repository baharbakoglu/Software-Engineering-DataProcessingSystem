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
    public partial class FormOgrenciTranskript : Form
    {
        private Ogrenci ogrenci;
        private Form anaForm=null;

        public FormOgrenciTranskript(Ogrenci ogrenci, Form anaForm)
        {
            InitializeComponent();
            this.ogrenci = ogrenci;
            labelKullanici.Text = "Giriş Yapan Kullanıcı:" + ogrenci.Adi + " " + ogrenci.Soyadi;
            /*
            vt = VeriTabani.getVt;

            ogrenci.dersEkle("356-101", "013-014", DersNotu.F2);
            ogrenci.dersEkle("356-101", "014-015", DersNotu.B1);
            ogrenci.dersEkle("356-102", "014-015", DersNotu.B1);
            ogrenci.dersEkle("356-103", "014-015", DersNotu.B2);
            */
            this.anaForm = anaForm;
            List<Ders> dersListesi = ogrenci.DersListesi;

            if (dersListesi.Count == 0) {
                lblGenelAOrt.Text = "Öğrencinin Ders Bilgisi Bulunmamaktadır!!";
                listNot.Visible = false;
                return;
            }
            lblGenelAOrt.Text = "Genel Akademik Ortalama: " + ogrenci.toplamPuan()+" / "+ ogrenci.toplamKredi()+"  =>  "+ogrenci.genelOrtalama();
            foreach(Ders d in dersListesi){
                listNot.Items.Add(d.Donem.Aciklama+"     "+d.Adi+" "+"    "+d.Kredi.ToString()+"    "+ogrenci.NotHarfBilgisi(d) +"   =>   "+ogrenci.dersPuani(d));
            }

        }


        private void btnKisiselBilgiler_MouseEnter(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle;
        }

        private void btnKisiselBilgiler_MouseLeave(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle_sb;
        }

        private void btnKarne_MouseEnter(object sender, EventArgs e)
        {
            btnKarne.BackgroundImage = Resources.karne;
        }

        private void btnKarne_MouseLeave(object sender, EventArgs e)
        {
            btnKarne.BackgroundImage = Resources.karne_sb;
        }

        private void btnCikis_MouseEnter(object sender, EventArgs e)
        {
            btnCikis.BackgroundImage = Resources.cikis;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.BackgroundImage = Resources.cikis_sb;
        }

     
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

         private void FormOgrenciTranskript_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }

        private void FormOgrenciTranskript_Load(object sender, EventArgs e)
        {

        }

    }
}
