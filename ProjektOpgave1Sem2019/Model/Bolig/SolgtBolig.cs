﻿using ProjektOpgave1Sem2019.Model;
using ProjektOpgave1Sem2019.Model.Kunde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019
{
    public class SolgtBolig:Bolig,IComparable
    {
        private int _KøberID;
        public int KøberID { get { return _KøberID; } private set { if (value > 0) _KøberID = value; else throw new FormatException("Køber ID skal være over 0"); } }
        private double _KøbsPris;
        public double KøbsPris { get { return _KøbsPris; } private set { if (value > 0 && value <= 2000000000) _KøbsPris = value; else throw new FormatException("Købspris skal være mellem 0 og 2 milliarder"); } }
        private DateTime _KøbsDato;
        public DateTime KøbsDato { get { return _KøbsDato; } private set { if (value.Year > 0 && value.Year <= DateTime.Today.Year) _KøbsDato = value; else throw new FormatException("år skal være mellem 2015 og nuværende år"); } }
        
        public Køber køber { get; private set; }
        
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

        public SolgtBolig(int ejendomsmæglerId)
        {
            this.EjendomsmæglerID = ejendomsmæglerId;
        }
        public void SetValues(int id, double pris, DateTime købsdato)
        {
            this.KøberID = id;
            this.KøbsPris = pris;
            this.KøbsDato = købsdato;
        }
        //Martin
        public new int CompareTo(object obj)
        {
            return this.KøbsDato.CompareTo(((SolgtBolig)obj).KøbsDato);
        }
        //MartinSlut
        public void SetSælgerOgKøberObjekter(int sælgerId, int køberID)
        {
            this.sælger = KundeDBTabel.GetSpecifikSælgerMedID(SælgerID);
            this.køber = KundeDBTabel.GetSpecifikKøberMedID(KøberID);
        }
    }
}
