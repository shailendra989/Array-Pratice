using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Class1
    {
        public static void c1()
        {
            string[] weakdays;

            weakdays = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
             
            for (int i = 0; i <= weakdays.Length; i++)
            {
                Console.WriteLine(weakdays[i]);
            }
        }
    }
}
