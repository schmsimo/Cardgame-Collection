using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardgameCollection
{
    public class Verwaltung
    {
    }

    public class VerwaltungS
    {
        public VerwaltungS()
        {
            throw new System.NotImplementedException();
        }

        private Spieler[] spieler
        {
            get => default(Spieler[]);
            set
            {
            }
        }

        private KartenDeck deck
        {
            get => default(KartenDeck);
            set
            {
            }
        }

        private Stapel stapel
        {
            get => default(Stapel);
            set
            {
            }
        }

        private Spieler amZug
        {
            get => default(Spieler);
            set
            {
            }
        }

        private bool ersterDurchlauf
        {
            get => default(bool);
            set
            {
            }
        }

        public Spieler Spieler
        {
            get => default(Spieler);
            set
            {
            }
        }

        public Stapel Stapel
        {
            get => default(Stapel);
            set
            {
            }
        }

        public KartenDeck KartenDeck
        {
            get => default(KartenDeck);
            set
            {
            }
        }

        public void austeilen()
        {
            throw new System.NotImplementedException();
        }
    }
}