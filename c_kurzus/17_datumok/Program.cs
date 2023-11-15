using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_datumok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime datum = new DateTime(2001, 5, 10, 10, 5, 15);

            Console.WriteLine(datum);

            Console.WriteLine(datum.Year);

            Console.WriteLine(datum.ToString("yyyy. MMMM d."));

            string datumString = "2002/7/10";

            DateTime konvertalt = DateTime.Parse(datumString);
            Console.WriteLine(konvertalt);



            DateTime maiDatum = DateTime.Now;
            DateTime szuletes = new DateTime(2001, 4, 30);

            TimeSpan elteltIdo = maiDatum - szuletes;

            Console.WriteLine(elteltIdo);

            Console.WriteLine(elteltIdo.TotalDays / 365);


            List<int> szamok = new List<int>();

            //int sum = szamok.Sum();
            //double avg = szamok.Average();
            //int min = szamok.Min();
            //int max = szamok.Max();

            Dictionary<string, int> statisztika = new Dictionary<string, int>();

            statisztika.Add("MP1", 10);
            statisztika.Add("Kalkulus", 20);

            Console.WriteLine($"Kalkuluson ennyien mentek át: {statisztika["Kalkulus"]}");
            statisztika["Kalkulus"] = 300;
            Console.ReadLine();
        }
    }
}
