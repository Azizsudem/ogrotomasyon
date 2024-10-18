using System;
using System.Drawing;
using System.Windows.Forms;

namespace ogrbilgisistemi
{
    public partial class ogrkayit : Form
    {
        private GroupBox groupBox; // GroupBox değişkeni

        public ogrkayit()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Form1_Resize); // Formun boyutu değiştiğinde olay bağla
            this.Load += new EventHandler(Form1_Load); // Form yüklendiğinde olay bağla
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // GroupBox oluştur
            groupBox = new GroupBox();
            groupBox.Text = "Bilgi Grubu"; // GroupBox başlığı
            groupBox.Size = new Size(300, 200); // GroupBox boyutu
            this.Controls.Add(groupBox); // GroupBox'ı forma ekle

            CenterGroupBox(groupBox); // Başlangıçta GroupBox'ı ortala
        }

        private void CenterGroupBox(GroupBox groupBox)
        {
            // GroupBox'ı formun ortasında yerleştir
            groupBox.Left = (this.ClientSize.Width - groupBox.Width) / 2;
            groupBox.Top = (this.ClientSize.Height - groupBox.Height) / 2;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Form boyutu değiştiğinde GroupBox'ı tekrar ortala
            CenterGroupBox(groupBox);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            // Bu metoda eklemek istediğiniz başka bir işlev varsa buraya ekleyebilirsiniz
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
