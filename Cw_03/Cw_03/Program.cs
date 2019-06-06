using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stworz nowa kolejke
            Queue<string> numery = new Queue<string>();
            numery.Enqueue("jeden");
            numery.Enqueue("dwa");
            numery.Enqueue("trzy");
            numery.Enqueue("cztery");
            // Wydrukuj zawartosc kolejki na ekranie
            foreach (string num in numery)
            {
                Console.WriteLine(num);
            }
            // Wyciaganie elementow
            Console.WriteLine();
            Console.WriteLine("Wyciagam element: {0}", numery.Dequeue());
            Console.WriteLine("Na poczatku kolejki jest teraz: {0}", numery.Peek());
            Console.WriteLine("Wyciagam element: {0}", numery.Dequeue());
            Console.ReadKey();
        }
    }
}
