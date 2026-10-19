using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_genericka_kolekcija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> red = new Queue<int>();  
            //red.Enqueue(10);
            //red.Enqueue(20);
            //red.Enqueue(30);
            //red.Enqueue(40);

            //// 10 20 30 40

            //foreach (var item in red)
            //    Console.Write(item + "   ");

            //red.Dequeue();
            //red.Dequeue();
            //red.Dequeue();
            
            //// 40

            //Console.WriteLine("Edited queue: ");
            
            //foreach (var item in red)
            //    Console.Write(item + "   ");
            ObradaPoruka poruka = new ObradaPoruka();
            poruka.DodajPoruku("Prva");
            poruka.DodajPoruku("Druga");
            poruka.DodajPoruku("Treca");

            poruka.ObradiPoruke();

        }
    }
}
