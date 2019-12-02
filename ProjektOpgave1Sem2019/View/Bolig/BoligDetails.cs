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
using ProjektOpgave1Sem2019.View.Bolig;

namespace ProjektOpgave1Sem2019
{
    //Martin
    public partial class BoligDetails : UserControl
    {
        BoligViewModel viewModel;
        bool editMode;
        Bolig selectedBolig;
        BoligForm parent;
        Ejendomsmægler valgtEMægl = null;
        bool isEditMode;
        public BoligDetails(BoligViewModel model, BoligForm parent)
        {
            InitializeComponent();
            editMode = false;

            this.parent = parent; //Bruges til opdatering af listen

            viewModel = model;
            CBPostNr.DataSource = model.postNumre;
            CBPostNr.DisplayMember = "PostNummer";

            TBEMæglerNavn.ReadOnly = true;

            Hide();
        }
        public void InitializeCreateMode()
        {
            viewModel.SetSelEMæglerNull(); //Sætter Valgt Emægler til null, bruges til evaluering senere
            editMode = false;
            Show();
            CBPostNr.Show(); //Hides unnecessary controls
            TBPostNr.Hide();
            LabelID.Hide();
            BTNSolgt.Hide();
            BtnDelete.Enabled = false; //Kan ikke slette i Create mode

            //makes things that are unchangeable in editMode, changeable
            TBAdresse.ReadOnly = false;
            TBAdresse.Text = "";

            TBAreal.ReadOnly = false;
            TBAreal.Text = "";

            TBPris.Text = "";

            TBPostNr.Text = "";

            LabelID.Text = "";

            TBEMæglerNavn.Text = "";

            DTPOpretDato.Enabled = false; //Date er altid idag. -Martin
            DTPOpretDato.Value = DateTime.Now; //på nuværende tidspunkt kan kun oprettes dags dato
            
            BtnVælgE.Enabled = true;
            LabelMode.Text = "CREATE MODE";
        }

        public void InitializeEditMode()
        {
            editMode = true;
            Show();
            TBPostNr.Show();
            TBAdresse.Text = viewModel.ValgtBolig.Adresse;
            TBAdresse.ReadOnly = true; //Adresse ændres ikke medmindre vi henter en kæmpe lastbil.

            TBAreal.Text = viewModel.ValgtBolig.Kvm.ToString();
            TBAreal.BackColor = Color.Gray;
            TBAreal.ReadOnly = true; //Areal ændres ikke

            TBPris.Text = viewModel.ValgtBolig.Pris.ToString();
            TBPris.BackColor = Color.White;

            CBPostNr.Hide(); //PostNr skal ikke ændres ever
            TBPostNr.Text = viewModel.ValgtBolig.PostNr.ToString();
            TBPostNr.ReadOnly = true;

            LabelID.Text = viewModel.ValgtBolig.ID.ToString();

            BtnVælgE.Enabled = false; //Kan ikke vælge EMægler i edit

            BtnDelete.Enabled = true; //Kan slette i editMode

            DTPOpretDato.Value = viewModel.ValgtBolig.OprettelsesDato;
            DTPOpretDato.Enabled = false; //Kan ikke ændre dato

            TBEMæglerNavn.Text = viewModel.ValgtEmægler.ToString(); //Tostring metoden er overridet
                                                                //Til at vise navn

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
                viewModel.SaveEdit(viewModel.ValgtBolig, Convert.ToDouble(TBPris.Text)); //Forsøger at holde logik og datamanipulation i ViewModel
            }
            else
            {
                if (viewModel.ValgtEmægler != null)
                {
                    viewModel.SaveNewBolig(TBAdresse.Text, Convert.ToDouble(TBPris.Text),
                                                Convert.ToInt32(TBAreal.Text), DTPOpretDato.Value,
                                                ((PostNumre)CBPostNr.SelectedItem).PostNummer);

                    //BoligTabelDB.Create(newBolig);
                    this.Hide();
                    parent.FyldListView(viewModel.FillListView());
                }
                else
                {
                    MessageBox.Show("Vælg en Ejendomsmægler via knappen 'Vælg E' Først");
                    BtnVælgE.Enabled = true;
                }
            }
            //MessageBox.Show("Boop, pranked, Im out");
            //Hide(); //Gammel Hide() -Martin
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
            TBEMæglerNavn.Text = viewModel.ValgtEmægler.ToString(); //overridet, giver navn og ID
            BtnVælgE.Enabled = false;
        }
        private void BtnVælgBillede_Click(object sender, EventArgs e) //Til valg af billede til hus
        {   //endnu ikke fuldt implementeret.
            Form pictureForm = new ImageSelectorForm();
            pictureForm.ShowDialog();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            viewModel.Delete(viewModel.ValgtBolig);
            parent.FyldListView(viewModel.FillListView()); //reset listen når der slettes
        }

        private void BoligDetails_Load(object sender, EventArgs e)
        {

        }
        /// Nichlas leger her
        /// 

        private void CBPostNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = CBPostNr.SelectedItem as PostNumre;
            LBLPris.Text = item.PrisPrm2.ToString() + " ,-KR"; 

        }


        private void BTNSolgt_Click(object sender, EventArgs e)
        {
            viewModel.SælgBolig(viewModel.ValgtBolig, this);

        }

        private void btnKontrakter_Click(object sender, EventArgs e)
        {

        }
    }        /// 
}
