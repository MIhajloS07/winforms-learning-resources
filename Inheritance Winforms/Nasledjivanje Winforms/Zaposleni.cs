using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje_Winforms
{
    internal class Zaposleni
    {
        private double _plata;
        public string Ime { get; set; }
        public double Plata
        {
            get {  return _plata; }
            set 
            {
                if (value < 0) 
                    throw new ArgumentOutOfRangeException("Plata mora biti veca od 0!");
                _plata = value;
            }
        }    
        public Zaposleni(string ime, double plata)
        {
            Ime = ime;
            Plata = plata;
        }
        public virtual string prikaziPodatke()
        {
            return $"Ime: {this.Ime}, Plata: {this.Plata}";
        }
        public override string ToString()
        {
            return prikaziPodatke();
        }
    }
}
