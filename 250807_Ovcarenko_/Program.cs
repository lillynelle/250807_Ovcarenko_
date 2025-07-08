namespace _250807_Ovcarenko_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan ;
            Console.BackgroundColor = ConsoleColor.Gray ;
            Console.ResetColor();
            
            Console.Write("Napiš svoje jméno:");

            string userName = Console.ReadLine();

            Console.Write("Napiš svůj věk:");

            string userAgeInput = Console.ReadLine();

            // bez : userAgeInput = Console.ReadLine();

            int userAge;

            bool succes = int.TryParse(userAgeInput, out userAge);

            if (succes)
            {


                if (userAge >= 21)
                {
                    Console.WriteLine(userName + ", je Vám" + userAgeInput + ", proto alkohol v Americe pít smíte.");
                }
                else
                {
                    Console.WriteLine(userName + ", je Vám" + userAgeInput + ", proto alkohol v Americe pít nesmíte.");
                }

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("vstup, ktery jsi zadal neni cislo");
            }

        }
    }
}
