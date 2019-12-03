using ProjektOpgave1Sem2019.Model;
using ProjektOpgave1Sem2019.Model.Kunde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019
{
    class KundeViewModel
    {
        public bool IsSælgerMode = false; //Start i køber mode
        private List<Køber> købere = new List<Køber>();
        private List<Sælger> sælgere = new List<Sælger>();
        public Person SelectedKunde; 
        

        //Martin
        public KundeViewModel()
        {
            købere = KundeDBTabel.GetAllKøbere();
            sælgere = KundeDBTabel.GetAllSælgere();
        }

        public List<Person> GetAll()
        {
            List<Person> returnList = new List<Person>();
            if(IsSælgerMode)
            {
                foreach(Sælger s in sælgere)
                {
                    returnList.Add(s);
                }
            }
            else
            {
                foreach(Køber k in købere)
                {
                    returnList.Add(k);
                }
            }
            return returnList;
        }

        public List<Person> DisplaySearchResults(string kriterie, string input)
        {
            List<Person> returnList = new List<Person>();
            if (IsSælgerMode)
            {
                switch (kriterie)
                {
                    case "Fornavn":
                        foreach(Sælger s in sælgere)
                        {
                            if(s.Navn.ToLower().Contains(input))
                            {
                                returnList.Add(s);
                            }
                        }
                        break;
                    case "Efternavn":
                        foreach (Sælger s in sælgere)
                        {
                            if (s.Efternavn.ToLower().Contains(input))
                            {
                                returnList.Add(s);
                            }
                        }
                        break;
                    case "Adresse":
                        foreach (Sælger s in sælgere)
                        {
                            if (s.Addresse.ToLower().Contains(input))
                            {
                                returnList.Add(s);
                            }
                        }
                        break;
                    case "Tlf":
                        foreach (Sælger s in sælgere)
                        {
                            if (s.TelefonNr.ToLower().Contains(input))
                            {
                                returnList.Add(s);
                            }
                        }
                        break;
                }
            }
            else
            {
                switch (kriterie)
                {
                    case "Fornavn":
                        foreach (Køber s in købere)
                        {
                            if (s.Navn.ToLower().Contains(input))
                            {
                                returnList.Add(s);
                            }
                        }
                        break;
                    case "Efternavn":
                        foreach (Køber s in købere)
                        {
                            if (s.Efternavn.ToLower().Contains(input))
                            {
                                returnList.Add(s);
                            }
                        }
                        break;
                    case "Adresse":
                        foreach (Køber s in købere)
                        {
                            if (s.Addresse.ToLower().Contains(input))
                            {
                                returnList.Add(s);
                            }
                        }
                        break;
                    case "Tlf":
                        foreach (Køber s in købere)
                        {
                            if (s.TelefonNr.ToLower().Contains(input))
                            {
                                returnList.Add(s);
                            }
                        }
                        break;
                }
            }
            return returnList;
        }

        public void SetSelectedPerson(string id) //Sætter valgt kunde til edit mode
        {
            if(IsSælgerMode)
            {
                foreach(Person p in sælgere)
                {
                    if(p.Id == Convert.ToInt32(id))
                    {
                        SelectedKunde = p;
                    }
                }
            }
            else
            {
                foreach(Person p in købere)
                {
                    if(p.Id == Convert.ToInt32(id))
                    {
                        SelectedKunde = p;
                    }
                }
            }
        }
        //Martin Slut


            //karl

        public bool OpretSælger(Sælger s)
        {
            bool success = false;

            try
            {
            Sælger nySælger = KundeDBTabel.OpretSælger(s);
            sælgere.Add(nySælger);

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }

            return success;
        }

        public bool OpdaterSælger(Sælger s)
        {
            bool success = false;

            if (KundeDBTabel.UpdateSælger(s))
                success = true;
            else
                success = false;

            return success;
        }

        public bool OpretKøber(Køber k)
        {
            bool success = false;

            //try
            //{
            //    //Køber nyKøber = KundeDBTabel.OpretKøber(k);
            //}
            //catch (Exception e)
            //{

            //}
            if (KundeDBTabel.OpretKøber(k))
                success = true;
            else
                success = false;

            return success;
        }

        public bool OpdaterKøber(Køber k)
        {
            bool success = false;

            if (KundeDBTabel.UpdateKøber(k))
                success = true;
            else
                success = false;

            return success;
        }
    }

}
