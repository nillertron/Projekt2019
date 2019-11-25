using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.Model
{
    //Nichlas
    public abstract class Person
    {
        public int Id { get; }
        public string Navn { get; private set; }
        public string Efternavn { get; private set; }
        public string TelefonNr { get; private set; }
        public string KontoNr { get; private set; }
        public Person(int Id, string Navn, string Efternavn, string TelefonNr, string KontoNr)
        {
            this.Id = Id;
            this.Navn = Navn;
            this.Efternavn = Efternavn;
            this.TelefonNr = TelefonNr;
            this.KontoNr = KontoNr;
        }
    }
}
