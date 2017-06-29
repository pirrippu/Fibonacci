using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci();
            int n = 8181;
            Console.WriteLine(n + " : " + fib.ParseActualValue(fib.GetFibonacciValue(n)));

            Console.ReadLine();
        }
    }
}
