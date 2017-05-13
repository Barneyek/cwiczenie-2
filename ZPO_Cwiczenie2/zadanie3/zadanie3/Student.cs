using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Student: Osoba {
        private int rok;
        private int grupa;
        private int nrIndeksu;
        private List<Ocena> listaOcen = new List<Ocena>();

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrIndeksu)
            : base(imie, nazwisko, dataUrodzenia) {
            this.rok = rok;
            this.grupa = grupa;
            this.nrIndeksu = nrIndeksu;

        }

        public void WypiszInfo() {
            Console.WriteLine("Imie: " + this.imie + ", Nazwisko: " + this.nazwisko + ", urodzony: " + this.dataUrodzenia + ", Rok: " + this.rok + ", w grupie: " + this.grupa + ", nr indeksu: " + this.nrIndeksu);
        }
        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc) {

            Ocena o = new Ocena(nazwaPrzedmiotu, data, wartosc);
            Console.WriteLine("Usunieto ocene {0}, {1}, {2}", o.nazwaPrzedmiotu, o.data, o.ocena_2);
            listaOcen.Add(o);
        }
        public void WypiszOceny() {
            foreach (Ocena ocena in listaOcen) {
                ocena.WypiszInfo();
            }
        }
        public void WypiszOceny(string nazwaPrzedmiotu) {
            foreach (Ocena ocena in listaOcen) {
                if (ocena.nazwaPrzedmiotu == nazwaPrzedmiotu)
                    ocena.WypiszInfo();
            }
        }
        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc) {
            foreach (Ocena ocena in listaOcen) {
                if (ocena.nazwaPrzedmiotu == nazwaPrzedmiotu && ocena.data == data && ocena.ocena_2 == wartosc) {
                    Console.WriteLine("Usunales {0}, {1}, {2}", ocena.nazwaPrzedmiotu, ocena.data, ocena.ocena_2);
                    listaOcen.Remove(ocena);

                    break;
                }

            }
        }
        public void UsunOceny() {
            foreach (Ocena ocena in listaOcen) {

                listaOcen.Remove(ocena);
            }
            Console.WriteLine("Ni ma ocen.");
        }
        public void UsunOceny(string nazwaPrzedmiotu) {
            foreach (Ocena ocena in listaOcen) {
                if (ocena.nazwaPrzedmiotu == nazwaPrzedmiotu)
                    listaOcen.Remove(ocena);
            }
        }
    
    }
}
