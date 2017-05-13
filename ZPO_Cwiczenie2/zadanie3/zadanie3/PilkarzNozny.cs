using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class PilkarzNozny : Pilkarz
    {
        public PilkarzNozny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
            : base(imie, nazwisko, dataUrodzenia, pozycja, klub)
        {

        }
        public void StrzelGola()
        {
            Console.WriteLine("Pilkarz grajacy w noge {0} {1} strzelil brame!!", imie, nazwisko);
        }
    }
}
