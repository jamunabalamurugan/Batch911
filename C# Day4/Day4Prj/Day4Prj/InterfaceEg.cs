using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Prj
{
    interface ICustomer // inreface decaration
    {
        void Print();   // abstract method - only declaration
    }

    interface ISupplier
    {
        void Show();
    }

    //interface Icustomer2 : ICustomer
    //{
    //    void Print2();
    //}

    class Customer : ICustomer,ISupplier
    {
        public void Print()
        {
            Console.WriteLine("Printing from Customer Interface");
            
        }

        public void Show()
        {
            //Console.WriteLine("Printing From Supplier Interface");
        }
    }
    class InterfaceEg
    {
        public static void Main()
        {
            Customer c = new Customer();
            c.Print();
            c.Show();
            Console.Read();
        }
    }
}
