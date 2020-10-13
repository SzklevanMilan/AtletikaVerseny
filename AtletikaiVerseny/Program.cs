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
        static void Main(string[] args)
        {
            var a = new Atleta("623; Ug Imre; Kalocsai Rozmarok; 640");
            Beolvas();

            //foreach (var i in lista)
            //{
            //    Console.WriteLine($"{i.Rajtszam} - {i.VezNev}{i.KerNev} - {i.Egyesulet} - {i.Ugras}");
            //}
            Console.ReadKey();
        }
    }
}
