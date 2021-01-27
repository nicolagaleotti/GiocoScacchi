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
        public IDictionary<string, Posizione> Posizioni { get; private set; } = new Dictionary<string, Posizione>();

        private Scacchiera()
        {
            for (char c = 'A'; c <= 'H'; c++)
            {
                for (int n = 1; n <= 8; n++)
                {
                    Posizioni.Add($"{c}{n}", new Posizione(c, n));
                }
            }
        }


        public Posizione GetPosizione(char lettera, int numero)
        {
            string key = $"{lettera}{numero}";
            if (Posizioni.ContainsKey(key))
                return Posizioni[key];
            throw new Exception($"Posizione {key} non trovata!");
        }

        public void Print()
        {
            string s = "";
            int cellSize = 3;
            PrintLetters(ref s, cellSize);
            PrintLine(ref s, cellSize);
            for (int n = 8; n >= 1; n--)
            {
                s += $"{n}|";
                for (char c = 'A'; c <= 'H'; c++)
                {
                    Posizione cella = GetPosizione(c, n);
                    if (cella.Pedina != null)
                        s += cella.Pedina.ShortName.PadRight(cellSize);
                    else
                        s += $"".PadRight(cellSize);
                    s += "|";
                }
                s += "\n";
                PrintLine(ref s, cellSize);
            }
            PrintLetters(ref s, cellSize);
            Console.WriteLine(s);
        }

        private static void PrintLetters(ref string s, int cellSize)
        {
            s += " ";
            for (char c = 'A'; c <= 'H'; c++)
            {
                s += $"| {c} ".PadRight(cellSize + 1);
            }
            s += "|\n";
        }

        private static void PrintLine(ref string s, int cellSize)
        {
            s += " |".PadRight(cellSize * 11, '-') + "-\n";
        }

        public void Schiera() { }
    }
}
