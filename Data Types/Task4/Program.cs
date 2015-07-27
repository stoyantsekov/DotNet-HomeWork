using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value for the fist side of the rectangual");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a value for the second side of the rectangual");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine(first*second);
        }
    }
}
