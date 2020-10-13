using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtletikaiVerseny
{
    class Program
    {
        static List<Atleta> lista = new List<Atleta>();
        static void Beolvas()
        {
            StreamReader sr = new StreamReader("tavol.csv");
            while (!sr.EndOfStream)
            {
                lista.Add(new Atleta(sr.ReadLine()));
            }
            sr.Close();
        }
        static void Feladat2()
        {
            foreach (var l in lista)
            {
                Console.WriteLine("{0,15} {1,10} ",l.VezNev,l.Ugras);
            }
        }
        static void Feladat3()
        {
            //int db = 0;
            //foreach (var l in lista)
            //{
            //    if (l.Egyesulet == l.Egyesulet)
            //    {
            //        db++;
            //    }
            //}
        }
        static void Feladat4()
        {
            int max = 0;
            string nev = "";
            foreach (var l in lista)
            {
                if (l.Ugras > max)
                {
                    max = l.Ugras;
                    nev = l.VezNev;
                }
            }
            Console.WriteLine("{0}: {1} cm", nev, max);
        }
        static void Feladat5()
        {
            int osszeg = 0;
            int atlag = 0;
            int db = 0;
            foreach (var l in lista)
            {
                osszeg = osszeg + l.Ugras;
                atlag = osszeg / lista.Count();
                if (l.Ugras < atlag)
                {
                    db++;
                }
            }
            Console.WriteLine(atlag);
            Console.Write("Átlag alatt lévő ugrások száma: {0}.", db);
        }
        static void Feladat6()
        {
            StreamWriter sw = new StreamWriter("versenyzok.txt");
            foreach (var l in lista)
            {
                
                sw.WriteLine($"{ l.Rajtszam}; { l.VezNev}");
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            var a = new Atleta("623; Ug Imre; Kalocsai Rozmarok; 640");
            Console.WriteLine("1.feladat: Adatok beolvasása.");
            Beolvas();
            Console.WriteLine("\n2.feladat: Nevek és ugrások.");
            Feladat2();
            Console.WriteLine("\n3.feladat: Egyesületek nevei:");
            Feladat3();
            Console.WriteLine("\n4.feladat:Legnagyobb ugrás.");
            Feladat4();
            Console.WriteLine("\n5.feladat:");
            Feladat5();
            Console.WriteLine("\n6.feladat:Fájlba írás.");

            //foreach (var i in lista)
            //{
            //    Console.WriteLine($"{i.Rajtszam} - {i.VezNev}{i.KerNev} - {i.Egyesulet} - {i.Ugras}");
            //}
            Console.ReadKey();
        }
    }
}
