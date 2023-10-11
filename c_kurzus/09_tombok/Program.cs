using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg milyen hosszú legyen a tömb: ");

            // Ellenőrzés
            int hossz = Convert.ToInt32(Console.ReadLine());

            int[] szamok = new int[hossz];

            for(int i = 0; i < szamok.Length; i++)
            {
                do
                {
                    Console.Write($"Adja meg az {i + 1}. számot: ");
                } while (!int.TryParse(Console.ReadLine(), out szamok[i]));
            }

            for(int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            // Maximum

            int max = szamok[0];

            for(int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }
            }

            Console.WriteLine($"A legnagyobb szám: {max}");

            // Minimum hely keresés

            int minHely = 0;

            for(int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] <= szamok[minHely])
                {
                    minHely = i;
                }
            }

            Console.WriteLine($"A legkisebb elem a {minHely}. indexen található.");

            // Megszámlálás 3-nál nagyobb számok

            int darab = 0;

            for(int i = 0; i < szamok.Length;i++)
            {
                if (szamok[i] > 3)
                {
                    darab++; // darab = darab + 1;
                }
            }

            Console.WriteLine($"A tömbben {darab}. darab 3-nál nagyobb szám van");

            // összegzés

            int osszeg = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }


            Console.WriteLine($"A tömb összege: {osszeg}");
            Console.ReadLine();
        }
    }
}
