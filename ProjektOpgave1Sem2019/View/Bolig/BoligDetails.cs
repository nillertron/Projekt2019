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
using ProjektOpgave1Sem2019.View;

namespace ProjektOpgave1Sem2019
{
    //Martin
    public partial class BoligDetails : UserControl
    {
        BoligViewModel viewModel;
        bool editMode;
        Bolig selectedBolig;
        Ejendomsmægler valgtEMægl = null;
        bool isEditMode;
        public BoligDetails(BoligViewModel model)
        {
            InitializeComponent();
            editMode = false;

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
            BTNSolgt.Hide();

            TBAdresse.ReadOnly = false;
            TBAdresse.Text = "";

            TBAreal.ReadOnly = false;
            TBAreal.Text = "";

            TBPris.Text = "";

            TBPostNr.Text = "";

            LabelID.Text = "";

            DTPOpretDato.Value = DateTime.Now; //på nuværende tidspunkt kan kun oprettes dags dato
            
            BtnVælgE.Enabled = true;
            LabelMode.Text = "CREATE MODE";
        }

        public void InitializeEditMode(Bolig b, Ejendomsmægler e)
        {
            editMode = true;
            selectedBolig = b;
            Show();
            TBPostNr.Show();
            TBAdresse.Text = b.Adresse;
            TBAdresse.ReadOnly = true; //Adresse ændres ikke medmindre vi henter en kæmpe lastbil.

            TBAreal.Text = b.Kvm.ToString();
            TBAreal.BackColor = Color.Gray;
            TBAreal.ReadOnly = true; //Areal ændres ikke

            TBPris.Text = b.Pris.ToString();
            TBPris.BackColor = Color.White;

            CBPostNr.Hide(); //PostNr skal ikke ændres ever
            TBPostNr.Text = b.PostNr.ToString();
            TBPostNr.ReadOnly = true;

            LabelID.Text = b.ID.ToString();

            BtnVælgE.Enabled = false;

            DTPOpretDato.Value = b.OprettelsesDato;
            DTPOpretDato.Enabled = false; //Oprettelses datoen er fast.

            LabelMode.Text = "EDIT MODE";
            //tjekker om boligen er solgt, for så skal denne knap ikke vises!
            var erSolgt = viewModel.TjekBoligSolgt(selectedBolig);
            if (erSolgt)
                BTNSolgt.Hide();
            else
                BTNSolgt.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                viewModel.SaveEdit(selectedBolig, Convert.ToDouble(TBPris.Text)); //Forsøger at holde logik og datamanipulation i ViewModel
            }
            else
            {
                //Sælgerid hentes fra en liste sælgere, implementeres senere
                viewModel.SaveNewBolig(TBAdresse.Text, Convert.ToDouble(TBPris.Text),
                                            //EjendomsmæglerID hentes fra en liste af ejendomsmæglere, implementeres senere
                                            Convert.ToInt32(TBAreal.Text), DTPOpretDato.Value,
                                            ((PostNumre)CBPostNr.SelectedItem).PostNummer);

                //BoligTabelDB.Create(newBolig);
                this.Hide();
            }
            //MessageBox.Show("Boop, pranked, Im out");
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
        private void BtnVælgE_Click(object sender, EventArgs e)
        {
            Form VælgEMægler = new VælgEMæglerForm(this.viewModel);
            VælgEMægler.ShowDialog(); //Åbner ny form til valg af Ejendomsmægler
            BtnVælgE.Enabled = false;
        }

        private void BoligDetails_Load(object sender, EventArgs e)
        {

        }
        /// Nichlas leger her

        private void CBPostNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = CBPostNr.SelectedItem as PostNumre;
            LBLPris.Text = item.PrisPrm2.ToString() + " ,-KR"; 

        }


        private void BTNSolgt_Click(object sender, EventArgs e)
        {
            viewModel.SælgBolig(selectedBolig, this);

        }


    }        /// 
}
