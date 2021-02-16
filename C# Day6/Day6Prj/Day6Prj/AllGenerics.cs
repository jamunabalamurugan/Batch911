using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Prj
{
    class AllGenerics<T> where T:class
    {
        T genericMember;

        public AllGenerics(T val)
        {
            genericMember = val;
        }

        public T genericProperty { get; set; }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter Type :{0}, Value :{1}", typeof(T).ToString(),genericParameter);
            Console.WriteLine("Return Type:{0}, value :{1}",typeof(T).ToString(), genericMember);
            return genericMember;
        }
    }

    class Eval
    {
        static void Main()
        {
            //declaring object of a specific type - int
           // AllGenerics<int> ag = new AllGenerics<int>(10);
            //int retval = ag.genericMethod(200);
           // ag.genericProperty = 500;
          //  Console.WriteLine(ag.genericProperty);

            AllGenerics<string> ags = new AllGenerics<string>("Hi Generics");

            string s = ags.genericMethod("generics with string data type");

            ags.genericProperty = "Hello";
            Console.WriteLine(ags.genericProperty);

            Console.Read();
            

        }
    }
}
