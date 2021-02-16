using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Aggregates
    {
        static void Aggr1()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, };

             var result = numbers.Aggregate((a, b) => a * b);
             Console.WriteLine("Aggregates Multiplication:{0}",result);

                     
        }

        static void Main()
        {
            Aggr1();
            int[] num = { 4, 5, 6, 3, 7, 8 };

            var avg = num.Average();
            var ctr = num.Count();
            Console.WriteLine(avg + " " + ctr);
            Console.Read();
        }
    }
}
