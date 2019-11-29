using ProjektOpgave1Sem2019.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOpgave1Sem2019
{
    public partial class VælgEMæglerForm : Form
    {

        BoligViewModel viewModel;
        List<Ejendomsmægler> eList;
        public VælgEMæglerForm(BoligViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
        }

        private void VælgEMæglerForm_Load(object sender, EventArgs e)
        {
            BtnVælg.Enabled = false;
            eList = viewModel.GetAllEMægler();

            foreach(Ejendomsmægler emægl in eList)
            {
                LBEMæglere.Items.Add(emægl);
            }
        }

        private void LBEMæglere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LBEMæglere.SelectedItem != null)
            {
                BtnVælg.Enabled = true;
            }
            else
            {
                BtnVælg.Enabled = false;
            }
        }

        private void BtnVælg_Click(object sender, EventArgs e)
        {
            viewModel.SetValgtEMægler((Ejendomsmægler)LBEMæglere.SelectedItem);
            this.Close();
        }
    }
}
