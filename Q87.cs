using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Q87
    {
        public static void q87()
        {
            int[] arr = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9 };
            int count = 0;  
            foreach(int i in arr)
            {
                count++;
            }
            Console.WriteLine("Array Length = "+count);
        }
    }
}
