using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Számok 0-tól 100-ig");

            //int szam = 0;

            //while(szam <= 100)
            //{
            //    Console.WriteLine(szam);
            //    szam++;
            //    //szam = szam + 1;
            //}

            //Console.Write("Adjon meg egy számot:");

            int szam = 0;

            //if (int.TryParse(Console.ReadLine(), out szam))
            //{
            //    Console.WriteLine("Sikerült a konverzió!");
            //}
            //else
            //{
            //    Console.WriteLine("Nem sikerült!");
            //}

            // [10; 20]

            //do
            //{
            //    Console.Write("Kérem adjon meg egy számot: ");
            //} while (!int.TryParse(Console.ReadLine(), out szam) || szam < 10 || szam > 20);

            //Console.Write("Helyes számot adott meg!");

            //100-nál nagyobb számokat fogadjuk el

            Console.Write("Adjon meg egy számot:");

            if (int.TryParse(Console.ReadLine(), out szam) && szam > 100)
            {
                Console.WriteLine("Sikerült a konverzió!");
            }
            else
            {
                Console.WriteLine("Nem sikerült!");
            }

            Console.ReadLine();
        }
    }
}
