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

        static int F6(Csoki csoki)
        {
            if (csoki.szavatossag < DateTime.Now)
            {
                return 0;
            }

            if (csoki.tejcsokolade)
            {
                csoki.ar = (int)Math.Round(csoki.ar * 0.75);
            }
            else
            {
                csoki.ar = (int)Math.Round(csoki.ar * 0.70);
            }

            if (csoki.mennyiseg >= 60)
            {
                csoki.ar = (int)Math.Round(csoki.ar * 0.94);
            }

            return csoki.ar;
        }
        static void F5(List<Csoki> lista, int ar, List<Csoki> valogatott)
        {
            valogatott.Clear();

            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i].ar > ar)
                    valogatott.Add(lista[i]);
            }
        }
        
        static bool F3_eldönt(List<Csoki> csokik, string gyarto, string izesites)
        {
            for (int i = 0; i < csokik.Count; i++)
            {
                if (csokik[i].marka == gyarto && csokik[i].izesites == izesites)
                {
                    return true;
                }
            }
            return false;
        }

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

            Console.Write("Adja meg a gyártót:");
            string gyarto = Console.ReadLine();
            Console.Write( "Adja meg az ízesítést:");
            string izesites= Console.ReadLine();

            if (F3_eldönt(csokik, gyarto, izesites))
            {
                for (int i = 0; i < csokik.Count; i++)
                {
                    if (csokik[i].marka == gyarto && csokik[i].izesites == izesites)
                    {
                        Console.WriteLine($"{csokik[i].azonosito}, {csokik[i].tomeg}, {csokik[i].ar}, {(csokik[i].mennyiseg <= 0 ? "nincs raktáron " : "van raktáron")} ");
                    }

                }
            }
            else Console.Write("Nincs ilyen csoki a raktáron.");

            // 7. feladat
            List<Csoki> szűrtLista = new List<Csoki>();
            F5(csokik, 650, szűrtLista);

            Console.WriteLine("7. feladat");

            foreach(Csoki csoki in szűrtLista)
            {
                if (csoki.szavatossag >= DateTime.Now)
                {
                    Console.WriteLine($"{csoki.azonosito}: {csoki.marka} ({csoki.izesites}) Ár: {csoki.ar} Ft, Akciós ár: {F6(csoki)} Ft");
                }
            }
            //8.feladat
            int torlendoIndex = -1;
            for (int i = 0;i < csokik.Count; i++)
            {
                if (csokik[i].azonosito == "NBKL5NQ")
                {
                    torlendoIndex = i;
                    break;
                }
            }
            if (torlendoIndex == -1) Console.WriteLine("Nincsen benne az adott termék.");
            else 
            {
                csokik.RemoveAt(torlendoIndex);
                Console.WriteLine("A törlés sikeres volt!");
            }
            
            //9. feladat
            List<string> gyartok = new List<string>();
            for (int i = 0; i < csokik.Count; i++)
            {
                bool benneVanE = false;
                for (int j = 0; j < gyartok.Count; j++)
                {
                    if (gyartok[i] == csokik[i].marka)
                    {
                        benneVanE = true;
                    }
                }
                if (!benneVanE) 
                {
                    gyartok.Add(csokik[i].marka);
                }

                //if (!gyarto.Contains(csokik[i].marka))
                //    gyartok.Add(csokik[i].marka);
            }

            for (int i = 0; i < gyartok.Count; i++)
            {
                Csoki max = new Csoki();
                max.ar = -1;
                for (int j = 0;j < csokik.Count; j++)
                {
                    if (csokik[j].marka == gyartok[i] && csokik[j].ar > max.ar)
                    {
                        max = csokik[j];
                    }
                }
                Console.WriteLine($"A {gyartok[i]} gyártónak a legdrágább csokiának az ízesítése: {max.izesites}");
                Console.WriteLine($"Ha minden csokit eladnánk akkor {max.mennyiseg * max.ar} Ft lenne a profitunk");
            }

            Console.ReadLine();



        }
    }
}
