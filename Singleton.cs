using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternIS
{
    public sealed class Singleton
    {
        private static Singleton instanca;
        private Singleton(){ }
        private List<Pacijent> pacijenti = new List<Pacijent>();
        public static Singleton GetInstance()
        {
            if(instanca == null)
            {
                instanca = new Singleton();
            }
            
            return instanca;
        }
        public void DodajPacijenta(Pacijent pacijent)
        {
            pacijenti.Add(pacijent);
        }
        public void UkloniPacijenta(int id)
        {
            var p = pacijenti.Where(pacijent => pacijent.Id == id).FirstOrDefault();
            pacijenti.Remove(p);
        }
        public void PrepraviPacijena(int id, Pacijent pac)
        {
            var p = pacijenti.Where(pacijent => pacijent.Id == id).FirstOrDefault();
            p.Id = pac.Id;
            p.Ime = pac.Ime;
            p.Prezime = pac.Prezime;
            p.Datum_rodjenja = pac.Datum_rodjenja;
            p.Telefon = pac.Telefon;
        }
        public void IspisPacijenata()
        {
            foreach (Pacijent p in pacijenti)
            {
                Console.WriteLine(p.Id + "-" + p.Ime + " " + p.Prezime + "--" + p.Datum_rodjenja.ToShortDateString() + "--" + p.Telefon + Environment.NewLine);
            }
            Console.ReadLine();
        }

    }
}
