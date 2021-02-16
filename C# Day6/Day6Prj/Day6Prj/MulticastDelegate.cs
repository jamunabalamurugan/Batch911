using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Prj
{
    public delegate void Multicast();
    class MulticastDelegate
    {
        static void Main()
        {
            //MulticastDelegate mcd = new MulticastDelegate();
            //Multicast d1, d2, d3, d4;
            //d1 = new Multicast(Method1);
            //d2 = new Multicast(Method2);
            //d3 = new Multicast(Method3);
            //d4 = d1 + d2 + d3; // multicasting using +    
            //d4();
            //or just create one delegate object and cast it to other functions of the same signature
            Multicast d1 = new Multicast(Method1);
            d1 += Method2;
            d1 += Method3;
            d1();
            d1 -= Method3;
            d1();
            Console.Read();


        }

        public static void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }
        public static void Method3()
        {
            Console.WriteLine("Method 3");
        }
    }
}
