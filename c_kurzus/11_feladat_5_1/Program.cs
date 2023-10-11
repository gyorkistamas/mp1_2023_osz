using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_feladat_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az osztály létszámát: ");

            //Hf:ellenőrizni
            int letszam = Convert.ToInt32(Console.ReadLine());

            int[] jegyek = new int[letszam];

            for (int i = 0; i < jegyek.Length; i++)
            {
                Console.Write($"Adja meg az {i + 1}. diák jegyét:");
                // HF: ellenőrizni
                jegyek[i] = Convert.ToInt32(Console.ReadLine());
            }

            double atlag = 0;

            for (int i = 0; i < jegyek.Length; i++)
            {
                atlag += jegyek[i];
            }

            atlag = atlag / jegyek.Length;

            Console.WriteLine($"Az átlag: {atlag}");

            int jobbJegyekDarab = 0;

            for(int i = 0; i < jegyek.Length;i++)
            {
                if (jegyek[i] > atlag)
                {
                    jobbJegyekDarab++;
                }
            }

            Console.WriteLine($"{jobbJegyekDarab} darab tanuló ért el jobb eredményt, mint az átlag.");


            // Console.ForeGrounColor
            Console.ReadLine();
        }
    }
}
