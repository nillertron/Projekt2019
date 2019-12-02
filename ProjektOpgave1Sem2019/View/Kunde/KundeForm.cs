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
        //bool isSælgerMode = false; //Test bool, fjernes senere når ViewModel har
        //List<Person> people = new List<Person>(); //Test list fjernes senere
        //List<Person> sælgere = new List<Person>(); //test list, fjernes senere
        public KundeForm()
        {
            InitializeComponent();
            ViewModel = new KundeViewModel();
        }
        private void KundeForm_Load(object sender, EventArgs e)
        {
            AddSearchCategories();
            CBKriterie.SelectedIndex = 0;
            //Test liste, fjernes senere
            //people.Add(new Køber(1, "Martin", "Sørensen", "20304059", "in22", 6100, "HejVej"));
            //people.Add(new Køber(2, "Karl", "Mogensen", "33445566", "te22", 7500, "Okovej"));
            ////test list, remove later
            //sælgere.Add(new Sælger(1, "HAns", "Karlsen", "22334112", "ijdf", 4400, "Sælgervej"));
            //sælgere.Add(new Sælger(2, "Trine", "Gertsen", "99334411", "idsjf2", 4569, "Googlevej"));
            FillListView(ViewModel.GetAll());
        }

        private void FillListView(List<Person> personList) //Fylder listview med Person typer fra en list
        {
            LWSearchResults.Items.Clear();
            foreach (Person p in personList)
            {
                var item = LWSearchResults.Items.Add(p.Navn);
                item.SubItems.Add(p.Efternavn);
                item.Name = p.Id.ToString();
            }
        }

        private void AddSearchCategories() //Tilføjer søgekategorier. Flere kan tilføjes her.
        {                                   //Skal også tilføjes i ViewModel DisplaySearchResults()
            CBKriterie.Items.Add("Fornavn");
            CBKriterie.Items.Add("Efternavn");
            CBKriterie.Items.Add("Adresse");
            CBKriterie.Items.Add("Tlf");
        }

        private void BtnMode_Click(object sender, EventArgs e)
        {
            if(ViewModel.isSælgerMode) //ViewModel udkommenteres når ViewModel er implementeret
            {
                BtnMode.Text = "Skift til sælger Mode";
                LabelMode.Text = "Køber mode";
                ViewModel.isSælgerMode = false;
                //FillListView(people); //test, skal fjernes
            }
            else
            {
                BtnMode.Text = "Skift til køber Mode";
                LabelMode.Text = "Sælger mode";
                ViewModel.isSælgerMode = true;
                //FillListView(sælgere); //Test, skal fjernes senere
            }
            FillListView(ViewModel.GetAll()); //Fylder listview med kunder, ViewModel ved om den skal give sælger eller køber
        }

        private void TBInput_TextChanged(object sender, EventArgs e)
        {
            string kriterie = CBKriterie.SelectedItem.ToString();
            string input = TBInput.Text;
            FillListView(ViewModel.DisplaySearchResults(kriterie, input.ToLower()));
        }
    }
}
