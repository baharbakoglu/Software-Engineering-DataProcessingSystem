using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBM487
{
    public partial class OgrenciNotGiris : UserControl
    {
        private Ogrenci ogrenci;
        public Ogrenci Ogrenci{
            set {
                ogrenci = value;
                txtAciklama.Text = String.Format("{0,-15}\t{1,-40}\t{2,-40}",value.OgrenciNo,value.Adi,value.Soyadi); 
            }
            get { return ogrenci; }
        }
        public String Notu {
            get { return dersNotu.Text; }
        }
        public void notGirisAktif(bool aktif) {
            dersNotu.Visible = aktif;
        }


        public OgrenciNotGiris(Ogrenci ogrenci,Ders ders)
        {
            InitializeComponent();
            this.ogrenci = ogrenci;
            Ogrenci = ogrenci;
            dersNotu.SelectedIndex = 0;
            if(ogrenci.DersListesi.Contains(ders)){
                dersNotu.Text=DersNotu.harfNotu(ogrenci.dersNotu(ders));
            }
        }
    }
}
