using System;
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
        public bool Occupata
        {
            get
            {
                if (Pedina != null)
                    return true;
                else return false;
            }
        }

        internal Posizione(char lettera, int numero)
        {
            Lettera = lettera;
            Numero = numero;
            if (lettera % 2 == 1 && numero % 2 == 1 || lettera % 2 == 0 && numero % 2 == 0)
            {
                Colore = Colore.Nero;
            }
            else Colore = Colore.Bianco;
        }
        public override string ToString()
        {
            return $"{Lettera + Numero}";
        }
    }
}
