using ProjektOpgave1Sem2019.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019
{
    class Form1ViewModel
    {
        public List<Ejendomsmægler> EjendomsmæglerListe;
        public Form1ViewModel(Form1 form)
        {
            EjendomsmæglerListe = new List<Ejendomsmægler>();


        }

        public async Task GetEjendomsmæglere()
        {
            EjendomsmæglerListe = await EjendomsmæglerTabelDB.GetAllEjendomsmæglere();
        }

        public async Task OpretEjendomsmægler()
        {
            var d = "16-04-1994";
            DateTime dato = new DateTime();
            dato = Convert.ToDateTime(d);

            var e1 = new Ejendomsmægler("bob", "bobsen", "88888888", "1234567",dato);
            await EjendomsmæglerTabelDB.OpretEjendomsmægler(e1);
        }
    }
}
