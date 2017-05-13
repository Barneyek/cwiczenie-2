using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int bramy = 0;

        public Pilkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
            : base(imie, nazwisko, dataUrodzenia)
        {
            this.pozycja = pozycja;
            this.klub = klub;

        }
        public void WypiszInfo()
        {
            Console.WriteLine("" + this.imie + " " + this.nazwisko + ", urodzony: " + this.dataUrodzenia + ", grajacy na poozycji: " + this.pozycja + " w klubie: " + this.klub);
        }
        public void StrzelGola()
        {
            bramy++;
            Console.WriteLine("Pilkarz {0} {1} GOOOOOOL!!!!", imie, nazwisko);
        }
    }
}
