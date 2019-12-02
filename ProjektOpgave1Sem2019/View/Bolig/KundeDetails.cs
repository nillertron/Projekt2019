using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektOpgave1Sem2019.Model;

namespace ProjektOpgave1Sem2019.View.Bolig
{                                                       //karl
    partial class KundeDetails : UserControl
    {
        private KundeViewModel ViewModel;
        private KundeForm Parent;
        public KundeDetails(KundeViewModel ViewModel, KundeForm Parent)
        {
            InitializeComponent();

            this.ViewModel = ViewModel;
            this.Parent = Parent;




        }

        public void InitializeCreateMode()
        {
            //generelt for create mode
            Control[] controlsToDisplay = { LblFornavn, TbFornavn, LblEfternavn, TbEfternavn }; 
            ShowThese(controlsToDisplay);




            if (ViewModel.IsSælgerMode)
            {
                LblTitel.Text = "Opret Sælger";
                BtnAction.Text = "Opret Sælger";
            }
            else // er køber
            {
                LblTitel.Text = "Opret Køber";
                BtnAction.Text = "Opret Køber"; 
            }
        }

        private void ShowThese(Control[] controls)
        {
            foreach(Control c in controls)
            {
                c.Show();
                c.BringToFront();
            }
        }

        private void LockThese(Control[] controls)
        {
            foreach(Control c in controls)
            {
                c.Enabled = false;
            }
        }
        public void InitializeEditMode()
        {
            //generelt for edit mode
            Control[] controlsToDisplay = { LblFornavn, TbFornavn, LblEfternavn, TbEfternavn, LblId };
            ShowThese(controlsToDisplay);
        

            
            LblId.Text = ViewModel.SelectedKunde.Id.ToString();
            Person kunde = ViewModel.SelectedKunde;

            TbFornavn.Text = kunde.Navn;
            TbEfternavn.Text = kunde.Efternavn;
            TbAdresse.Text = kunde.Addresse;
            TbPostNr.Text = kunde.PostNr.ToString();
            TbTlf.Text = kunde.TelefonNr;
            TbKontoNr.Text = kunde.KontoNr;


            

            
            if (ViewModel.IsSælgerMode)
            {
                LblTitel.Text = "Opdater Sælger";
                BtnAction.Text = "Opdater Sælger"; 
            }
            else // er køber
            {
                LblTitel.Text = "Opdater Køber";
                BtnAction.Text = "Opdater Køber";
            }
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            string buttonFunction = BtnAction.Text;


            string fornavn = TbFornavn.Text;
            string efternavn = TbEfternavn.Text;
            string adresse = TbKontoNr.Text;
            string tlf = TbTlf.Text;
            string kontoNr = TbKontoNr.Text;
            int postNr = Convert.ToInt32(TbPostNr.Text);


            switch (buttonFunction)
            {
                case "Opret Sælger":
                    Sælger sælgerToCreate = new Sælger(fornavn, efternavn, tlf, kontoNr, postNr, adresse);
                    if (ViewModel.OpretSælger(sælgerToCreate))
                        MessageBox.Show("Sælger oprettet!");
                    else
                        MessageBox.Show("Der skete en fejl, sælger blev ikke oprettet");
                        break;

                case "Opdater Sælger":

                    Sælger sælgerToUpdate = new Sælger(ViewModel.SelectedKunde.Id, fornavn, efternavn, tlf, kontoNr, postNr, adresse);
                    if (ViewModel.OpdaterSælger(sælgerToUpdate))
                        MessageBox.Show("Sælger opdateret!");
                    else
                        MessageBox.Show("Der skete en fejl, sælger blev ikke opdateret");
                    break;

                    




                case "Opret Køber":
                    Køber køberToCreate = new Køber(fornavn, efternavn, tlf, kontoNr, postNr, adresse);
                    if (ViewModel.OpretKøber(køberToCreate))
                        MessageBox.Show("Køber oprettet!");
                    else
                        MessageBox.Show("Der skete en fejl, køber blev ikke oprettet");
                    break;


                case "Opdater Køber":
                    Køber køberToUpdate = new Køber(ViewModel.SelectedKunde.Id, fornavn, efternavn, tlf, kontoNr, postNr, adresse);
                    if (ViewModel.OpdaterKøber(køberToUpdate))
                        MessageBox.Show("Køber opdateret!");
                    else
                        MessageBox.Show("Der skete en fejl, køber blev ikke opdateret");
                    break;

            }
        }
    }
}
