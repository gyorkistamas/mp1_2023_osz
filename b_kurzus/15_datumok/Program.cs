using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_datumok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime datum = new DateTime(2001, 5, 10);

            Console.WriteLine(datum.Month);

            datum = datum.AddYears(1);
            Console.WriteLine(datum);

            Console.WriteLine(datum.ToString("yyyy. MMMM d."));

            DateTime maiDatum = DateTime.Today;

            TimeSpan elteltIdo = maiDatum - datum;

            Console.WriteLine(elteltIdo.TotalDays / 365);

            Console.ReadLine();
        }
    }
}
