using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_gyak_megoldas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Milyen típusú a gépjármű?");
            string gepjarmuTipus = Console.ReadLine();

            Console.WriteLine("Milyen típusú benzinnel tankolt?");
            int benzinTipus = 0;
            while (!int.TryParse(Console.ReadLine(), out benzinTipus) || (benzinTipus != 95 && benzinTipus != 100))
            {
                Console.WriteLine("Rossz számot adott meg! Próbálja meg újra.");
            }
            Console.WriteLine("Adja meg mennyit tankolt: ");
            double mennyiseg = 0;
            while (!double.TryParse(Console.ReadLine(), out mennyiseg) || (mennyiseg < 1 || mennyiseg > 50))
            {
                Console.WriteLine("Nem megfelelő mennyiséget adott meg. Próbálja újra: ");
            }

            double osszeg = 0;

            if (benzinTipus == 95)
            {
                if (gepjarmuTipus == "cég")
                {
                    osszeg = mennyiseg * 800;
                }
                else if (gepjarmuTipus == "magán")
                {
                    osszeg = mennyiseg * 480;
                }
            }
            else
            {
                osszeg = mennyiseg * 830;
            }

            osszeg = Math.Round(osszeg);

            Console.WriteLine("Van pontkártyája?");
            string kartya = Console.ReadLine();
            if (kartya == "igen")
            {
                int pont = (int)mennyiseg;
                if (benzinTipus == 100)
                {
                    pont *= 5; // pont = pont * 5;
                }
                Console.WriteLine($"Szerzett pont: {pont}");
            }
            Console.WriteLine("Viszontlátásra.");

            Console.ReadLine();
        }
    }
}
