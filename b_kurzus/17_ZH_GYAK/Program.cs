using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ZH_GYAK
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
        static bool VanEFilmRendezovel(List<Film> lista, string rendezo)
        {
            for(int i = 0;i < lista.Count; i++)
            {
                if (lista[i].rendezo == rendezo)
                {
                    return true;
                }
            }

            return false;
        }

        static void KategoriabaTartozoFilmek(List<Film> filmek, List<Film> szurtFilmek, string kategoria)
        {
            szurtFilmek.Clear();

            for (int i = 0; i < filmek.Count; i++)
            {
                for(int j = 0; j < filmek[i].kategoriak.Count; j++)
                {
                    if (filmek[i].kategoriak[j] == kategoria)
                    {
                        szurtFilmek.Add(filmek[i]);
                        break;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            List<Film> filmek = new List<Film>();




            Console.WriteLine("4. feladat");
            Console.Write("Adja meg a kedvenc rendezőjét: ");
            string rendezo = Console.ReadLine();

            if (VanEFilmRendezovel(filmek, rendezo))
            {
                for(int i = 0; i <  filmek.Count; i++)
                {
                    if (filmek[i].rendezo == rendezo)
                    {
                        Console.WriteLine($"{filmek[i].cim} - {filmek[i].premier.Year}");
                    }
                }
            }
            else
            {
                Console.WriteLine("A rendezőnek nincs filmje a listában!");
            }

            List<Film> eredmeny = new List<Film>();
            KategoriabaTartozoFilmek(filmek, eredmeny, "sci-fi");

            for (int i = 0; i < eredmeny.Count; i++)
            {
                // 1. lehetőség
                string szinkron = "";
                if (eredmeny[i].feliratos)
                {
                    szinkron = "feliratos";
                }
                else
                {
                    szinkron = "szinkronos";
                }
                Console.WriteLine($"{eredmeny[i].rendezo} - {eredmeny[i].cim} ({szinkron})");


                // 2. lehetőség
                Console.WriteLine($"{eredmeny[i].rendezo} - {eredmeny[i].cim} ({(eredmeny[i].feliratos ? "feliratos" : "szinkronos")})");

            }


            // 7. feladat
            Console.WriteLine("Adjon meg egy rendezőt: ");
            string rendezoTorolni = Console.ReadLine();

            Console.WriteLine("Adjon meg egy címet: ");
            string cimTorolni = Console.ReadLine();

            bool vanEFilm = false;

            for (int i = 0; i < filmek.Count; i++)
            {
                if (filmek[i].rendezo == rendezoTorolni && filmek[i].cim == cimTorolni)
                {
                    vanEFilm = true;
                    filmek.RemoveAt(i);
                    continue;
                }
            }

            if (vanEFilm)
            {
                Console.WriteLine("A film törlésre került!");
            }
            else
            {
                Console.WriteLine("Nincs ilyen film a listában!");
            }

            Console.ReadLine();
        }
    }
}
