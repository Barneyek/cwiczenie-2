using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Ocena
    {
        public string nazwaPrzedmiotu { get; private set; }
        public string data { get; private set; }
        public double ocena_2 { get; private set; }

        public Ocena(string nazwaPrzedmiotu, string data, double wartosc)
        {
            this.nazwaPrzedmiotu = nazwaPrzedmiotu;
            this.data = data;
            this.ocena_2 = wartosc;
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Przedmiot: " + this.nazwaPrzedmiotu + ", z dnia: " + this.data + ", ocena: " + this.ocena_2);
        }
    }
}
