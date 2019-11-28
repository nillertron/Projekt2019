using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Nichlas
namespace ProjektOpgave1Sem2019
{
    public partial class BoligForm : UserControl
    {
        BoligViewModel ViewModel;
        private List<Bolig> BoligListe = new List<Bolig>();
        public BoligForm()
        {
            InitializeComponent();
            ViewModel = new BoligViewModel(this);
            var kriterier = new string[] { "Areal større end", "Areal mindre end", "Pris større end", "Pris mindre end" };
            CBKriterie.Items.AddRange(kriterier);
            BoligListe = ViewModel.FillListView();


        }

        private void FyldListView()
        {
            BoligListe.ForEach(o => )
        }

        private void BoligView_Load(object sender, EventArgs e)
        {

        }

        private void TBInput_TextChanged(object sender, EventArgs e)
        {
            var input = TBInput.Text;
            var kriterie = CBKriterie.SelectedItem.ToString();
            bool ok = ViewModel.ValiderInput(input, kriterie);
            if (!ok)
                LWSearchResults.Items.Add("Fejl i søgnings input");


        }
    }
}
