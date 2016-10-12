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
    public partial class FormOgrenciKarne : Form
    {
        private Ogrenci ogrenci;
        private Form anaForm;
        VeriTabani vt;
        public FormOgrenciKarne(Ogrenci ogrenci, Form anaForm)
        {
            InitializeComponent();
            int count = 0;
            this.ogrenci = ogrenci;
            labelKullanici.Text = "Giriş Yapan Kullanıcı:" + ogrenci.Adi + " " + ogrenci.Soyadi;
            this.anaForm = anaForm;
            List<Ders> dersListesi = ogrenci.DersListesi;
            vt = VeriTabani.getVt;
            labelDonem.Text = vt.aktifDonem.Aciklama;
            foreach (Ders d in dersListesi)
            {
                if (d.Donem.DonemKodu.Equals(vt.aktifDonem.DonemKodu))
                {
                    listKarne.Items.Add(d.DersKodu + "     " + d.Adi + "    " + d.Kredi.ToString());
                    count++;
                }
            }
            if (count == 0)
            {
                listKarne.Items.Add("Henüz bu döneme ait ders kaydı yapılmamıştır!!");
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

        private void btnTranskript_MouseEnter(object sender, EventArgs e)
        {
            btnTranskript.BackgroundImage = Resources.transkript;
        }

        private void btnTranskript_MouseLeave(object sender, EventArgs e)
        {
            btnTranskript.BackgroundImage = Resources.transkript_sb;
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

        private void btnTranskript_Click(object sender, EventArgs e)
        {
            Hide();
            new FormOgrenciTranskript(ogrenci, this).Show();
        }
        private void FormOgrenciKarne_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaForm.Show();
        }
    }
}
