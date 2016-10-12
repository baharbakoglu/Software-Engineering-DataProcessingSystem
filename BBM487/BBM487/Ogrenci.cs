using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBM487
{
    public class Ogrenci : Kullanici
    {
        private String tcNo;
        private String ogrNo;
        private String bolum;
        private String danisman;
        private String adi;
        private String soyadi;
        private String mail;
        private String sifre;
        public String TCKimlikNo
        {
            get { return tcNo; }
            set { tcNo = value; }
        }
        public String OgrenciNo
        {
            get { return ogrNo; }
            set { ogrNo = value; }
        }
        public String BolumKodu
        {
            get { return bolum; }
            set { bolum = value; }
        }
        public String DanismanKodu
        {
            get { return danisman; }
            set { danisman = value; }
        }
        public String Adi
        {
            get { return adi; }
            set { adi = value; }
        }
        public String Soyadi
        {
            get { return soyadi; }
            set { soyadi = value; }
        }
        public String Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public String Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
        public List<Ders> DersListesi
        {
            get { return dersListesi.Keys.ToList(); }
        }
        public float dersNotu(Ders ders)
        {
            return dersListesi[ders];
        }

        public String NotHarfBilgisi(Ders ders)
        {
            return DersNotu.harfNotu(dersNotu(ders));
        }

        private Dictionary<Ders, float> dersListesi;



        public Ogrenci(String tcNo, String ogrenciNo, String bolum, String danisman, String adi, String soyadi, String mail, String sifre)
        {
            TCKimlikNo = tcNo;
            OgrenciNo = ogrenciNo;
            BolumKodu = bolum;
            DanismanKodu = danisman;
            Adi = adi;
            Soyadi = soyadi;
            Mail = mail;
            Sifre = sifre;
            dersListesi = new Dictionary<Ders, float>();
        }

        public void dersEkle(String dersKodu, String dersDonem, float not)
        {
            VeriTabani vt = VeriTabani.getVt;
            Ders ders = vt.dersBul(dersKodu, dersDonem);
            if (dersListesi.Keys.Contains(ders))
            {
                MessageBox.Show(dersKodu+" "+"Zaten Ekli!!");
                return;
            }
            dersListesi.Add(ders, not);
        }
        public void dersEkle(Ders ders, String harfNotu)
        {
            VeriTabani vt = VeriTabani.getVt;
            if (dersListesi.Keys.Contains(ders))
            {
                MessageBox.Show(ders.DersKodu + " "+"Zaten Ekli!!");
                return;
            }
            dersListesi.Add(ders, DersNotu.rakamNotu(harfNotu));
        }






        public void dersSil(String dersKodu, String dersDonem)
        {
            VeriTabani vt = VeriTabani.getVt;
            Ders ders = vt.dersBul(dersKodu, dersDonem);
            if (dersListesi.Keys.Contains(ders))
            {
                dersListesi.Remove(ders);
                return;
            }
            MessageBox.Show("Bu ders daha Önce Eklenmemiş!!");
        }
        public void dersSil(Ders ders)
        {
            VeriTabani vt = VeriTabani.getVt;
            if (dersListesi.Keys.Contains(ders))
            {
                dersListesi.Remove(ders);
                return;
            }
            MessageBox.Show("Bu ders daha Önce Eklenmemiş!!");
        }







        public float dersPuani(Ders ders)
        {
            float not = dersNotu(ders);
            not = not <= 0 ? 0 : not;
            return not * (float)ders.Kredi;
        }
        public float toplamPuan()
        {
            float toplam = 0;
            foreach (Ders d in DersListesi)
                toplam += dersPuani(d);
            return toplam;
        }
        public float toplamKredi()
        {
            float toplam = 0;
            List<String> alinanDersler = new List<string>();
            foreach (Ders d in DersListesi)
            {
                if (alinanDersler.Contains(d.DersKodu)) continue;
                toplam += d.Kredi;
                alinanDersler.Add(d.DersKodu);
            }
            return toplam;
        }

        public float genelOrtalama()
        {
            float ort = toplamPuan() / toplamKredi();
            return (float)Math.Round(ort, 2);
        }
        public void dersNotuGuncelle(Ders ders , String harfNotu) {
            if (!DersListesi.Contains(ders)) return;
            dersListesi[ders] = DersNotu.rakamNotu(harfNotu);
        }

        public string getKa()
        {
            return OgrenciNo;
        }

        public string getSifre()
        {
            return Sifre;
        }
        public String getTur()
        {
            return "ogrenci";
        }
        public String getTc()
        {
            return TCKimlikNo;
        }
        public override string ToString()
        {
            String var = "\"" + TCKimlikNo + "\""
                + ";\"" + OgrenciNo + "\""
                + ";\"" + BolumKodu + "\""
                + ";\"" + DanismanKodu + "\""
                + ";\"" + Adi + "\""
                + ";\"" + Soyadi + "\""
                + ";\"" + Mail + "\""
                + ";\"" + Sifre + "\"";
            return var;
        }

    }
}
