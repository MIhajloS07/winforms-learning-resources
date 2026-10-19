using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_genericka_kolekcija
{
    internal class ObradaPoruka
    {
        private Queue<string> redPoruka = new Queue<string>();  

        public void DodajPoruku(string poruka)
        {
            redPoruka.Enqueue(poruka);
            Console.WriteLine($"Poruka -> '{poruka}' je dodata!");
        }
        public void ObradiPoruke()
        {
            while (redPoruka.Count > 0)
            {             
                string poruka = redPoruka.Dequeue();
                Console.WriteLine($"---> Obrada poruke '{poruka}' <---");
                Console.WriteLine($"Poruka -> '{poruka}' je obradjena!");
            }
        }
    }
}
