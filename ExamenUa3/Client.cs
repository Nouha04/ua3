using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUa3
{
    internal class Client
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Courriel { get; set; }
        public string CarteCredit { get; set; }
        public int NumChambre { get; set; }

        public Client(string nom, string prenom, string courriel, string carteCredit, int numChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            CarteCredit = carteCredit;
            NumChambre = numChambre;
        }
    }
}
