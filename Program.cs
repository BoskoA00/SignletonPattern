using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternIS
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Singleton singleton = Singleton.GetInstance();

            singleton.DodajPacijenta(new Pacijent { Id = 1, Ime = "Bosko", Prezime = "Boskovic", Datum_rodjenja = new DateTime(1995, 2, 10),Telefon="061777777" });
            singleton.DodajPacijenta(new Pacijent { Id = 2, Ime = "Marko", Prezime = "Markovic", Datum_rodjenja = new DateTime(2002, 7, 23), Telefon = "06455555" });
            singleton.DodajPacijenta(new Pacijent { Id = 3, Ime = "Ana", Prezime = "Anic", Datum_rodjenja = new DateTime(1990, 11, 5), Telefon = "06322222" });


            singleton.PrepraviPacijena(1, new Pacijent { Id = 3, Ime = "Stefan", Prezime = "Savic", Datum_rodjenja = new DateTime(1990, 11, 5), Telefon = "06322222" });

            Singleton singleton1 = Singleton.GetInstance();

            Console.WriteLine(singleton == singleton1);
            Console.WriteLine(Environment.NewLine);
            singleton.IspisPacijenata();



        }
    }
}
