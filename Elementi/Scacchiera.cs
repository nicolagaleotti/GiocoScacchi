using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementi
{
    public class Scacchiera
    {
        public List<Posizione> Posizioni { get; private set; }

        public Scacchiera() { }

        public void CreaPosizioni(int numero)
        {
            int x = 1;
            char c = 'A';
            for (int i = 1; i <= numero; i++)
            {
                if (x <= 8)
                {
                    Posizione p = new Posizione(c, x);
                    Posizioni.Add(p);
                    x++;
                }
                else
                {
                    x = 1;
                    c++;
                    Posizione p = new Posizione(c, x);
                    Posizioni.Add(p);
                }
            }
        }

        public Posizione GetPosizione(char lettera, int numero)
        {
            foreach(Posizione p in Posizioni)
            {
                if (p.Lettera == lettera && p.Numero == numero)
                {
                    return p;
                }
                else return null;
            }
        }

        public void Schiera() { }
    }
}
