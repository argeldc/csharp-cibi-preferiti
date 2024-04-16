using System;

namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Array
            string[] cibiPreferiti = { "Pizza", "Frittura di pesce", "Foresta Nera", "Gelato", "Lasagna", "Ramen", "Mela", "Arancia" };
            int intermedio = cibiPreferiti.Length / 2;
            int intermedioPari = cibiPreferiti.Length / 2 - 1;
            Console.WriteLine($"Lunghezza array: {cibiPreferiti.Length}");
            Console.WriteLine();
            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cibiPreferiti[i]}");
            }
            Console.WriteLine();
            Console.WriteLine($"Il mio cibo top è {cibiPreferiti[0]}");
            Console.WriteLine($"Il mio cibo preferito ma non troppo è {cibiPreferiti[cibiPreferiti.Length - 1]}");

            if (cibiPreferiti.Length % 2 == 0)
            {
                Console.WriteLine($"Il mio cibo preferito che sta a metà classifica sono {cibiPreferiti[intermedioPari]} e {cibiPreferiti[intermedio]}");
            }
            else
            {
                Console.WriteLine($"Il mio cibo preferito che sta a metà classifica è {cibiPreferiti[intermedio]}");
            }
        }
    }
}
