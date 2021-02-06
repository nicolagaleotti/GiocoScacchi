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
        private Posizione posizione;
        public Posizione Posizione
        {
            get => posizione; set
            {
                if (posizione != null)
                    posizione.Pedina = null;
                posizione = value;
                posizione.Pedina = this;
            }
        }

        public Pedina(int peso, Colore squadra)
        {
            Peso = peso;
            Squadra = squadra;
        }

        public virtual void Muovi(Posizione nuovaPosizione)
        {
            if (nuovaPosizione.Occupata == true)
                PosizioneOccupata();
        }

        public override string ToString()
        {
            return $"{GetType().Name} {Squadra} in {Posizione.Lettera}{Posizione.Numero}";
        }

        public string Name => $"{GetType().Name}\n({Squadra})";

        public virtual string ShortName => Name.Substring(0, 3);

        protected void Errore()
        {
            throw new Exception($"Mossa per {Name} non valida");
        }

        protected void PosizioneOccupata()
        {
            throw new Exception($"Spostamento non consentito. Posizione occupata!");
        }
    }
}
