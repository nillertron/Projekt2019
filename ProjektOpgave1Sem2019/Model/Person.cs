using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019
{
    //Nichlas
    public abstract class Person
    {
        private int _Id;
        public int Id { set { if (value > 0) _Id = value; else throw new FormatException("ID skal være over 0"); } get { return _Id; } }
        private string _Navn;
        public string Navn { protected set { if (value.Length > 0) _Navn = value; else throw new FormatException("Navn kan ikke være tom"); } get { return _Navn; } }
        private string _Efternavn;
        public string Efternavn { protected set { if (value.Length > 0) _Efternavn = value; else throw new FormatException("Efternavn må ikke være tom"); } get { return _Efternavn; } }
        private string _TelefonNr;
        public string TelefonNr { protected set { if (value.Length >= 8 && value.Length <= 15) _TelefonNr = value; else throw new FormatException("TelefonNr skal være mellem 8 og 15 tegn"); } get { return _TelefonNr; } }
        private string _KontoNr;
        public string KontoNr { protected set { if (value.Length > 0 && value.Length <= 15) _KontoNr = value; else throw new FormatException("KontoNr skal være mellem 0 og 15 tegn"); } get { return _KontoNr; } }
        public int PostNr { get;  protected set; }
        public string Addresse { get; protected set; }
        public Person(int Id, string Navn, string Efternavn, string TelefonNr, string KontoNr)
        {
            this.Id = Id;
            this.Navn = Navn;
            this.Efternavn = Efternavn;
            this.TelefonNr = TelefonNr;
            this.KontoNr = KontoNr;
        }
        public Person(string Navn, string Efternavn, string TelefonNr, string KontoNr)
        {
            this.Navn = Navn;
            this.Efternavn = Efternavn;
            this.TelefonNr = TelefonNr;
            this.KontoNr = KontoNr;
        }
    }
}
