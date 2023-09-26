using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int keresettBruttoBer = 0;

            Console.Write("Írja be a bruttó keresetét: ");

            if (!int.TryParse(Console.ReadLine(), out keresettBruttoBer) || keresettBruttoBer < 2100)
            {
                Console.WriteLine("A megadott érték hibás!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            double adoSzazalek = 0;

            if (keresettBruttoBer >= 2100 && keresettBruttoBer < 4200)
            {
                adoSzazalek = 0.1;
            }
            else if (keresettBruttoBer >= 4200 && keresettBruttoBer < 8000)
            {
                adoSzazalek = 0.2;
            }
            else if (keresettBruttoBer >= 8000 && keresettBruttoBer < 15000)
            {
                adoSzazalek = 0.3;
            }
            else
            {
                adoSzazalek = 0.4;
            }

            int eltartottGyerekekDb = 0;

            Console.Write("Adja meg a gyerekek számát: ");

            if (!int.TryParse(Console.ReadLine(), out eltartottGyerekekDb) || eltartottGyerekekDb < 0 || eltartottGyerekekDb > 69)
            {
                Console.WriteLine("Hibás a megadott érték!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            switch(eltartottGyerekekDb)
            {
                case 0:
                    break;

                case 1:
                    adoSzazalek *= 0.9;
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

            int keresettNettoBer = (int)(keresettBruttoBer - (keresettBruttoBer * adoSzazalek));

            keresettNettoBer = (keresettNettoBer / 10) * 10;

            Console.WriteLine("Az ön keresett nettó bére: {0} guba", keresettNettoBer);

            Console.ReadLine();
        }
    }
}
