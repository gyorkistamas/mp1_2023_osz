using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_kulonbozo_random_szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [10;20] 6 db különböző random számot

            int[] szamok = new int[6];

            Random rnd = new Random();

            for (int i = 0; i < szamok.Length; i++)
            {
                int generaltSzam = 0;

                bool benneVanE = false;

                do
                {
                    generaltSzam = rnd.Next(10, 21);
                    benneVanE = false;
                    for (int j = 0; j < szamok.Length; j++)
                    {
                        if (szamok[j] == generaltSzam)
                        {
                            benneVanE = true;
                            break;
                        }
                    }
                } while (benneVanE);

                szamok[i] = generaltSzam;
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            // Hány 14-nél nagyobb szám van a tömbünkben

            int darab = 0;

            for (int i = 0;i < szamok.Length; i++)
            {
                if (szamok[i] > 14)
                {
                    darab++;
                }
            }

            Console.WriteLine($"{darab} darab 14-nél nagyobb szám van a tömbben.");

            Console.ReadLine();
        }
    }
}
