using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOOPLAB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine(sum(a,b));
        }

        public static int sum(int a, int b)
        {
            ++a;
            b++;
            return a + b;
        }
            
    }
}
