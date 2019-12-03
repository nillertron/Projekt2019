using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektOpgave1Sem2019.Model;
using ProjektOpgave1Sem2019.View.Bolig;

namespace ProjektOpgave1Sem2019
{
    //MArtin
    public partial class KundeForm : UserControl
    {
        KundeViewModel ViewModel;
        KundeDetails Details;
        public KundeForm()
        {
            InitializeComponent();
            ViewModel = new KundeViewModel();
            //Details = new KundeDetails(ViewModel, this);
        }
        private void KundeForm_Load(object sender, EventArgs e)
        {
            AddSearchCategories();
            CBKriterie.SelectedIndex = 0;
            FillListView(ViewModel.GetAll());
            
        }

        private void FillListView(List<Person> personList) //Fylder listview med Person typer fra en list
        {
            LWSearchResults.Items.Clear();
            foreach (Person p in personList) //Person er både Køber og Sælger (Og EMægler, men ikke relevant her)
            {
                var item = LWSearchResults.Items.Add(p.Navn);
                item.SubItems.Add(p.Efternavn);
                item.Name = p.Id.ToString();
            }
        }

        private void AddSearchCategories() //Tilføjer søgekategorier. Flere kan tilføjes her.
        {                                   //nye tilføjede Skal også tilføjes i ViewModel DisplaySearchResults()
            CBKriterie.Items.Add("Fornavn");
            CBKriterie.Items.Add("Efternavn");
            CBKriterie.Items.Add("Adresse");
            CBKriterie.Items.Add("Tlf");
        }

        private void BtnMode_Click(object sender, EventArgs e)
        {
            //if(!Controls.Contains(Details)) //Add details hvis ikke added
            //{
            //    Controls.Add(Details); OVERFLØDIG PROBABLY NU, vi INSTANTIERER HVER GANG ISTEDET
            //}
            //Details.ClearData(); //Clear textboxes
            if(ViewModel.IsSælgerMode)//Check om vi arbejder med sælger eller køber
            {
                BtnMode.Text = "Skift til sælger Mode";
                BtnOpret.Text = "Opret Køber";
                LabelMode.Text = "Køber mode";
                ViewModel.IsSælgerMode = false;
            }
            else
            {
                BtnMode.Text = "Skift til køber Mode";
                BtnOpret.Text = "Opret Sælger";
                LabelMode.Text = "Sælger mode";
                ViewModel.IsSælgerMode = true;
            }
            FillListView(ViewModel.GetAll()); //Fylder listview med kunder, ViewModel ved om den skal give sælger eller køber
        }

        private void TBInput_TextChanged(object sender, EventArgs e)
        {
            string kriterie = CBKriterie.SelectedItem.ToString(); //Der er strings i CB
            string input = TBInput.Text;
            //input bliver lavet lowercase her så søgning er case insensitive
            FillListView(ViewModel.DisplaySearchResults(kriterie, input.ToLower()));
        }


        //karl start (Jeg har bare kopieret hele body'en fra metoden ovenfor, så jeg kan tilgå den fra view model)
        public void UpdateListViewWithCurrentSearchTerms()
        {
            string kriterie = CBKriterie.SelectedItem.ToString(); //Der er strings i CB
            string input = TBInput.Text;
            //input bliver lavet lowercase her så søgning er case insensitive
            FillListView(ViewModel.DisplaySearchResults(kriterie, input.ToLower()));
        }
        //karl stop

        private void LWSearchResults_DoubleClick(object sender, EventArgs e)
        {
            //Åben details her
            ViewModel.SetSelectedPerson(LWSearchResults.FocusedItem.Name);
            
            Details = new KundeDetails(ViewModel, this);
            if (!Controls.Contains(Details)) //Add details hvis ikke added
            {
                Controls.Add(Details);
            }
            Details.BringToFront();
            Details.InitializeEditMode();
        }

        private void BtnOpret_Click(object sender, EventArgs e)
        {


            Details = new KundeDetails(ViewModel, this);
            if (!Controls.Contains(Details)) //Add details hvis ikke added
            {
                Controls.Add(Details);
            }
            Details.BringToFront();
            Details.InitializeCreateMode();
        }
    }
}
