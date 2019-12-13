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
        public string Navn { protected set { if (value.Length > 0 && value.Length <= 50) _Navn = value; else throw new FormatException("Navn skal være mellem 1 og 50 tegn"); } get { return _Navn; } }
        private string _Efternavn;
        public string Efternavn { protected set { if (value.Length > 0 && value.Length <= 50) _Efternavn = value; else throw new FormatException("Efternavn skal være mellem 1 og 50 tegn"); } get { return _Efternavn; } }
        private string _TelefonNr;
        public string TelefonNr { protected set { if (value.Length >= 8 && value.Length <= 11) _TelefonNr = value; else throw new FormatException("TelefonNr skal være mellem 8 og 11 tegn"); } get { return _TelefonNr; } }
        private string _KontoNr;
        public string KontoNr { protected set { if (value.Length > 0 && value.Length <= 15) _KontoNr = value; else throw new FormatException("KontoNr skal være mellem 0 og 15 tegn"); } get { return _KontoNr; } }
        public int PostNr { get;  protected set; }
        private string _Adresse;
        public string Addresse { get { return _Adresse; } protected set { if (value.Length <= 50) { _Adresse = value; } else { throw new FormatException("Adresse kan ikke være længere end 50 tegn"); } } }
        public Person(int Id, string Navn, string Efternavn, string TelefonNr, string KontoNr, int PostNr, string Addresse)
        {
            this.Id = Id;
            this.Navn = Navn;
            this.Efternavn = Efternavn;
            this.TelefonNr = TelefonNr;
            this.KontoNr = KontoNr;
            this.PostNr = PostNr;
            this.Addresse = Addresse;
        }
        public Person(string Navn, string Efternavn, string TelefonNr, string KontoNr,int PostNr, string Addresse)
        {
            this.Navn = Navn;
            this.Efternavn = Efternavn;
            this.TelefonNr = TelefonNr;
            this.KontoNr = KontoNr;
            this.PostNr = PostNr;
            this.Addresse = Addresse;
        }
        public Person()
        {

        }

        public virtual void SendContract(string FP, SolgtBolig b)
        {

        }
    }
}
