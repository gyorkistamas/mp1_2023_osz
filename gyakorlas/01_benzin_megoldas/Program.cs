using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_benzin_megoldas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Milyen típusú a gépjármű? ");
            // A feladat nem kért ellenőrzést, úgyhogy csak eltároljuk
            string autoTipus = Console.ReadLine();

            int benzinTipus = 0;

            // Ellenőrzött bekérés
            do
            {
                Console.Write("\nAdja meg a tankolandó benzin típusát (95 vagy 100): ");
            } while (!int.TryParse(Console.ReadLine(), out benzinTipus) || (benzinTipus != 95 && benzinTipus != 100));

            double tankoltMennyiseg = 0;

            // Ellenőrzött bekérés
            do
            {
                Console.Write("\nAdja meg a tankolandó benzin mennyiségét literben (1-50): ");
            } while (!double.TryParse(Console.ReadLine(), out tankoltMennyiseg) || tankoltMennyiseg < 1 || tankoltMennyiseg > 50);

            int ar = 0;

            /*
             * Ha 95-öt írt be a felhasználó, akkor megnézzük, hogy milyen kocsija van; ha magánszemély, akkor 480 forint 1 liter ára, egyébknét cégesnek 800.
             * 
             * Ha nem 95-öt írt be, akkor 100-at, úgyhogy elég itt egy else ág, ebben az
             * esetben magán és céges esetén is 830 az ár a táblázat szerint, úgyhogy nem
             * kell levizsgálni a kocsi típusát.
             */
            if (benzinTipus == 95)
            {
                if (autoTipus == "magánszemély")
                    ar = 480;
                else
                    ar = 800;
            }
            else
            {
                ar = 830;
            }

            // Fizetendőt számoljuk, kerekítjük
            int fizetendo = (int)Math.Round(tankoltMennyiseg * ar);

            Console.WriteLine("\nA fizetendő összeg: {0} Ft", fizetendo);

            // Itt megint nem kért ellenőrzést a feladat
            Console.Write("\nVan pontgyűjtőkártyája? ");
            string pontGyujto = Console.ReadLine();

            /*
             * Ha van kártyája, akkor kiszámoljuk a pontokat.
             * Ha magánszemély, akkor literenként 1 pontot kap, szóval elég, ha csak
             * lekerekítjük a tankolt mennyiséget. (Lefele kerekítés a Math.Floor)
             * 
             * Ha 100-ast tankolt, akkor ezt megszorozzuk 5-tel.
             */ 
            if (pontGyujto == "igen")
            {
                int pontok = (int)Math.Floor(tankoltMennyiseg);

                if (benzinTipus == 100)
                {
                    pontok *= 5;
                }

                Console.WriteLine("\nÖnnek {0} pontot írunk fel hűségkártyájára!", pontok);
            }

            Console.WriteLine("\nViszontlátásra!");

            Console.ReadLine();
        }
    }
}
