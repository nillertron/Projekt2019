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

        public bool edit;
        private Ejendomsmægler E;
        EjendomsmæglerViewModel ViewModel;

        //hvis denne konstruktor bliver kaldt, ved klassen at den er i "create mode"
        public ValgtEjendomsMæglerDetails()
        {
            CreateMode();
        }
        //hvis denne konstruktor er kaldt, ved klassen at den er i edit mode
        public ValgtEjendomsMæglerDetails(Ejendomsmægler E, EjendomsmæglerViewModel View)
        {
            InitializeComponent();
            this.E = E;
            this.ViewModel = View;
            EditMode();
        }
        private void EditMode()
        {
            BTNOpret.Hide();
            edit = true;
            TBId.ReadOnly = true;
                BTNOpret.Hide();
                TBId.Text = E.Id.ToString();
                TBFødselsdag.Text = E.Fødseldato.ToString();
                TBKonto.Text = E.KontoNr.ToString();
                TBNavn.Text = E.Navn;
                TBTelefon.Text = E.TelefonNr;
            LBLoverskrift.Text = "Rediger";

        }
        private void CreateMode()
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
            TBEfternavn.Clear();
            TBId.Clear();
            TBKonto.Clear();
            TBNavn.Clear();
            TBTelefon.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                var phobj = new Ejendomsmægler(TBNavn.Text, TBEfternavn.Text, TBTelefon.Text, TBKonto.Text, TBFødselsdag.Value);
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
                    var ny = new Ejendomsmægler(TBNavn.Text, TBEfternavn.Text, TBTelefon.Text, TBKonto.Text, TBFødselsdag.Value);
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
