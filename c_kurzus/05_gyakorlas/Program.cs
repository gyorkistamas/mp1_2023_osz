using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bruttoBer = 0;

            Console.Write("Adja meg a keresett bruttó bért: ");

            if (!int.TryParse(Console.ReadLine(), out bruttoBer) || bruttoBer < 2100)
            {
                Console.WriteLine("Hibás értéket adott meg!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            double adoSzazalek = 0;

            if (bruttoBer >= 2100 && bruttoBer < 4200)
            {
                adoSzazalek = 0.1;
            }
            else if (bruttoBer >= 4200 && bruttoBer < 8000)
            {
                adoSzazalek = 0.2;
            }
            else if (bruttoBer >= 8000 && bruttoBer < 15000)
            {
                adoSzazalek = 0.3;
            }
            else
            {
                adoSzazalek = 0.4;
            }

            int eltartottGyerekDb = 0;

            Console.Write("Adja meg az eltartott gyerekek számát: ");

            if (!int.TryParse(Console.ReadLine(), out eltartottGyerekDb) || eltartottGyerekDb < 0 || eltartottGyerekDb > 69)
            {
                Console.WriteLine("Hibás adat!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            switch(eltartottGyerekDb)
            {
                case 0:
                    break;
                case 1:
                    adoSzazalek *= 0.9; // adoszazalek = adoszazalek * 0.9
                    break;
                case 2:
                    adoSzazalek *= 0.8;
                    break;
                case 3:
                    adoSzazalek *= 0.7;
                    break;
                default:
                    adoSzazalek *= 0.6;
                    break;
            }

            int nettoBer = (int)(bruttoBer - (bruttoBer * adoSzazalek));

            nettoBer = (int)((nettoBer / 10) * 10);

            Console.WriteLine("A nettó érték: {0}", nettoBer);

            Console.ReadLine();
        }
    }
}
