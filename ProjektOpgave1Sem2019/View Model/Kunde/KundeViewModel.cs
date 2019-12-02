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
        public bool isSælgerMode = false; //Start i køber mode
        private List<Køber> købere = new List<Køber>();
        private List<Sælger> sælgere = new List<Sælger>();

        public KundeViewModel()
        {
            købere = KundeDBTabel.GetAllKøbere();
            sælgere = KundeDBTabel.GetAllSælgere();
        }

        public List<Person> GetAll()
        {
            List<Person> returnList = new List<Person>();
            if(isSælgerMode)
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
            if (isSælgerMode)
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
    }
}
