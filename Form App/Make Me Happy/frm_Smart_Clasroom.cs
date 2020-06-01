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
    public partial class frm_Smart_Clasroom : Form
    {
        public frm_Smart_Clasroom()
        {
            InitializeComponent();
        }


        private void btnEgit_Click_1(object sender, EventArgs e)
        {
            try
            {
                SC_Eğitim.egitimEkle(txtKomutEgitim.Text, cbFonksiyonlar.SelectedItem.ToString());
                MessageBox.Show("Eğitim Başarılı");
            }
            catch
            {
                MessageBox.Show("Eğitim Başarısız");
            }
        }

        private void btnDene_Click_1(object sender, EventArgs e)
        {
            try
            {
                string gelenVeri = SC_Eğitim.veriGetir(txtKodMetin.Text);

                if (gelenVeri == "Pervane Dönsün")
                {
                    pbPervane.ImageLocation = @"C:\Users\Yakup\source\repos\Make Me Happy\Make Me Happy\Resources\pervanegif.gif";
                    MessageBox.Show("Tebrikler Pervaneyi Döndürmeyi Başardın");
                }
                else if (gelenVeri == "Pervaneyi Dursun")
                {
                    pbPervane.ImageLocation = @"C:\Users\Yakup\source\repos\Make Me Happy\Make Me Happy\Resources\pervane.jpg";
                    MessageBox.Show("Tebrikler Pervaneyi Durdurmayı Başardın");
                }
                else if (gelenVeri == "Ampul Yansın")
                {
                    pbLamba.ImageLocation = @"C:\Users\Yakup\source\repos\Make Me Happy\Make Me Happy\Resources\yananampulgif.gif";
                    MessageBox.Show("Tebrikler Lambayı Yakmayı Başardın");
                }
                else if (gelenVeri == "Ampul Sönsün")
                {
                    pbLamba.ImageLocation = @"C:\Users\Yakup\source\repos\Make Me Happy\Make Me Happy\Resources\yananampul.jpg";
                    MessageBox.Show("Tebrikler Lambayı Söndürdün");
                }
                else if (gelenVeri == "Tavşan Sevinsin")
                {
                    pbTavsan.ImageLocation = @"C:\Users\Yakup\source\repos\Make Me Happy\Make Me Happy\Resources\tavsangif.gif";
                    MessageBox.Show("Tebrikler Tavşanı Sevindirmeyi Başardın");
                }
                else if (gelenVeri == "Tavşan Üzülsün")
                {
                    pbTavsan.ImageLocation = @"C:\Users\Yakup\source\repos\Make Me Happy\Make Me Happy\Resources\tavsan.jpg";
                    MessageBox.Show("Tebrikler Tavşanı Üzmeyi Başardın");
                }
                else
                {
                    MessageBox.Show("Hatalı Kodlama");
                }
                txtKodMetin.Text = "";
            }
            catch
            {
                MessageBox.Show("HATA");
            }
        }
    }
}
