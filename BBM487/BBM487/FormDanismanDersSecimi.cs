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
    public partial class FormDanismanDersSecimi : Form
    {
        private Akademisyen akademisyen;
        private VeriTabani vt;
        private Form anaForm;
        private List<Ders> dersler;
        private Ders secilen = null;
        public Ders SecilenDers{
            get { return secilen; }
            set { secilen = value; }
    }
        public FormDanismanDersSecimi(Akademisyen akademisyen,Donem donem, Form anaForm)
        {
            InitializeComponent();
            this.akademisyen = akademisyen;
            listDersler.Visible = true;
            vt = VeriTabani.getVt;
            dersler = (from kayit in vt.listDers
                          where
                              kayit.Danisman.PersonelKod.Equals(akademisyen.PersonelKod) && kayit.Donem==donem
                                  select kayit).ToList<Ders>();
            foreach(Ders d in dersler){
                listDersler.Items.Add(d.Donem.Aciklama+"\t"+d.Adi);
            }
            this.anaForm = anaForm;
        }
        public FormDanismanDersSecimi(Akademisyen akademisyen, Form anaForm)
        {
            InitializeComponent();
            this.akademisyen = akademisyen;
            listDersler.Visible = true;
            vt = VeriTabani.getVt;
            dersler = (from kayit in vt.listDers
                       where
                           kayit.Danisman.PersonelKod.Equals(akademisyen.PersonelKod)
                       select kayit).ToList<Ders>();
            foreach (Ders d in dersler)
            {
                listDersler.Items.Add(d.Donem.Aciklama + "\t" + d.Adi);
            }
            this.anaForm = anaForm;
        }

        private void DanismaniOlduguOgrencilerListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (listDersler.SelectedIndex < 0) 
                secilen = null;
            else
            secilen = dersler[listDersler.SelectedIndex];
            
            Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            secilen = null;
            Hide();
        }

        private void FormDanismanDersSecimi_Load(object sender, EventArgs e)
        {

        }


        private void listDersler_DoubleClick(object sender, EventArgs e)
        {
            if (listDersler.SelectedIndex < 0)
                return;
            btnSec_Click(sender, e);
        }
    }
}
