using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _05_gyak_megoldas_kozos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ellenőrizni, hogy tényleg csak magán vagy céges-et ír be
            Console.Write("A gépjármű típusa: ");
            string vehicleType = Console.ReadLine();

            int fuel = 0;
            do
            {
                Console.WriteLine("Milyen benzint használsz?");
                
            } while (!int.TryParse(Console.ReadLine(), out fuel)|| (fuel != 95 && fuel !=100) );

            double tankoltLiter = 0;
            //do
            //{
            //    Console.WriteLine("Adja meg hány litert tankolt:");
            //} while (!double.TryParse(Console.ReadLine(), out tankoltLiter) || tankoltLiter <1 || tankoltLiter>50);

            Console.Write("Adja meg mennyit tankolt: ");

            while(!double.TryParse(Console.ReadLine(), out tankoltLiter) || tankoltLiter < 1 || tankoltLiter > 50)
            {
                Console.Write("Rossz értéket adott meg, kérjük adja meg újra: ");
            }

            double cost = 0;
            if (fuel==100)
            {
                cost = tankoltLiter * 830;
            }
            else
            {
                if (vehicleType == "magánszemély")
                {
                    cost = tankoltLiter * 480;
                }
                else
                {
                    cost = tankoltLiter * 800;
                }
            }
            cost=Math.Round(cost);
            Console.WriteLine($"A fizetendő összeg: {cost} Ft");

            // Ellenőrizni, hogy csak igent vagy nem-et ír be
            Console.WriteLine("Van pontgyűjtő kártyája?");
            string card = Console.ReadLine();


            if (card == "igen")
            {
                int points = (int)tankoltLiter;
                if (fuel == 100)
                {
                    points *= 5;
                }
                Console.WriteLine($"Hűségpontok: {points}");
            }
            Console.WriteLine("Viszont látásra!");


            Console.ReadLine();
        }
    }
}
