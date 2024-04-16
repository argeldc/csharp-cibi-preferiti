using System;

namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            string[] cibiPreferiti = { "pizza", "frittura di pesce", "foresta Nera", "gelato", "lasagna", "ramen", "mela", "arancia" };

            //variabili d'intermedio
            int intermedio = cibiPreferiti.Length / 2;
            int intermedioPari = cibiPreferiti.Length / 2 - 1;

            //Stampa della lunghezza array
            Console.WriteLine($"Lunghezza array: {cibiPreferiti.Length}");
            Console.WriteLine();

            //Stampa classifica cibi
            Console.WriteLine("Classifica: ");
            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Char.ToUpper(cibiPreferiti[i][0]) + cibiPreferiti[i].Substring(1)}");
            }

            //Stampa della prima in classifica
            Console.WriteLine();
            Console.WriteLine($"Il mio cibo top è {Char.ToUpper(cibiPreferiti[0][0]) + cibiPreferiti[0].Substring(1)}");

            //Stampa dell'ultima in classifica
            Console.WriteLine($"Il mio cibo preferito ma non troppo è {Char.ToUpper(cibiPreferiti[cibiPreferiti.Length - 1][0]) + cibiPreferiti[cibiPreferiti.Length - 1].Substring(1)}");

            //Stampa metà classifica
            if (cibiPreferiti.Length % 2 == 0)
            {
                //Se la lunghezza è pari, stampa i 2 elementi che stanno in mezzo alla classifica
                Console.WriteLine($"Il mio cibo preferito che sta a metà classifica sono {Char.ToUpper(cibiPreferiti[intermedioPari][0]) + cibiPreferiti[intermedioPari].Substring(1)} e {Char.ToUpper(cibiPreferiti[intermedio][0]) + cibiPreferiti[intermedio].Substring(1)}");
            }
            else
            {
                //Se la lunghezza è dispari, stampa 1 elemento che sta in mezzo alla classifica
                Console.WriteLine($"Il mio cibo preferito che sta a metà classifica è {Char.ToUpper(cibiPreferiti[intermedio][0]) + cibiPreferiti[intermedio].Substring(1)}");
            }
        }
    }
}
