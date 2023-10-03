using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_szamkitalalas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 és 100 közötti számok

            int also = 1;
            int felso = 100;
            int tippelt = 50;
            bool talalat = false;
            while(!talalat)
            {
                Console.WriteLine($"A tippem: {tippelt}");
                Console.Write("Eltaláltam-e, vagy kisebb vagy nagyobb? ");

                // Ellenőrzést
                string valasz = Console.ReadLine();

                switch(valasz)
                {
                    case "egyenlő":
                        talalat = true;
                        break;
                    case "kisebb":
                        felso = tippelt;
                        break;
                    case "nagyobb":
                        also = tippelt;
                        break;
                }
                tippelt = (also + felso) / 2;
            }

            Console.WriteLine("Köszönöm a játékot!");

            Console.ReadLine();
        }
    }
}
