using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {

        public interface IBohater
        {
            void bijWroga();
            void sprawdzHp();

        }
        abstract class Bohater : IBohater
        {
            protected int hp;
            protected int atak;
            protected Rasa rasa;
            public enum Rasa
            {
                Niziolek,
                Człowiek,
                Elf,
                Ork,
                Krasnolud
            }

            public void bijWroga()
            {
                Console.WriteLine("Orasz za: " + this.atak);
            }
            public void sprawdzHp()
            {
                Console.WriteLine("Hp: " + this.hp);
                if (this.hp > 0)
                    Console.WriteLine("zyjesz jeszcze");
                else
                    Console.WriteLine("Ta postac is ded, to znaczy ze ktos ją killim!");
                
            }
        }

 
     class mag : Bohater
    {
        private int mana;

        public mag(Rasa rasa)
        {
            this.rasa = rasa;
            this.hp = 28;
            this.atak = 9;
            this.mana = 45;
        }

        public void atakmaga()
        {
            Console.WriteLine("Utevo lux. Magu Orasz za 8.");
        }
    }

     class rzezimieszek : Bohater
    {
      
        public rzezimieszek(Rasa rasa)
        {
            this.atak = 6;
            this.hp = 35;
            this.rasa = rasa;
          
        }
    }
    class wojownik : Bohater
    {
        public wojownik(Rasa rasa)
        {
            this.hp = 50;
            this.atak = 5;
            this.rasa = rasa;
        }
        public void atakwoja()
        {
            Console.WriteLine("Atakujesz mieczem Bronisz sie tarcza, orasz za: 8.");
        }
}
        class uruk : Bohater
            {
         public uruk(Rasa rasa)
                {
                this.hp = 0;
                    this.atak = 6;
                    this.rasa = rasa;
                if (this.hp == 0 )
                {
                    Console.WriteLine("Uruk-Hai ginie. Przebieg walki:");
                }
                }
         public void atakurka()
                {
                    Console.WriteLine("orasz dzidą za 6.");
                }
            }

        
        static void Main(string[] args)
        {
            mag Xardas = new mag(Bohater.Rasa.Człowiek);
            rzezimieszek Diego = new rzezimieszek(Bohater.Rasa.Niziolek);
            wojownik Gorn = new wojownik(Bohater.Rasa.Krasnolud);
            uruk Random = new uruk(Bohater.Rasa.Ork);
            Xardas.bijWroga();
            Xardas.atakmaga();
            Xardas.sprawdzHp();

            Diego.bijWroga();
            Diego.sprawdzHp();
           

            Gorn.bijWroga();
            Gorn.atakwoja();
            Gorn.sprawdzHp();
            Random.bijWroga();
            Random.sprawdzHp();

           
        }
    }

   }


