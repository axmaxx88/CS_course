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
            int result;
            int[] array = new int[5];
            EditArray(array, 2, 5);
            
            Add(ref sum, x, y);
            result = summ(x, y);
            
            Console.WriteLine(sum);
        }

        static int summ(int h, int v)
        {
            return h + v;
        }

        int sum = 0;
        int x;

        static void Add(ref int sum, out int x, int y = 8)
        {
            sum = x + y;
        }

        static void EditArray(int[] array, int index, int value)
        {
            array[index] = value;
        }
    }
}
