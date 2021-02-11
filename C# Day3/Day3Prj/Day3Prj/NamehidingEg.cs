using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Prj
{

    class Parent
    {
        protected int data = 0;

        public void Methodhiding(string str)
        {
            Console.WriteLine("Message from Base class{0}", str);
        }

        public Parent(int a, int b)
        {
            Console.WriteLine("Parent Here...");
        }

    }

    class Child : Parent
    {
        new int data; // data here hides the data of the parent class - this is called Name Hiding
        public Child(int d1, int d2):base(d1,d2)
        {
            base.data = d1;
            data = d2;
        }
        public void Methodhiding(string str)
        {
            Console.WriteLine("Message from Child class{0}", str);
        }

        public void ShowData()
        {
            Console.WriteLine("Data in the Parent Class{0}",base.data);
            Console.WriteLine("Data in the Child Class{0}", data);
        }
    }
    class NamehidingEg
    {
        static void Main()
        {
            Parent p = new Child(2,3); // base class object can be made to point to a derived class
            // Child c1 = new Parent(); // derived classes cannot be made to point to a base class
            p.Methodhiding("Inheritance");
            Child c = new Child(10, 20);
           
            p.Methodhiding("Hi All");
            c.Methodhiding("child here");
            c.ShowData();
            Console.Read();
        }
    }
}
