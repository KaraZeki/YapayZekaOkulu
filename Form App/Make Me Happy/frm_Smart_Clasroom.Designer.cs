namespace Make_Me_Happy
{
    partial class frm_Smart_Clasroom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Smart_Clasroom));
            this.txtKodMetin = new System.Windows.Forms.TextBox();
            this.pbTavsan = new System.Windows.Forms.PictureBox();
            this.pbLamba = new System.Windows.Forms.PictureBox();
            this.pbPervane = new System.Windows.Forms.PictureBox();
            this.cbFonksiyonlar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKomutEgitim = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnEgit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDene = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTavsan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLamba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPervane)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKodMetin
            // 
            this.txtKodMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKodMetin.Location = new System.Drawing.Point(396, 325);
            this.txtKodMetin.Margin = new System.Windows.Forms.Padding(4);
            this.txtKodMetin.Multiline = true;
            this.txtKodMetin.Name = "txtKodMetin";
            this.txtKodMetin.Size = new System.Drawing.Size(338, 45);
            this.txtKodMetin.TabIndex = 3;
            // 
            // pbTavsan
            // 
            this.pbTavsan.Image = global::Make_Me_Happy.Properties.Resources.tavsan;
            this.pbTavsan.Location = new System.Drawing.Point(517, 13);
            this.pbTavsan.Margin = new System.Windows.Forms.Padding(4);
            this.pbTavsan.Name = "pbTavsan";
            this.pbTavsan.Size = new System.Drawing.Size(242, 247);
            this.pbTavsan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTavsan.TabIndex = 2;
            this.pbTavsan.TabStop = false;
            // 
            // pbLamba
            // 
            this.pbLamba.Image = global::Make_Me_Happy.Properties.Resources.yananampul;
            this.pbLamba.Location = new System.Drawing.Point(276, 13);
            this.pbLamba.Margin = new System.Windows.Forms.Padding(4);
            this.pbLamba.Name = "pbLamba";
            this.pbLamba.Size = new System.Drawing.Size(233, 247);
            this.pbLamba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLamba.TabIndex = 1;
            this.pbLamba.TabStop = false;
            // 
            // pbPervane
            // 
            this.pbPervane.Image = ((System.Drawing.Image)(resources.GetObject("pbPervane.Image")));
            this.pbPervane.Location = new System.Drawing.Point(13, 13);
            this.pbPervane.Margin = new System.Windows.Forms.Padding(4);
            this.pbPervane.Name = "pbPervane";
            this.pbPervane.Size = new System.Drawing.Size(255, 247);
            this.pbPervane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPervane.TabIndex = 0;
            this.pbPervane.TabStop = false;
            // 
            // cbFonksiyonlar
            // 
            this.cbFonksiyonlar.FormattingEnabled = true;
            this.cbFonksiyonlar.Items.AddRange(new object[] {
            "Pervane Dönsün",
            "Pervane Dursun",
            "Ampul Yansın",
            "Ampul Sönsün",
            "Tavşan Sevinsin",
            "Tavşan Üzülsün"});
            this.cbFonksiyonlar.Location = new System.Drawing.Point(161, 369);
            this.cbFonksiyonlar.Margin = new System.Windows.Forms.Padding(4);
            this.cbFonksiyonlar.Name = "cbFonksiyonlar";
            this.cbFonksiyonlar.Size = new System.Drawing.Size(192, 24);
            this.cbFonksiyonlar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(28, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "EĞİTİM BÖLÜMÜMÜZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(5, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Çalışacak Fonksiyon >";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(37, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Komutu Yazınız>";
            // 
            // txtKomutEgitim
            // 
            this.txtKomutEgitim.Location = new System.Drawing.Point(161, 324);
            this.txtKomutEgitim.Margin = new System.Windows.Forms.Padding(4);
            this.txtKomutEgitim.Name = "txtKomutEgitim";
            this.txtKomutEgitim.Size = new System.Drawing.Size(192, 22);
            this.txtKomutEgitim.TabIndex = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnEgit
            // 
            this.btnEgit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEgit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEgit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEgit.BorderRadius = 0;
            this.btnEgit.ButtonText = "Eğitimi Tamamla";
            this.btnEgit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEgit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEgit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEgit.Iconimage = null;
            this.btnEgit.Iconimage_right = null;
            this.btnEgit.Iconimage_right_Selected = null;
            this.btnEgit.Iconimage_Selected = null;
            this.btnEgit.IconMarginLeft = 0;
            this.btnEgit.IconMarginRight = 0;
            this.btnEgit.IconRightVisible = true;
            this.btnEgit.IconRightZoom = 0D;
            this.btnEgit.IconVisible = true;
            this.btnEgit.IconZoom = 90D;
            this.btnEgit.IsTab = false;
            this.btnEgit.Location = new System.Drawing.Point(161, 412);
            this.btnEgit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEgit.Name = "btnEgit";
            this.btnEgit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEgit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEgit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEgit.selected = false;
            this.btnEgit.Size = new System.Drawing.Size(192, 44);
            this.btnEgit.TabIndex = 12;
            this.btnEgit.Text = "Eğitimi Tamamla";
            this.btnEgit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEgit.Textcolor = System.Drawing.Color.White;
            this.btnEgit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgit.Click += new System.EventHandler(this.btnEgit_Click_1);
            // 
            // btnDene
            // 
            this.btnDene.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDene.BorderRadius = 0;
            this.btnDene.ButtonText = "Test Et";
            this.btnDene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDene.DisabledColor = System.Drawing.Color.Gray;
            this.btnDene.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDene.Iconimage = null;
            this.btnDene.Iconimage_right = null;
            this.btnDene.Iconimage_right_Selected = null;
            this.btnDene.Iconimage_Selected = null;
            this.btnDene.IconMarginLeft = 0;
            this.btnDene.IconMarginRight = 0;
            this.btnDene.IconRightVisible = true;
            this.btnDene.IconRightZoom = 0D;
            this.btnDene.IconVisible = true;
            this.btnDene.IconZoom = 90D;
            this.btnDene.IsTab = false;
            this.btnDene.Location = new System.Drawing.Point(467, 378);
            this.btnDene.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDene.Name = "btnDene";
            this.btnDene.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDene.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDene.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDene.selected = false;
            this.btnDene.Size = new System.Drawing.Size(217, 59);
            this.btnDene.TabIndex = 13;
            this.btnDene.Text = "Test Et";
            this.btnDene.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDene.Textcolor = System.Drawing.Color.White;
            this.btnDene.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDene.Click += new System.EventHandler(this.btnDene_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(489, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "UYGULAMA BÖLÜMÜMÜZ";
            // 
            // frm_Smart_Clasroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(766, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDene);
            this.Controls.Add(this.btnEgit);
            this.Controls.Add(this.txtKomutEgitim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFonksiyonlar);
            this.Controls.Add(this.txtKodMetin);
            this.Controls.Add(this.pbTavsan);
            this.Controls.Add(this.pbLamba);
            this.Controls.Add(this.pbPervane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Smart_Clasroom";
            this.Text = "Smart_Clasroom";
            ((System.ComponentModel.ISupportInitialize)(this.pbTavsan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLamba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPervane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPervane;
        private System.Windows.Forms.PictureBox pbLamba;
        private System.Windows.Forms.PictureBox pbTavsan;
        private System.Windows.Forms.TextBox txtKodMetin;
        private System.Windows.Forms.ComboBox cbFonksiyonlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKomutEgitim;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEgit;
        private Bunifu.Framework.UI.BunifuFlatButton btnDene;
        private System.Windows.Forms.Label label4;
    }
}