using System.Numerics;

namespace ovcarenko2520
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<int> list = new List<int>() { 25, 54, 21, 35};

            bool pet = list.Contains(28);

            if (pet)
            {
                Console.WriteLine("Tuto hodnotu list obsahuje.");
            }  
            else
            {
                Console.WriteLine("Tuto hodnotu list neobsahuje.");

                int minimum = list.Min();
                int maximum = list.Max();
                Console.WriteLine($"Minimum: " + minimum);
                Console.WriteLine($"Maximum: " + maximum);

                Console.ReadKey();
            }
            
        }
    }
}
