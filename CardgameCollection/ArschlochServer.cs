using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardgameCollection
{
    public class ArschlochServer
    {

        private List<ClientThread> clients
        {
            get => default(List<ClientThread>);
            set
            {
            }
        }

        private System.Net.Sockets.Socket serverSocket
        {
            get => default(System.Net.Sockets.Socket);
            set
            {
            }
        }

        public Verwaltung Verwaltung
        {
            get => default(Verwaltung);
            set
            {
            }
        }

        /// <summary></summary>
        public ClientThread ClientThread
        {
            get => default(ClientThread);
            set
            {
            }
        }

        public bool sindAlleBereit()
        {
            throw new System.NotImplementedException();
        }

        public bool gibtsGenugSpieler()
        {
            throw new System.NotImplementedException();
        }

        public bool istVoll()
        {
            throw new System.NotImplementedException();
        }

        public void spielStarten()
        {
            throw new System.NotImplementedException();
        }

        public string status()
        {
            throw new System.NotImplementedException();
        }

        public void run()
        {
            throw new System.NotImplementedException();
        }
    }
}