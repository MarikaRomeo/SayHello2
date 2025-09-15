using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt per l'utente 
            Console.Write("Ange ditt namn: ");
            string name = Console.ReadLine() ?? "";

            // Chiamata al metodo
            SayHello(name);
        }

        // Metodo che stampa  saluto
        static void SayHello(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Hej! Trevligt att träffas."); // saluto generico se niente inserito
            }
            else
            {
                Console.WriteLine($"Hej, {name}!");
            }
        }
    }
}
