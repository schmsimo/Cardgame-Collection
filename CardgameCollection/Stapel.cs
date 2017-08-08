using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardgameCollection
{
    public class Stapel
    {
        public Stapel()
        {
            throw new System.NotImplementedException();
        }

        private KartenContainer obersteKarten
        {
            get => default(KartenContainer);
            set
            {
            }
        }

        public Spielkarte Spielkarte
        {
            get => default(Spielkarte);
            set
            {
            }
        }

        public KartenContainer KartenContainer
        {
            get => default(KartenContainer);
            set
            {
            }
        }

        public KartenContainer getKarten()
        {
            throw new System.NotImplementedException();
        }

        public void setKarten(KartenContainer karten)
        {
            throw new System.NotImplementedException();
        }
    }
}