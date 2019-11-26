using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOpgave1Sem2019
{
    public partial class EjendomsmæglereForm : UserControl
    {
        Form1 ParentForm;
        public EjendomsmæglereForm(Form1 ParentForm)
        {
            this.ParentForm = ParentForm;
            InitializeComponent();
            
        }
    }
}
