using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_kulonbozo_szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[5];

            Random rnd = new Random();

            for(int i = 0; i < szamok.Length; i++)
            {
                int generaltSzam = 0;
                bool benneVane;
                do
                {
                    benneVane = false;
                    generaltSzam = rnd.Next(1, 6);
                    for(int j = 0; j < szamok.Length; j++)
                    {
                        if (szamok[j] == generaltSzam)
                        {
                            benneVane = true;
                            break;
                        }
                    }
                } while (benneVane);

                szamok[i] = generaltSzam;
            }

            for(int i = 0;i < szamok.Length;i++)
            {
                Console.WriteLine(szamok[i]);
            }


            Console.ReadLine();
        }
    }
}
