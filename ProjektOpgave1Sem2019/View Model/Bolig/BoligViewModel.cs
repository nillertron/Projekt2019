//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Drawing;
//using ProjektOpgave1Sem2019.Model;
//using System.Windows.Forms;
//using ProjektOpgave1Sem2019.View;

//namespace ProjektOpgave1Sem2019
//{
//    class BoligViewModel
//    {
//        List<PostNumre> postNumre = new List<PostNumre>();
//        List<Bolig> boliger = new List<Bolig>();

//        BoligForm parentForm;

//        public BoligViewModel(BoligForm parent)
//        {
//            parentForm = parent;
//            boliger = BoligTabelDB.GetAll();
//            FillListView(boliger);
//            postNumre = PostNrTabelDB.GetAllPostnumre();
//        }

//        public void AddBoligToList(Bolig bolig)
//        {
//            boliger.Add(bolig);
//            FillListView(boliger);
//        }

//        public void FillListView(List<Bolig> boligListe) //kaldes hver gang det der skal vises ændres
//        {                                                   //f.eks. søgning eller form creation
//            parentForm.SeachResults.Items.Clear();
//            foreach (Bolig b in boligListe)
//            {
//                ListViewItem item = new ListViewItem(b.Adresse);
//                item.SubItems.Add(b.PostNr.ToString());
//                item.Name = b.ID.ToString();

//                parentForm.SearchResults.Items.Add(item);
//            }
//        }

//        public void ShowBolig(Bolig b)
//        {

//        }

//        public void Opret()
//        {

//        }

//        public void Edit(Bolig b)
//        {

//        }

//        public void Delete(Bolig b)
//        {

//        }

//        public void DisplaySearchResults()
//        {
//            bool validInput = true;

//            string searchTerm = parentForm.Input.Text.ToLower();
//            string searchCategory = parentForm.Kriterie.Text;

//            List<Bolig> searchResults = new List<Bolig>();

//            if (searchCategory == "Pris højere end" || searchCategory == "Pris lavere end")
//            {
//                if (double.TryParse(searchTerm, out double d)) //Valider input da der sammenlignes på doubles
//                {
//                    searchResults = SearchFor(searchCategory, searchTerm); //Seperat metode til søgning fordi, mere læseligt for mig.
//                }
//                else
//                {
//                    validInput = false;
//                }
//            }
//            if (searchCategory == "Areal større end" || searchCategory == "Areal mindre end")
//            {
//                if (int.TryParse(searchTerm, out int i)) //Valider search input da der sammenlignes på integers
//                {
//                    searchResults = SearchFor(searchCategory, searchTerm);
//                }
//                else
//                {
//                    validInput = false;
//                }
//            }
//            else
//            {
//                searchResults = SearchFor(searchCategory, searchTerm);
//            }


//            if (validInput)
//            {
//                FillListView(searchResults); //fylder listview med den nye liste af boliger.
//            }
//            else
//            {
//                parentForm.Input.BackColor = Color.Red; //indikerer at input er invalid
//                FillListView(boliger); //Vis alle boliger da søgningen ikke er valid
//            }
//        }

//        public List<Bolig> SearchFor(string category, string term)
//        {
//            List<Bolig> returnList = new List<Bolig>();
//            switch (category)
//            {
//                case "Adresse":
//                    foreach (Bolig b in boliger)
//                    {
//                        if (b.Adresse.ToLower().Contains(term))
//                        {
//                            returnList.Add(b);
//                        }
//                    }
//                    break;
//                case "PostNr":
//                    foreach (Bolig b in boliger)
//                    {
//                        if (b.PostNr.ToString().ToLower().Contains(term))
//                        {
//                            returnList.Add(b);
//                        }
//                    }
//                    break;
//                case "Pris højere end":
//                    foreach (Bolig b in boliger)
//                    {
//                        if (b.Pris > Convert.ToDouble(term))
//                        {
//                            returnList.Add(b);
//                        }
//                    }
//                    break;
//                case "Pris lavere end":
//                    foreach (Bolig b in boliger)
//                    {
//                        if (b.Pris < Convert.ToDouble(term))
//                        {
//                            returnList.Add(b);
//                        }
//                    }
//                    break;
//                case "Areal større end":
//                    foreach (Bolig b in boliger)
//                    {
//                        if (b.Kvm > Convert.ToInt32(term))
//                        {
//                            returnList.Add(b);
//                        }
//                    }
//                    break;
//                case "Areal mindre end":
//                    foreach (Bolig b in boliger)
//                    {
//                        if (b.Kvm < Convert.ToInt32(term))
//                        {
//                            returnList.Add(b);
//                        }
//                    }
//                    break;
//            }
//            return returnList;
//        }

//        //public void GetBoligSoldDateInterval(DateTime startDate, DateTime endDate)
//        //{

//        //    foreach(Bolig b in boliger)
//        //    {
//        //        if
//        //    }
//        //}

//    }
//}
