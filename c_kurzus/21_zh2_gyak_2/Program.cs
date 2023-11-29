using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_zh2_gyak_2
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
        static bool F3_VanEAdottGyartojuEsIzesitesuCsoki(List<Csoki> csokik, string gyarto, string izesites)
        {
            foreach (Csoki csoki in csokik)
            {
                if (csoki.marka == gyarto && csoki.izesites == izesites)
                {
                    return true;
                }
            }

            return false;
        }

        static void F5_PremiumCsokik(List<Csoki> osszesCsoki, List<Csoki> premiumCsokik, int arHatar)
        {
            premiumCsokik.Clear();

            foreach (Csoki csoki in osszesCsoki)
            {
                if (csoki.ar > arHatar)
                {
                    premiumCsokik.Add(csoki);
                }
            }
        }

        static int F6_AkciosAr(Csoki csoki)
        {
            int ar = csoki.ar;

            if(csoki.szavatossag < DateTime.Now)
            {
                ar = 0;
            }

            if(csoki.tejcsokolade)
            {
                ar = (int)(ar - (ar * 0.25));
            }
            else
            {
                ar = (int)(ar - (ar * 0.3));
            }

            if (csoki.mennyiseg >= 60)
            {
                ar = (int)(ar - (ar * 0.06));
            }

            return ar;
        }

        static void Main(string[] args)
        {
            List<Csoki> csokik = new List<Csoki>();

            StreamReader sr = new StreamReader("csokik.csv");

            sr.ReadLine();

            while(!sr.EndOfStream) 
            {
                string[] sor = sr.ReadLine().Split(';');

                Csoki csoki = new Csoki();
                csoki.azonosito = sor[0];
                csoki.marka = sor[1];
                //csoki.tejcsokolade = sor[2] == "tej";
                if (sor[2] == "tej")
                {
                    csoki.tejcsokolade = true;
                }
                else
                {
                    csoki.tejcsokolade = false;
                }

                csoki.izesites = sor[3];

                csoki.szavatossag = DateTime.Parse(sor[4]);

                csoki.ar = int.Parse(sor[5]);
                csoki.tomeg = int.Parse(sor[6]);
                csoki.mennyiseg = int.Parse(sor[7]);

                csokik.Add(csoki);
            }

            sr.Close();


            // 2. feladat
            Console.WriteLine("2. feladat");

            double kidobottTomeg = 0;
            foreach (Csoki csoki in csokik)
            {
                if (csoki.szavatossag < DateTime.Now && csoki.mennyiseg > 0)
                {
                    Console.WriteLine($"{csoki.azonosito}: {csoki.marka} - {csoki.izesites} ({(csoki.tejcsokolade ? "tej" : "ét")}) ({csoki.szavatossag.ToString("yyyy MMMM dd")})");
                    kidobottTomeg += csoki.tomeg * csoki.mennyiseg;
                }
            }

            Console.WriteLine($"Ezek megsemmisítésével {Math.Round(kidobottTomeg / 1000, 2)} kg csokoládé kerül ki a raktárból.");

            // 4. feladat
            Console.Write("Melyik a kedvenc márkája? ");
            string kedvencMarka = Console.ReadLine();

            Console.Write("Melyik a kedvenc ízesítése? ");
            string kedvencIzesites = Console.ReadLine();

            if (F3_VanEAdottGyartojuEsIzesitesuCsoki(csokik, kedvencMarka, kedvencIzesites))
            {
                foreach (Csoki csoki in csokik)
                {
                    if (csoki.marka == kedvencMarka && csoki.izesites == kedvencIzesites)
                    {
                        Console.WriteLine($"{csoki.azonosito} - {csoki.tomeg} g - {csoki.ar} Ft - {(csoki.mennyiseg > 0 ? "Van raktáron" : "Nincs raktáron")}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Nincs ilyen feltételeknek megfelelő csoki!");
            }

            // 7. feladat: használjuk a 5-6. feladatban megírt függvényt
            //Console.Write($"{F6_AkciosAr(csoki)}");

            Console.ReadLine();
        }
    }
}
