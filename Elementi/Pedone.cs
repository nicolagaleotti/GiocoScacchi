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
            throw new NotImplementedException();
        }
    }
}
