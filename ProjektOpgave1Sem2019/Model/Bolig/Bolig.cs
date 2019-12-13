using ProjektOpgave1Sem2019.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019
{
    public class Bolig:IComparable
    {
        private int _ID;
        public int ID { protected set { if (value > 0) _ID = value; else throw new FormatException("ID skal være over 0"); } get { return _ID; } }
        private string _Adresse;
        public string Adresse { protected set { if (value.Length > 0 && value.Length <= 50) { _Adresse = value; } else { throw new FormatException("Adresse skal være mellem 1 og 50 karakterer"); } } get { return _Adresse; } }
        private double _Pris;
        public double Pris { protected set { if (value > 0 && value <= 2000000000) _Pris = value; else throw new FormatException("Pris skal være over 0 og under 2 milliarder"); } get { return _Pris; } }
        private int _SælgerID;
        public int SælgerID { protected set { if (value > 0) _SælgerID = value; else throw new FormatException("ID skal være over 0"); } get { return _SælgerID; } }
        private int _Kvm;
        public int Kvm { protected set { if (value > 0 && value < 2000) _Kvm = value; else throw new FormatException("Kvm skal være mellem 1 og 2000"); } get { return _Kvm; } }

        private DateTime _OprettelsesDato;
        public DateTime OprettelsesDato { protected set { if (value.Year >= 2015) _OprettelsesDato = value; else 
                    throw new FormatException("Oprettelsesåret minimum er 2015"); } get { return _OprettelsesDato; } }

        private int _EjendomsmæglerID;
        public int EjendomsmæglerID { protected set { if (value > 0) _EjendomsmæglerID = value; else throw new FormatException("ID skal være størrere end 0"); } get { return _EjendomsmæglerID; }}

        private int _PostNr;
        public int PostNr { protected set { if (value > 500 && value < 10000) _PostNr = value; } get { return _PostNr; } }

        public Sælger sælger { get; protected set; }
        public Bolig()
        {

        }
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
        public Bolig(int ID, string Adresse, double Pris, int SælgerID, int Kvm, DateTime OprettelsesDato, int EjendomsmæglerID, int PostNr, Sælger sælger)
        {
            this.ID = ID;
            this.Adresse = Adresse;
            this.Pris = Pris;
            this.SælgerID = SælgerID;
            this.Kvm = Kvm;
            this.OprettelsesDato = OprettelsesDato;
            this.EjendomsmæglerID = EjendomsmæglerID;
            this.PostNr = PostNr;
            this.sælger = sælger;
        }
        public Bolig(string Adresse, double Pris, int SælgerID, int Kvm, DateTime OprettelsesDato, int EjendomsmæglerID, int PostNr)
        {
            this.Adresse = Adresse;
            this.Pris = Pris;
            this.SælgerID = SælgerID;
            this.Kvm = Kvm;
            this.OprettelsesDato = OprettelsesDato;
            this.EjendomsmæglerID = EjendomsmæglerID;
            this.PostNr = PostNr;
        }
        //Martin
        public int CompareTo(object obj)
        {
            return this.OprettelsesDato.CompareTo(((Bolig)obj).OprettelsesDato);
        }
        
        public void UpdatePris(double d)
        {
            this.Pris = d;
        }
        //Martin slut
    }
}
