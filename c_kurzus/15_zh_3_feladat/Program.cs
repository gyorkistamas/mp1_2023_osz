using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_zh_3_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg hány versenyző indult: ");
            int versenyzokSzama = 0;

            if (!int.TryParse(Console.ReadLine(), out versenyzokSzama) || versenyzokSzama < 3)
            {
                Console.WriteLine("Legalább 3 versenyzőnek kell lennie!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            double[] eredmenyek = new double[versenyzokSzama * 5];

            Random rnd = new Random();
            for(int i = 0; i < eredmenyek.Length; i++)
            {
                // rnd.NextDouble() * (felsőhatár - alsóHatár) + alsóHatár
                // rnd.NextDouble() * (5 - 0) + 0
                eredmenyek[i] = Math.Round(rnd.NextDouble() * 5, 2);
            }

            double[] atlagok = new double[versenyzokSzama];
            for(int versenyzoIndex = 0; versenyzoIndex < versenyzokSzama; versenyzoIndex++)
            {
                double atlag = 0;
                // Azért 5, mert minden versenyzőnek 5 db értékelése van
                for(int versenyzoEredmenyeIndex = 0; versenyzoEredmenyeIndex < 5; versenyzoEredmenyeIndex++)
                {
                    atlag += eredmenyek[versenyzoEredmenyeIndex + versenyzoIndex * 5];
                }
                atlag = atlag / 5;
                atlagok[versenyzoIndex] = atlag;
                Console.WriteLine($"A {versenyzoIndex + 1}. versenyző átlaga: {atlag}");
            }

            int maxHely = 0;
            for (int i = 0; i < eredmenyek.Length;i++)
            {
                if (eredmenyek[i] > eredmenyek[maxHely])
                {
                    maxHely = i;
                }
            }
            Console.WriteLine($"A legnagyobb eredményt a {maxHely / 5 + 1}. versenyző érte el, ez: {eredmenyek[maxHely]}");

            for(int i = 0; i < versenyzokSzama; i++)
            {
                bool bena = true;

                for (int j = 0; j < 5; j++)
                {
                    if (eredmenyek[j + i * 5] > 2.00)
                    {
                        bena = false;
                    }
                }
                Console.WriteLine($"A {i + 1}. versenyző {(bena ? "" : "nem")} béna");
                //if (bena)
                //{
                //    Console.WriteLine("A versenyző béna");
                //}
                //else
                //{
                //    Console.WriteLine("A versenyző nem béna!");
                //}
            }

            int nyertesHely = 0;
            for (int i = 0; i < atlagok.Length; i++)
            {
                if (atlagok[i] > atlagok[nyertesHely])
                {
                    nyertesHely = i;
                }
            }
            Console.WriteLine($"A nyertes a {nyertesHely + 1}. versenyző {atlagok[nyertesHely]} átlagponttal.");

            Console.ReadLine();
        }
    }
}
