using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float yazili1, yazili2, devamsızlık, ortalama,durum;
            
            yazili1=Convert.ToSingle(txtYazili1.Text);
            yazili2=Convert.ToSingle(txtYazili2.Text);
            devamsızlık = Convert.ToSingle(txtDevamsızlık.Text);

            ortalama = (yazili1 + yazili2) / 2;

            if (ortalama >= 50 && devamsızlık<10)
            {
                lblDurum.Text = "GEÇTİ:)";
            }
            else
            {
                lblDurum.Text = "Kaldı";
            }

            
        }
    }
}
