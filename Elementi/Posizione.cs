﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementi
{
    public class Posizione
    {
        public char Lettera { get; private set; }
        public int Numero { get; private set; }
        public Colore Colore { get; private set; }
        public Pedina Pedina { get; set; }

        public Posizione(char lettera, int numero)
        {
            Lettera = lettera;
            Numero = numero;
            if (lettera % 2 == 1 && numero % 2 == 1 || lettera % 2 == 0 && numero % 2 == 0)
            {
                Colore = Colore.Nero;
            }
            else Colore = Colore.Bianco;
        }
    }
}