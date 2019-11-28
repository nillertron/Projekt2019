using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektOpgave1Sem2019;
using ProjektOpgave1Sem2019.Model;

namespace ProjektOpgave1Sem2019
{
    public partial class BoligDetails : UserControl
    {
        private void BoligDetails_Load(object sender, EventArgs e)
        {

        }
        public BoligDetails(Bolig b)
        {
            InitializeComponent();


        }
    }
}
