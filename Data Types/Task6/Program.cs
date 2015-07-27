using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name:  ?");
            string first = Console.ReadLine();
            Console.WriteLine("What is you last name:  ?");
            string last = Console.ReadLine();
            Console.WriteLine("You name is:  ");
            Console.WriteLine(first+"|"+last);
        }
    }
}
