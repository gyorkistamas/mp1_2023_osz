using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az első számot: ");
            double elso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem a második számot: ");
            double masodik = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem a műveletet: ");
            string muvelet = Console.ReadLine();

            //if (muvelet == "+")
            //{
            //    Console.WriteLine("{0} + {1} = {2}", elso, masodik, elso + masodik);
            //}
            //else if (muvelet == "-")
            //{
            //    Console.WriteLine("{0} - {1} = {2}", elso, masodik, elso - masodik);
            //}
            //else if (muvelet == "*")
            //{
            //    Console.WriteLine("{0} * {1} = {2}", elso, masodik, elso * masodik);
            //}
            //else if (muvelet == "/")
            //{
            //    Console.WriteLine("{0} / {1} = {2}", elso, masodik, elso / masodik);
            //}
            //else
            //{
            //    Console.WriteLine("A megadott művelet nem létezik!");
            //}

            switch(muvelet)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", elso, masodik, elso + masodik);
                    break;

                case "-":
                    Console.WriteLine("{0} - {1} = {2}", elso, masodik, elso - masodik);
                    break;

                case "*":
                    Console.WriteLine("{0} * {1} = {2}", elso, masodik, elso * masodik);
                    break;

                case "/":
                    Console.WriteLine("{0} / {1} = {2}", elso, masodik, elso / masodik);
                    break;

                default:
                    Console.WriteLine("A megadott művelet nem létezik!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
