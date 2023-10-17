using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_stringek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szoveg = "görög";

            Console.WriteLine(szoveg[1]);

            for(int i = szoveg.Length - 1; i >= 0; i--)
            {
                Console.Write(szoveg[i]);
            }

            // Palindrom
            bool palindrom = true;
            for(int i = 0; i < szoveg.Length / 2; i++)
            {
                if (szoveg[i] != szoveg[szoveg.Length - 1 - i])
                {
                    palindrom = false;
                }
            }

            Console.WriteLine(palindrom);


            Console.ReadLine();
        }
    }
}
