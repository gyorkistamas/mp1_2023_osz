
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_fuggvenyek
{
    internal class Program
    {
        static int EllenorzottBekeres(string szoveg = "Adj meg egy számot: ")
        {
            int szam = 0;
            do
            {
                Console.Write(szoveg);
            } while (!int.TryParse(Console.ReadLine(), out szam));

            return szam;
        }


        static void Noveles(int szam)
        {
            Console.WriteLine($"A szám értéke növelés előtt: {szam}");
            szam++;
            Console.WriteLine($"A szám értéke növelés után: {szam}");
        }

        static void Kiir(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{lista[i]} ");
            }
        }

        static void TizesHozzadasaListahoz(List<int> lista)
        {
            Console.WriteLine("\nA lista elemei a hozzáadás előtt: ");
            Kiir(lista);

            lista.Add(10);

            Console.WriteLine("\nA lista elemei a hozzáadás után: ");
            Kiir(lista);
        }

        static void Noveles2(ref int szam)
        {
            szam++;
        }

        static void Ertekadas(out int szam)
        {
            szam = 10;
        }


        static void Main(string[] args)
        {
            //int szam1 = EllenorzottBekeres("Adja meg az első számot: ");
            //int szam2 = EllenorzottBekeres("Adja meg az második számot: ");
            //int szam3 = EllenorzottBekeres("Adja meg az harmadik számot: ");

            //int szam4 = EllenorzottBekeres();
            //int szam5 = EllenorzottBekeres();
            //int szam6 = EllenorzottBekeres();
            int asd = 10;
            Console.WriteLine($"A szám értéke metódushívás előtt: {asd}");
            Noveles(asd);
            Console.WriteLine($"A szám értéke metódushívás után: {asd}");

            Console.WriteLine($"A szám értéke metódushívás előtt: {asd}");
            Noveles2(ref asd);
            Console.WriteLine($"A szám értéke metódushívás után: {asd}");

            Console.WriteLine("\n\n\n");

            List<int> szamok = new List<int>();
            szamok.Add(1);
            szamok.Add(2);
            szamok.Add(3);

            Console.WriteLine("\nA lista értékei metódus hívás előtt: ");
            Kiir(szamok);

            TizesHozzadasaListahoz(szamok);

            Console.WriteLine("\nA lista értékei metódus hívás után: ");
            Kiir(szamok);

            int valami;
            Ertekadas(out valami);
            Console.WriteLine(valami);

            Console.ReadLine();
        }
    }
}
