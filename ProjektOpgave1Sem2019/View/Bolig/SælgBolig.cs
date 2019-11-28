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
using ProjektOpgave1Sem2019.Model;

namespace ProjektOpgave1Sem2019.View
{
    //Nichlas
    public partial class SælgBolig : UserControl
    {
        Bolig ValgtBolig;
        SælgBoligViewModel ViewModel;
        public SælgBolig(Bolig b)
        {
            InitializeComponent();
            ViewModel = new SælgBoligViewModel();
            ValgtBolig = b;
            Start();

        }

        private void Start()
        {
            LblAdresse.Text = ValgtBolig.Adresse;
            tbSælger.ReadOnly = true;
            tbSælger.Text = ValgtBolig.SælgerID.ToString();
            cbKøber.DataSource = ViewModel.KøberListe;
            cbKøber.DisplayMember = "Navn";
            tbSalgsPris.Text = ValgtBolig.Pris.ToString();
            tbSalgsPris.ReadOnly = true;

            
        }



        private void SælgBolig_Load(object sender, EventArgs e)
        {
            var køber = cbKøber.SelectedItem as Køber;
            try
            {
                var solgtBolig = (SolgtBolig)ValgtBolig;
                solgtBolig.SælgBolig(køber.Id, Convert.ToDouble(tbKøbsPris.Text), dtpKøbsDato.Value);

            }
            catch(FormatException ee)
            {
                MessageBox.Show(ee.Message);
            }
            
        }
    }
}
