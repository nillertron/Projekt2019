using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOpgave1Sem2019.View
{
    public partial class ValgtEjendomsMæglerDetails : UserControl
    {
        private Ejendomsmægler ValgtEjendomsmægler;
        public ValgtEjendomsMæglerDetails(Ejendomsmægler E)
        {
            InitializeComponent();
            ValgtEjendomsmægler = E;
        }

        private void ValgtEjendomsMæglerDetails_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
