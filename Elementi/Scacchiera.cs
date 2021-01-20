using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementi
{
    public class Scacchiera
    {
        public static Scacchiera Istanza { get; } = new Scacchiera();
        public List<Posizione> Posizioni { get; private set; } = new List<Posizione>();

        private Scacchiera()
        {
            for (char c = 'A'; c <= 'H'; c++)
            {
                for (int n = 1; n <= 8; n++)
                {
                    Posizioni.Add(new Posizione(c, n));
                }
            }
        }


        public Posizione GetPosizione(char lettera, int numero)
        {
            foreach (Posizione p in Posizioni)
            {
                if (p.Lettera == lettera && p.Numero == numero)
                {
                    return p;
                }
            }
            throw new Exception("Posizione non valida!");
        }

        public void Schiera() { }
    }
}
