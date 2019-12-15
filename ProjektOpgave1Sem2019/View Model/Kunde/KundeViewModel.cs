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
        public List<PostNumre> postNumre = new List<PostNumre>();
        

        //Martin
        public KundeViewModel()
        {
            købere = KundeDBTabel.GetAllKøbere();
            sælgere = KundeDBTabel.GetAllSælgere();
            postNumre = PostNrTabelDB.GetAllPostnumre();
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

            bool success = KundeDBTabel.OpretSælger(s);

            if(success)
                sælgere.Add(s);

            return success;

        }

        public bool OpdaterSælger(Sælger s)
        {
            bool success = KundeDBTabel.UpdateSælger(s);

            if (success)
            {
                for (int i = 0; i < sælgere.Count; i++)
                {
                    //opdater sælger
                    Sælger sælger = sælgere[i];
                    if (sælger.Id == s.Id)
                        sælgere[i] = s; 
                }
            }


            return success;
        }

        public bool OpretKøber(Køber k)
        {
            bool success = KundeDBTabel.OpretKøber(k);

            if (success)
                købere.Add(k);

            return success;
          
        }

        public bool OpdaterKøber(Køber k)
        {
            bool success = KundeDBTabel.UpdateKøber(k);

            if (success)
            {
                for(int i = 0; i < købere.Count; i++)
                {
                    Køber køber = købere[i];
                    if (køber.Id == k.Id)
                        købere[i] = k; 
                }
            }

            return success;
        }
        public bool SletSælger()
        {
            Sælger sælgerToDelete = (Sælger)this.SelectedKunde;
            bool success = KundeDBTabel.SletSælger(sælgerToDelete);

            if (success)
                sælgere.Remove(sælgerToDelete);

            return success; 
            
        }

        public bool SletKøber()
        {
            Køber køberToDelete = (Køber)this.SelectedKunde;
            bool success = KundeDBTabel.SletKøber(køberToDelete);

            if(success)
              købere.Remove(køberToDelete);

            return success;
        }
    }

}
