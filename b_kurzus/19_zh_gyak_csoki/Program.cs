using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_zh_gyak_csoki
{
    class Csoki
    {
        public string azonosito;
        public string marka;
        public bool tejcsokolade;
        public string izesites;
        public DateTime szavatossag;
        public int ar;
        public int tomeg;
        public int mennyiseg;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat

            List<Csoki> csokik = new List<Csoki>();

            // Beolvasás
            StreamReader sr = new StreamReader("csokiraktar.csv");

            // Ha van fejléc, akkor azt eldobjuk
            sr.ReadLine();


            while (!sr.EndOfStream)
            {
                // Beolvassuk a sort és tördeljük pontosvesszők mentén
                string[] adatok = sr.ReadLine().Split(';');

                Csoki uj = new Csoki();
                uj.azonosito = adatok[0];
                uj.marka = adatok[1];
                if (adatok[2] == "tej")
                {
                    uj.tejcsokolade = true;
                }
                else
                {
                    uj.tejcsokolade = false;
                }
                uj.izesites = adatok[2];
                uj.szavatossag = DateTime.Parse(adatok[3]);
                uj.ar = int.Parse(adatok[4]);
                uj.tomeg = int.Parse(adatok[5]);
                uj.mennyiseg = int.Parse(adatok[6]);

                csokik.Add(uj);

            }

            sr.Close();

            //2 .feladat
            Console.WriteLine("2. feladat");

            double kidobottTomeg = 0;
            foreach(Csoki csoki in csokik)
            {
                if (csoki.szavatossag < DateTime.Now && csoki.mennyiseg > 0)
                {
                    kidobottTomeg += csoki.mennyiseg * csoki.tomeg;
                    Console.WriteLine($"{csoki.azonosito}: {csoki.marka} - {csoki.izesites} ({(csoki.tejcsokolade ? "tej" : "ét")}) ({csoki.szavatossag.ToString("yyyy MMMM dd")})");
                }
            }

            Console.WriteLine($"A kidobott mennyiség: {Math.Round(kidobottTomeg / 1000, 2)} kg");
            Console.ReadLine();
        }
    }
}
