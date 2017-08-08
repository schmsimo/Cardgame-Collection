using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardgameCollection
{
    public class ClientThread
    {
        public ClientThread()
        {
            throw new System.NotImplementedException();
        }

        private Spieler spieler
        {
            get => default(Spieler);
            set
            {
            }
        }

        private bool bereit
        {
            get => default(bool);
            set
            {
            }
        }

        private System.Net.Sockets.NetworkStream networkStream
        {
            get => default(System.Net.Sockets.NetworkStream);
            set
            {
            }
        }

        private System.Net.Sockets.Socket clientSocket
        {
            get => default(System.Net.Sockets.Socket);
            set
            {
            }
        }

        private List<ClientThread> clients
        {
            get => default(List<ClientThread>);
            set
            {
            }
        }

        public string getSpielerName()
        {
            throw new System.NotImplementedException();
        }

        public bool istBereit()
        {
            throw new System.NotImplementedException();
        }

        public void run()
        {
            throw new System.NotImplementedException();
        }
    }
}