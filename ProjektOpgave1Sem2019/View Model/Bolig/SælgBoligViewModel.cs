using ProjektOpgave1Sem2019.Model;
using ProjektOpgave1Sem2019.Model.Kunde;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.View_Model
{
    //Nichlas
    class SælgBoligViewModel
    {
        public List<Køber> KøberListe;
        public SælgBoligViewModel()
        {
            KøberListe = new List<Køber>();
            KøberListe = KundeDBTabel.GetAllKøbere();
        }

        public bool IndsætSolgtBolig(SolgtBolig bolig)
        {
            bool success = BoligTabelDB.CreateSolgtBolig(bolig);
            if(success)
                PostNrTabelDB.OpdaterGennemsnitsPrisPrM2IEtPostNummer(bolig.PostNr);

            return success;
        }

    }
}
