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
        public override void SendContract(string FP, SolgtBolig b)
        {
            FileWriter.UdskrivSælgerKontrakt(this,FP,b);
        }

        //Martin
        public override string ToString() //ToString bliver brugt til hvad der vises i ListBox i VælgSælgerForm
        {
            return Id + " " + Navn + " " + Efternavn;
        }
        //Martin Slut
    }
}
