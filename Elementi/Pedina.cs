using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementi
{
    public abstract class Pedina
    {
        public int Peso { get; private set; }
        public Colore Squadra { get; private set; }
        public Posizione Posizione
        {
            get => Posizione; set
            {
                if (Posizione != null)
                    Posizione.Pedina = null;
                Posizione = value;
                Posizione.Pedina = this;
            }
        }

        public Pedina(int peso, Colore squadra)
        {
            Peso = peso;
            Squadra = squadra;
        }

        public virtual void Muovi(Posizione nuovaPosizione)
        {
            if (Posizione.Occupata == true)
                PosizioneOccupata();
        }

        public override string ToString()
        {
            return $"{GetType().Name} {Squadra} in {Posizione}";
        }

        public string Name => GetType().Name;

        public virtual string ShortName => Name.Substring(0, 3);

        protected void Errore()
        {
            throw new Exception($"Mossa per {Name} non valida");
        }

        protected void PosizioneOccupata()
        {
            throw new Exception($"Postamento non consentito. Posizione occupata!");
        }
    }
}
