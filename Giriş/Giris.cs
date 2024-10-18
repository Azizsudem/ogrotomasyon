using ogrbilgisistemi.Giriş;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrbilgisistemi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void idarigiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            IdariSayfasi Formac = new IdariSayfasi();
            Formac.Show();
        }
    }
}
