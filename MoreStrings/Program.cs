using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonna nimi:");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Tere, {firstName[0]} {lastName[0]}");
        }
    }
}
