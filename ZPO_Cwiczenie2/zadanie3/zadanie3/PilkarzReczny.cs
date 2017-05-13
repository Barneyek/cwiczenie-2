using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class PilkarzReczny : Pilkarz {
        public PilkarzReczny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
            : base(imie, nazwisko, dataUrodzenia, pozycja, klub) {

    }
    public void StrzelGola()
    {

        Console.WriteLine("Pilkarz reczny {0} {1} strzelil GOLA!!", imie, nazwisko);
    }

}
}
