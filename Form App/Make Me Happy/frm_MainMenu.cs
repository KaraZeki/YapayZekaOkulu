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
    public partial class frm_MainMenu : Form
    {
        public frm_MainMenu()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
            
                LogoAnimasyonu.Hide(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 45;
                btnMenu2.Show();
                PanelAnimasyonu.ShowSync(sidemenu);
                panel2.Dock = DockStyle.Fill;

          
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            sidemenu.Visible = false;
            btnMenu2.Visible = false;
            sidemenu.Width = 228;
            PanelAnimasyonu.ShowSync(sidemenu);
            LogoAnimasyonu.ShowSync(logo);
            panel2.Dock = DockStyle.Fill;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // Panel'in içini temizliyoruz..

            frm_CarOrCup coc = new frm_CarOrCup();
            coc.TopLevel = false;

            panel2.Controls.Add(coc);
            coc.Show();
            coc.Dock = DockStyle.Fill;
            coc.BringToFront();


        }

        private void btnOynaHappy_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frmMakeMeHappy mmh = new frmMakeMeHappy();
            mmh.TopLevel = false;
            panel2.Controls.Add(mmh);
            mmh.Show();
            mmh.Dock = DockStyle.Fill;
            mmh.BringToFront();

        }

        private void btnOynaChameleon_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frm_Chameleon cha = new frm_Chameleon();
            cha.TopLevel = false;
            panel2.Controls.Add(cha);
            cha.Show();
            cha.Dock = DockStyle.Fill;
            cha.BringToFront();
        }

        private void btnOynaSmartClassroom_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frm_Smart_Clasroom sclass = new frm_Smart_Clasroom();
            sclass.TopLevel = false;
            panel2.Controls.Add(sclass);
            sclass.Show();
            sclass.Dock = DockStyle.Fill;
            sclass.BringToFront();

        }

        private void btnOynaJourneySchool_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            frm_Journey_School journey = new frm_Journey_School();
            journey.TopLevel = false;
            panel2.Controls.Add(journey);
            journey.Show();
            journey.Dock = DockStyle.Fill;
            journey.BringToFront();
        }
    }
}
