using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Q90
    {
        public static void q90()
        {
            int[] arv = { 1, 2, 3, 5, 6, 7, 8, 9, };
            int min = arv[0];
            for(int i =1;i<arv.Length;i++)
            {
                if (arv[i] < min)
                {
                    min = arv[i];
                }
            }
            Console.Write(min);
        }
    }
}
