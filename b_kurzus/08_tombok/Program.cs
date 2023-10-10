using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg, hány jegyet szeretne megadni:");

            int db = Convert.ToInt32(Console.ReadLine());

            int[] jegyek = new int[db];

            for(int i = 0; i < jegyek.Length; i++) 
            {
                int temp = 0;
                do
                {
                    Console.Write($"Adja meg az {i + 1}. jegyét: ");
                } while (!int.TryParse(Console.ReadLine(), out temp) || temp < 1 || temp > 5);

                jegyek[i] = temp;
            }

            double atlag = 0;

            // Átlagolás
            for(int i = 0; i < jegyek.Length;i++)
            {
                atlag += jegyek[i];
            }

            atlag = atlag / (double)jegyek.Length;

            Console.WriteLine($"A jegyek átlaga: {atlag:0.00}");

            // Maximum kiválasztás

            int max = int.MinValue; // Minimum esetén MaxValue

            for(int i = 0; i < jegyek.Length;i++)
            {
                if (jegyek[i] > max) // Minimum esetén fordul a reláció
                {
                    max = jegyek[i];
                }
            }

            Console.WriteLine($"A legnagyobb jegy a tömbben: {max}");

            // Maximum helyének a kiválasztása
            int maxHely = 0;

            for (int i = 1; i < jegyek.Length; i++)
            {
                if (jegyek[i] >= jegyek[maxHely])
                {
                    maxHely = i;
                }
            }

            Console.WriteLine($"A legnagyobb elem a {maxHely}. helyen található.");

            Console.ReadLine();
        }
    }
}
