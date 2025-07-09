using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OvcarenkoPrumer_znamek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // PRUMER ZNAMEK
            Console.Write("Napis prvni znamku: ");
            string vstup1 = Console.ReadLine();

            Console.Write("Napis druhou znamku: ");
            string vstup2 = Console.ReadLine();

            Console.Write("Napis treti znamku: ");
            string vstup3 = Console.ReadLine();

            Console.Write("Napis ctvrtou znamku: ");
            string vstup4 = Console.ReadLine();

            Console.Write("Napis patou znamku: ");
            string vstup5 = Console.ReadLine();

            int znamka1 = Convert.ToInt32(vstup1);
            int znamka2 = Convert.ToInt32(vstup2);
            int znamka3 = Convert.ToInt32(vstup3);
            int znamka4 = Convert.ToInt32(vstup4);
            int znamka5 = Convert.ToInt32(vstup5);

            int[] poleZnamek = {znamka1, znamka2, znamka3, znamka4, znamka5};

            double average = (double) poleZnamek.Sum() / poleZnamek.Length;

            //Median
            Array.Sort(poleZnamek);
            Console.WriteLine(poleZnamek[2]);

            //Min and max
            Console.WriteLine(poleZnamek[0]);
            Console.WriteLine(poleZnamek[poleZnamek.Length - 1]);

            Console.Write($"Prumer: {average}");

            Console.ReadKey();
        }
    }
}
