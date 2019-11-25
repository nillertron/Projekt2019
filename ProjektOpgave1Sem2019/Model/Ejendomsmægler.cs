﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.Model
{
    class Ejendomsmægler : Person 
    {
        public DateTime Fødseldato { private set; get; }
        public Ejendomsmægler(int Id, string Navn, string Efternavn, string TelefonNr, string KontoNr, DateTime Fødselsdato ) : base (Id, Navn, Efternavn, TelefonNr, KontoNr)
        {
            this.Fødseldato = Fødseldato; 
        }
    }
}
