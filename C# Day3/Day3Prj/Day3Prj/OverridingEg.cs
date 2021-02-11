using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Prj
{
    class Shape
    {
        protected float R, L, B;

        public virtual float Area()
        {
            Console.WriteLine("Reached Base class Area");
            return 3.14F * R * R;
        }

        public virtual float Circumference()
        {
            return 2 *  R;
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.WriteLine("Enter Length:");
            L = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth:");
            B = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
           // base.Area();
            return L * B;
        }

        public override float Circumference()
        {
            return 2 * (L + B);
        }
    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.WriteLine("Enter Radius:");
            R=float.Parse(Console.ReadLine());

        }
    }
    class OverridingEg
    {
        static void Main()
        {
         
            Rectangle r = new Rectangle();
            r.GetLB();
            Console.WriteLine("Area : {0}", r.Area());
            Console.WriteLine("Perimeter:{0}",r.Circumference());
            Console.WriteLine();
            Circle c = new Circle();
            c.GetRadius();
            Console.WriteLine("Area of the Circle :{0}", c.Area());
            Console.WriteLine("Circumference of the Circle :{0}", c.Circumference());
            Console.Read();
        }
    }
}
