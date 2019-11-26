'using System;
using ProjektOpgave1Sem2019.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.View_Model
{
    //Nichlas
    class EjendomsmæglerViewModel
    {
        public List<Ejendomsmægler> EjendomsmæglerListe;

        public EjendomsmæglerViewModel()
        {
            EjendomsmæglerListe = new List<Ejendomsmægler>();
            GetAll();
        }
        public void GetAll()
        {

            EjendomsmæglerListe = EjendomsmæglerTabelDB.GetAllEjendomsmæglere();
        }

        public void Edit(Ejendomsmægler e)
        {
            bool succes = EjendomsmæglerTabelDB.Update(e);
            if (succes)
                EjendomsmæglerListe.ForEach(o => { if (o.Id == e.Id) o = e; });
        }

        public void Delete(Ejendomsmægler e)
        {
            bool succes = EjendomsmæglerTabelDB.Delete(e);
            if (succes)
                EjendomsmæglerListe.Remove(e);
            else
                MessageBox.Show("Error, try again");
        }

        public void Opret(Ejendomsmægler e)
        {
            bool succes = EjendomsmæglerTabelDB.Create(e);
            if (succes)
                EjendomsmæglerListe.Add(e);
            else
                MessageBox.Show("Error, try again");


        }
    }
}
