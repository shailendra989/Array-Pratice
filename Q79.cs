using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Q79
    {
        public static void q79()
        {
            int[] number = new int[] { 1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for(int i =number.Length-1 ;i>=0;i--)
            {
                Console.WriteLine(number[i]);
            }
        }
    }
}
