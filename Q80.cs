using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Q80
    {
        public static void  q80() 
        {
            int[] number = new int[] {12,11,13,14,15,16,1,17,18,19,20 };
            for(int i = 0;i<= number.Length;i++)
            {
                if (number[i] %2 == 0)
                {
                    Console.WriteLine(number[i]);
                }
            }
        }
    }
}
