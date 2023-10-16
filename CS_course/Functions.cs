using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course
{
    internal class Functions
    {
        static void Main(string[] args)
        {
            int sum = 0, x = 1, y = 5;
            Add(ref sum, x, y);
            Console.WriteLine(sum);
        }

        static int summ(int h, int v)
        {
            return h + v;
        }

        static void Add(ref int sum, int x, int y = 8)
        {
            sum = x + y;
        }
    }
}
