﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOpgave1Sem2019.Model
{
    class Køber : Person
    {
        public Køber(int Id, string Navn, string Efternavn, string TelefonNr, string KontoNr) : base(Id, Navn, Efternavn, TelefonNr, KontoNr)
        {

        }
    }
}
