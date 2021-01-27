using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementi
{
    public class Cavallo : Pedina
    {
        public Cavallo(Colore colore) : base(3, colore) { }

        public override void Muovi(Posizione nuovaPosizione)
        {
            if (Math.Abs(nuovaPosizione.Lettera - Posizione.Lettera) == Math.Abs(1) && Math.Abs(nuovaPosizione.Numero - Posizione.Numero) == Math.Abs(2) ||
                Math.Abs(nuovaPosizione.Lettera - Posizione.Lettera) == Math.Abs(2) && Math.Abs(nuovaPosizione.Numero - Posizione.Numero) == Math.Abs(1))
            {
                Posizione = nuovaPosizione;
            }
            Errore();
        }
    }
}
