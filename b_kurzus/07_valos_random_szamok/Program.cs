using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_valos_random_szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generáljunk 10 db véletlen valós számot [5;10] 2 tizedesjegy pontosággal

            Random rnd = new Random();

            for(int i = 0; i < 10; i++)
            {
                // rnd.NextDouble() * (felsőHatár - alsóHatár) + alsóHatár
                double szam = Math.Round(rnd.NextDouble() * (10 - 5) + 5, 2);
                Console.WriteLine(szam);
            }
            Console.ReadLine();
        }
    }
}
