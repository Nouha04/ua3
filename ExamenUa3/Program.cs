namespace ExamenUa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, prenom, carteCredit, courriel;
            int numChambre;
            Client personne1;
            Hotel hotel;
            Console.WriteLine("Merci, d'ajouter les informations d'un client ");
            Console.WriteLine("Le nom: ");
            nom = Console.ReadLine();
            Console.WriteLine("Le prenom: ");
            prenom = Console.ReadLine();
            Console.WriteLine("Le courriel: ");
            courriel = Console.ReadLine();
            Console.WriteLine("Le carteCredit: ");
            carteCredit = Console.ReadLine();
            Console.WriteLine("Le numChambre: ");
            numChambre = int.Parse(Console.ReadLine());

            personne1 = new Client(nom, prenom, courriel, carteCredit, 3);
            hotel= new Hotel();

            hotel.AjouterClient(personne1);
        }
    }
}