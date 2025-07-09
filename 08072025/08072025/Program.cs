using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

namespace _08072025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
                if (i == 100)
                {
                    break;
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("buzz");
                }
               
                else if (i % 3 == 0)
                {
                    Console.Write("fizz");
                }

            }













            /*int i = 0;
            
              while (true)
                {
                
                Console.WriteLine(i);
                i++;
                
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("spatna klavesa");
                }*/




        }


                /*int[] ourArr = { 1, 2, 3, 4, 5, 6 };

                for (int i = 0; i < ourArr.Length; i++)
                {

                    Console.WriteLine($"Hodnota {ourArr[i]} - {i}");
                }
                */

                /*int i = 0;
                while (true)
                {
                    Console.WriteLine(i);
                    i++;
                    if(i ==2000)
                    {
                        break;
                    }
                }
                */


                /*int[] ourArr = { 32, 32, 47, 52 };



                for (int i = 0; i < ourArr.Length; i++)
                {       

                    Console.Write("Vypsano pomoci for loop:  ");
                    Console.WriteLine(ourArr[i]);
                }
                foreach (int i in ourArr)
                {
                    Console.Write("Vypsano pomoci foreach loop: " );
                    Console.WriteLine(i);
                }
                Console.WriteLine("konec");
                */

            
    }
}
