﻿using System;
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
            UpdateListView(ViewModel.DisplaySearchResults());

        }

        private void TBInput_TextChanged(object sender, EventArgs e)
        {

            UpdateListView(ViewModel.DisplaySearchResults(CBKriterie.Text, TBInput.Text));
            

            
        }

        public void UpdateListView(List<Ejendomsmægler> ejendomsmæglere)
        {
            SearchResults.Items.Clear();
            foreach(Ejendomsmægler e in ejendomsmæglere)
            {
                ListViewItem item = new ListViewItem(e.Navn);
                item.SubItems.Add(e.Efternavn);

                item.Name = e.Id.ToString();



                SearchResults.Items.Add(item);
            }
        }

        private void LWSearchResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var details = new ValgtEjendomsMæglerDetails(ViewModel, this);
            if (!panelContent.Controls.Contains(details))
                panelContent.Controls.Add(details);
            details.BringToFront();
            var ejendomsmægler = ViewModel.FindEjendomsmægler();

            details.EditMode(ejendomsmægler);
        }

        private void EjendomsmæglereForm_Load(object sender, EventArgs e)
        {

        }

        private void LWSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var details = new ValgtEjendomsMæglerDetails(ViewModel,this);
            if (!panelContent.Controls.Contains(details))
                panelContent.Controls.Add(details);
            details.BringToFront();
            details.CreateMode();
        }

        private void CBKriterie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

