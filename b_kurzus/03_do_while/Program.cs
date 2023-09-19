using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //while(szoveg != "stop")
            //{
            //    Console.Write("Adja meg a következő sor szöveget: ");
            //    szoveg = Console.ReadLine();
            //}

            int szam = 0;

            // [10; 20]

            do
            {
                Console.Write("Adjon meg egy egész számot: ");
            } while (!int.TryParse(Console.ReadLine(), out szam) || szam < 10 || szam > 20);

            Console.ReadLine();
        }
    }
}
