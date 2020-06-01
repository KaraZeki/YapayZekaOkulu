using Make_Me_Happy.Entity;
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
    public partial class frm_Journey_School : Form
    {
        public frm_Journey_School()
        {
            InitializeComponent();
        }

       
        private void btnEgit_Click_1(object sender, EventArgs e)
        {
            try
            {
                JourneyToSchool.egitimEkle(txtYasE.Text, txtKiloE.Text, txtUzaklikE.Text, cmbUlasimTipiE.SelectedItem.ToString());
                MessageBox.Show("Eğitim Başarılı Daha Fazla Eğitim Ekleyelim");
            }
            catch
            {
                MessageBox.Show("Eğitim Başarısız");
            }
        }

        private void btnTest_Click_1(object sender, EventArgs e)
        {
            try
            {
                JourneySchool journey = new JourneySchool();
                journey.Yas = txtYas.Text;
                journey.Kilo = txtKilo.Text;
                journey.Uzaklik = txtUzaklik.Text;
                string ulasimTipi = JourneyToSchool.veriGetir(journey);
                MessageBox.Show("Bu Kişi Büyük Bir İhtimalle " + ulasimTipi + " ile Ulaşım Sağlıyor");
            }
            catch
            {
                MessageBox.Show("EKSİK VERİ LÜTFEN EĞİTİM YAPINIZ");
            }
        }
    }
}
