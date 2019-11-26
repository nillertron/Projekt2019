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
        public DateTime Fødseldato { private set { if (value.Year > 1930 && value.Year <= DateTime.Now.Year) value = _Fødselsdato; else throw new FormatException("Hov hov, så gammel/ung er du vidst ikke!");  } get { return _Fødselsdato; } }
        public Ejendomsmægler(int Id, string Navn, string Efternavn, string TelefonNr, string KontoNr, DateTime Fødselsdato ) : base (Id, Navn, Efternavn, TelefonNr, KontoNr)
        {
            this.Fødseldato = Fødselsdato; 
        }
        public Ejendomsmægler(string Navn, string Efternavn, string TelefonNr, string KontoNr, DateTime Fødselsdato) : base(Navn, Efternavn, TelefonNr, KontoNr)
        {
            this.Fødseldato = Fødselsdato;
        }
    }
}
