using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();

            szamok.Add(50);
            szamok.Add(10);
            szamok.Add(20);
            szamok.Add(10);

            for(int i = 0; i < szamok.Count;i++)
            {
                Console.WriteLine(szamok[i]);
            }

            szamok.Remove(10);
            Console.WriteLine("-------------------");
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.WriteLine(szamok[i]);
            }


            szamok.RemoveAt(0);
            Console.WriteLine("-------------------");
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.WriteLine(szamok[i]);
            }


            szamok.Insert(0,500);
            Console.WriteLine("-------------------");
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            Console.ReadLine();
        }
    }
}
