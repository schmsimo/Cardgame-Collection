using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardgameCollection
{
    public class KartenDeck
    {
        public KartenDeck()
        {
            throw new System.NotImplementedException();
        }

        private List<Spielkarte> karten
        {
            get => default(List<Spielkarte>);
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

        public void fuellen()
        {
            throw new System.NotImplementedException();
        }

        public Spielkarte getKarte()
        {
            throw new System.NotImplementedException();
        }

        public void mischen()
        {
            throw new System.NotImplementedException();
        }
    }
}