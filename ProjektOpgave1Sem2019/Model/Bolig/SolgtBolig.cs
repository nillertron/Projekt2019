using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019
{
    class SolgtBolig:Bolig
    {
        private int _KøberID;
        public int KøberID { get { return _KøberID; } private set { if (value > 0) _KøberID = value; else throw new FormatException("Køber ID skal være over 0"); } }
        private double _KøbsPris;
        public double KøbsPris { get { return _KøbsPris; } private set { if (value > 0) _KøbsPris = value; else throw new FormatException("Den er da ikke solgt gratis?"); } }
        private DateTime _KøbsDato;
        public DateTime KøbsDato { get { return _KøbsDato; } private set { if (value.Year > 1930 && value.Year < DateTime.Today.Year) _KøbsDato = value; else throw new FormatException("år skal være mellem 1930 og nuværende år"); } }
        public SolgtBolig(int ID, string Adresse, double Pris, int SælgerID, int Kvm, DateTime OprettelsesDato, int EjendomsmæglerID, int PostNr, int KøberID, double KøbsPris, DateTime KøbsDato):base(ID, Adresse, Pris, SælgerID, Kvm, OprettelsesDato, EjendomsmæglerID, PostNr)
        {
            this.KøberID = KøberID;
            this.KøbsPris = KøbsPris;
            this.KøbsDato = KøbsDato;
        }

    }
}
