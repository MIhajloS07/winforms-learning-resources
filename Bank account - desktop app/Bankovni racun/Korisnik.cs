using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovni_racun
{
    internal class Korisnik
    {
        private string ime;
        private string prezime;
        private string korisnickoIme;
        private string lozinka;

        public Korisnik(string ime, string prezime, string korisnickoIme, string lozinka)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoIme = korisnickoIme; 
            this.lozinka = lozinka;
        }
        public bool ProveraLozinke(string lozinka)
        {
            if (lozinka == this.lozinka) 
                return true;
            return false;
        }
        public string prikazInfo()
        {
            return $"ime: {ime} {prezime} | korisnicko ime: {korisnickoIme} | lozinka {lozinka}";
        }
    }
}
