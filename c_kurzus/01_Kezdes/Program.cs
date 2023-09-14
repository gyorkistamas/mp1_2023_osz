using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Kezdes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kérjük be egy téglalap 'a' és 'b' oldalhosszúságát, és irassuk ki a terület és kerület értékeket (valamint a használt képletet is).
             * T = a*b
             * K = 2*(a +b)
             */

            Console.Write("Kérem, adja meg az a oldal hosszát: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nKérem, adja meg a b oldal hosszát: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double terulet = a * b;

            double kerulet = 2 * (a + b);

            Console.WriteLine("\nA téglalap területe: {0}\n\nA téglalap kerülete: {1}", terulet, kerulet);

            //Console.WriteLine("A téglalap kerülete: {0}", kerulet);

            Console.ReadLine();
        }
    }
}
