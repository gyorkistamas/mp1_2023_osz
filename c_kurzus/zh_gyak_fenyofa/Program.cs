using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh_gyak_fenyofa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fakNaponta = 0;
            Console.Write("Adja meg naponta mennyi fát termelnek ki [33, 55]: ");
            while(!int.TryParse(Console.ReadLine(), out fakNaponta) || fakNaponta < 33 || fakNaponta > 55)
            {
                Console.Write("Hibás értéket adott meg, próbálja újra: ");
            }

            int[] fakMagassaga = new int[14 * fakNaponta];

            Random rnd = new Random();
            for (int i = 0; i < fakMagassaga.Length; i++)
            {
                fakMagassaga[i] = rnd.Next(150, 301);
            }

            for (int i = 0; i < 14; i++)
            {
                double atlag = 0;
                for(int j = 0; j < fakNaponta; j++)
                {
                    atlag += fakMagassaga[j + i * fakNaponta];
                }
                atlag = (atlag / fakNaponta) / 100;
                Console.WriteLine($"A {i + 1}. napon {atlag} méter volt az átlagmagasság.");
            }

            int minIndex = 0;
            // Megjegy.: lehetne használni a dupla ciklusos megoldást is
            for(int i = 1; i < fakMagassaga.Length; i++)
            {
                if (fakMagassaga[i] < fakMagassaga[minIndex])
                {
                    minIndex = i;
                }
            }

            int nap = (minIndex / fakNaponta) + 1;
            int hossz = fakMagassaga[minIndex];

            Console.WriteLine($"A legkisebb fa a {nap} napon volt, és ennek az értéke: {hossz}");
            //Egyik megoldás a max kiválasztására
            int maxNap = 0;
            int maxBevetel = 0;
            for(int i = 0; i < 14; i++)
            {
                int osszegSum = 0;
                for(int j = 0; j < fakNaponta; j++)
                {
                    osszegSum += ((fakMagassaga[j + i * fakNaponta]) / 10) * 500;
                }
                Console.WriteLine($"A {i + 1}. napon {osszegSum} Ft volt az összbevétel.");
                if (osszegSum > maxBevetel)
                {
                    maxNap = i;
                    maxBevetel = osszegSum;
                }
            }
            Console.WriteLine($"A legnagyobb bevétel a {maxNap + 1}. napon volt, és ez: {maxBevetel} Ft");

            // Másik megoldás
            int[] bevetelNaponta = new int[14];
            for (int i = 0; i < 14; i++)
            {
                int osszegSum = 0;
                for (int j = 0; j < fakNaponta; j++)
                {
                    osszegSum += ((fakMagassaga[j + i * fakNaponta]) / 10) * 500;
                }
                Console.WriteLine($"A {i + 1}. napon {osszegSum} Ft volt az összbevétel.");
                bevetelNaponta[i] = osszegSum;
            }

            int maxIndex = 0;
            for (int i = 1; i < bevetelNaponta.Length; i++)
            {
                if (bevetelNaponta[i] > bevetelNaponta[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine($"A legnagyobb bevétel a {maxIndex + 1}. napon volt, és ez: {bevetelNaponta[maxIndex]} Ft");

            Console.ReadLine();
        }
    }
}
