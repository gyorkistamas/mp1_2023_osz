using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_random_szamok_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int kitalalando = rnd.Next(1, 101);

            int tipp = 0;

            while(kitalalando != tipp)
            {
                do
                {
                    Console.Write("Adjon meg egy tippet: ");
                } while (!int.TryParse(Console.ReadLine(), out tipp));

                if (tipp > kitalalando)
                {
                    Console.WriteLine("A kitalálandó szám kisebb!");
                }
                else if(tipp < kitalalando)
                {
                    Console.WriteLine("A kitalálandó szám nagyobb!");
                }
                else
                {
                    Console.WriteLine("Eltaláltad a számot!");
                }
            }

            // HF: ellentettje: a felhasz. talál ki számot, és a gép tippel

            Console.ReadLine();
        }
    }
}
