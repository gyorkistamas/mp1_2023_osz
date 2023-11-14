using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_alprogramok
{
    internal class Program
    {
        static int EllenorzottBekeres(string szoveg = "Adjon meg egy számot: ")
        {
            Console.Write(szoveg);
            int szam = 0;
            while(!int.TryParse(Console.ReadLine(), out szam))
            {
                Console.Write("Nem számot adott meg, próbálja újra: ");
            }
            return szam;
        }

        static void EllenorzottBekeres2(out int visszatero, string szoveg = "Adjon meg egy számot: ")
        {
            Console.Write(szoveg);
            while (!int.TryParse(Console.ReadLine(), out visszatero))
            {
                Console.Write("Nem számot adott meg, próbálja újra: ");
            }
        }

        static bool PozitivE()
        {
            int szam = EllenorzottBekeres("Adjon meg egy számot: ");

            //if (szam > 0)
            //{
            //    return true;
            //}
            //return false;
            return szam > 0;
        }

        static void MegnovelEggyel(int szam)
        {
            Console.WriteLine($"A szám értéke növelés előtt: {szam}");
            szam++;
            Console.WriteLine($"A szám értéke növelés után: {szam}");
        }

        static void MegnovelEggyelRef(ref int szam)
        {
            Console.WriteLine($"A szám értéke növelés referencia előtt: {szam}");
            szam++;
            Console.WriteLine($"A szám értéke növelés referencia után: {szam}");
        }

        static void Main(string[] args)
        {
            //PozitivE();
            //int szam1 = EllenorzottBekeres("Adja meg az elsőt: ");
            //int szam2 = EllenorzottBekeres();

            int valami = 10;
            Console.WriteLine($"A szám értéke metódus hívás előtt: {valami}");
            MegnovelEggyel(valami);
            Console.WriteLine($"A szám értéke metódus hívás után: {valami}");

            Console.WriteLine("\n\n");

            Console.WriteLine($"A szám értéke metódus hívás előtt (referencia): {valami}");
            MegnovelEggyelRef(ref valami);
            Console.WriteLine($"A szám értéke metódus hívás után (referencia): {valami}");

            int szam3 = 0;
            EllenorzottBekeres2(out szam3);

            Console.ReadLine();
        }
    }
}
