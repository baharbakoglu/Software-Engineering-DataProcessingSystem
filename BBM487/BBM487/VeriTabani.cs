using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBM487
{
    class VeriTabani
    {
        public static VeriTabani getVt {
            get { return vt; }
        }
        public List<Bolum> listBolum=null;
        public List<Donem> listDonem=null;
        public List<Ders> listDers=null;
        public List<Kullanici> listKullanici=null;
        private String file;
        private static VeriTabani vt = null;
        public Donem aktifDonem=null;
        public bool dersEklemeAktif = false;


        private VeriTabani(String file)
        {
            this.file = file;
            listKullanici = new List<Kullanici>();
            listBolum = new List<Bolum>();
            listDonem = new List<Donem>();
            listDers = new List<Ders>();
        }
        public static bool start() {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Veri Tabanı Dosyasını Seçiniz!!";
            dlg.Filter = ".csv File |*.csv|All Types|*.*";
            DialogResult res = dlg.ShowDialog();
            if (res != DialogResult.OK || dlg.FileName==null)
                return false;
            vt = new VeriTabani(dlg.FileName);
            vt.readFile(vt.file);
            return true;
        }

        private void readFile(String file) {
            int rec =-1;
            String[] lines;
            try
            {
                lines = File.ReadAllLines(file, Encoding.UTF8);
            }
            catch {
                throw new Exception("Dosya Açılamadı!!");
            }
            foreach (String s in lines){
                String line =s.ToLower();
                if (line.Equals("bolum:"))
                {
                    if (rec != -1) throw new Exception("Veri Tabanı Düzgün Yapılandırılmamış!!");
                    rec = 1;
                    continue;
                }
                if (line.Equals("ogrenci:"))
                {
                    if (rec != 1) throw new Exception("Veri Tabanı Düzgün Yapılandırılmamış!!");
                    rec = 2;
                    continue;
                }
                if (line.Equals("akademisyen:")) {
                    if (rec != 2) throw new Exception("Veri Tabanı Düzgün Yapılandırılmamış!!");
                    rec = 3;
                    continue;
                }
                if (line.Equals("personel:"))
                {
                    if (rec != 3) throw new Exception("Veri Tabanı Düzgün Yapılandırılmamış!!");
                    rec = 4;
                    continue;
                }
                if (line.Equals("donem:"))
                {
                    if (rec != 4) throw new Exception("Veri Tabanı Düzgün Yapılandırılmamış!!");
                    rec = 5;
                    continue;
                }
                if (line.Equals("ders:"))
                {
                    if (rec != 5) throw new Exception("Veri Tabanı Düzgün Yapılandırılmamış!!");
                    rec = 6;
                    continue;
                }
                if (line.Equals("ders notu:"))
                {
                    if (rec != 6) throw new Exception("Veri Tabanı Düzgün Yapılandırılmamış!!");
                    rec = 7;
                    continue;
                }
                if (line.Equals("aktif donem:"))
                {
                    if (rec != 7) throw new Exception("Veri Tabanı Düzgün Yapılandırılmamış!!");
                    rec = 8;
                    continue;
                }
                if (line == String.Empty)
                    continue;
                try{
                    String[] vars = s.Replace("\"","").Split(';');
                switch(rec){
                    case 1:
                        Bolum b = new Bolum(vars[0], vars[1]);
                        listBolum.Add(b);
                        break;
                    case 2:
                        Ogrenci o = new Ogrenci(vars[0], vars[1], vars[2], vars[3], vars[4], vars[5], vars[6], vars[7]);
                        listKullanici.Add(o);
                        break;
                    case 3:
                        Akademisyen a = new Akademisyen(vars[0], vars[1], vars[2], vars[3], vars[4], vars[5], vars[6]);
                        listKullanici.Add(a);
                        break;
                    case 4:
                        Personel p = new Personel(vars[0], vars[1]);
                        listKullanici.Add(p);
                        break;
                    case 5:
                        Donem d = new Donem(vars[0],vars[1]);
                        listDonem.Add(d);
                        break;
                    case 6:
                        Ders de = Ders.createDers(vars[0], vars[1], vars[2], vars[3], vars[4],Int32.Parse(vars[5]));
                        listDers.Add(de);
                        break;
                    case 7:
                        Ogrenci ogr = vt.ogrenciBul(vars[0]);
                        Ders ders = vt.dersBul(vars[1], vars[2]);
                        if (ogr == null || ders==null) continue;
                        ogr.dersEkle(ders, vars[3]);
                        break;
                    case 8:
                        Donem donem = vt.donemBul(vars[0]);
                        if (donem == null) throw new Exception("Veri Tabanı Düzgün Yapılandırılmamış!!");
                        aktifDonem = donem;
                        break;
                }
                }catch{
                    throw new Exception("Veri Tabanı Düzgün Yapılandırılmamış!!");
                }
            }
            if (rec == -1) {
                throw new Exception("Veri Tabanı Düzgün Yapılandırılmamış!!");
            }
        
        }
        public void kullaniciEkle(Kullanici kullanici) {
            listKullanici.Add(kullanici);
        }
        public List<Ogrenci> ogrenciListesi() {
            List<Ogrenci> list = (from kayit in listKullanici where kayit.getTur().Equals("ogrenci") select (Ogrenci)kayit).ToList();
            return list;
        }
        public List<Akademisyen> akademisyenListesi() {
            List<Akademisyen> list = (from kayit in listKullanici where kayit.getTur().Equals("akademisyen") select (Akademisyen)kayit).ToList();
            return list;
        }
        public Ogrenci ogrenciBul(String ogrenciNo) {
            try
            {
                List<Ogrenci> list = ogrenciListesi();
                Ogrenci o = (from kayit in list where kayit.OgrenciNo.Equals(ogrenciNo) select kayit).First();
                return o;
            }
            catch {
                return null;
            }
        }
        public Ders dersBul(String dersKodu,String donem) {
            try{
            Ders d = (from kayit in listDers where kayit.DersKodu.Equals(dersKodu) && kayit.Donem.DonemKodu.Equals(donem) select kayit).First();
            return d;
            }catch{
            return null;
            }
        }
        public Bolum bolumBul(String bolumKodu) {
            try
            {
                Bolum b = (from kayit in listBolum where kayit.BolumKodu.Equals(bolumKodu) select kayit).First();
                return b;
            }
            catch {
                return null;
            }
        }
        public Donem donemBul(String donemKodu) {
            try
            {
                Donem d = (from kayit in listDonem where kayit.DonemKodu.Equals(donemKodu) select kayit).First();
                return d;
            }
            catch {
                return null;
            }
        }
        public Akademisyen akademisyenBul(String akademisyenKod) {
            try
            {
                List<Akademisyen> list = akademisyenListesi();
                Akademisyen a = (from kayit in list where kayit.PersonelKod.Equals(akademisyenKod) select kayit).First();
                return a;
            }
            catch {
                return null;
            }
        }
        public Personel personelBul(String kullaniciAdi) {
            try
            {
                List<Personel> list = (from kayit in listKullanici where kayit.getTur().Equals("personel") select (Personel)kayit).ToList();
                Personel p = (from kayit in list where kayit.KullaniciAdi.Equals(kullaniciAdi) select kayit).First();
                return p;
            }
            catch {
                return null;
            }
        }

        public void saveChanges() {
            StreamWriter writer;
            try
            {
                writer = new StreamWriter(file, false, Encoding.UTF8);
            }
            catch {
                MessageBox.Show("Değişiklikler Kaydedilemedi!!!", "Dosya Yazma Hatası!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            writer.WriteLine("Bolum:");
            foreach (Bolum b in listBolum)
            {
                writer.WriteLine(b);
            }
            writer.WriteLine("Ogrenci:");
            foreach (Kullanici o in listKullanici)
            {
                if (o.getTur().Equals("ogrenci"))
                    writer.WriteLine(o);
            }
            writer.WriteLine("Akademisyen:");
            foreach (Kullanici a in listKullanici)
            {
                if (a.getTur().Equals("akademisyen"))
                    writer.WriteLine(a);
            }
            writer.WriteLine("Personel:");
            foreach (Kullanici p in listKullanici)
            {
                if (p.getTur().Equals("personel"))
                    writer.WriteLine(p);
            }
            writer.WriteLine("Donem:");
            foreach (Donem d in listDonem)
            {
                writer.WriteLine(d);
            }
            writer.WriteLine("Ders:");
            foreach (Ders d in listDers)
            {
                writer.WriteLine(d);
            }
            writer.WriteLine("Ders Notu:");
            foreach (Kullanici o in listKullanici)
            {
                if (!o.getTur().Equals("ogrenci")) continue;
                Ogrenci ogr = (Ogrenci)o;
                List<Ders> dersListesi = ogr.DersListesi;
                if(dersListesi.Count==0) continue;
                foreach(Ders d in dersListesi){
                    writer.WriteLine("\""+ogr.OgrenciNo+"\";"+
                                     "\""+d.DersKodu+"\";"+
                                     "\""+d.Donem.DonemKodu+"\";"+
                                     "\""+DersNotu.harfNotu(ogr.dersNotu(d))+"\""
                        );
                }
            }
            writer.WriteLine("Aktif Donem:");
            if (aktifDonem != null) writer.WriteLine(aktifDonem.DonemKodu);
            //her bir ogrencinin ders listesini alıp yazdır
            writer.Flush();
            writer.Close();
        }



        internal List<Ogrenci> ogrenciListesi(Ders ders)
        {

            List<Ogrenci> ogrenciler = (from kayit in listKullanici
                          where
                              kayit.getTur().Equals("ogrenci") && ((Ogrenci)kayit).DersListesi.Contains(ders)
                          select (Ogrenci)kayit
                            ).ToList<Ogrenci>();
            return ogrenciler;
        }
    }
}
