using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWinforms_zadatak
{
    internal class Osoba
    {
        private int godine;
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godine
        {
            get { return godine; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Broj godina mora biti veci od 0!");
                godine = value;
            }
        }
        public Osoba (string ime, string prezime, int godine)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Godine = godine;
        }
        public string PrikaziInfo()
        {
            return $"Ime: {this.Ime},\n\rPrezime: {this.Prezime},\n\rGodine: {this.Godine}";
        }
    }
}
