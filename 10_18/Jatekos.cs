﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_18
{
    class Jatekos
    {
        public string Nev { get; set; }
        public int EvesFizu { get; set; }
        public int Evek { get; set; }

        public Jatekos(string nev, int evesFizu, int evek)
        {
            Nev = nev;
            EvesFizu = evesFizu;
            Evek = evek;
        }
    }
}