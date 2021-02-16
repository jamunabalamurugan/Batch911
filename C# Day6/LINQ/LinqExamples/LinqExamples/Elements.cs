using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Elements
    {
        static void ElementAt()
        {
            string[] words = {"Red","Blue" };

            // var result = words.ElementAtOrDefault(1);

            var res = words.Single();
                Console.WriteLine(res);
        }

        static void Main()
        {
            ElementAt();
            Console.Read();
        }
    }
}
