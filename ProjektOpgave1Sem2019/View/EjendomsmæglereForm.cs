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
    public partial class EjendomsmæglereForm : UserControl
    {
        EjendomsmæglerViewModel ViewModel;
        public ComboBox Kriterie;
        public ListView SearchResults;
       public TextBox  Input;
        public EjendomsmæglereForm()
        {
            
            InitializeComponent();
            
            LoadFields();
        }
        private void LoadFields()
        {
            this.ViewModel = new EjendomsmæglerViewModel(this);
            this.Kriterie = CBKriterie;
            this.SearchResults = LWSearchResults;
            this.Input = TBInput;
            

        }

        private void TBInput_TextChanged(object sender, EventArgs e)
        {

            ViewModel.DisplaySearchResults();

            
        }
        private void wr(string s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }

        private void LWSearchResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ViewModel.ShowEjendomsmægler();
        }
    }
}

