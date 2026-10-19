using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_test_programiranje
{
    internal class Krug
    {
        private double poluprecnik;

        public Krug() { this.poluprecnik = 1; }
        public Krug(double poluprecnik) { this.poluprecnik = poluprecnik; }
        // metode
        public double Povrsina() => Math.Pow(this.poluprecnik, 2) * Math.PI;
        public double Obim() => 2 * this.poluprecnik * Math.PI;
    }
}
