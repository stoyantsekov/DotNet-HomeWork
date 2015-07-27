using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you name:  ");
            string first = Console.ReadLine();
            char last = first[first.Length - 1];
            Console.WriteLine(last);
        }
    }
}
