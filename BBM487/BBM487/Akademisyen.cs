using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM487
{
    public class Akademisyen : Kullanici
    {
        private String tcNo;
        private String perNo;
        private String bolum;
        private String adi;
        private String soyadi;
        private String mail;
        private String sifre;
        public List<Ders> dersListesi;
        public String TCKimlikNo
        {
            get { return tcNo; }
            set { tcNo = value; }
        }
        public String PersonelKod
        {
            get { return perNo; }
            set { perNo = value; }
        }
        public String BolumKodu
        {
            get { return bolum; }
            set { bolum = value; }
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

        public Akademisyen(String tcNo, String perKod, String bolum, String adi, String soyadi, String mail, String sifre)
        {
            TCKimlikNo = tcNo;
            PersonelKod = perKod;
            BolumKodu = bolum;
            Adi = adi;
            Soyadi = soyadi;
            Mail = mail;
            Sifre = sifre;
            dersListesi = new List<Ders>();
        }


        public string getKa()
        {
            return PersonelKod;
        }

        public string getSifre()
        {
            return Sifre;

        }
        public String getTur()
        {
            return "akademisyen";
        }
        public override string ToString()
        {
            String var = "\"" + TCKimlikNo + "\""
                + ";\"" + PersonelKod + "\""
                + ";\"" + BolumKodu + "\""
                + ";\"" + Adi + "\""
                + ";\"" + Soyadi + "\""
                + ";\"" + Mail + "\""
                + ";\"" + Sifre + "\"";
            return var;
        }
        public String getTc()
        {
            return TCKimlikNo;
        }
    }
}
