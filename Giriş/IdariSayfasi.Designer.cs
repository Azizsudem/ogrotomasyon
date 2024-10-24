namespace ogrbilgisistemi.Giriş
{
    partial class IdariSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdariSayfasi));
            ogrkayit = new Button();
            ogrliste = new Button();
            akadliste = new Button();
            akadkayit = new Button();
            devamsızlık = new Button();
            dersprog = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ogrkayit
            // 
            ogrkayit.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            ogrkayit.Location = new Point(136, 250);
            ogrkayit.Name = "ogrkayit";
            ogrkayit.Size = new Size(419, 61);
            ogrkayit.TabIndex = 11;
            ogrkayit.Text = "Öğrenci Kayıt";
            ogrkayit.UseVisualStyleBackColor = true;
            ogrkayit.Click += ogrkayit_Click;
            // 
            // ogrliste
            // 
            ogrliste.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            ogrliste.Location = new Point(136, 317);
            ogrliste.Name = "ogrliste";
            ogrliste.Size = new Size(419, 61);
            ogrliste.TabIndex = 12;
            ogrliste.Text = "Öğrenci Liste";
            ogrliste.UseVisualStyleBackColor = true;
            // 
            // akadliste
            // 
            akadliste.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            akadliste.Location = new Point(559, 317);
            akadliste.Name = "akadliste";
            akadliste.Size = new Size(419, 61);
            akadliste.TabIndex = 13;
            akadliste.Text = "Akademisyen Liste";
            akadliste.UseVisualStyleBackColor = true;
            // 
            // akadkayit
            // 
            akadkayit.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            akadkayit.Location = new Point(559, 250);
            akadkayit.Name = "akadkayit";
            akadkayit.Size = new Size(419, 61);
            akadkayit.TabIndex = 14;
            akadkayit.Text = "Akademisyen Kayıt";
            akadkayit.UseVisualStyleBackColor = true;
            akadkayit.Click += akadkayit_Click;
            // 
            // devamsızlık
            // 
            devamsızlık.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            devamsızlık.Location = new Point(136, 384);
            devamsızlık.Name = "devamsızlık";
            devamsızlık.Size = new Size(419, 61);
            devamsızlık.TabIndex = 15;
            devamsızlık.Text = "Devamsızlık";
            devamsızlık.UseVisualStyleBackColor = true;
            // 
            // dersprog
            // 
            dersprog.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            dersprog.Location = new Point(559, 384);
            dersprog.Name = "dersprog";
            dersprog.Size = new Size(419, 61);
            dersprog.TabIndex = 16;
            dersprog.Text = "Ders programı";
            dersprog.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1090, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            button2.Location = new Point(984, 250);
            button2.Name = "button2";
            button2.Size = new Size(118, 61);
            button2.TabIndex = 19;
            button2.Text = "Akademisyen Liste";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            button3.Location = new Point(984, 484);
            button3.Name = "button3";
            button3.Size = new Size(118, 61);
            button3.TabIndex = 20;
            button3.Text = "Akademisyen Liste";
            button3.UseVisualStyleBackColor = true;
            // 
            // IdariSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 647);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(dersprog);
            Controls.Add(devamsızlık);
            Controls.Add(akadkayit);
            Controls.Add(akadliste);
            Controls.Add(ogrliste);
            Controls.Add(ogrkayit);
            Name = "IdariSayfasi";
            Text = "IdariSayfasi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button ogrkayit;
        private Button ogrliste;
        private Button akadliste;
        private Button akadkayit;
        private Button devamsızlık;
        private Button dersprog;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
    }
}