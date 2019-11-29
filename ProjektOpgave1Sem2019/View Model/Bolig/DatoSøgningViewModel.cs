using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.View_Model
{
    class DatoSøgningViewModel
    {
        //bruges til et bestemme dimensioner på arrayet
        public int AntalSælgere { get; private set; }
        public int AntalHuse { get; private set; }
        //Nichlas
        //lister!!! <3
        List<SolgtBolig> BoligListe;
        List<SolgtBolig> SorteretListe = new List<SolgtBolig>();
        List<SolgtBolig> phListe;
        public DatoSøgningViewModel(List<Bolig> liste)
        {
            BoligListe = new List<SolgtBolig>();
            //tager en liste med boliger med fra parentform (den som er initialiseret i boligviewmodel, så bare en komplet liste
            //sender den med ned i min metode, som blot er lavet for at constructoren ikke skal se rodet ud
            FindSolgteBoliger(liste);
        }

        private void FindSolgteBoliger(List<Bolig> Liste)
        {
            //placeholder liste
            var phlist = new List<Bolig>();
            //foreach (x)=element, tilføj til phliste, det element
            Liste.ForEach(x => phlist.Add(x));
            //så har vi en liste vi kan smadre uden at tænke videre over det
            //og her tjekker vi for hvert element i listen, om det er en solgt bolig
            Liste.ForEach(o =>
            {
                bool tjek =BoligTabelDB.TjekBoligSolgt(o);
                if (!tjek)
                    //Hvis den ikke er solgt, så fjern det skidt fra listen
                    phlist.Remove(o);
            });
            //nu skal vi have transformeret vores objekter fra bolig til solgt bolig
            var phsbolig = new SolgtBolig();
            //foreach element i placeholder listen, cast til solgtbolig objekt med placeholder værdier som bliver replaced i database kaldet om lidt
            phlist.ForEach(o => { phsbolig = phsbolig.SælgBolig(o, 1, 1, DateTime.Now); BoligListe.Add(phsbolig); });
           // BoligListe = phlist.Cast<SolgtBolig>().ToList();
           //En metode til at finde de manglende værdier i databasen, tager en liste som input og returnere en liste hvor der er fyldt de sidste detajler på objektet
            BoligListe = BoligTabelDB.GetSolgtDetaljerFraListe(BoligListe);
        }
        public void SorterEfter2datoer(DateTime offset, DateTime end)
        {
            //cleare lige listen først, hvis der nu skal laves flere søgninger
            SorteretListe.Clear();
            //SorteretListe = BoligListe;
            //føre værdierne over i denne liste, så vi bevare boligliste og den kan bruges igen hvis man skal det
            BoligListe.ForEach(x => SorteretListe.Add(x));
            //her sortere vi listen ud fra de input vi har fået i forhold til datoer
            SorteretListe = SorteretListe.Where(o => o.KøbsDato > offset && o.KøbsDato < end).ToList();
            //sætter antalhuse, som er en variabel øverst i klassen, bruges til at bestemme dimensioner på array
            AntalHuse = SorteretListe.Count;
            //laver placeholder liste igen
            phListe = new List<SolgtBolig>();
            //smider hele listen over
            BoligListe.ForEach(x => phListe.Add(x));
            //Tjekker for dubletter, og sørger for hver unik ID kun er tilbage 1 gang
            phListe = phListe.GroupBy(o => o.EjendomsmæglerID).Select(o => o.First()).ToList();
            //hermed kan vi regne os frem til hvor mange forskellige Ejendomsmægler ID vi har at arbejde med, og kan bestemme den anden dimension i arrayet
            AntalSælgere = phListe.Count;
        }

        public string[,] KonverterTilArray()
        {
            //Det er her det ikke giver mening for mig længere!
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

        public string[,] KonverterTilArrayKarl()
        {
           



            string[,] arr = new string[ AntalHuse + 1, AntalSælgere ];
            List<Bolig> distinctSælgere = new List<Bolig>();
            int counter = 0; 

            //fill sælgere
            for(int i = 0; i < phListe.Count; i++)
            {
                //check om sælger allerede eksisterer 
                Bolig b = phListe[i];
                bool doesExists = false;

                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[0, j] == b.SælgerID.ToString())
                        doesExists = true;

                if (!doesExists)
                {
                    //add sælger 
                    arr[0, counter] = b.SælgerID.ToString();
                    counter++;
                }
            }

           

         for(int i = 0;i < phListe.Count; i++)
            {
                Bolig b = phListe[i]; 


               
                //find tilhørende sælger 
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                
                    if(arr[0,j] == b.SælgerID.ToString())
                    {
                        int count = 1;

                        while (arr[count, j] != null)
                            count++;


                        arr[count, j] = b.ID.ToString(); //her indsættes den værdi som man gerne vil gemme for hver sælger, behøver ikke være boligID, opgaven beskriver ikke nøjagtig hvilke oplysninger som skal gemmes fra boligen i arrayet
                    }
                }
            }



           
            return arr;

                
        }
     
       
    }
}
