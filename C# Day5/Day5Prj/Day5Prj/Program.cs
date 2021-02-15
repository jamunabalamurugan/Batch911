using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Prj
{
    class Program
    {
        public virtual void Show()
        {
            Console.WriteLine("Parents Show");
        }

        public void Show1()
        {
            Console.WriteLine("Hi reached show");
        }
        public void Show1(string s)
        {
            Console.WriteLine(s);
        }
    }

    class Class1 :Program
    {
        public override void Show()
        {
            Console.WriteLine("Childs Show");
        }
    }

    class testing
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.Show2();
            p.Show();
            // Class1 c = new Class1();
            p = new Class1();
            p.Show();
            Console.Read();
           
        }
    }
}
