using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Q89
    {
        public static   void q89()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, };
            int max = arr[0];
            for(int i =1;i<arr.Length;i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
