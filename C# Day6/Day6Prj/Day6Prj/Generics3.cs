using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Prj
{
    class Generics3<T> where T:GenericMethod
    {
        T phno;
        public dynamic Total<T>(T Maths, T Science1, T Science2)
        {
            dynamic m = Maths;
            dynamic s1 = Science1;
            dynamic s2 = Science2;
            return m + s1 + s2;
        }

        public void GetData<T>(T val, T val1)
        {
            Console.WriteLine("{0},{1}", val, val1);
        }
    }

    class CheckGeneric
    {
        static void Main()
        {
            Generics3<GenericMethod> gobj = new Generics3<GenericMethod>();
            double sum = gobj.Total<float>(75.65f, 89.07f, 90.65f);
            Console.WriteLine(sum);
            
            gobj.GetData<int>(45,'a');
            gobj.GetData<string>("A", "hello");

            Console.Read();
        }
    }
}
