using ogrbilgisistemi.Giriş;
using ogrbilgisistemi.İdari_Giriş;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrbilgisistemi.Giriş
{
    public partial class IdariSayfasi : Form
    {
        public IdariSayfasi()
        {
            InitializeComponent();
        }

        private void ogrkayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ogrkayit Formac = new ogrkayit();
            Formac.Show();
        }

        private void akadkayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Akadkayit Formac = new Akadkayit();
            Formac.Show();
        }
    }
}