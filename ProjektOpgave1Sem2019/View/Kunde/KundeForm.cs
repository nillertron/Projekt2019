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

namespace ProjektOpgave1Sem2019
{
    //MArtin
    public partial class KundeForm : UserControl
    {
        KundeViewModel ViewModel;
        public KundeForm()
        {
            InitializeComponent();
            ViewModel = new KundeViewModel();
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
            if(ViewModel.IsSælgerMode)//Check om vi arbejder med sælger eller køber
            {
                BtnMode.Text = "Skift til sælger Mode";
                LabelMode.Text = "Køber mode";
                ViewModel.IsSælgerMode = false;
            }
            else
            {
                BtnMode.Text = "Skift til køber Mode";
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
    }
}
