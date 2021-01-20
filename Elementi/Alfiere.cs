using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementi
{
    public class Alfiere : Pedina
    {
        public Alfiere(Colore colore) : base(3, colore) { }

        public override void Muovi(Posizione nuovaPosizione)
        {
            if (Math.Abs(nuovaPosizione.Lettera - Posizione.Lettera) == Math.Abs(nuovaPosizione.Numero - Posizione.Numero))
            {
                Posizione = nuovaPosizione;
            }
            else throw new Exception("Mossa non valida");
        }
    }
}
