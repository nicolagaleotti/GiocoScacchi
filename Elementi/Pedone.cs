using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementi
{
    public class Pedone : Pedina
    {
        public Pedone(Colore colore) : base(1, colore) { }

        public override void Muovi(Posizione nuovaPosizione)
        {
            switch (Squadra)
            {
                case Colore.Bianco:
                    if (nuovaPosizione.Lettera == Posizione.Lettera && nuovaPosizione.Numero == Posizione.Numero + 1)
                    {
                        Posizione = nuovaPosizione;
                    }
                    else if (nuovaPosizione.Lettera == Posizione.Lettera && nuovaPosizione.Numero == Posizione.Numero + 2 && Posizione.Numero == 2)
                    {
                        Posizione = nuovaPosizione;
                    }
                    else throw new Exception("Mossa non valida");
                    break;

                case Colore.Nero:
                    if (nuovaPosizione.Lettera == Posizione.Lettera && nuovaPosizione.Numero == Posizione.Numero - 1)
                    {
                        Posizione = nuovaPosizione;
                    }
                    else if (nuovaPosizione.Lettera == Posizione.Lettera && nuovaPosizione.Numero == Posizione.Numero - 2 && Posizione.Numero == 7)
                    {
                        Posizione = nuovaPosizione;
                    }
                    else throw new Exception("Mossa non valida");
                    break;
            }
        }
    }
}
