using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.View_Model
{
    class DatoSøgningViewModel
    {
        public int AntalSælgere { get; private set; }
        public int AntalHuse { get; private set; }
        //Nichlas
        List<SolgtBolig> BoligListe;
        List<SolgtBolig> SorteretListe = new List<SolgtBolig>();
        List<SolgtBolig> phListe;
        public DatoSøgningViewModel(List<Bolig> liste)
        {
            BoligListe = new List<SolgtBolig>();
            FindSolgteBoliger(liste);
        }

        private void FindSolgteBoliger(List<Bolig> Liste)
        {
            var phlist = new List<Bolig>();
            Liste.ForEach(x => phlist.Add(x));
            Liste.ForEach(o =>
            {
                bool tjek =BoligTabelDB.TjekBoligSolgt(o);
                if (!tjek)
                    phlist.Remove(o);
            });
            var phsbolig = new SolgtBolig();
            phlist.ForEach(o => { phsbolig = phsbolig.SælgBolig(o, 1, 1, DateTime.Now); BoligListe.Add(phsbolig); });
           // BoligListe = phlist.Cast<SolgtBolig>().ToList();

            BoligListe = BoligTabelDB.GetSolgtDetaljerFraListe(BoligListe);
        }
        public void SorterEfter2datoer(DateTime offset, DateTime end)
        {
            SorteretListe.Clear();
            //SorteretListe = BoligListe;
            BoligListe.ForEach(x => SorteretListe.Add(x));
            SorteretListe = SorteretListe.Where(o => o.KøbsDato > offset && o.KøbsDato < end).ToList();
            AntalHuse = SorteretListe.Count;
            phListe = new List<SolgtBolig>();
            BoligListe.ForEach(x => phListe.Add(x));
            phListe = phListe.GroupBy(o => o.EjendomsmæglerID).Select(o => o.First()).ToList();
            AntalSælgere = phListe.Count;
        }

        public string[,] KonverterTilArray()
        {
            string[,] array = new string[AntalHuse, AntalSælgere];
            for(int i = 0; i < phListe.Count; i++)
            {
                array[0, i] = phListe[i].EjendomsmæglerID.ToString();
            }
            for (int i = 1; i < array.GetUpperBound(0) + 1; i++)
            {
                

                for (int x = 0; x < array.GetUpperBound(1) + 1; x++)
                {



                        array[i, x] = SorteretListe[i].KøbsPris.ToString();




                }

            }
            return array;
        }
    }
}
