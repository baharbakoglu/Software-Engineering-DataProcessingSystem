using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM487
{
    public class Personel:Kullanici
    {
        private String kad;
        private String sifre;
        public String KullaniciAdi {
            get { return kad; }
            set { kad = value; }
        }
        public String Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
       
        public Personel(String kad,String sifre) {
            KullaniciAdi = kad;
            Sifre = sifre;
        }

        public String getKa()
        {
            return KullaniciAdi;
        }

        public String getSifre()
        {
            return Sifre;
        }
        public String getTur() {
            return "personel";
        }
        public override string ToString()
        {
            String var = "\""+KullaniciAdi+"\""
                + ";\"" + Sifre+"\"";
            return var;
        }
        public String getTc()
        {
            return null;
        }
    }
}
