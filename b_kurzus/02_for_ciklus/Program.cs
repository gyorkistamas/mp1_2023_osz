using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_for_ciklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Meddig szeretné a számokat kiírni: ");

            int darab = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < darab; i += 2)
            {
                //if (i % 2 == 0)
                //{
                //    Console.WriteLine(i);
                //}

                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
