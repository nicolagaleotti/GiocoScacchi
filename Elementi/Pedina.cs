using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementi
{
    public abstract class Pedina
    {
        public int Peso { get; private set; }
        public Colore Squadra { get; private set; }
        public Posizione Posizione { get; set; }

        public Pedina(int peso, Colore squadra)
        {
            Peso = peso;
            Squadra = squadra;
        }

        public abstract void Muovi(Posizione nuovaPosizione);
    }
}
