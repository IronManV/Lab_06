using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_00
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("Baby");
            myList.Add("Don't");
            myList.Add("Hurt");
            myList.Add("Me");

            foreach(string text in myList)
            {
                Console.WriteLine(text);
            }

            Console.WriteLine("-----------------");

            myList.Remove("Don't");
            Console.ReadKey();
        }
    }
}
