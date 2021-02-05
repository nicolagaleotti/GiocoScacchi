using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementi
{
    public class Torre : Pedina
    {
        public Torre(Colore colore) : base(5, colore) { }

        public override void Muovi(Posizione nuovaPosizione)
        {
            base.Muovi(nuovaPosizione);
            if (nuovaPosizione.Lettera == Posizione.Lettera || nuovaPosizione.Numero == Posizione.Numero)
            {
                Posizione = nuovaPosizione;
            }
            else
                Errore();
        }
    }
}
