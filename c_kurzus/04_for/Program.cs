using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0-től 99-ig a számokat

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 0-tól 99-ig a páros számokat
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 0; i < 100; i += 2) // i = i + 2
            //{
            //    Console.WriteLine(i);
            //}

            //Számok 100-tól 0-ig
            for(int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
