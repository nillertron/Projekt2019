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
namespace ProjektOpgave1Sem2019.View
{
    public partial class BoligForm : UserControl
    {
        BoligViewModel ViewModel;
        public BoligForm()
        {
            InitializeComponent();
            ViewModel = new BoligViewModel();
        }

        private void BoligView_Load(object sender, EventArgs e)
        {

        }

        private void TBInput_TextChanged(object sender, EventArgs e)
        {
            var input = TBInput.Text;
            var kriterie = CBKriterie.SelectedItem.ToString();
            bool ok = ViewModel.Edit(input, kriterie);
            if (!ok)
                LWSearchResults.Items.Add("Fejl i søgnings input");


        }
    }
}
