using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektOpgave1Sem2019.View_Model;

namespace ProjektOpgave1Sem2019
{
    public partial class ValgtEjendomsMæglerDetails : UserControl
    {
        //private ValgtEjendomsMæglerDetails _instance;
        //public ValgtEjendomsMæglerDetails Instance { get { if (_instance != null) _instance } }

        public bool edit;
        private Ejendomsmægler E;
        EjendomsmæglerViewModel ViewModel;

        //hvis denne konstruktor bliver kaldt, ved klassen at den er i "create mode"
        public ValgtEjendomsMæglerDetails(EjendomsmæglerViewModel View)
        {
            InitializeComponent();
            this.ViewModel = View;
        }
        
        public void EditMode(Ejendomsmægler E)
        {
            this.E = E;
            TBId.Show();
            BTNOpret.Hide();
            edit = true;
            TBId.ReadOnly = true;
                BTNOpret.Hide();
                TBId.Text = E.Id.ToString();
                TBFødselsdag.Text = E.Fødseldato.ToString();
                TBKonto.Text = E.KontoNr.ToString();
                TBNavn.Text = E.Navn;
            TBEfternavn.Text = E.Efternavn;
                TBTelefon.Text = E.TelefonNr;
            LBLoverskrift.Text = "Rediger";
            //
        }
        public void CreateMode()
        {
            ClearTekstBokse();
            TBId.Hide();
            BTNEdit.Hide();
            BTNSlet.Hide();
            edit = false;
            LBLoverskrift.Text = "Opret";
        }

        private void ValgtEjendomsMæglerDetails_Load(object sender, EventArgs e)
        {
            
        }
        private void ClearTekstBokse()
        {
            TBEfternavn.Text = "";
            TBId.Text = "";
            TBKonto.Text = "";
            TBNavn.Text = "";
            TBTelefon.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                var phobj = new Ejendomsmægler(TBNavn.Text, TBEfternavn.Text, TBTelefon.Text, TBFødselsdag.Value, TBKonto.Text);
                E.Opdater(phobj);
                ViewModel.Edit(E);
            }
        }

        private void BTNOpret_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                try
                {
                    var ny = new Ejendomsmægler(TBNavn.Text, TBEfternavn.Text, TBTelefon.Text, TBFødselsdag.Value, TBKonto.Text);
                    ViewModel.Opret(ny);
                    ClearTekstBokse();
                }
                catch (FormatException eee)
                {
                    MessageBox.Show(eee.Message);
                }
            }
        }

        private void BTNSlet_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                ViewModel.Delete(E);
                ClearTekstBokse();
            }
        }
    }
}
