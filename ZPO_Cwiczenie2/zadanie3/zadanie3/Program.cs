using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("Jan", "Kowalski", "22.01.1990", 3, 1, 119498);
            PilkarzNozny p1 = new PilkarzNozny("Cristiano", "Ronaldo", "21.06.1990", "napastnik", "Real Madryt");

            s1.DodajOcene("matematyka", "22.01.2017", 3);
            s1.DodajOcene("matematyka", "21.02.2017", 3);
            s1.DodajOcene("historia", "22.22.22", 4);
            s1.WypiszInfo();
            s1.WypiszOceny();
            s1.UsunOcene("matematyka", "21.02.2017", 3);

            s1.WypiszOceny();

            p1.WypiszInfo();
            p1.StrzelGola();


            Console.ReadKey();
        }
    }
}
