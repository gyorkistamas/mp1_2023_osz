using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_stringek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "görög";

            Console.Write(szoveg[1]);

            string fordiott = "";
            Console.WriteLine();

            for (int i = szoveg.Length - 1; i >=0; i--)
            {
                fordiott = fordiott + szoveg[i];
            }

            Console.WriteLine(fordiott);

            bool palindrom = true;
            for(int i = 0; i < szoveg.Length / 2; i++)
            {
                if (szoveg[i] != szoveg[szoveg.Length - 1 - i])
                {
                    palindrom = false;
                }
            }
            Console.WriteLine($"A megadott szöveg {(palindrom ? "" : "nem")} palindrom");

            Console.ReadLine();
        }
    }
}
