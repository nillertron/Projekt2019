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
using ProjektOpgave1Sem2019.Model;

//Nichlas
namespace ProjektOpgave1Sem2019
{
    public partial class ValgtEjendomsMæglerDetails : UserControl
    {


        private bool edit;
        private Ejendomsmægler E;
        EjendomsmæglerViewModel ViewModel;
        EjendomsmæglereForm ParentForm;

        public ValgtEjendomsMæglerDetails(EjendomsmæglerViewModel View, EjendomsmæglereForm ParentForm)
        {
            InitializeComponent();

            this.ParentForm = ParentForm;

            this.ViewModel = View;
            CBPostNr.DataSource = View.PostNummerListe;
            CBPostNr.DisplayMember = "PostNummer";
            var valgt = CBPostNr.SelectedItem as PostNumre;
            LBLdistrikt.Text = valgt.Distrikt;

            CBPostNr.SelectedIndexChanged += (o, e) => 
            {
                 valgt = CBPostNr.SelectedItem as PostNumre;
                LBLdistrikt.Text = valgt.Distrikt;
            };

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
                TBKonto.Text = E.KontoNr;
            TBAdresse.Text = E.Addresse;
                TBNavn.Text = E.Navn;
            TBEfternavn.Text = E.Efternavn;
                TBTelefon.Text = E.TelefonNr;
            LBLoverskrift.Text = "Rediger";
            BTNSlet.Show();
            BTNEdit.Show();

            CBPostNr.SelectedIndex = ViewModel.PostNummerListe.FindIndex(o => o.PostNummer == E.PostNr);

            //
        }
        public void CreateMode()
        {
            ClearTekstBokse();
            CBPostNr.SelectedIndex = 0;
            TBId.Hide();
            BTNEdit.Hide();
            BTNSlet.Hide();
            BTNOpret.Show();
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
            TBAdresse.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (edit)
            {
                PostNumre valgt = CBPostNr.SelectedItem as PostNumre;
                
                try
                {
                    var phobj = new Ejendomsmægler(TBNavn.Text, TBEfternavn.Text, TBTelefon.Text, TBFødselsdag.Value, valgt.PostNummer, TBKonto.Text, TBAdresse.Text);
                    E.Opdater(phobj);
                    ViewModel.Edit(E);


                }
                catch (FormatException eee)
                {
                    MessageBox.Show(eee.Message);
                }

                
                ParentForm.UpdateListView(ViewModel.DisplaySearchResults());

            }
        }

        private void BTNOpret_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                try
                {
                    PostNumre valgt = CBPostNr.SelectedItem as PostNumre;

                    var ny = new Ejendomsmægler(TBNavn.Text, TBEfternavn.Text, TBTelefon.Text, TBFødselsdag.Value, valgt.PostNummer, TBKonto.Text, TBAdresse.Text);
                    ViewModel.Opret(ny);
                    ClearTekstBokse();
                    MessageBox.Show("Oprettet");

                }
                catch (FormatException eee)
                {
                    MessageBox.Show(eee.Message);
                }

                ParentForm.UpdateListView(ViewModel.DisplaySearchResults());
            }
        }

        private void BTNSlet_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                try
                {
                    if (ViewModel.Delete(E))
                    {
                        ClearTekstBokse();
                        ParentForm.UpdateListView(ViewModel.DisplaySearchResults());
                        MessageBox.Show("Ejendomsmægler slettet");
                    }

                }
                catch(Exception eee)
                {
                    MessageBox.Show(eee.Message);
                }

                
            }
        }
        


    }
}
