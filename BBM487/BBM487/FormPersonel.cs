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
    public partial class FormPersonel : Form
    {
        private Personel personel;
        public FormPersonel(Personel personel)
        {
            InitializeComponent();
            this.personel = personel;
            labelPersonel.Text = "Giriş Yapan Kullanıcı:" + personel.KullaniciAdi;
        }


        private void btnBolumBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnBolumBilgileri.BackgroundImage = Resources.bolumbilgileri_sb;
        }
        private void btnBolumBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnBolumBilgileri.BackgroundImage = Resources.bolumbilgileri;
        }
        private void btnDonemBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnDonemBilgileri.BackgroundImage = Resources.donembilgileri_sb;
        }
        private void btnDonemBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnDonemBilgileri.BackgroundImage = Resources.donembilgileri;
        }
        private void btnOgrenciBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnOgrenciBilgileri.BackgroundImage = Resources.ogrenciListesi_sb;
        }
        private void btnOgrenciBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnOgrenciBilgileri.BackgroundImage = Resources.ogrenciListesi;
        }

        private void btnAkademisyenBilgileri_MouseEnter(object sender, EventArgs e)
        {
            btnAkademisyenBilgileri.BackgroundImage = Resources.akademisyenbilgileri;
        }

        private void btnAkademisyenBilgileri_MouseLeave(object sender, EventArgs e)
        {
            btnAkademisyenBilgileri.BackgroundImage = Resources.akademisyenbilgileri_sb;
        }

        private void btnKayıtAc_MouseLeave(object sender, EventArgs e)
        {
            btnKayıtAc.BackgroundImage = Resources.kayitac_sb;
        }
        private void btnKayıtAc_MouseEnter(object sender, EventArgs e)
        {
            btnKayıtAc.BackgroundImage = Resources.kayitac;
        }

        private void btnKisiselBilgiler_MouseLeave(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle_sb;
        }
        private void btnKisiselBilgiler_MouseEnter(object sender, EventArgs e)
        {
            btnKisiselBilgiler.BackgroundImage = Resources.bilgiGuncelle;
        }

        private void buttonCikis_MouseLeave(object sender, EventArgs e)
        {
            buttonCikis.BackgroundImage = Resources.cikis_sb;
        }

        private void buttonCikis_MouseEnter(object sender, EventArgs e)
        {
            buttonCikis.BackgroundImage = Resources.cikis;
        }


        private void PersonelForm_Load(object sender, EventArgs e)
        {

        }


        private void btnKisiselBilgiler_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelKisisel(personel,this).ShowDialog();

        }

        private void btnOgrenciBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelOgrenci(personel, this).ShowDialog();
        }

        private void btnBolumBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelBolum(personel, this).ShowDialog();
        }

        private void btnDonemBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelDonem(personel, this).ShowDialog();
        }

        private void btnKayıtAc_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelDers(personel, this).ShowDialog();
        }

        private void btnAkademisyenBilgileri_Click(object sender, EventArgs e)
        {
            Hide();
            new FormPersonelAkademisyen(personel, this).ShowDialog();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
