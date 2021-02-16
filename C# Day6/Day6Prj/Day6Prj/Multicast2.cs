using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Prj
{
    delegate int delreturn(int x);

    class Sample
    {
        static int data;

        public int Square(int x)
        {
            data = x * x;
            return data;
        }

        public int triplet(int q)
        {
            data = q * q * q;
            return data;
        }
    }
    class Multicast2
    {
        static void Main()
        {
            Sample s = new Sample();
            delreturn del1 = new delreturn(s.Square);
            //  delreturn del2 = new delreturn(s.triplet);
            del1 += s.triplet;
           int retval= del1(5);
            Console.WriteLine(retval);
            Console.Read();

        }
    }
}
