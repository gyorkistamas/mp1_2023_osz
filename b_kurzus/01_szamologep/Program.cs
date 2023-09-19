using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_szamologep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az első számot: ");

            double elsoSzam = Convert.ToDouble(Console.ReadLine());

            Console.Write("Adja meg a második számot: ");

            double masodikSzam = Convert.ToDouble(Console.ReadLine());

            Console.Write("Milyen műveletet szeretne elvégezni: ");

            string muvelet = Console.ReadLine();

            //if (muvelet == "+")
            //{
            //    Console.WriteLine("{0} + {1} = {2}", elsoSzam, masodikSzam, elsoSzam + masodikSzam);
            //}
            //else if( muvelet == "-")
            //{
            //    Console.WriteLine("{0} - {1} = {2}", elsoSzam, masodikSzam, elsoSzam - masodikSzam);
            //}
            //else if (muvelet == "*")
            //{
            //    Console.WriteLine("{0} * {1} = {2}", elsoSzam, masodikSzam, elsoSzam * masodikSzam);
            //}
            //else if (muvelet == "/")
            //{
            //    Console.WriteLine("{0} / {1} = {2}", elsoSzam, masodikSzam, elsoSzam / masodikSzam);
            //}
            //else
            //{
            //    Console.WriteLine("Ilyen művelet nem létezik!");
            //}


            switch (muvelet)
            {
                case "+":
                case "osszeadas:":
                    Console.WriteLine("{0} + {1} = {2}", elsoSzam, masodikSzam, elsoSzam + masodikSzam);
                    break;

                case "-":
                    Console.WriteLine("{0} - {1} = {2}", elsoSzam, masodikSzam, elsoSzam - masodikSzam);
                    break;

                case "*":
                    Console.WriteLine("{0} * {1} = {2}", elsoSzam, masodikSzam, elsoSzam * masodikSzam);
                    break;

                case "/":
                    Console.WriteLine("{0} / {1} = {2}", elsoSzam, masodikSzam, elsoSzam / masodikSzam);
                    break;

                default:
                    Console.WriteLine("Hibás opeártort adott meg!");
                    break;
            }


            Console.ReadLine();
        }
    }
}
