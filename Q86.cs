using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Q86
    {
        public static int[] Array()
        {  

            Console.WriteLine("Input a size -");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

                for(int i = 0; i < size; i++)
                { 
                Console.WriteLine("enter a array");
                int x = Convert.ToInt32(Console.ReadLine());
                arr[i] = x;


                 }
                 return arr;

        }
    }
}
