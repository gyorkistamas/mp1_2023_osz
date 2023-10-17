using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_2_megoldas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a
            Console.Write("Adja meg milyen hosszú legyen a tömb:");
            int hossz = int.Parse(Console.ReadLine());
            int[] szamok = new int[hossz];

            // b
            Console.Write("Adja meg az alsó határt: ");
            int alsoHatar = int.Parse(Console.ReadLine());

            // Vizsgálni kéne, hogy nagyobb legyen, mint az alsó határ
            Console.Write("Adja meg az felső határt: ");
            int felsoHatar = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for(int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(alsoHatar, felsoHatar + 1);
            }

            // c: 1. megoldás
            for(int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i]);
                if (i != szamok.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            // c: 2. megoldás
            for (int i = 0; i < szamok.Length - 1; i++)
            {
                Console.Write($"{szamok[i]}, ");
            }
            Console.WriteLine(szamok[szamok.Length - 1]);

            // d
            for (int i = 0;i < szamok.Length;i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.Write(szamok[i]);

                if (i != szamok.Length - 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" --> ");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            // e
            int osszeg = 0;
            for(int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0 || szamok[i] < 0)
                {
                    osszeg += szamok[i];
                }
            }
            Console.WriteLine($"A páros vagy negatív számok összege: {osszeg}");

            //g
            int maxHely = 0;
            int minHely = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] > szamok[maxHely])
                {
                    maxHely = i;
                }

                if (szamok[i] < szamok[minHely])
                {
                    minHely = i;
                }
            }

            Console.WriteLine($"A legkisebb szám a {minHely}. indexen található, értéke: {szamok[minHely]}");

            Console.WriteLine($"A legnagyobb szám a {maxHely}. indexen található, értéke: {szamok[maxHely]}");

            //h
            bool vanENegativEgyjegyu = false;
            for (int i = 0;i < szamok.Length;i++)
            {
                if (szamok[i] > -10 && szamok[i] < 0)
                {
                    vanENegativEgyjegyu = true;
                    break;
                }
            }

            //if (vanENegativEgyjegyu)
            //{
            //    Console.WriteLine("Van egyjegyű negatív szám a tömbben");
            //}
            //else
            //{
            //    Console.WriteLine("Nincs egyjegyű negatív szám a tömbben");
            //}

            Console.WriteLine($"{(vanENegativEgyjegyu ? "Van" : "Nincs")} egyjegyű negatív szám a tömbben");


            Console.ReadLine();
        }
    }
}
