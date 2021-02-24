using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Iterations
{
    class Test
    {
        static void Main()
        {
            testfunction();
            Console.Read();
        }
        public static void testfunction()
        {
            //try
            //{
                       
            //string[] words = { "one", "two", "three" };
            //var result=words.SingleOrDefault();
            //Console.WriteLine(result);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            string[] words = { "one", "two", "three" };
            var result = words.LastOrDefault();
            Console.WriteLine(result);
            ArrayList a = new ArrayList();
            a.Add(10);
            a.Add(45);
            a.Add("aaa");
            a.Add("AAA");
            a.Add("BBB");
            a.Add("XXX");

            foreach (var v in a)
            {
                Console.WriteLine(v);
            }

            a.RemoveAt(2);

            foreach (var v in a)
            {
                Console.WriteLine(v);
            }
            Console.Read();
        }
    }
}
