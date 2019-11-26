using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.Model
{
    class Bolig
    {
        private int _ID;
        public int ID { private set { if (value > 0) _ID = value;   } get { return _ID; } }
        public string Adresse { private set; get; }
        private double _Pris;
        public double Pris { private set { if (value > 0) _Pris = value; } get { return _Pris; } }

        public int SælgerID { private set; get; }

        public int Kvm { private set; get; }

        public DateTime OprettelsesDato { private set; get; }

        public int EjendomsmæglerID { private set; get; }

        public int PostNr { private set; get; }

        public Bolig(int ID, string Adresse,double Pris, int SælgerID, int Kvm, DateTime OprettelsesDato, int EjendomsmæglerID, int PostNr)
        {
            this.ID = ID;
            this.Adresse = Adresse;
            this.Pris = Pris;
            this.SælgerID = SælgerID;
            this.Kvm = Kvm;
            this.OprettelsesDato = OprettelsesDato;
            this.EjendomsmæglerID = EjendomsmæglerID;
            this.PostNr = PostNr;
        }
       
    }
}
