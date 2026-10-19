using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledjivanje_Winforms
{
    internal class Menadzer : Zaposleni
    {
        public Menadzer(string ime, double plata) : base(ime, plata) { }
        public override string prikaziPodatke()
        {
            return $"{base.prikaziPodatke()}, tip: Menadzer";
        }
    }
}
