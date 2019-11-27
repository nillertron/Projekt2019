using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.Model
{
    class Sælger : Person 
    {
        public Sælger(int Id, string Navn, string Efternavn, string TelefonNr, string KontoNr, int PostNr, string Adresse) : base(Id, Navn, Efternavn, TelefonNr, KontoNr, PostNr, Adresse)
        {

        }
    }
}
