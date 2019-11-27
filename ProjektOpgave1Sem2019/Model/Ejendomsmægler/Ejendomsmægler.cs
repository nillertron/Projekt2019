using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019
{
    public class Ejendomsmægler : Person 
    {
        private DateTime _Fødselsdato;
        public DateTime Fødseldato { private set { if (value.Year > 1930 && value.Year <= DateTime.Now.Year)  _Fødselsdato = value; else throw new FormatException("Hov hov, så gammel/ung er du vidst ikke!");  } get { return _Fødselsdato; } }
        public Ejendomsmægler(int Id, string Navn, string Efternavn, string TelefonNr,  DateTime Fødselsdato, string KontoNr ) : base (Id, Navn, Efternavn, TelefonNr, KontoNr)
        {
            this.Fødseldato = Fødselsdato; 
        }
        public Ejendomsmægler(string Navn, string Efternavn, string TelefonNr,  DateTime Fødselsdato, string KontoNr) : base(Navn, Efternavn, TelefonNr, KontoNr)
        {
            this.Fødseldato = Fødselsdato;
        }

        public void Opdater(Ejendomsmægler NyeVærdier)
        {
            this.Efternavn = NyeVærdier.Efternavn;
            this.Fødseldato = NyeVærdier.Fødseldato;
            this.KontoNr = NyeVærdier.KontoNr;
            this.Navn = NyeVærdier.Navn;
            this.TelefonNr = NyeVærdier.TelefonNr;
        }
    }
}
