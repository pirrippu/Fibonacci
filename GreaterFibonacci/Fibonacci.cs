using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterFibonacci
{
    public class Fibonacci
    {
        private const int MAX_LENGTH = 2048;

        public int[] GetNextSequence(int[] n1, int[] n2)
        {
            int[] nVal = Enumerable.Repeat(0, MAX_LENGTH).ToArray();

            for (int index = MAX_LENGTH - 1; index >= 0; index--)
            {
                nVal[index] = n1[index] + n2[index];
                if (nVal[index] > 9)
                {
                    n1[index - 1]++;
                    nVal[index] = nVal[index] - 10;
                }
            }

            return nVal;
        }

        public int[] GetFibonacciValue(int n)
        {
            int[] n1 = Enumerable.Repeat(0, MAX_LENGTH).ToArray();
            int[] n2 = Enumerable.Repeat(0, MAX_LENGTH).ToArray();
            n2[MAX_LENGTH - 1] = 1;

            for (int i = 0; i < n; i++)
            {
                int[] temp = n1;
                n1 = n2;
                n2 = GetNextSequence(temp, n2);
            }

            return n1;
        }

        public string ParseActualValue(int[] fibonacci)
        {
            StringBuilder value = new StringBuilder();

            foreach (int i in fibonacci)
            {
                value.Append(i.ToString());
            }

            string fib = value.ToString().TrimStart(new Char[] { '0' });

            return String.IsNullOrWhiteSpace(fib) ? "0" : fib;
        }
    }
}
