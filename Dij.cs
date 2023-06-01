﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNobel
{
    public class Dij
    {
        int evszam;
        string tipus;
        string keresztnev;
        string vezeteknev;

        public Dij(int evszam, string tipus, string keresztnev, string vezeteknev)
        {
            this.evszam = evszam;
            this.tipus = tipus;
            this.keresztnev = keresztnev;
            this.vezeteknev = vezeteknev;
        }

        public int Evszam { get => evszam;  }
        public string Tipus { get => tipus;  }
        public string Keresztnev { get => keresztnev; }
        public string Vezeteknev { get => vezeteknev; }
    }
}
