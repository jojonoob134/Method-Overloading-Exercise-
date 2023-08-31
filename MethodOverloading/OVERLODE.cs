using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class OVERLODE
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void Add(bool money, int a, int b)
        {
            int total = a + b;
            if (money == true && total <= 1)
            {
                Console.WriteLine($"you have {total} dollar in total");
            }
            else if (money == true)
            {
                Console.WriteLine($"you have {total} dollars in total");
            }
            else
            {
                Console.WriteLine(total);
            }
        }
    }
}
