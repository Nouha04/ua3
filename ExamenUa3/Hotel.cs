using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUa3
{
    internal class Hotel
    {
        public ArrayList ListeClients { get; set; }

        public Hotel()
        {
            ListeClients = new ArrayList();
        }

        public void AjouterClient(Client client)
        {
            ListeClients.Add(client);
        }
    }
}
