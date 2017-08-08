using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardgameCollection
{
    public class Spieler
    {
        public Spieler(string name)
        {
            throw new System.NotImplementedException();
        }

        private string name
        {
            get => default(string);
            set
            {
            }
        }

        private List<Spielkarte> handkarten
        {
            get => default(List<Spielkarte>);
            set
            {
            }
        }

        private Rang rang
        {
            get => default(Rang);
            set
            {
            }
        }

        public Rang Rang
        {
            get => default(Rang);
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

        public void addKarte(Spielkarte karte)
        {
            throw new System.NotImplementedException();
        }

        public KartenContainer ablegen()
        {
            throw new System.NotImplementedException();
        }

        public void setRang(Rang rang)
        {
            throw new System.NotImplementedException();
        }

        public Rang getRang()
        {
            throw new System.NotImplementedException();
        }

        public int getAnzahlHandkarten()
        {
            throw new System.NotImplementedException();
        }

        public string getName()
        {
            throw new System.NotImplementedException();
        }
    }
}