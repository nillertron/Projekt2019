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

        public void FyldListView(List<Bolig> liste) //Har gjort den her public til brug I BoligDetails -Martin
        {
            //THIS WRONG, SUCKS, DONT LISTEN TO PAST MARTIN!!! -MARTIN
            //TBInput.Text = ""; //Resetter listen hver gang der slettes eller oprettes
            //Derfor skal der ikke være nogen søgning efterfølgende -Martin
            LWSearchResults.Items.Clear(); //Sikrer at Listen bliver clearet hver gang den skal opdateres (Maybe) -Martin
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
                bool ok = ViewModel.ValiderInput(input, kriterie); //Valider input, da man kan søge på integer og double
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
            var edit = new BoligDetails(ViewModel, this);
            if (!panelContent.Controls.Contains(edit))
                panelContent.Controls.Add(edit);
            ViewModel.Edit(edit,Valgt);
            //Details.InitializeEditMode(Valgt);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var opret = new BoligDetails(ViewModel,this);
            if (!panelContent.Controls.Contains(opret))
                panelContent.Controls.Add(opret);

            opret.InitializeCreateMode();
        }

        public void SælgBoligToFront(Bolig b, BoligDetails instans)
        {
            var S = new SælgBolig(b, instans, ViewModel);
            if (!panelContent.Controls.Contains(S))
            panelContent.Controls.Add(S);
            S.BringToFront();


        }

        private void btnUdskrivAlleBoligerIkkeSolgt_Click(object sender, EventArgs e)
        {
            bool b = false;
            var SøgForm = new BoligSøgning(ViewModel,b);
            if (!panelContent.Controls.Contains(SøgForm))
                panelContent.Controls.Add(SøgForm);
            SøgForm.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = true;
            var SøgForm = new BoligSøgning(ViewModel,b);
            if (!panelContent.Controls.Contains(SøgForm))
                panelContent.Controls.Add(SøgForm);
            SøgForm.BringToFront();

        }

        private void btnDatoSøgning_Click(object sender, EventArgs e)
        {
            var SøgDato = new DatoSøgning(ViewModel.boliger);
            if (!panelContent.Controls.Contains(SøgDato))
                panelContent.Controls.Add(SøgDato);
            SøgDato.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var UdskrivKontrakt = new UdskrivKontraktView();
                if (!panelContent.Controls.Contains(UdskrivKontrakt))
                panelContent.Controls.Add(UdskrivKontrakt);
            UdskrivKontrakt.BringToFront();
        }

        private void CBKriterie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TBInput.Text.Length > 0)
            {
                FyldListView(ViewModel.SearchFor(CBKriterie.SelectedItem.ToString(), TBInput.Text.ToLower()));
            }
            else
            {
                FyldListView(ViewModel.FillListView());
            }
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
