using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_listak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();

            szamok.Add(1);
            szamok.Add(2);
            szamok.Add(3);
            szamok.Add(4);
            szamok.Add(5);

            szamok[2] = 10;

            szamok.Remove(5);

            // Összes 5-ös törlése
            while(szamok.Contains(5))
            {
                szamok.Remove(5);
            }

            szamok.RemoveAt(0);

            int osszeg = szamok.Sum();
            double atlag = szamok.Average();
            int min = szamok.Min();
            int max = szamok.Max();

            szamok.Insert(2, 300);
            Console.ReadLine();
        }
    }
}
