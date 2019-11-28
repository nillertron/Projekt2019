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
    //Martin
    public partial class BoligDetails : UserControl
    {
        BoligViewModel viewModel;
        bool editMode;
        Bolig selectedBolig;
        bool isEditMode;
        public BoligDetails(BoligViewModel model)
        {
            editMode = false;
            InitializeComponent();

            viewModel = model;
            CBPostNr.DataSource = model.postNumre;
            CBPostNr.DisplayMember = "PostNummer";

            Hide();
        }
        public void InitializeCreateMode()
        {
            editMode = false;
            Show();
            CBPostNr.Show(); //Hides unnecessary controls
            TBPostNr.Hide();
            LabelID.Hide();

            TBAdresse.ReadOnly = false;
            TBAdresse.Text = "";

            TBAreal.ReadOnly = false;
            TBAreal.Text = "";

            TBPris.Text = "";

            TBPostNr.Text = "";

            LabelID.Text = "";

            DTPOpretDato.Value = DateTime.Now;
            

            LabelMode.Text = "CREATE MODE";
        }

        public void InitializeEditMode(Bolig b)
        {
            editMode = true;
            Show();
            TBAdresse.Text = b.Adresse;
            TBAdresse.ReadOnly = true; //Adresse ændres ikke medmindre vi henter en kæmpe lastbil.

            TBAreal.Text = b.Kvm.ToString();
            TBAreal.ReadOnly = true; //Areal ændres ikke

            TBPris.Text = b.Pris.ToString();

            CBPostNr.Hide(); //PostNr skal ikke ændres ever
            TBPostNr.Text = b.PostNr.ToString();
            TBPostNr.ReadOnly = true;

            LabelID.Text = b.ID.ToString();

            DTPOpretDato.Value = b.OprettelsesDato;
            DTPOpretDato.Enabled = false; //Oprettelses datoen er fast.

            LabelMode.Text = "EDIT MODE";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //if (isEditMode)
            //{
            //    if (double.TryParse(TBPris.Text, out double d)) //Valider at der står en valid double i feltet
            //    {
            //        if (d > 0) //Pris er ikke negativ
            //        {
            //            selectedBolig.UpdatePris(d); //Opdaterer boligs pris med den nye double (object er reference, 
            //            BoligTabelDB.Update(selectedBolig); //Dermed ændres den også her)
            //            this.Hide();
            //        }
            //    }
            //}
            //else
            //{
            //    //Sælgerid hentes fra en liste sælgere, implementeres senere
            //    Bolig newBolig = new Bolig(TBAdresse.Text, Convert.ToDouble(TBPris.Text), Convert.ToInt32(TBSælgerID.Text),
            //                                //EjendomsmæglerID hentes fra en liste af ejendomsmæglere, implementeres senere
            //                                Convert.ToInt32(TBAreal.Text), DTPOpretDato.Value, Convert.ToInt32(TBEjendomsmæglerID),
            //                                (int)CBPostNr.SelectedItem);

            //    BoligTabelDB.Create(newBolig);
            //    this.Hide();
            //}
            MessageBox.Show("Boop, pranked, Im out");
            Hide();
        }

        //public bool InputsAreValid()
        //{
        //    bool returnBool = false;

        //    if(int.TryParse(TBAreal.Text, out int i))
        //    {
        //        returnBool = true;
        //    }
        //    else
        //    {
        //        returnBool = false;
        //    }
        //    if(double.TryParse(TBPris.Text, out double d))
        //    {
        //        returnBool = true;
        //    }
        //    else
        //    {
        //        returnBool = false;
        //    }
        //    return returnBool;
        //}

        private void TBPris_TextChanged(object sender, EventArgs e)
        {
            if(!InputValidation.ValiderDouble(TBPris.Text))
            {
                TBPris.BackColor = Color.Red; //Gør textbox baggrund rød og
                BtnSave.Enabled = false; //Slå save knap fra når invalid input indtastes
            }
            else
            {
                TBPris.BackColor = Color.White;
                if (TBAreal.BackColor != Color.Red) //Check at den anden inputvalidering ikke også er fejlet tidligere
                {
                    BtnSave.Enabled = true;
                }
            }
        }

        private void TBAreal_TextChanged(object sender, EventArgs e)
        {
            if (!editMode)
            {
                if (!InputValidation.ValiderInt(TBAreal.Text))
                {
                    TBAreal.BackColor = Color.Red;//Gør textbox baggrund rød og
                    BtnSave.Enabled = false;//Slå save knap fra når invalid input indtastes
                }
                else
                {
                    TBAreal.BackColor = Color.White;
                    if (TBPris.BackColor != Color.Red) //Check at anden inputværdi ikke har fejlet validering tidligere
                    {
                        BtnSave.Enabled = true;
                    }
                }
            }
        }
    }
}
