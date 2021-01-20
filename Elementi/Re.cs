using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementi
{
    public class Re : Pedina
    {
        public Re(Colore colore) : base(int.MaxValue, colore) { }

        public override void Muovi(Posizione nuovaPosizione)
        {
            if (Math.Abs(nuovaPosizione.Lettera - Posizione.Lettera) == Math.Abs(1) && nuovaPosizione.Numero == Posizione.Numero ||
                Math.Abs(nuovaPosizione.Numero - Posizione.Numero) == Math.Abs(1) && nuovaPosizione.Lettera == Posizione.Lettera ||
                Math.Abs(nuovaPosizione.Lettera - Posizione.Lettera) == Math.Abs(1) && Math.Abs(nuovaPosizione.Numero - Posizione.Numero) == Math.Abs(1))
            {
                Posizione = nuovaPosizione;
            }
            else throw new Exception("Mossa non valida");
        }
    }
}
