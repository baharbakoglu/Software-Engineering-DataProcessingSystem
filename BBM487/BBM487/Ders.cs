using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBM487
{
    public class Ders
    {
        public String DersKodu {
            get { return dersKodu; }
        }
        public Donem Donem {
            get { return donem; }
        }
        public Bolum Bolum {
            get { return bolum; }
        }
        public Akademisyen Danisman {
            get { return danisman; }
        }
        public String Adi {
            get { return adi; }
        }
        public int Kredi {
            get { return kredi; }
        }

        private String dersKodu;
        private Donem donem=null;
        private Bolum bolum=null;
        private Akademisyen danisman=null;
        private String adi;
        private int kredi;

        private Ders(String dersKodu,Donem donem,Bolum bolum,Akademisyen danisman,String adi,int kredi){
            this.dersKodu = dersKodu;
            this.adi = adi;
            this.donem = donem;
            this.bolum = bolum;
            this.danisman = danisman;
            this.kredi = kredi;

        }

        public static Ders createDers(String dersKodu, String donemKodu, String bolumKodu, String danismanKodu, String adi,int kredisi)
        {
            VeriTabani vt = VeriTabani.getVt;
            if (vt == null) return null;//daha kurulum yapilmamis
            Donem donem = vt.donemBul(donemKodu);
            Bolum bolum = vt.bolumBul(bolumKodu);
            Akademisyen danisman=vt.akademisyenBul(danismanKodu);
            Ders ders = new Ders(dersKodu, donem, bolum, danisman, adi, kredisi);
            return ders;
        }
        public override string ToString()
        {
            String var = "\"" + dersKodu + "\""
                + ";\"" + donem.DonemKodu + "\""
                +";\""+bolum.BolumKodu+"\""
                +";\""+danisman.PersonelKod+"\""
                +";\""+adi+"\""
                + ";\"" + kredi + "\"";
            return var;
        }

    }
}
