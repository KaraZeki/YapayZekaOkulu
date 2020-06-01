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
    public partial class frmMakeMeHappy : Form
    {
        public frmMakeMeHappy()
        {
            InitializeComponent();
        }


        private void btnImageSelect_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog doc = new OpenFileDialog();
            doc.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            doc.Title = "MAKE ME HAPPY";
            doc.ShowDialog();
            string docWay = doc.FileName;
            tbResimYolu.Text = doc.FileName;
            pbImages.ImageLocation = docWay;
        }


        string resimTip;
        
        private void btnResimEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (rbMutlu.Checked == true)
                {
                    resimTip = "Mutlu";
                }
                if (rbUzgun.Checked == true)
                {
                    resimTip = "Üzgün";
                }
                MMH_Resim.resimEkle(tbResimYolu.Text, resimTip);
                MessageBox.Show("EKLEME BAŞARILI");
            }
            catch
            {
                MessageBox.Show("HATA");
            }
        }
        string docWay;
        private void btnImageSelect1_Click(object sender, EventArgs e)
        {
            OpenFileDialog doc = new OpenFileDialog();
            doc.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            doc.Title = "MAKE ME HAPPY";
            doc.ShowDialog();
            docWay = doc.FileName;
            pbImages1.ImageLocation = docWay;
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(MMH_Resim.resimKontrol(docWay));
            }
            catch
            {
                MessageBox.Show("RESİM EKLİ DEĞİL LÜTFEN RESİMİ EKLEYİNİZ");
            }
        }
    }
}
