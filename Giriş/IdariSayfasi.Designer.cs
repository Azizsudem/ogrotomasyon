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
            pictureBox1 = new PictureBox();
            ogrkayit = new Button();
            ogrliste = new Button();
            akadliste = new Button();
            akadkayit = new Button();
            devamsızlık = new Button();
            dersprog = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bilkent;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1090, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // ogrkayit
            // 
            ogrkayit.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            ogrkayit.Location = new Point(12, 250);
            ogrkayit.Name = "ogrkayit";
            ogrkayit.Size = new Size(419, 61);
            ogrkayit.TabIndex = 11;
            ogrkayit.Text = "Öğrenci Kayıt";
            ogrkayit.UseVisualStyleBackColor = true;
            // 
            // ogrliste
            // 
            ogrliste.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            ogrliste.Location = new Point(12, 317);
            ogrliste.Name = "ogrliste";
            ogrliste.Size = new Size(419, 61);
            ogrliste.TabIndex = 12;
            ogrliste.Text = "Öğrenci Liste";
            ogrliste.UseVisualStyleBackColor = true;
            // 
            // akadliste
            // 
            akadliste.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            akadliste.Location = new Point(12, 451);
            akadliste.Name = "akadliste";
            akadliste.Size = new Size(419, 61);
            akadliste.TabIndex = 13;
            akadliste.Text = "Akademisyen Liste";
            akadliste.UseVisualStyleBackColor = true;
            // 
            // akadkayit
            // 
            akadkayit.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            akadkayit.Location = new Point(12, 384);
            akadkayit.Name = "akadkayit";
            akadkayit.Size = new Size(419, 61);
            akadkayit.TabIndex = 14;
            akadkayit.Text = "Akademisyen Kayıt";
            akadkayit.UseVisualStyleBackColor = true;
            // 
            // devamsızlık
            // 
            devamsızlık.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            devamsızlık.Location = new Point(437, 250);
            devamsızlık.Name = "devamsızlık";
            devamsızlık.Size = new Size(419, 61);
            devamsızlık.TabIndex = 15;
            devamsızlık.Text = "Devamsızlık";
            devamsızlık.UseVisualStyleBackColor = true;
            // 
            // dersprog
            // 
            dersprog.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            dersprog.Location = new Point(437, 317);
            dersprog.Name = "dersprog";
            dersprog.Size = new Size(419, 61);
            dersprog.TabIndex = 16;
            dersprog.Text = "Dersprogramı";
            dersprog.UseVisualStyleBackColor = true;
            // 
            // IdariSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 647);
            Controls.Add(dersprog);
            Controls.Add(devamsızlık);
            Controls.Add(akadkayit);
            Controls.Add(akadliste);
            Controls.Add(ogrliste);
            Controls.Add(ogrkayit);
            Controls.Add(pictureBox1);
            Name = "IdariSayfasi";
            Text = "IdariSayfasi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button ogrkayit;
        private Button button1;
        private Button ogrliste;
        private Button akadliste;
        private Button akadkayit;
        private Button devamsızlık;
        private Button dersprog;
    }
}