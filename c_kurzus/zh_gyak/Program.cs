using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh_gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int napiTermeles = 0;

            Console.Write("Adja meg naponta mennyit termelnek [35, 55]: ");
            while (!int.TryParse(Console.ReadLine(), out napiTermeles)
                    || napiTermeles < 35 || napiTermeles > 55)
            {
                Console.Write("Hibás érték, próbálja újra: ");
            }

            int[] fakMagassa = new int[14 * napiTermeles];

            Random rnd = new Random();
            for (int i = 0;i < fakMagassa.Length; i++)
            {
                fakMagassa[i] = rnd.Next(150, 301);
            }

            for (int i = 0; i < 14; i++)
            {
                double atlag = 0;

                for (int j = 0; j < napiTermeles; j++)
                {
                    atlag += fakMagassa[j + napiTermeles * i];
                }

                atlag = Math.Round((atlag / napiTermeles) / 100, 2);
                Console.WriteLine($"{i + 1} napon az átlag: {atlag} méter");
            }

            int minIndex = 0;

            for(int i = 0; i < fakMagassa.Length ; i++)
            {
                if (fakMagassa[i] < fakMagassa[minIndex])
                {
                    minIndex = i;
                }
            }

            int nap = minIndex / napiTermeles + 1;
            int magassag = fakMagassa[minIndex];

            Console.WriteLine($"A legkisebb fa a {nap}. napon volt és {magassag} volt a magassága");

            // Egyik megoldás
            int[] osszegNaponta = new int[14];

            for(int i = 0; i < 14; i++)
            {
                int osszeg = 0;
                for(int j = 0; j < napiTermeles; j++)
                {
                    osszeg += fakMagassa[j + i * napiTermeles] / 100 * 500;
                }
                Console.WriteLine($"{i + 1}. napon {osszeg} Ft bevételre számíthatunk");
                osszegNaponta[i] = osszeg;
            }

            int maxIndex = 0;
            for (int i = 0;i < osszegNaponta.Length; i++)
            {
                if (osszegNaponta[i] > osszegNaponta[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine($"A legnagyobb bevételt a {maxIndex + 1}. napon volt, ami {osszegNaponta[maxIndex]} Ft.");

            // Másik megoldás

            int maxNap = 0;
            int max = 0;

            for (int i = 0; i < 14; i++)
            {
                int osszeg = 0;
                for (int j = 0; j < napiTermeles; j++)
                {
                    osszeg += fakMagassa[j + i * napiTermeles] / 10 * 500;
                }
                Console.WriteLine($"{i + 1}. napon {osszeg} Ft bevételre számíthatunk");
                if (osszeg > max)
                {
                    max = osszeg;
                    maxNap = i;
                }
            }
            Console.WriteLine($"A legnagyobb bevételt a {maxNap + 1}. napon volt, ami {max} Ft.");
            Console.ReadLine();
        }
    }
}
