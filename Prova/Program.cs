using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elementi;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Scacchiera s = new Scacchiera();
            s.CreaPosizioni(64);
            foreach(Posizione p in s.Posizioni)
            {
                Console.WriteLine(p.Lettera + " " + p.Numero);
            }
            Console.ReadLine();
        }
    }
}
