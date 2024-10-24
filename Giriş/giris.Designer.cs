namespace ogrbilgisistemi
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            idarigiris = new Button();
            akadgiris = new Button();
            ogrgiris = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // idarigiris
            // 
            idarigiris.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            idarigiris.Location = new Point(349, 468);
            idarigiris.Name = "idarigiris";
            idarigiris.Size = new Size(419, 61);
            idarigiris.TabIndex = 12;
            idarigiris.Text = "İdari Giriş";
            idarigiris.UseVisualStyleBackColor = true;
            idarigiris.Click += idarigiris_Click;
            // 
            // akadgiris
            // 
            akadgiris.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            akadgiris.Location = new Point(349, 396);
            akadgiris.Name = "akadgiris";
            akadgiris.Size = new Size(419, 61);
            akadgiris.TabIndex = 11;
            akadgiris.Text = "Akademisyen Giriş";
            akadgiris.UseVisualStyleBackColor = true;
            // 
            // ogrgiris
            // 
            ogrgiris.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            ogrgiris.Location = new Point(349, 324);
            ogrgiris.Name = "ogrgiris";
            ogrgiris.Size = new Size(419, 61);
            ogrgiris.TabIndex = 10;
            ogrgiris.Text = "Öğrenci Giriş";
            ogrgiris.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1090, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, -39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1090, 694);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 647);
            Controls.Add(pictureBox1);
            Controls.Add(idarigiris);
            Controls.Add(akadgiris);
            Controls.Add(ogrgiris);
            Controls.Add(pictureBox2);
            Name = "giris";
            Text = "giris";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button idarigiris;
        private Button akadgiris;
        private Button ogrgiris;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}