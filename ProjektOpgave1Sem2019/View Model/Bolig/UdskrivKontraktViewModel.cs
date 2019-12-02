using ProjektOpgave1Sem2019.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOpgave1Sem2019
{
    class UdskrivKontraktViewModel
    {
        public List<SolgtBolig> SolgtBoligListe;
        public UdskrivKontraktViewModel()
        {
            FyldListe();
        }
        public void FyldListe()
        {
            SolgtBoligListe = BoligTabelDB.GetAllSolgteBoliger();
            SolgtBoligListe.ForEach(o =>
            {
                o.SetSælgerOgKøberObjekter(o.SælgerID, o.KøberID);

            });
        }

        public List<ListViewItem> GetListViewItems()
        {
            var collection = new List<ListViewItem>();

            SolgtBoligListe.ForEach(o =>
            {
                var item = new ListViewItem(o.Adresse);
                item.Tag = o.ID;
                var array = new[] { o.sælger.Navn+" "+o.sælger.Efternavn, o.køber.Navn+" "+o.køber.Efternavn };
                item.SubItems.AddRange(array);
                collection.Add(item);
            });
            return collection;

            
        }

        public void UdskrivTilFil(int id, string path)
        {
            var solgtBolig = SolgtBoligListe.First(o => o.ID == id);

            var personer = new List<Person>();
            personer.Add(solgtBolig.køber);
            personer.Add(solgtBolig.sælger);
            personer.ForEach(o => o.SendContract(path, solgtBolig));
        }
    }
}
