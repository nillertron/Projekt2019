using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019
{
    class SolgtBolig:Bolig
    {
        public int KøberID { get; private set; }
        public double KøbsPris { get; private set; }
        public DateTime KøbsDato { get; private set; }
        public SolgtBolig(int ID, string Adresse, double Pris, int SælgerID, int Kvm, DateTime OprettelsesDato, int EjendomsmæglerID, int PostNr, int KøberID, double KøbsPris, DateTime KøbsDato):base(ID, Adresse, Pris, SælgerID, Kvm, OprettelsesDato, EjendomsmæglerID, PostNr)
        {
            this.KøberID = KøberID;
            this.KøbsPris = KøbsPris;
            this.KøbsDato = KøbsDato;
        }

    }
}
