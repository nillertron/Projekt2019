using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019
{
    class Bolig:IComparable
    {
        private int _ID;
        public int ID { private set { if (value > 0) _ID = value; else throw new FormatException("ID skal være over 0"); } get { return _ID; } }
        public string Adresse { private set; get; }
        private double _Pris;
        public double Pris { private set { if (value > 0) _Pris = value; else throw new FormatException("Pris skal være over 0"); } get { return _Pris; } }
        private int _SælgerID;
        public int SælgerID { private set { if (value > 0) _SælgerID = value; else throw new FormatException("ID skal være over 0"); } get { return _SælgerID; } }
        private int _Kvm;
        public int Kvm { private set { if (value > 0 && value < 2000) _Kvm = value; else throw new FormatException("Kvm skal være mellem 1 og 2000"); } get { return _Kvm; } }

        private DateTime _OprettelsesDato;
        public DateTime OprettelsesDato { private set { if (value.Year > 2015) _OprettelsesDato = value; else throw new FormatException("Oprettelsesåret minimum er 2015"); } get { return _OprettelsesDato; } }

        private int _EjendomsmæglerID;
        public int EjendomsmæglerID { private set { if (value > 0) _EjendomsmæglerID = value; else throw new FormatException("ID skal være størrere end 0"); } get { return _EjendomsmæglerID; }}

        private int _PostNr;
        public int PostNr { private set { if (value > 500 && value < 10000) _PostNr = value; } get { return _PostNr; } }

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
        public Bolig()
        {

        }
        
        public int CompareTo(object obj)
        {
            int returnValue;
            if(Pris.CompareTo(((Bolig)obj).Pris) < 0)
            {
                returnValue = -1;
            }
            else if(Pris.CompareTo(((Bolig)obj).Pris) > 0)
            {
                returnValue = 1;
            }
            else
            {
                returnValue = 0;
            }
            return returnValue;
        }
    }
}
