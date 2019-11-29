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
    public partial class DatoSøgning : UserControl
    {//Nichlas
        DatoSøgningViewModel ViewModel;
        public DatoSøgning(List<Bolig> liste)
        {
            InitializeComponent();
            ViewModel = new DatoSøgningViewModel(liste);
        }

        private void DatoSøgning_Load(object sender, EventArgs e)
        {

        }
    }
}
