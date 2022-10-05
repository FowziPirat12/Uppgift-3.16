using System;
namespace ConsoleApp_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter och sekunder ska en låt vara?");
            Console.Write("Skriv här: ");  string svar = Console.ReadLine();
            string[] svarsplit = svar.Split(" ");
            int minuter = int.Parse(svarsplit[0]);
            int sekunder = int.Parse(svarsplit[2]);
           
            if (minuter == 2 && sekunder >= 45 && sekunder <= 60)
            {
                Console.WriteLine("Din låt får spelas på våran radiostation.");
            }

            else if (minuter == 3 && sekunder <= 60)
            {
                Console.WriteLine("Din låt får spelas på våran radiostation.");
            }

            else if (minuter == 4 && sekunder <= 20)
            {
                Console.WriteLine("Din låt får spelas på våran radiostation.");
            }

            else if (sekunder > 60)
            {
                Console.WriteLine("Ditt dumme fan.");

            }

            else
            {
                Console.WriteLine("Din låt får INTE spelas på våran radiostation.");
            }
        }
    }
}