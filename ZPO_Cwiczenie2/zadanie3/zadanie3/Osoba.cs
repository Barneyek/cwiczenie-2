using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public Osoba(string imie, string dataUrodzenia, string nazwisko )
        {
            this.imie = imie;
            this.dataUrodzenia = dataUrodzenia;
            this.nazwisko = nazwisko;
           
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Imie: " + this.imie + ", nazwisko: " + this.nazwisko + ", urodzony: " + this.dataUrodzenia);
        }
    }
}
