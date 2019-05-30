using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>() { 10, 20, 30, 40 };

            Console.WriteLine("Second element: {0}", number[1]);

            Console.WriteLine("Length: {0}", number.Count);

            number.Insert(1, 15);

            number.RemoveAt(2);
            number.Remove(30);

            foreach(int num in number)
            {
                Console.WriteLine(num);
            }
            bool positiveOnly = number.TrueForAll(num => num > 0);
            Console.WriteLine(positiveOnly);
        }
    }
}
