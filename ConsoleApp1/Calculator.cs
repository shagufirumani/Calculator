﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        int X;
        int Y;
        int result;
        public void add()
        {
            Console.WriteLine("Enter First number");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            Y= int.Parse(Console.ReadLine());
            result = X + Y;
                Console.WriteLine("Addition:" + result);
        }
        public void sub()
        {
            int result1 = X - Y;
            Console.WriteLine("sub:" + result1);

        }

        public void Mul()
        {
            result = X * Y;
            Console.WriteLine("Multiplication: " + result);

        }
    }
}
