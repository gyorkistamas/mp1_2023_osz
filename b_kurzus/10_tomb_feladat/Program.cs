using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_tomb_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Nullánál nagyobb legyen
            Console.Write("Adja meg milyen hosszú legyen a tömb: ");
            int hossz = Convert.ToInt32(Console.ReadLine());

            int[] szamok = new int[hossz];

            Console.Write("Adja meg az alsó határt: ");
            int alsoHatar = Convert.ToInt32(Console.ReadLine());

            // Nagyobb (vagy egyenlő), mint az alsó határ
            Console.Write("Adja meg az felső határt: ");
            int felsoHatar = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(alsoHatar, felsoHatar + 1);
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i]);
                if ( i != szamok.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            //Console.ForegroundColor = ConsoleColor.DarkGreen;

            // 5.2-es feladat befejezése


            Console.ReadLine();
        }
    }
}
