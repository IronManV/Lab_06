using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");

            foreach(string num in numbers)
            {
                Console.WriteLine(num);
            }
            //Poping elemnts form the stack
            Console.WriteLine();
            Console.WriteLine("Poping element: {0}", numbers.Pop());
            Console.WriteLine("On top of the stack, we now have: {0}", numbers.Peek());
            Console.WriteLine("Poping element: {0}", numbers.Pop());
            Console.ReadKey();
        }
    }
}
