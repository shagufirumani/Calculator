using System;
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
            Console.WriteLine("Enter First number");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            Y = int.Parse(Console.ReadLine());
            int result1 = X - Y;
            Console.WriteLine("sub:" + result1);

        }

        public void Mul()
        {
            Console.WriteLine("Enter First number");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            Y = int.Parse(Console.ReadLine());
            result = X * Y;
            Console.WriteLine("Multiplication: " + result);

        }

        public void DeepaTest()
        {
            Console.WriteLine("method by Deepa");
        }
       

        public void Div()
        {
            Console.WriteLine("Enter First number");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            Y = int.Parse(Console.ReadLine());
            result = X / Y;
            Console.WriteLine("Division: " + result);
        }
        public void naughtyfellows()
        {
            Console.WriteLine("method by grp");
        }
    }
}
