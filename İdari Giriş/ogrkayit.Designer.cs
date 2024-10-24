namespace ogrbilgisistemi
{
    partial class ogrkayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrkayit));
            groupBox3 = new GroupBox();
            ogrbolum = new ComboBox();
            label12 = new Label();
            ogrdonem = new ComboBox();
            ogrsinif = new ComboBox();
            ogrno = new MaskedTextBox();
            label23 = new Label();
            label24 = new Label();
            label27 = new Label();
            groupBox1 = new GroupBox();
            Gender = new ComboBox();
            cinsiyet = new Label();
            ogrposta = new MaskedTextBox();
            velisoyadi = new MaskedTextBox();
            ogrtel = new MaskedTextBox();
            veliadi = new MaskedTextBox();
            label18 = new Label();
            ogradi = new MaskedTextBox();
            ogrsoyadi = new MaskedTextBox();
            label17 = new Label();
            TCKimlik = new MaskedTextBox();
            ogrdogumyeri = new ComboBox();
            ogrtime = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ogrbolum);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(ogrdonem);
            groupBox3.Controls.Add(ogrsinif);
            groupBox3.Controls.Add(ogrno);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label27);
            groupBox3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(559, 191);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(508, 162);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "OKUL BİLGİLERİ";
            // 
            // ogrbolum
            // 
            ogrbolum.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ogrbolum.FormattingEnabled = true;
            ogrbolum.Items.AddRange(new object[] { "", "Bilgisayar Mühendisliği", "Elektrik – Elektronik Mühendisliği", "Makine Mühendisliği" });
            ogrbolum.Location = new Point(291, 59);
            ogrbolum.Name = "ogrbolum";
            ogrbolum.Size = new Size(211, 30);
            ogrbolum.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label12.Location = new Point(6, 90);
            label12.Name = "label12";
            label12.Size = new Size(87, 34);
            label12.TabIndex = 22;
            label12.Text = "SINIF";
            // 
            // ogrdonem
            // 
            ogrdonem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ogrdonem.FormattingEnabled = true;
            ogrdonem.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            ogrdonem.Location = new Point(291, 128);
            ogrdonem.Name = "ogrdonem";
            ogrdonem.Size = new Size(211, 30);
            ogrdonem.TabIndex = 21;
            // 
            // ogrsinif
            // 
            ogrsinif.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ogrsinif.FormattingEnabled = true;
            ogrsinif.Items.AddRange(new object[] { "1", "2", "3", "4" });
            ogrsinif.Location = new Point(291, 94);
            ogrsinif.Name = "ogrsinif";
            ogrsinif.Size = new Size(211, 30);
            ogrsinif.TabIndex = 20;
            // 
            // ogrno
            // 
            ogrno.Location = new Point(252, 26);
            ogrno.Name = "ogrno";
            ogrno.Size = new Size(250, 30);
            ogrno.TabIndex = 18;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label23.Location = new Point(6, 59);
            label23.Name = "label23";
            label23.Size = new Size(140, 34);
            label23.TabIndex = 4;
            label23.Text = "BÖLÜMÜ";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label24.AutoSize = true;
            label24.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label24.Location = new Point(0, 124);
            label24.Name = "label24";
            label24.Size = new Size(124, 34);
            label24.TabIndex = 3;
            label24.Text = "DÖNEM";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label27.Location = new Point(6, 26);
            label27.Name = "label27";
            label27.Size = new Size(145, 34);
            label27.TabIndex = 0;
            label27.Text = "OKUL NO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Gender);
            groupBox1.Controls.Add(cinsiyet);
            groupBox1.Controls.Add(ogrposta);
            groupBox1.Controls.Add(velisoyadi);
            groupBox1.Controls.Add(ogrtel);
            groupBox1.Controls.Add(veliadi);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(ogradi);
            groupBox1.Controls.Add(ogrsoyadi);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(TCKimlik);
            groupBox1.Controls.Add(ogrdogumyeri);
            groupBox1.Controls.Add(ogrtime);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(48, 191);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 372);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "KİŞİ BİLGİLERİ";
            // 
            // Gender
            // 
            Gender.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "KADIN", "erkek", "Diğer" });
            Gender.Location = new Point(291, 332);
            Gender.Name = "Gender";
            Gender.Size = new Size(211, 30);
            Gender.TabIndex = 28;
            // 
            // cinsiyet
            // 
            cinsiyet.AutoSize = true;
            cinsiyet.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            cinsiyet.Location = new Point(6, 328);
            cinsiyet.Name = "cinsiyet";
            cinsiyet.Size = new Size(143, 34);
            cinsiyet.TabIndex = 27;
            cinsiyet.Text = "CİNSİYET";
            // 
            // ogrposta
            // 
            ogrposta.Location = new Point(252, 233);
            ogrposta.Name = "ogrposta";
            ogrposta.Size = new Size(250, 30);
            ogrposta.TabIndex = 19;
            // 
            // velisoyadi
            // 
            velisoyadi.Location = new Point(252, 297);
            velisoyadi.Name = "velisoyadi";
            velisoyadi.Size = new Size(250, 30);
            velisoyadi.TabIndex = 25;
            // 
            // ogrtel
            // 
            ogrtel.Location = new Point(252, 201);
            ogrtel.Name = "ogrtel";
            ogrtel.Size = new Size(250, 30);
            ogrtel.TabIndex = 18;
            // 
            // veliadi
            // 
            veliadi.Location = new Point(252, 263);
            veliadi.Name = "veliadi";
            veliadi.Size = new Size(250, 30);
            veliadi.TabIndex = 26;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label18.Location = new Point(0, 294);
            label18.Name = "label18";
            label18.Size = new Size(192, 34);
            label18.TabIndex = 4;
            label18.Text = "VELİ SOYADI";
            // 
            // ogradi
            // 
            ogradi.Location = new Point(252, 63);
            ogradi.Name = "ogradi";
            ogradi.Size = new Size(250, 30);
            ogradi.TabIndex = 15;
            // 
            // ogrsoyadi
            // 
            ogrsoyadi.Location = new Point(252, 97);
            ogrsoyadi.Name = "ogrsoyadi";
            ogrsoyadi.Size = new Size(250, 30);
            ogrsoyadi.TabIndex = 14;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label17.Location = new Point(0, 260);
            label17.Name = "label17";
            label17.Size = new Size(135, 34);
            label17.TabIndex = 5;
            label17.Text = "VELİ ADI";
            // 
            // TCKimlik
            // 
            TCKimlik.Location = new Point(252, 29);
            TCKimlik.Name = "TCKimlik";
            TCKimlik.Size = new Size(250, 30);
            TCKimlik.TabIndex = 13;
            // 
            // ogrdogumyeri
            // 
            ogrdogumyeri.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ogrdogumyeri.FormattingEnabled = true;
            ogrdogumyeri.Items.AddRange(new object[] { "Adana  ", "Adıyaman  ", "Afyonkarahisar  ", "Ağrı  ", "Amasya  ", "Ankara  ", "Antalya  ", "Artvin  ", "Aydın  ", "Balıkesir  ", "Bilecik  ", "Bingöl  ", "Bitlis  ", "Bolu  ", "Burdur  ", "Bursa  ", "Çanakkale  ", "Çankırı  ", "Çorum  ", "Denizli  ", "Diyarbakır  ", "Edirne  ", "Elazığ  ", "Erzincan  ", "Erzurum  ", "Eskişehir  ", "Gaziantep  ", "Giresun  ", "Gümüşhane  ", "Hakkari  ", "Hatay  ", "Isparta  ", "Mersin  ", "İstanbul  ", "İzmir  ", "Kars  ", "Kastamonu  ", "Kayseri  ", "Kırklareli  ", "Kırşehir  ", "Kocaeli  ", "Konya  ", "Kütahya  ", "Malatya  ", "Manisa  ", "Kahramanmaraş  ", "Mardin  ", "Muğla  ", "Muş  ", "Nevşehir  ", "Niğde  ", "Ordu  ", "Rize  ", "Sakarya  ", "Samsun  ", "Siirt  ", "Sinop  ", "Sivas  ", "Tekirdağ  ", "Tokat  ", "Trabzon  ", "Tunceli  ", "Şanlıurfa  ", "Uşak  ", "Van  ", "Yozgat  ", "Zonguldak  ", "Aksaray  ", "Bayburt  ", "Karaman  ", "Kırıkkale  ", "Batman  ", "Şırnak  ", "Bartın  ", "Ardahan  ", "Iğdır  ", "Yalova  ", "Karabük  ", "Kilis  ", "Osmaniye  ", "Düzce" });
            ogrdogumyeri.Location = new Point(291, 132);
            ogrdogumyeri.Name = "ogrdogumyeri";
            ogrdogumyeri.Size = new Size(211, 30);
            ogrdogumyeri.TabIndex = 12;
            // 
            // ogrtime
            // 
            ogrtime.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            ogrtime.Location = new Point(252, 163);
            ogrtime.Name = "ogrtime";
            ogrtime.Size = new Size(250, 30);
            ogrtime.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.Location = new Point(0, 196);
            label8.Name = "label8";
            label8.Size = new Size(224, 34);
            label8.TabIndex = 7;
            label8.Text = "CEP TELEFONU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.Location = new Point(0, 230);
            label7.Name = "label7";
            label7.Size = new Size(241, 34);
            label7.TabIndex = 6;
            label7.Text = "E POSTA ADRESİ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.Location = new Point(6, 60);
            label6.Name = "label6";
            label6.Size = new Size(66, 34);
            label6.TabIndex = 5;
            label6.Text = "ADI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(6, 94);
            label5.Name = "label5";
            label5.Size = new Size(123, 34);
            label5.TabIndex = 4;
            label5.Text = "SOYADI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(6, 128);
            label4.Name = "label4";
            label4.Size = new Size(198, 34);
            label4.TabIndex = 3;
            label4.Text = "DOĞUM YERİ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 162);
            label3.Name = "label3";
            label3.Size = new Size(230, 34);
            label3.TabIndex = 2;
            label3.Text = "DOĞUM TARİHİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(163, 34);
            label1.TabIndex = 0;
            label1.Text = "T.C KİMLİK";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(967, 365);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 19;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1090, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // ogrkayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 647);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "ogrkayit";
            Text = "ogrkayit";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox3;
        private ComboBox ogrbolum;
        private Label label12;
        private ComboBox ogrdonem;
        private ComboBox ogrsinif;
        private MaskedTextBox ogrno;
        private Label label23;
        private Label label24;
        private Label label27;
        private GroupBox groupBox1;
        private MaskedTextBox ogrposta;
        private MaskedTextBox ogrtel;
        private MaskedTextBox ogradi;
        private MaskedTextBox ogrsoyadi;
        private MaskedTextBox TCKimlik;
        private ComboBox ogrdogumyeri;
        private DateTimePicker ogrtime;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button button1;
        private Label label17;
        private Label label18;
        private MaskedTextBox veliadi;
        private MaskedTextBox velisoyadi;
        private PictureBox pictureBox1;
        private ComboBox Gender;
        private Label cinsiyet;
    }
}