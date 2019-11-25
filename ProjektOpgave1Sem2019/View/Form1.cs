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
    public partial class Form1 : Form
    {
        Form1ViewModel ViewModel;
        public Form1()
        {
            InitializeComponent();
            ViewModel = new Form1ViewModel(this);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewModel.fyldliste();
        }
    }
}
