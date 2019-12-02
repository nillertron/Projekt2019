using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.Model
{
    public class Sælger : Person 
    {
        public Sælger(int Id, string Navn, string Efternavn, string TelefonNr, string KontoNr, int PostNr, string Adresse) : base(Id, Navn, Efternavn, TelefonNr, KontoNr, PostNr, Adresse)
        {

        }
        public Sælger()
        {

        }
        public Sælger( string Navn, string Efternavn, string TelefonNr, string KontoNr, int PostNr, string Adresse) : base( Navn, Efternavn, TelefonNr, KontoNr, PostNr, Adresse)
        {

        }
    }
}
