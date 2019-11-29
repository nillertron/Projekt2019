using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.View_Model
{
    class DatoSøgningViewModel
    {
        //Nichlas
        List<SolgtBolig> BoligListe;
        public DatoSøgningViewModel(List<Bolig> liste)
        {
             FindSolgteBoliger(liste);
            BoligListe = new List<SolgtBolig>();
        }

        private void FindSolgteBoliger(List<Bolig> Liste)
        {
            var phlist = new List<Bolig>();
            phlist = Liste;
            BoligListe.ForEach(o =>
            {
                bool tjek =BoligTabelDB.TjekBoligSolgt(o);
                if (tjek)
                    phlist.Remove(o);
            });
            BoligListe = phlist.Cast<SolgtBolig>().ToList();
        }
    }
}
