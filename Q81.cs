using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Q81
    {
        public static void q81()
        {
            int  sum =0;
            int[] number = new int[] { 12, 11, 13, 14, 15, 16, 1, 17, 18, 19, 20 };
            for (int i = 0; i <= number.Length-1; i++)
            {
                sum+= number[i];
            }
            Console.WriteLine(sum);
        }
    }
}
