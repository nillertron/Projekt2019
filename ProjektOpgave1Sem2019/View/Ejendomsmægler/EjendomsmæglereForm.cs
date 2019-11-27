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
using ProjektOpgave1Sem2019;

namespace ProjektOpgave1Sem2019
{
    public partial class EjendomsmæglereForm : UserControl
    {
        public ValgtEjendomsMæglerDetails uc { get; set; }
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
            this.SearchResults = LWSearchResults;
            this.ViewModel = new EjendomsmæglerViewModel(this);
            this.Kriterie = CBKriterie;
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

        private void EjendomsmæglereForm_Load(object sender, EventArgs e)
        {

        }

        private void LWSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewModel.NyEjendomsmægler();
        }
    }
}

