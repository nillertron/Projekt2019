using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.Model
{
    class Køber : Person
    {
        public Køber(int Id, string Navn, string Efternavn, string TelefonNr, string KontoNr, int PostNr, string Adresse) : base(Id, Navn, Efternavn, TelefonNr, KontoNr, PostNr, Adresse)
        {

        }
        public Køber( string Navn, string Efternavn, string TelefonNr, string KontoNr, int PostNr, string Adresse) : base( Navn, Efternavn, TelefonNr, KontoNr, PostNr, Adresse)
        {

        }


        public override void SendContract(string FP, SolgtBolig b)
        {
            FileWriter.UdskrivKøberKontrakt(this, FP, b);
        }
    }
}
