using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Q83
    {
        public static void q83()
        {
            int sum = 0;
            int[] number = new int [] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17 };
            for(int i =0;i<number.Length;i++)
            {
                if (number[i] % 2 == 0)
                {
                    sum+= number[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
