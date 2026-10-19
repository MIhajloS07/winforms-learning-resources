using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovni_racun
{
    internal class Racun
    {
        private double stanje;
        private int brojRacuna;

        public Racun(double stanje, int brojRacuna)
        {
            this.stanje = stanje;
            this.brojRacuna = brojRacuna;
        }
        public void Uplata(double iznos)
        {
            iznos += stanje;
        }
        public void Isplata(double iznos)
        {
            if (iznos > stanje)
                throw new ArgumentException("Iznos koji ste uneli je veci od postojeceg na racunu!");
            else iznos -= stanje;
        }
    }
}
