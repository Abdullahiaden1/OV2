using System;

namespace AdditionAndSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Mata in två tal:");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Vill du addera (+) eller subtrahera (-) talen?");
            string operation = Console.ReadLine();

            
            double resultat;
            if (operation == "+")
            {
                resultat = tal1 + tal2;
                Console.WriteLine($"{tal1} + {tal2} = {resultat}");
            }
            else if (operation == "-")
            {
                resultat = tal1 - tal2;
                Console.WriteLine($"{tal1} - {tal2} = {resultat}");
            }
            else
            {
                Console.WriteLine("Ogiltigt val av operation.");
            }

          
            Console.WriteLine("Tryck på en tangent för att avsluta...");
            
        }
    }
}