using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_random_szamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for(int i = 0; i < 10; i++)
            {
                // 10 és 50 közötti számok
                // [10;51)
                int generalt = rnd.Next(10,51);
                Console.WriteLine(generalt);
            }

            for(int i = 0;i < 10;i++)
            {
                //[10;50] közötti két tizedes jegyű véletlen szám
                // rnd.NextDouble() * (felsőhatár - alsóhatár) + alsóhatár
                double generalt = Math.Round(rnd.NextDouble() * (50 - 10) + 10, 2);
                Console.WriteLine(generalt);
            }

            Console.ReadLine();
        }
    }
}
