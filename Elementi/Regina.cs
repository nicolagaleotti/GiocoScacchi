using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementi
{
    public class Regina : Pedina
    {
        public Regina(Colore colore) : base(10, colore) { }

        public override void Muovi(Posizione nuovaPosizione)
        {
            base.Muovi(nuovaPosizione);
            if (nuovaPosizione.Lettera == Posizione.Lettera || nuovaPosizione.Numero == Posizione.Numero ||
                Math.Abs(nuovaPosizione.Lettera - Posizione.Lettera) == Math.Abs(nuovaPosizione.Numero - Posizione.Numero))
            {
                Posizione = nuovaPosizione;
            }
            Errore();
        }
    }
}
