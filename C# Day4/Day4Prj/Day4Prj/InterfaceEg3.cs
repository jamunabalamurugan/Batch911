using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Prj
{
    //explicit implementation of interface

    interface I1
    {
        void IMethod();
    }

    interface I2
    {
        void IMethod();
    }

    

    class Checker : I1, I2
    {
      public void IMethod()
        {
            Console.WriteLine("Interface 1 Method 1");
        }

        void I2.IMethod()
        {
            Console.WriteLine("Interface 2 Method 2");
        }

    }

    class InterfaceEg3
    {
        static void Main()
        {
            Checker c = new Checker();
            /*  ((I1)c).IMethod();
              ((I2)c).IMethod();
              Console.Read();

              I1 i1 = new Checker();
              I2 i2 = new Checker();
              i1.IMethod();
              i2.IMethod();*/
            c.IMethod();
            Console.Read();

        }

    }
}
