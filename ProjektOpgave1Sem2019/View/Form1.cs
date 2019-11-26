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
            EjendomsmæglereKnap.MouseEnter += (o, e) => EjendomsmæglereKnap.BackColor = Color.FromArgb(185, 55, 55);
            EjendomsmæglereKnap.MouseLeave += (o, e) => EjendomsmæglereKnap.BackColor = Color.Transparent;
            button4.MouseEnter += (o, e) => button4.BackColor = Color.FromArgb(185, 55, 55);
            button4.MouseLeave += (o, e) => button4.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            EjendomsmæglereKnap.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            #endregion
            //Test indstilling af knapper

            LoadFields();

            ShowEmptyControl();


        }
        private void ShowEmptyControl()
        {
           // Background.BringToFront();

            
        }
        private void LoadFields()
        {
           

        }
        private void SetBinding()
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void EjendomsmæglereKnap_Click(object sender, EventArgs e)
        {
            EjendomsmæglereForm eForm = new EjendomsmæglereForm(this);

            if (!this.Controls.Contains(eForm))
                this.Controls.Add(eForm);
            
        }
    }
}
