﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:  ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Please enter a second number:  ");
            int b = int.Parse(Console.ReadLine());
            int c = a % b;
            Console.WriteLine("The left from the equation is : {0}",c);
        }
    }
}
