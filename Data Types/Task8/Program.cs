using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word:  ");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter a second word: ");
            string second = Console.ReadLine();
            Console.WriteLine(first.Contains(second));
        }
    }
}
