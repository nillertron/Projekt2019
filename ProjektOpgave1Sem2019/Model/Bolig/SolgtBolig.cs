using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019
{
    class SolgtBolig:Bolig,IComparable
    {
        public Bolig bolig;
        private int _KøberID;
        public int KøberID { get { return _KøberID; } private set { if (value > 0) _KøberID = value; else throw new FormatException("Køber ID skal være over 0"); } }
        private double _KøbsPris;
        public double KøbsPris { get { return _KøbsPris; } private set { if (value > 0) _KøbsPris = value; else throw new FormatException("Den er da ikke solgt gratis?"); } }
        private DateTime _KøbsDato;
        public DateTime KøbsDato { get { return _KøbsDato; } private set { if (value.Year > 2015 && value.Year <= DateTime.Today.Year) _KøbsDato = value; else throw new FormatException("år skal være mellem 2015 og nuværende år"); } }
        public SolgtBolig(int ID, string Adresse, double Pris, int SælgerID, int Kvm, DateTime OprettelsesDato, int EjendomsmæglerID, int PostNr, int KøberID, double KøbsPris, DateTime KøbsDato):base(ID, Adresse, Pris, SælgerID, Kvm, OprettelsesDato, EjendomsmæglerID, PostNr)
        {
            this.KøberID = KøberID;
            this.KøbsPris = KøbsPris;
            this.KøbsDato = KøbsDato;
        }

        public SolgtBolig SælgBolig(Bolig b, int køberId, double købsPris, DateTime købsDato)
        {
            var solgtbolig = new SolgtBolig();
            solgtbolig.Adresse = b.Adresse;
            solgtbolig.EjendomsmæglerID = b.EjendomsmæglerID;
            solgtbolig.ID = b.ID;
            solgtbolig.Kvm = b.Kvm;
            solgtbolig.OprettelsesDato = b.OprettelsesDato;
            solgtbolig.PostNr = b.PostNr;
            solgtbolig.Pris = b.Pris;
            solgtbolig.SælgerID = b.SælgerID;
            solgtbolig.KøberID = køberId;
            solgtbolig.KøbsPris = købsPris;
            solgtbolig.KøbsDato = købsDato;
            return solgtbolig;

        }
        public SolgtBolig()
        {

        }
        ////Martin
        //public int CompareTo(object obj)
        //{
        //    return this.KøbsDato.CompareTo(((SolgtBolig)obj).KøbsDato);
        //}
    }
}
