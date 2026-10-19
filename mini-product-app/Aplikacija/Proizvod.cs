using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    internal class Proizvod
    {
        private int kolicina;
        public string Naziv {  get; set; }
        public int Cena { get; set; }
        public Proizvod(string naziv, int cena, int kolicina)
        {
            if (cena < 0)
                throw new ArgumentException("Cena mora biti veća od 0.");
            Naziv = naziv;
            Cena = cena;
            this.kolicina = kolicina;   
        }
        public int UkupnaVrednost() => Cena * kolicina;
    }
}
