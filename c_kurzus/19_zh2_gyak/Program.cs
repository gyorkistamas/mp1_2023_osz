using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_zh2_gyak
{
    class Film
    {
        public string rendezo;
        public string cim;
        public DateTime premier;
        public List<string> kategoriak = new List<string>();
        public double ertekeles;
        public int korhatar;
        public bool feliratos;
    }


    internal class Program
    {
        static bool F3_VanFilmjeARendezonek(List<Film> filmek, string rendezo)
        {
            for(int i = 0; i < filmek.Count; i++)
            {
                if (filmek[i].rendezo == rendezo)
                {
                    return true;
                }
            }

            return false;
        }

        static void F5_KategoriabaTartozoFilmek(List<Film> filmek, List<Film> szurt, string kategoria)
        {
            szurt.Clear();
            for (int i = 0; i < filmek.Count; i++)
            {
                Film temp = filmek[i];
                for (int j = 0; j < temp.kategoriak.Count; j++)
                {
                    if (temp.kategoriak[j] == kategoria)
                    {
                        szurt.Add(temp);
                        break;
                    }
                }
            }
        }

        static List<string> F8_Kedvenckategoriak()
        {
            List<string> kategoriak = new List<string>();

            Console.WriteLine("Adja meg a kedvenc kategóriáit, vége szóval léphet ki");

            while(true)
            {
                Console.Write("> ");
                string kategoria = Console.ReadLine();

                if (kategoria == "vége")
                {
                    break;
                }

                if (!kategoriak.Contains(kategoria))
                {
                    kategoriak.Add(kategoria);
                }
            }

            return kategoriak;
        }

        static void Main(string[] args)
        {
            List<Film> filmek = new List<Film>();

            StreamReader reader = new StreamReader("adatok.csv", Encoding.UTF8);

            //Ha van fejléce a fájlnak
            //reader.ReadLine();

            while(!reader.EndOfStream)
            {
                string sor = reader.ReadLine();
                string[] darabolt = sor.Split(';');

                //string[] darabolt = reader.ReadLine().Split(';');

                Film uj = new Film();
                uj.rendezo = darabolt[0];
                uj.cim = darabolt[1];
                uj.premier = new DateTime(int.Parse(darabolt[2]), int.Parse(darabolt[3]), int.Parse(darabolt[4]));

                string[] kategoriak = darabolt[5].Split(',');
                for(int i = 0; i < kategoriak.Length; i++)
                {
                    uj.kategoriak.Add(kategoriak[i]);
                }

                uj.ertekeles = double.Parse(darabolt[6]);
                uj.korhatar = int.Parse(darabolt[7]);

                //1. lehetőség
                if (darabolt[8] == "feliratos")
                {
                    uj.feliratos = true;
                }
                else
                {
                    uj.feliratos = false;
                }

                //2. lehetőség
                uj.feliratos = darabolt[8] == "feliratos" ? true : false;


                filmek.Add(uj);
            }

            reader.Close();

            Console.WriteLine("1. feladat: fájl beolvasva.");

            Console.WriteLine("\n2. feladat: filmek a listában: ");

            for(int i = 0; i < filmek.Count; i++)
            {
                Film temp = filmek[i];
                if (temp.premier > DateTime.Now)
                {
                    Console.WriteLine($"{temp.rendezo} - {temp.cim} ({temp.premier.ToString("yyyy MMMM dd")})");
                }
            }

            Console.WriteLine("\n4. feladat: ");
            Console.Write("Adja meg a kedvenc rendezőjét: ");
            string rendezo = Console.ReadLine();

            if (F3_VanFilmjeARendezonek(filmek, rendezo))
            {
                for (int i = 0; i < filmek.Count; i++)
                {
                    Film temp = filmek[i];
                    if (temp.rendezo == rendezo)
                    {
                        Console.WriteLine($"{temp.cim} - {temp.premier.Year}");
                    }
                }
            }
            else
            {
                Console.WriteLine("A rendezőnek nincs filmje a listában!");
            }

            Console.WriteLine("\n5. feladat: sci-fi filmek ");

            List<Film> scifik = new List<Film>();
            F5_KategoriabaTartozoFilmek(filmek, scifik, "sci-fi");

            for (int i = 0; i < scifik.Count; i++)
            {
                Film temp = scifik[i];
                // Egyik lehetőség a feliratos/szinkronos kiíratásra
                Console.WriteLine($"{temp.rendezo} - {temp.cim} ({(temp.feliratos ? "feliratos" : "szinkronos")})");

                // Másik
                //string szinkron = "";
                //if (temp.feliratos)
                //{
                //    szinkron = "feliratos";
                //}
                //else
                //{
                //    szinkron = "szinkronos";
                //}
                //Console.WriteLine($"{temp.rendezo} - {temp.cim} ({szinkron})");
            }


            Console.WriteLine("\n7. feladat:");

            Console.Write("Adjon meg egy rendezőt: ");
            string rendezoTorolni = Console.ReadLine();

            Console.Write("Adjon meg egy címet: ");
            string cimTorolni = Console.ReadLine();

            bool voltFilm = false;
            for (int i = 0; i < filmek.Count; i++)
            {
                if (filmek[i].rendezo == rendezoTorolni && filmek[i].cim == cimTorolni)
                {
                    voltFilm = true;
                    filmek.RemoveAt(i);
                    break;
                }
            }

            if (voltFilm)
            {
                Console.WriteLine("A filmet töröltük.");
            }
            else
            {
                Console.WriteLine("Nem volt ilyen film a listában!");
            }

            //8. feladat: eljárás (void), do-while(beolvasot != "vége")

            //9. feladat: életkor bekér, meghívjátok a 8. feladat függvényét,
            //bekéritek, hogy lehet-e felíratos, ciklussal végigmentek a listán, if-el megnézitek, hogy mely filmek felelnek meg a kritériumoknak
            Console.Write("Adja meg a legfiatalabb néző életkorát: ");
            int eletkor = int.Parse(Console.ReadLine());

            List<string> kedvencKategoriak = F8_Kedvenckategoriak();

            bool feliratos = false;
            Console.Write("Lehet feliratos a film? ");
            string valasz = Console.ReadLine();
            if (valasz == "igen")
            {
                feliratos = true;
            }

            for(int i = 0; i < filmek.Count; i++)
            {
                if (filmek[i].korhatar <= eletkor)
                {
                    bool megfeleloKategoriajuE = false;
                    for (int j = 0; j < kedvencKategoriak.Count; j++)
                    {
                        if (filmek[i].kategoriak.Contains(kedvencKategoriak[j]))
                        {
                            megfeleloKategoriajuE = true;
                            break;
                        }
                    }

                    if (megfeleloKategoriajuE)
                    {
                        if (feliratos)
                        {
                            Console.WriteLine($"{filmek[i].cim}");
                        }
                        else if (!filmek[i].feliratos)
                        {
                            Console.WriteLine($"{filmek[i].cim}");
                        }
                    }
                }
            }


            // 10. Csináltok egy listát, amibe kigyüjtitek a kategóriákat (végigmentek a filmek listán és ha olyan kategóriát találtok, ami még nincs benne a listában, akkor azt hozzáadjátok (lista.Contains()))
            // Végig mentek ezen ciklussol, azon belül egy másik ciklussal kiválasztjátok a kategóriához tartozó legmagasabb értékelésű filmet

            // Másik lehetőség: dictionary

            List<string> osszesKategoria = new List<string>();

            for (int i = 0; i < filmek.Count; i++)
            {
                for (int j = 0; j < filmek[i].kategoriak.Count; j++)
                {
                    if (!osszesKategoria.Contains(filmek[i].kategoriak[j]))
                    {
                        osszesKategoria.Add(filmek[i].kategoriak[j]);
                    }
                }
            }

            foreach(string kategoria in osszesKategoria)
            {
                Film max = new Film();
                foreach(Film film in filmek)
                {
                    if (film.kategoriak.Contains(kategoria) &&
                        film.premier < DateTime.Now &&
                        film.ertekeles > max.ertekeles)
                    {
                        max = film;
                    }
                }

                Console.WriteLine($"A {kategoria} kategóriában a legnagyobb értékelésű film a {max.cim} ({max.ertekeles})");
            }

            Console.ReadLine();
        }
    }
}
