using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBM487
{
    public class Donem
    {
        public String DonemKodu {
            get { return donemKodu; }
            set { donemKodu = value; }
        }
        public String Aciklama {
            get { return aciklama; }
            set { aciklama = value; }
        }
        private String donemKodu;
        private String aciklama;
        public Donem(String donemKodu,String aciklama) {
            this.DonemKodu = donemKodu;
            this.Aciklama = aciklama;
        }
                public override string ToString()
        {
            String var = "\"" + donemKodu + "\""
                + ";\"" + aciklama + "\"";
            return var;
        }
    }
}
