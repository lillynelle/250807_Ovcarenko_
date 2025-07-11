using System;
using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===GENERÁTOR HESEL===");

        String odpoved;
        do
        {
            Console.Write("Zadejte požadovanou délku hesla: ");
            int delka;
            while (!int.TryParse(Console.ReadLine(), out delka) || delka <= 0)
            {
                Console.Write("Neplatná hodnota!");
            }

            Console.Write("Chcete použít speciální znaky? (a/n): ");
            string volba = Console.ReadLine().ToLower();

            string pismenaCisla = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specialniZnaky = "!@#$%^&*()_+-=[]{}|;:',.<>?/`";

            string vsechnyZnaky = pismenaCisla;
            bool pouzitSpecialni = (volba == "a");

            if (pouzitSpecialni)
            {
                vsechnyZnaky += specialniZnaky;
            }
            Random nahoda = new Random();
            string heslo;

            do
            {
                heslo = "";
                for (int i = 0; i < delka; i++)
                {
                    int index = nahoda.Next(vsechnyZnaky.Length);
                    heslo += vsechnyZnaky[index];
                }
            }
            while (pouzitSpecialni && !heslo.Any(c => specialniZnaky.Contains(c)));
            Console.WriteLine("Vygenerované heslo: " + heslo);

            Console.Write("Chcete vygenerovat další heslo? (a/n): ");
            odpoved = Console.ReadLine().ToLower();


        } while (odpoved == "a");
        Console.WriteLine("Program ukončen.");
        }
    }
