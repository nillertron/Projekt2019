using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOpgave1Sem2019.View
{
    public partial class ValgtEjendomsMæglerDetails : UserControl
    {
        private static string Mode = "Opret";
        private Ejendomsmægler ValgtEjendomsmægler;
        public ValgtEjendomsMæglerDetails(Ejendomsmægler E)
        {
            InitializeComponent();
            ValgtEjendomsmægler = E;
            TBId.ReadOnly = true;
            if (Mode == "Rediger")
            {
                BTNOpret.Hide();
                TBId.Text = E.Id.ToString();
                TBFødselsdag.Text = E.Fødseldato.ToString();
                TBKonto.Text = E.KontoNr.ToString();
                TBNavn.Text = E.Navn;
                TBTelefon.Text = E.TelefonNr;
            }
        }

        private void ValgtEjendomsMæglerDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
