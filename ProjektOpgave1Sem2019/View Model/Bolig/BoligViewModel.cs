using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ProjektOpgave1Sem2019.Model;
using System.Windows.Forms;
using ProjektOpgave1Sem2019;

namespace ProjektOpgave1Sem2019
{
    //Martin
    public class BoligViewModel
    {
        public List<PostNumre> postNumre = new List<PostNumre>();
        List<Bolig> boliger = new List<Bolig>();
        BoligDetails Details;
        //List<Bolig> resultatListe = 

        //BoligForm parentForm;

        public BoligViewModel(/*BoligForm parent*/)
        {
            //parentForm = parent;
            boliger = BoligTabelDB.GetAll();
            Details = new BoligDetails(this);
            //FillListView(boliger);
            postNumre = PostNrTabelDB.GetAllPostnumre();
        }

        public void AddBoligToList(Bolig bolig)
        {
            boliger.Add(bolig);
            //Note til senere
            MessageBox.Show("Ny bolig tilføjet til liste i BoligViewModel. Husk at opdatere listen I" 
                        + " UI laget via FillListView eller DisplaySearchResults. Denne messagebox kan slettes når det er gjort");
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
            Details.InitializeEditMode(b);
        }

        public void Delete(Bolig b)
        {

        }

        public Bolig GetBolig(string id)
        {
            foreach(Bolig b in boliger)
            {
                if(b.ID.ToString() == id)
                {
                    return b;
                }
            }
            return null;
        }

        public List<Bolig> DisplaySearchResults(string searchTerm, string searchCategory)
        {
            //string searchTerm = parentForm.Input.Text.ToLower();
            //string searchCategory = parentForm.Kriterie.Text;

            List<Bolig> searchResults = new List<Bolig>();

            searchResults = SearchFor(searchCategory, searchTerm);

            return searchResults;
        }

        public List<Bolig> SearchFor(string category, string term)
        {
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
