using Make_Me_Happy.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Me_Happy
{
    public partial class frm_Chameleon : Form
    {
        public frm_Chameleon()
        {
            InitializeComponent();
        }
        string resimYolu;
        string picWay;
        private void btnResimSec_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog doc = new OpenFileDialog();
            doc.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            doc.Title = "CHAMELEON";
            doc.ShowDialog();
            resimYolu = doc.FileName;
            pbImages.ImageLocation = resimYolu;
        }
        private void btnEgit_Click_1(object sender, EventArgs e)
        {
            string renk = "";
            if (rbKirmizi.Checked == true) { renk = "KIRMIZI"; }
            if (rbMavi.Checked == true) { renk = "MAVİ"; }
            if (rbYesil.Checked == true) { renk = "YEŞİL"; }
            Chameleon.egitimEkle(resimYolu, renk);
        }

        private void btnSec_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog doc = new OpenFileDialog();
            doc.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            doc.Title = "CHAMELEON";
            doc.ShowDialog();
            picWay = doc.FileName;
            pbGorunen.ImageLocation = picWay;
        }


        private void btnDene_Click_1(object sender, EventArgs e)
        {
            try
            {
                string gelenRenk = Chameleon.veriGetir(picWay);
                if (gelenRenk == "KIRMIZI") { pbUyg.ImageLocation = @"C:\Users\Yakup\source\repos\Make Me Happy\Make Me Happy\Resources\kirmizibukalemun.jpg"; }
                else if (gelenRenk == "MAVİ") { pbUyg.ImageLocation = @"C:\Users\Yakup\source\repos\Make Me Happy\Make Me Happy\Resources\mavibukalemun.jpg"; }
                else if (gelenRenk == "YEŞİL") { pbUyg.ImageLocation = @"C:\Users\Yakup\source\repos\Make Me Happy\Make Me Happy\Resources\yesilbukalemun.jpg"; }
                else { MessageBox.Show("HATALI GİRİŞ"); }
            }
            catch
            {
                MessageBox.Show("HATA");
            }

        }
    }
}
