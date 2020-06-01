namespace Make_Me_Happy
{
    partial class frmMakeMeHappy
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
            this.pbImages = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbResimYolu = new System.Windows.Forms.TextBox();
            this.rbMutlu = new System.Windows.Forms.RadioButton();
            this.rbUzgun = new System.Windows.Forms.RadioButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnImageSelect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnResimEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKontrol = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImageSelect1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbImages1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImages1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImages
            // 
            this.pbImages.Location = new System.Drawing.Point(3, 72);
            this.pbImages.Margin = new System.Windows.Forms.Padding(4);
            this.pbImages.Name = "pbImages";
            this.pbImages.Size = new System.Drawing.Size(344, 228);
            this.pbImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImages.TabIndex = 1;
            this.pbImages.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // tbResimYolu
            // 
            this.tbResimYolu.Location = new System.Drawing.Point(13, 317);
            this.tbResimYolu.Margin = new System.Windows.Forms.Padding(4);
            this.tbResimYolu.Name = "tbResimYolu";
            this.tbResimYolu.Size = new System.Drawing.Size(132, 22);
            this.tbResimYolu.TabIndex = 5;
            // 
            // rbMutlu
            // 
            this.rbMutlu.AutoSize = true;
            this.rbMutlu.ForeColor = System.Drawing.Color.Gold;
            this.rbMutlu.Location = new System.Drawing.Point(13, 349);
            this.rbMutlu.Margin = new System.Windows.Forms.Padding(4);
            this.rbMutlu.Name = "rbMutlu";
            this.rbMutlu.Size = new System.Drawing.Size(63, 21);
            this.rbMutlu.TabIndex = 7;
            this.rbMutlu.TabStop = true;
            this.rbMutlu.Text = "Mutlu";
            this.rbMutlu.UseVisualStyleBackColor = true;
            // 
            // rbUzgun
            // 
            this.rbUzgun.AutoSize = true;
            this.rbUzgun.ForeColor = System.Drawing.Color.Gold;
            this.rbUzgun.Location = new System.Drawing.Point(13, 377);
            this.rbUzgun.Margin = new System.Windows.Forms.Padding(4);
            this.rbUzgun.Name = "rbUzgun";
            this.rbUzgun.Size = new System.Drawing.Size(70, 21);
            this.rbUzgun.TabIndex = 8;
            this.rbUzgun.TabStop = true;
            this.rbUzgun.Text = "Üzgün";
            this.rbUzgun.UseVisualStyleBackColor = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnImageSelect
            // 
            this.btnImageSelect.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnImageSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnImageSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImageSelect.BorderRadius = 0;
            this.btnImageSelect.ButtonText = "Resim Seç";
            this.btnImageSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageSelect.DisabledColor = System.Drawing.Color.Gray;
            this.btnImageSelect.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImageSelect.Iconimage = null;
            this.btnImageSelect.Iconimage_right = null;
            this.btnImageSelect.Iconimage_right_Selected = null;
            this.btnImageSelect.Iconimage_Selected = null;
            this.btnImageSelect.IconMarginLeft = 0;
            this.btnImageSelect.IconMarginRight = 0;
            this.btnImageSelect.IconRightVisible = true;
            this.btnImageSelect.IconRightZoom = 0D;
            this.btnImageSelect.IconVisible = true;
            this.btnImageSelect.IconZoom = 90D;
            this.btnImageSelect.IsTab = false;
            this.btnImageSelect.Location = new System.Drawing.Point(169, 317);
            this.btnImageSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImageSelect.Name = "btnImageSelect";
            this.btnImageSelect.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnImageSelect.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnImageSelect.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImageSelect.selected = false;
            this.btnImageSelect.Size = new System.Drawing.Size(108, 28);
            this.btnImageSelect.TabIndex = 9;
            this.btnImageSelect.Text = "Resim Seç";
            this.btnImageSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImageSelect.Textcolor = System.Drawing.Color.White;
            this.btnImageSelect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageSelect.Click += new System.EventHandler(this.btnImageSelect_Click_1);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnResimEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnResimEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResimEkle.BorderRadius = 0;
            this.btnResimEkle.ButtonText = "Resim Ekle";
            this.btnResimEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResimEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btnResimEkle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnResimEkle.Iconimage = null;
            this.btnResimEkle.Iconimage_right = null;
            this.btnResimEkle.Iconimage_right_Selected = null;
            this.btnResimEkle.Iconimage_Selected = null;
            this.btnResimEkle.IconMarginLeft = 0;
            this.btnResimEkle.IconMarginRight = 0;
            this.btnResimEkle.IconRightVisible = true;
            this.btnResimEkle.IconRightZoom = 0D;
            this.btnResimEkle.IconVisible = true;
            this.btnResimEkle.IconZoom = 90D;
            this.btnResimEkle.IsTab = false;
            this.btnResimEkle.Location = new System.Drawing.Point(173, 353);
            this.btnResimEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnResimEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnResimEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnResimEkle.selected = false;
            this.btnResimEkle.Size = new System.Drawing.Size(104, 28);
            this.btnResimEkle.TabIndex = 10;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResimEkle.Textcolor = System.Drawing.Color.White;
            this.btnResimEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click_1);
            // 
            // btnKontrol
            // 
            this.btnKontrol.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnKontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKontrol.BorderRadius = 0;
            this.btnKontrol.ButtonText = "KONTROLÜ BAŞLAT";
            this.btnKontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKontrol.DisabledColor = System.Drawing.Color.Gray;
            this.btnKontrol.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKontrol.Iconimage = null;
            this.btnKontrol.Iconimage_right = null;
            this.btnKontrol.Iconimage_right_Selected = null;
            this.btnKontrol.Iconimage_Selected = null;
            this.btnKontrol.IconMarginLeft = 0;
            this.btnKontrol.IconMarginRight = 0;
            this.btnKontrol.IconRightVisible = true;
            this.btnKontrol.IconRightZoom = 0D;
            this.btnKontrol.IconVisible = true;
            this.btnKontrol.IconZoom = 90D;
            this.btnKontrol.IsTab = false;
            this.btnKontrol.Location = new System.Drawing.Point(581, 317);
            this.btnKontrol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnKontrol.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnKontrol.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKontrol.selected = false;
            this.btnKontrol.Size = new System.Drawing.Size(140, 57);
            this.btnKontrol.TabIndex = 13;
            this.btnKontrol.Text = "KONTROLÜ BAŞLAT";
            this.btnKontrol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKontrol.Textcolor = System.Drawing.Color.White;
            this.btnKontrol.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // btnImageSelect1
            // 
            this.btnImageSelect1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnImageSelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnImageSelect1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImageSelect1.BorderRadius = 0;
            this.btnImageSelect1.ButtonText = "RESİM SEÇİNİZ";
            this.btnImageSelect1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageSelect1.DisabledColor = System.Drawing.Color.Gray;
            this.btnImageSelect1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImageSelect1.Iconimage = null;
            this.btnImageSelect1.Iconimage_right = null;
            this.btnImageSelect1.Iconimage_right_Selected = null;
            this.btnImageSelect1.Iconimage_Selected = null;
            this.btnImageSelect1.IconMarginLeft = 0;
            this.btnImageSelect1.IconMarginRight = 0;
            this.btnImageSelect1.IconRightVisible = true;
            this.btnImageSelect1.IconRightZoom = 0D;
            this.btnImageSelect1.IconVisible = true;
            this.btnImageSelect1.IconZoom = 90D;
            this.btnImageSelect1.IsTab = false;
            this.btnImageSelect1.Location = new System.Drawing.Point(414, 317);
            this.btnImageSelect1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImageSelect1.Name = "btnImageSelect1";
            this.btnImageSelect1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnImageSelect1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnImageSelect1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImageSelect1.selected = false;
            this.btnImageSelect1.Size = new System.Drawing.Size(140, 57);
            this.btnImageSelect1.TabIndex = 12;
            this.btnImageSelect1.Text = "RESİM SEÇİNİZ";
            this.btnImageSelect1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImageSelect1.Textcolor = System.Drawing.Color.White;
            this.btnImageSelect1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageSelect1.Click += new System.EventHandler(this.btnImageSelect1_Click);
            // 
            // pbImages1
            // 
            this.pbImages1.Location = new System.Drawing.Point(375, 72);
            this.pbImages1.Margin = new System.Windows.Forms.Padding(4);
            this.pbImages1.Name = "pbImages1";
            this.pbImages1.Size = new System.Drawing.Size(365, 233);
            this.pbImages1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImages1.TabIndex = 11;
            this.pbImages1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "EĞİTİM BÖLÜMÜMÜZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(471, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "UYGULAMA BÖLÜMÜMÜZ";
            // 
            // frmMakeMeHappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(766, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.btnImageSelect1);
            this.Controls.Add(this.pbImages1);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.btnImageSelect);
            this.Controls.Add(this.rbUzgun);
            this.Controls.Add(this.rbMutlu);
            this.Controls.Add(this.tbResimYolu);
            this.Controls.Add(this.pbImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMakeMeHappy";
            this.Text = "MAKE ME HAPPY";
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImages1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImages;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tbResimYolu;
        private System.Windows.Forms.RadioButton rbMutlu;
        private System.Windows.Forms.RadioButton rbUzgun;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnResimEkle;
        private Bunifu.Framework.UI.BunifuFlatButton btnImageSelect;
        private Bunifu.Framework.UI.BunifuFlatButton btnKontrol;
        private Bunifu.Framework.UI.BunifuFlatButton btnImageSelect1;
        private System.Windows.Forms.PictureBox pbImages1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

