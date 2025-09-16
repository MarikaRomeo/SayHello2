using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for the user
            Console.Write("Ange ditt namn: ");
            string name = Console.ReadLine() ?? "";

            // Call to methods
            SayHello(name);
        }

        // Method that print
        static void SayHello(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Hej! Trevligt att träffas."); // what to print if no name shows
            }
            else
            {
                Console.WriteLine($"Hej, {name}!");
            }
        }
    }
}
