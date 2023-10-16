using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_B_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(78, 95));
            Console.WriteLine(test(95, 95));
            Console.WriteLine(test(99, 70));
            Console.ReadLine();
        }
        public static int test(int a, int b)
        {
            const int n = 100;
            var val = Math.Abs(a - n);
            var val2 = Math.Abs(b - n);

            return val == val2 ? 0 : (val < val2 ? a : b);
        }
    }
}
