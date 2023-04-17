namespace ExamenUa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, prenom, carteCredit, courriel;
            int numChambre;
            Client client1;
            Hotel hotel1;
            Console.WriteLine("Merci, d'ajouter les informations d'un client ");
            Console.WriteLine("Le nom: ");
            nom = Console.ReadLine();
            Console.WriteLine("Le prenom: ");
            prenom= Console.ReadLine();
            Console.WriteLine("Le courriel: ");
            courriel = Console.ReadLine();
            Console.WriteLine("Le carteCredit: ");
            carteCredit= Console.ReadLine();
            Console.WriteLine("Le numChambre: ");
            numChambre = Console.ReadLine();

            client1 = new Client(nom, prenom, courriel, carteCredit, numChambre);
            hotel1 = new Hotel();

            hotel1.AjouterClient(client1);


        }
    }
}