
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_kiiratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();

            nevek.Add("Tamás");
            nevek.Add("Áron");
            nevek.Add("Péter");
            nevek.Add("Balázs");

            StreamWriter sr = new StreamWriter("nevek.txt", true);

            for(int i = 0; i < nevek.Count; i++)
            {
                sr.Write(nevek[i]);
            }

            sr.Close();

            Console.ReadLine();
        }
    }
}
