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
    public partial class frm_CarOrCup : Form
    {
        public frm_CarOrCup()
        {
            InitializeComponent();
        }

       
        string docWay;
  
        private void btnResimSec_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog doc = new OpenFileDialog();
            doc.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            doc.Title = "CAR OR CUP";
            doc.ShowDialog();
            docWay = doc.FileName;
            pbEgitim.ImageLocation = docWay;
        }

        private void btnEgit_Click_1(object sender, EventArgs e)
        {
            try
            {
                CarOrCup.egitimEkle(docWay, cmbTip.SelectedItem.ToString());
                MessageBox.Show("Eğitim BAŞARILI");
            }
            catch
            {
                MessageBox.Show("Eğitim HATALI");
            }
        }

        private void btnSIRALA_Click_1(object sender, EventArgs e)
        {
            List<string> gelenArabaList = new List<string>();
            gelenArabaList = CarOrCup.veriGetirAraba();
            pbAraba1.ImageLocation = gelenArabaList[0];
            pbAraba2.ImageLocation = gelenArabaList[1];
            pbAraba3.ImageLocation = gelenArabaList[2];
            pbAraba4.ImageLocation = gelenArabaList[3];
            pbAraba5.ImageLocation = gelenArabaList[4];

            List<string> gelenBardakList = new List<string>();
            gelenBardakList = CarOrCup.veriGetirBardak();
            pbKupa1.ImageLocation = gelenBardakList[0];
            pbKupa2.ImageLocation = gelenBardakList[1];
            pbKupa3.ImageLocation = gelenBardakList[2];
            pbKupa4.ImageLocation = gelenBardakList[3];
            pbKupa5.ImageLocation = gelenBardakList[4];
        }
    }
}
