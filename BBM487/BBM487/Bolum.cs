using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBM487
{
    public class Bolum
    {
        public String BolumKodu {
            get { return bolumKodu; }
            set { bolumKodu = value; }
        }
        public String Aciklama {
            get { return aciklama; }
            set { aciklama = value; }
        }
        private String bolumKodu;
        private String aciklama;

        public Bolum(String bolumKodu,String aciklama) {
            this.BolumKodu = bolumKodu;
            this.Aciklama = aciklama;
        }
        public override string ToString()
        {
            String var = "\"" + bolumKodu + "\""
                + ";\"" + aciklama + "\"";
            return var;
        }

    }
}
