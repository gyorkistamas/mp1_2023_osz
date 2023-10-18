using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_megoldas_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg milyen hosszú legyen a tömb: ");

            int hossz = int.Parse(Console.ReadLine());

            int[] szamok = new int[hossz];


            Console.Write("Adja meg az alsó határt: ");

            int alsoHatar = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a felső határt: ");

            int felsoHatar = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for(int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(alsoHatar, felsoHatar + 1);
            }

            // Egyik megoldás
            for( int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i]);
                if (i != szamok.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            // Másik megoldás
            for (int i = 0; i < szamok.Length - 1; i++)
            {
                Console.Write($"{szamok[i]}, ");
            }
            Console.Write(szamok[szamok.Length - 1]);

            // Nyilak

            for (int i = 0; i < szamok.Length - 1; i++)
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" --> ");
            }
            if (szamok[szamok.Length - 1] % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.Write(szamok[szamok.Length - 1]);

            Console.ForegroundColor = ConsoleColor.White;

            int osszeg = 0;
            for(int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0 || szamok[i] < 0)
                {
                    osszeg += szamok[i];
                }
            }
            Console.WriteLine($"A páros vagy negatív számok összege: {osszeg}");

            double atlag = 0;
            double darab = 0;
            for (int i = 0;i < szamok.Length;i++)
            {
                if (szamok[i] % 3 == 0 || szamok[i] > 0)
                {
                    atlag += szamok[i];
                    darab++;
                }
            }
            atlag = atlag / darab;
            Console.WriteLine($"A 3-al osztható vagy pozitív számok átlaga: {atlag}");

            Console.ReadLine();
        }
    }
}
