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
    //Martin
    public partial class VælgSælgerForm : Form
    {
        List<Sælger> sælgerList = new List<Sælger>();
        BoligViewModel ViewModel;
        public VælgSælgerForm(BoligViewModel model)
        {
            InitializeComponent();
            ViewModel = model;
        }

        private void BtnVælg_Click(object sender, EventArgs e)
        {
            VælgSælgerOgLuk();
        }

        private void VælgSælgerOgLuk()
        {
            ViewModel.ValgtSælger = (Sælger)LBSælgere.SelectedItem;

            Close();
        }

        private void LBSælgere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LBSælgere.SelectedIndex != -1)
            {
                BtnVælg.Enabled = true;
            }
            else
            {
                BtnVælg.Enabled = false;
            }
        }

        private void VælgSælgerForm_Load(object sender, EventArgs e)
        {
            BtnVælg.Enabled = false;
            sælgerList = ViewModel.GetAllSælger();

            foreach(Sælger s in sælgerList)
            {
                LBSælgere.Items.Add(s);
            }
        }

        private void LBSælgere_DoubleClick(object sender, EventArgs e)
        {
            VælgSælgerOgLuk();
        }
    }
}
