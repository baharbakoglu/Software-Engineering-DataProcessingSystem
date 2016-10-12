using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBM487
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            bool res = false ;
            try
            {
               res = VeriTabani.start();
            }catch(Exception ex){
                MessageBox.Show(ex.Message, "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            if (!res) {
                MessageBox.Show("Veri Tabanı Seçmediniz!!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            new FormGiris().ShowDialog();
            //save vt changes
            VeriTabani.getVt.saveChanges();
        }
    }
}
