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
    public partial class FormGiris : Form
    {
        private VeriTabani vt;
        public FormGiris()
        {
            InitializeComponent();
            vt = VeriTabani.getVt;
            if (vt.aktifDonem == null)
            {
                txtDonem.Visible = false;
                return;
            }
            txtDonem.Text = vt.aktifDonem.Aciklama;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            String ka = txtKa.Text;
            String sfr = txtSfr.Text;
            var  kisi = from kayit in vt.listKullanici
                       where kayit.getKa().Equals(ka) && kayit.getSifre().Equals(sfr)
                       select kayit;
            if(kisi.Count()!=1){
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre!!","Giriş Reddedildi!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else{
                txtSfr.Clear();
                Kullanici k = kisi.Single();
                String tur = k.getTur();
                if (tur == "ogrenci")
                    
                    new formOgrenci((Ogrenci)k).ShowDialog();
              
                if (tur == "akademisyen")
                   
                    new formDanisman((Akademisyen)k).ShowDialog();
                if (tur == "personel")
                
                    new FormPersonel((Personel)k).ShowDialog();
            }
                        
        }

        private void formGiris_Load(object sender, EventArgs e)
        {

        }


    }
}
