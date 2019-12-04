﻿using System;
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

            this.Location = new Point(370, 80); //Ændrer location, midlertidig for at jeg ikke fucker design ved at åbne designer -MArtin 

            LoadItems(); 
            
        }
        private void LoadItems()
        {
            foreach (PostNumre postNr in ViewModel.postNumre)
                CbPostNr.Items.Add(postNr.PostNummer);
        }



        public void InitializeCreateMode()
        {
            //generelt for create mode
            Control[] controlsToDisplay = { LblFornavn, TbFornavn, LblEfternavn, TbEfternavn }; 
            ShowThese(controlsToDisplay);


            ClearData(); //-Martin, må gerne laves om hvis du vil

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

        //Martin, gerne ændres hvis du vil, kaldes også fra KundeForm når mode skiftes
        public void ClearData()
        {
            TbFornavn.Text = "";
            TbEfternavn.Text = "";
            TbAdresse.Text = "";
            CbPostNr.Text = "";
            TbTlf.Text = "";
            TbKontoNr.Text = "";
            
        }
        //Martin Slut

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
        

            
            LblId.Text = "ID: " + ViewModel.SelectedKunde.Id.ToString();
            Person kunde = ViewModel.SelectedKunde;

            TbFornavn.Text = kunde.Navn;
            TbEfternavn.Text = kunde.Efternavn;
            TbAdresse.Text = kunde.Addresse;
            CbPostNr.Text = kunde.PostNr.ToString();
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
            string adresse = TbAdresse.Text;
            string tlf = TbTlf.Text;
            string kontoNr = TbKontoNr.Text;
            int postNr = Convert.ToInt32(CbPostNr.Text);

            bool success = false;
            switch (buttonFunction)
            {
                
                case "Opret Sælger":
                    try
                    {
                    Sælger sælgerToCreate = new Sælger(fornavn, efternavn, tlf, kontoNr, postNr, adresse);
                        success = ViewModel.OpretSælger(sælgerToCreate);
                    }
                    catch
                    {
                        MessageBox.Show("Der skete en fejl, sælger blev ikke oprettet");
                    }

                    if (success)
                    {
                        MessageBox.Show("Sælger oprettet!");
                        ClearData();
                    }
                       
                        break;

                case "Opdater Sælger":

                    try
                    {
                    Sælger sælgerToUpdate = new Sælger(ViewModel.SelectedKunde.Id, fornavn, efternavn, tlf, kontoNr, postNr, adresse);
                        success = ViewModel.OpdaterSælger(sælgerToUpdate);
                    }
                    catch
                    {
                        MessageBox.Show("Der skete en fejl, sælger blev ikke opdateret");
                    }

                    if(success)
                        MessageBox.Show("Sælger opdateret!");
                    
                       
                    break;

                    




                case "Opret Køber":
                    try
                    {
                    Køber køberToCreate = new Køber(fornavn, efternavn, tlf, kontoNr, postNr, adresse);
                        success = ViewModel.OpretKøber(køberToCreate);
                    }
                    catch
                    {
                        MessageBox.Show("Der skete en fejl, køber blev ikke oprettet");
                    }
                    if (success)
                    {
                        MessageBox.Show("Køber oprettet!");
                        ClearData();
                    }
                    
                        
                    break;


                case "Opdater Køber":
                    try
                    {
                    Køber køberToUpdate = new Køber(ViewModel.SelectedKunde.Id, fornavn, efternavn, tlf, kontoNr, postNr, adresse);
                        success = ViewModel.OpdaterKøber(køberToUpdate);
                    }
                    catch
                    {
                        MessageBox.Show("Der skete en fejl, køber blev ikke opdateret");
                    }

                    if(success)
                        MessageBox.Show("Køber opdateret!");
                    
                        
                    break;

            }

            Parent.UpdateListViewWithCurrentSearchTerms();
            

        }
    }
}
