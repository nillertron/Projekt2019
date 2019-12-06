using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ProjektOpgave1Sem2019.Model;
using System.Windows.Forms;
using ProjektOpgave1Sem2019;
using ProjektOpgave1Sem2019.View;
using ProjektOpgave1Sem2019.Model.Kunde;

namespace ProjektOpgave1Sem2019
{
    //Martin
    public class BoligViewModel
    {
        public List<PostNumre> postNumre = new List<PostNumre>();
        public List<Bolig> boliger = new List<Bolig>();

        private BoligDetails boligDetails;
        public BoligDetails Details { get { return boligDetails; } private set { boligDetails = value; } }

        Ejendomsmægler valgtEmægler = null; //Bruges i forbindelse med valg af Boligs EMægler
        public Ejendomsmægler ValgtEmægler { get { return valgtEmægler; } private set { valgtEmægler = value; } }
        Sælger valgtSælger = null; //I forbindelse med valg af boligs sælger;
        public Sælger ValgtSælger { get { return valgtSælger; } set { valgtSælger = value; } }
        Bolig valgtBolig = null;
        public Bolig ValgtBolig { get { return valgtBolig; } private set { valgtBolig = value; } }
        //List<Bolig> resultatListe = 

        private BoligForm view;


        public BoligViewModel(BoligForm parent)
        {
            view = parent;
            boliger = BoligTabelDB.GetAll();
            FyldPostnummerListe();
            //FillListView(boliger);

            Details = new BoligDetails(this, parent);
        }
        public void FyldPostnummerListe()
        {
            postNumre.Clear();
            postNumre = PostNrTabelDB.GetAllPostnumre();
        }

        public void AddBoligToList(Bolig bolig)
        {
            boliger.Add(bolig);
            //Note til senere
            //MessageBox.Show("Ny bolig tilføjet til liste i BoligViewModel. Husk at opdatere listen I" 
              //          + " UI laget via FillListView eller DisplaySearchResults. Denne messagebox kan slettes når det er gjort");
            //FillListView(boliger);
        }

        public List<Bolig> FillListView() //kaldes hver gang det der skal vises ændres
        {                                                   //f.eks. søgning eller form creation
            List<Bolig> tempBoliger = new List<Bolig>();
            foreach (Bolig b in boliger)
            {
                tempBoliger.Add(b);
            }

            return tempBoliger;
        }

        public void ShowBolig()
        {
            //Details.Show();
        }

        public void Opret()
        {
            Details.InitializeCreateMode();
        }

        public void Edit(Bolig b)
        {
            //Get Ejendomsmægler knyttet til bolig
            ValgtEmægler = EjendomsmæglerTabelDB.GetEjendomsmægler(b.EjendomsmæglerID);
            ValgtSælger = KundeDBTabel.GetSælger(b.SælgerID);
            ValgtBolig = b;
            //Details.Show();
            Details.InitializeEditMode();
        }

        public bool Delete(Bolig b)
        {
            bool returnBool = false;
            if (BoligTabelDB.Delete(b)) //Vis deletion lykkes
            {
                returnBool = true;
                boliger.Remove(b);
            }
            else
            {
                returnBool = false;
            }
            return returnBool;
        }

        public Bolig GetBolig(string id)
        {
            foreach(Bolig b in boliger)
            {
                if(b.ID.ToString() == id)
                {
                    //valgtEmægler = EjendomsmæglerTabelDB.GetEjendomsmægler(b.ID); //Not used
                    return b;
                }
            }
            return null;
        }

        //public List<Bolig> DisplaySearchResults(string searchTerm, string searchCategory) //Unused så vidt jeg ved - Martin
        //{
        //    //string searchTerm = parentForm.Input.Text.ToLower();
        //    //string searchCategory = parentForm.Kriterie.Text;

        //    List<Bolig> searchResults = new List<Bolig>();

        //    searchResults = SearchFor(searchCategory, searchTerm);

        //    return searchResults;
        //}

        

        public List<Bolig> SearchFor(string category, string term)
        { //Søgefunktion, kaldes hver gang søgning ændres i BoligForm
            List<Bolig> returnList = new List<Bolig>();
            switch (category)
            {
                case "Adresse":
                    foreach (Bolig b in boliger)
                    {
                        if (b.Adresse.ToLower().Contains(term))
                        {
                            returnList.Add(b);
                        }
                    }
                    break;
                case "PostNr":
                    foreach (Bolig b in boliger)
                    {
                        if (b.PostNr.ToString().ToLower().Contains(term))
                        {
                            returnList.Add(b);
                        }
                    }
                    break;
                case "Pris større end":
                    foreach (Bolig b in boliger)
                    {
                        if (b.Pris > Convert.ToDouble(term))
                        {
                            returnList.Add(b);
                        }
                    }
                    break;
                case "Pris mindre end":
                    foreach (Bolig b in boliger)
                    {
                        if (b.Pris < Convert.ToDouble(term))
                        {
                            returnList.Add(b);
                        }
                    }
                    break;
                case "Areal større end":
                    foreach (Bolig b in boliger)
                    {
                        if (b.Kvm > Convert.ToInt32(term))
                        {
                            returnList.Add(b);
                        }
                    }
                    break;
                case "Areal mindre end":
                    foreach (Bolig b in boliger)
                    {
                        if (b.Kvm < Convert.ToInt32(term))
                        {
                            returnList.Add(b);
                        }
                    }
                    break;
            }
            return returnList;
        }



        public bool ValiderInput(string searchTerm, string searchCategory)
        {

            bool returnBool = false ;
            if(searchCategory == "Areal større end" || searchCategory == "Areal mindre end")
            {
                if(int.TryParse(searchTerm, out int i))
                {
                    returnBool = true;
                }
                else
                {
                    returnBool = false;
                }
            }
            else if(searchCategory == "Pris større end" || searchCategory == "Pris mindre end")
            {
                if(double.TryParse(searchTerm, out double d))
                {
                    returnBool = true;
                }
                else
                {
                    returnBool = false;
                }
            }
            else
            {
                returnBool = true;
            }

            return returnBool;
        }

        public void SaveEdit(Bolig b, double d)
        {
            double formerPrice = b.Pris;

            b.UpdatePris(d);
            if(BoligTabelDB.Update(b))
            {
                MessageBox.Show("Huzzah, update was a success. Probably change this message later");
            }
            else
            {
                MessageBox.Show("Boohoo, update failed :(");
                b.UpdatePris(formerPrice);
            }
        }

        public void SaveNewBolig(string adresse, double pris, int areal, DateTime opretDato, int postNr)
        {
            if (valgtEmægler != null)
            {
                int ejendomsmæglerID = valgtEmægler.Id;
                int sælgerID = valgtSælger.Id;

                Bolig newBolig = new Bolig(adresse, pris, sælgerID, areal, opretDato, ejendomsmæglerID, postNr);
                newBolig = BoligTabelDB.Create(newBolig);
                AddBoligToList(newBolig);
            }
            else
            {
                MessageBox.Show("Fejl, har du husket at tilføje en ejendomsmægler?");
            }
        }

        //Oldschool get og set fordi jeg lavede en masse baseret på en af dem først. 
        //Ændrer måske til property senere -Martin
        public void SetValgtEMægler(Ejendomsmægler e)
        {
            valgtEmægler = e;
        }
        public Ejendomsmægler GetValgtEMægler()
        {
            return valgtEmægler;
        }

        public List<Ejendomsmægler> GetAllEMægler() //Til valg af ejendomsmægler
        {
            return EjendomsmæglerTabelDB.GetAll();
        }
        public List<Sælger> GetAllSælger() //Til valg af sælger
        {
            return KundeDBTabel.GetAllSælgere();
        }

        public void SetSelEMæglerNull() //null skal bruges til evaluering når man opretter ny bolig
        {
            valgtEmægler = null;
        }
        public void SetValgtSælgerNull() //Til validering af sælger under oprettelse af Bolig
        {
            valgtSælger = null;
        }


        //Nichlas
        //internal void MarkerSolgt()
        internal bool TjekBoligSolgt(Bolig selectedBolig)
        {
            return BoligTabelDB.TjekBoligSolgt(ValgtBolig);
        }
        internal void SælgBolig(Bolig b, BoligDetails instans)
        {
            view.SælgBoligToFront(b,instans);
        }
        internal void UdskrivBoligerTilTxtFil(string path)
        {
            var liste = new List<Bolig>();
            boliger.ForEach(o => liste.Add(o));
            boliger.ForEach(o => { bool Solgt = BoligTabelDB.TjekBoligSolgt(o); if (Solgt) liste.Remove(o); });
            FileWriter.BoligerTilSalgToFile(path, liste);

        }
        internal void UdskrivBoligerFraByTilTxtFil(int PostNummer, string path)
        {
            var liste = new List<Bolig>();
            liste = BoligTabelDB.GetAllBoligMedSælger();
            liste = liste.Where(o => o.PostNr == PostNummer).ToList();
            FileWriter.UdskrivBoligerIbestemtPostNr(path, liste);

        }

        public double GetKvmPrisMedPostNr(int postNr)
        {
            var obj = postNumre.First(o => o.PostNummer == postNr);
            var kvmPris = obj.PrisPrm2;
            return kvmPris;
                
        }
        //
        //public void GetBoligSoldDateInterval(DateTime startDate, DateTime endDate)
        //{

        //    foreach(Bolig b in boliger)
        //    {
        //        if
        //    }
        //}

    }
}
