using ProjektOpgave1Sem2019.Model;
using ProjektOpgave1Sem2019;
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
    //Nichlas
    public partial class Form1 : Form
    {
        Form1ViewModel ViewModel;
        public Form1()
        {
            InitializeComponent();

            //Konfiguere UI ting her, knapper mouse over og fjerner borders
            #region UI stuff
            ViewModel = new Form1ViewModel(this);
            button1.MouseEnter += (o, e) => button1.BackColor = Color.FromArgb(185,55,55);
            button1.MouseLeave += (o, e) => button1.BackColor = Color.Transparent;
            button2.MouseEnter += (o, e) => button2.BackColor = Color.FromArgb(185, 55, 55);
            button2.MouseLeave += (o, e) => button2.BackColor = Color.Transparent;
            BTNEjendomsmæglere.MouseEnter += (o, e) => BTNEjendomsmæglere.BackColor = Color.FromArgb(185, 55, 55);
            BTNEjendomsmæglere.MouseLeave += (o, e) => BTNEjendomsmæglere.BackColor = Color.Transparent;
            button4.MouseEnter += (o, e) => button4.BackColor = Color.FromArgb(185, 55, 55);
            button4.MouseLeave += (o, e) => button4.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            BTNEjendomsmæglere.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            #endregion
            



        }
     
     

        private void Form1_Load(object sender, EventArgs e)
        { 

            
        }

        private void BTNEjendomsmæglere_Click(object sender, EventArgs e)
        {
            EjendomsmæglereForm eForm = new EjendomsmæglereForm();
            if (!this.Controls.Contains(eForm))
                this.Controls.Add(eForm);
            eForm.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void valgtEjendomsMæglerDetails1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                var bolig = new BoligForm();
                if (!this.Controls.Contains(bolig))
            {
                Controls.Add(bolig);
                bolig.Anchor = AnchorStyles.Top + Left;
                bolig.BringToFront();
            }

        }
    }
}
