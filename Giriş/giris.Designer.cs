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
            idarigiris = new Button();
            akadgiris = new Button();
            ogrgiris = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // idarigiris
            // 
            idarigiris.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            idarigiris.Location = new Point(349, 453);
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
            akadgiris.Location = new Point(349, 381);
            akadgiris.Name = "akadgiris";
            akadgiris.Size = new Size(419, 61);
            akadgiris.TabIndex = 11;
            akadgiris.Text = "Akademisyen Giriş";
            akadgiris.UseVisualStyleBackColor = true;
            // 
            // ogrgiris
            // 
            ogrgiris.Font = new Font("Verdana", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            ogrgiris.Location = new Point(349, 309);
            ogrgiris.Name = "ogrgiris";
            ogrgiris.Size = new Size(419, 61);
            ogrgiris.TabIndex = 10;
            ogrgiris.Text = "Öğrenci Giriş";
            ogrgiris.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bilkent;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1090, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 647);
            Controls.Add(idarigiris);
            Controls.Add(akadgiris);
            Controls.Add(ogrgiris);
            Controls.Add(pictureBox1);
            Name = "giris";
            Text = "giris";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button idarigiris;
        private Button akadgiris;
        private Button ogrgiris;
        private PictureBox pictureBox1;
    }
}