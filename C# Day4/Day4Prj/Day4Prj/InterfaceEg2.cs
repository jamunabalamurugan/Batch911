using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Prj
{
   public interface Icustomer1
    {
        void PrintOption1();
    }

    interface Icustomer2:Icustomer1  // inheritance chain -- Implemenattion of all the methods in the chain
                                     //is a must for the derived class
    {
        void PrintOption2();
    }

    class Cust : Icustomer2
    {
       public void PrintOption1()
        {
            Console.WriteLine("Print 1 from Interface 2");
        }

       public  void PrintOption2()
        {
            Console.WriteLine("Print 2 from Interface 1");
        }
    }
    class InterfaceEg2
    {
    }
}
