using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Prj
{

    //declare abstract class
    abstract class AreaClass
    {
        //declare abstract method
        abstract public int Area();
        abstract public void DisplayMessage(string s);

        public void Show()
        {
           System.Console.WriteLine("Happy Learning");
        }
        
    }

    class Square : AreaClass
    {
        int side = 0;

        public Square(int x)
        {
            side = x;
        }

        public override int Area()
        {
            side = side * side;
            return side;
        }

        public override void DisplayMessage(string str)
        {
            Console.WriteLine("Hello{0}, Area of a Square is {1}", str,side);
        }

    }
    class Program 
    {
        static void Main(string[] args)
        {
            AreaClass ac = new Square(4);
            ac.Area();
            ac.DisplayMessage("911");
            ac.Show();
            Console.Read();
                
        }
    }
}
