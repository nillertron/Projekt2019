using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektOpgave1Sem2019.View;
using ProjektOpgave1Sem2019.View.Bolig;
//Nichlas
namespace ProjektOpgave1Sem2019
{
    public partial class BoligForm : UserControl
    {
        BoligViewModel ViewModel;
        BoligDetails Details;
        public BoligForm()
        {
            InitializeComponent();
            ViewModel = new BoligViewModel(this);
            var kriterier = new string[] { "Adresse", "PostNr", "Areal større end", "Areal mindre end", "Pris større end", "Pris mindre end" };
            CBKriterie.Items.AddRange(kriterier);
            FyldListView(ViewModel.FillListView());
            CBKriterie.SelectedIndex = 0;
            Details = ViewModel.Details;
            Controls.Add(Details);

        }

        private void FyldListView(List<Bolig> liste)
        {
            //LWSearchResults.Items.Clear(); //Sikrer at Listen bliver clearet hver gang den skal opdateres (Maybe) -Martin
            liste.ForEach(o => 
            {
                var enhed = new ListViewItem(o.Adresse);
                enhed.SubItems.Add(o.PostNr.ToString());
                enhed.Name = o.ID.ToString();
                
                LWSearchResults.Items.Add(enhed);



            });
        }

        private void BoligView_Load(object sender, EventArgs e)
        {

        }

        private void TBInput_TextChanged(object sender, EventArgs e)
        {
            var phListe = new List<Bolig>();
            LWSearchResults.Items.Clear();
            if (TBInput.TextLength == 0)
                FyldListView(ViewModel.FillListView());
            else
            {
                var input = TBInput.Text;
                var kriterie = CBKriterie.SelectedItem.ToString();
                bool ok = ViewModel.ValiderInput(input, kriterie);
                if (!ok && TBInput.TextLength != 0)
                    LWSearchResults.Items.Add("Fejl i søgnings input");
                else
                {
                    phListe = ViewModel.SearchFor(kriterie, input.ToLower());
                    FyldListView(phListe);
                    phListe.Clear();
                }
            }






        }

        private void LWSearchResults_DoubleClick(object sender, EventArgs e)
        {
            var Valgt = ViewModel.GetBolig(LWSearchResults.FocusedItem.Name);
            ViewModel.FillListView().ForEach(o => { if (o.ID.ToString() == LWSearchResults.FocusedItem.Name) Valgt = o; });

            ViewModel.Edit(Valgt);
            //Details.InitializeEditMode(Valgt);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ViewModel.Opret();
        }

        public void SælgBoligToFront(Bolig b, BoligDetails instans)
        {
            var S = new SælgBolig(b, instans);
            
            Controls.Add(S);
            S.BringToFront();


        }

        private void btnUdskrivAlleBoligerIkkeSolgt_Click(object sender, EventArgs e)
        {
            ViewModel.UdskrivBoligerTilTxtFil();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var SøgForm = new BoligSøgning(ViewModel);
            if (!Controls.Contains(SøgForm))
                Controls.Add(SøgForm);
            SøgForm.BringToFront();

        }
    }
}
