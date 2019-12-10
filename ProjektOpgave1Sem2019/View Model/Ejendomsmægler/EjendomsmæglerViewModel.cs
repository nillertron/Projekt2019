using System;
using ProjektOpgave1Sem2019.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektOpgave1Sem2019;

namespace ProjektOpgave1Sem2019.View_Model
{
    //Nichlas
    public class EjendomsmæglerViewModel
    {
        public List<Ejendomsmægler> EjendomsmæglerListe;
        public List<PostNumre> PostNummerListe;

        EjendomsmæglereForm ParentForm;
        
        public Ejendomsmægler ValgtEjendomsmægler;
        private ValgtEjendomsMæglerDetails Details;

        public EjendomsmæglerViewModel(EjendomsmæglereForm ParentForm)
        {
            PostNummerListe = new List<PostNumre>();
            FyldPostnumre();
            EjendomsmæglerListe = new List<Ejendomsmægler>();
            GetAll();
            Details = new ValgtEjendomsMæglerDetails(this, ParentForm);
            this.ParentForm = ParentForm;
            
           
        }
   

        private void FyldPostnumre()
        {
            PostNummerListe = PostNrTabelDB.GetAllPostnumre();
        }
        private void AddEjendomsmæglerToList(Ejendomsmægler e)
        {
            

            ListViewItem item = new ListViewItem(e.Navn);
            item.SubItems.Add(e.Efternavn);

            item.Name = e.Id.ToString();

            

            ParentForm.SearchResults.Items.Add(item);

        }
        public Ejendomsmægler FindEjendomsmægler()
        {
            foreach (Ejendomsmægler e in EjendomsmæglerListe)
                if (e.Id.ToString() == ParentForm.SearchResults.FocusedItem.Name)
                    ValgtEjendomsmægler = e;
            return ValgtEjendomsmægler;




        }
        public void NyEjendomsmægler()
        {
            //skal have vist user control herfra også
            ParentForm.Controls.Add(Details);
            Details.CreateMode();

        }
        public void GetAll()
        {

            EjendomsmæglerListe = EjendomsmæglerTabelDB.GetAll();
        }

        public void Edit(Ejendomsmægler e)
        {

            bool succes = EjendomsmæglerTabelDB.Update(e);
            if (succes)
            {
                EjendomsmæglerListe.ForEach(o => { if (o.Id == e.Id) o = e; });
                MessageBox.Show($"{e.Navn} blev opdateret!");
            }
            else
            {
                MessageBox.Show("Fejl!");
            }
        }

        public bool Delete(Ejendomsmægler e)
        {
            bool succes = EjendomsmæglerTabelDB.Delete(e);
            if (succes)
                EjendomsmæglerListe.Remove(e);

            return succes;
        }



        public void Opret(Ejendomsmægler e)
        {
            bool succes = EjendomsmæglerTabelDB.Create(e);
            if (succes)
            {
                EjendomsmæglerListe.Add(e);
                MessageBox.Show($"{e.Navn} oprettet");
            }
            else
                MessageBox.Show("Error, try again");


        }

        public List<Ejendomsmægler> DisplaySearchResults(string kriterie, string input)
        {
          


            List<Ejendomsmægler> searchResults = new List<Ejendomsmægler>();

           


            
                switch (kriterie)
                {
                    case "Navn":
                        foreach (Ejendomsmægler e in EjendomsmæglerListe)
                        {
                        string fuldtNavn = e.Navn + e.Efternavn;
                            if (fuldtNavn.ToLower().Contains(input))
                                searchResults.Add(e);
                        }
                        break;
                case "Fornavn":
                    foreach(Ejendomsmægler e in EjendomsmæglerListe)
                    {
                        if (e.Navn.ToLower().Contains(input))
                            searchResults.Add(e);
                    }
                    break;
                    case "Efternavn":
                        foreach (Ejendomsmægler e in EjendomsmæglerListe)
                        {
                            if (e.Efternavn.ToLower().Contains(input))
                                searchResults.Add(e);
                        }
                        break;
                    case "FødselsDato":
                        foreach (Ejendomsmægler e in EjendomsmæglerListe)
                        { 
                        if (e.Fødseldato.ToString().Contains(input))
                                searchResults.Add(e);
                        }
                        break;

                    case "Tlf":
                        foreach (Ejendomsmægler e in EjendomsmæglerListe)
                        {
                            if (e.TelefonNr.ToString().Contains(input))
                                searchResults.Add(e);

                        }
                        break;



                }

            return searchResults;



            

        }
        public List<Ejendomsmægler> DisplaySearchResults()
        {
            return EjendomsmæglerListe;
        }
    }
}
