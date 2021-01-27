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
            Scacchiera s = Scacchiera.Istanza;
            s.Print();
            Console.ReadLine();
        }
    }
}
