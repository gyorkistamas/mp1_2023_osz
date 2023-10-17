using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _12_zh1_feladat_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg hány versenyző indult: ");
            int versenyzokSzama = int.Parse(Console.ReadLine());

            if (versenyzokSzama < 3)
            {
                Console.WriteLine("Legalább 3 versenyzőnek kell lennie!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            double[] ertekelesek = new double[versenyzokSzama * 5];

            Random rnd = new Random();

            for(int i = 0; i < ertekelesek.Length; i++)
            {
                // rnd.NextDouble() * (felsőHatár - alsóHatár) + alsóHatár
                ertekelesek[i] = Math.Round(rnd.NextDouble() * 5, 2);
            }

            double[] atlagok = new double[versenyzokSzama];
            for(int i = 0; i < versenyzokSzama; i++)
            {
                double atlag = 0;

                for(int j = 0; j < 5; j++)
                {
                    atlag = atlag + ertekelesek[j + i * 5];
                }

                atlag = atlag / 5;
                atlagok[i] = atlag;
                Console.WriteLine($"A {i + 1}. versenyző átlaga: {atlag}");
            }

            int maxPontSzamIndex = 0;

            for(int i = 0; i < ertekelesek.Length; i++)
            {
                if (ertekelesek[i] > ertekelesek[maxPontSzamIndex])
                {
                    maxPontSzamIndex = i;
                }
            }

            Console.WriteLine($"A legmagasabb pontszámot a {maxPontSzamIndex / 5 + 1}. versenyző szerezte: {ertekelesek[maxPontSzamIndex]}");

            for(int i = 0; i < versenyzokSzama; i++)
            {
                bool benaE = true;

                for (int j = 0; j < 5; j++)
                {
                    if (ertekelesek[j + i * 5] > 2.00)
                    {
                        benaE = false;
                    }
                }
                Console.WriteLine($"A {i + 1}. versenyző {(benaE ? "" : "nem")} béna");
            }

            int nyertesIndex = 0;
            for (int i = 0; i < atlagok.Length; i++)
            {
                if (atlagok[i] > atlagok[nyertesIndex])
                {
                    nyertesIndex = i;
                }
            }

            Console.WriteLine($"A nyertes a {nyertesIndex + 1}. versenyző {atlagok[nyertesIndex]} átlagos ponttal");

            Console.ReadLine();
        }
    }
}
