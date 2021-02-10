using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Prj
{
    class Program
    {
       static void Main(string[] args) // not a member function, but a member
        {
            /* Program p = new Program();
            // Program.Msg("Banurekha"); // calling a static function
           int answer= p.add(5, 10); //calling an instance function
             Console.WriteLine(answer);
             p.display();*/

            Sample s1 = new Sample();
            s1.v1 = 10;
            s1.v2 = 20;
            Console.WriteLine(s1.v1 + s1.v2);
            Sample s2 = new Sample();
            s2 = s1; //implicit conversion
            Console.WriteLine(s2.v1 + s2.v2);
            s1.v1 = 40;
            s1.v2 = 50;
            Console.WriteLine("After reassigning values to s1");
            Console.WriteLine(s1.v1 + s1.v2);
            Console.WriteLine(s2.v1 + s2.v2);
            //implicitly typed variables
            int i;
            i = 10;
            float fl = 23.67f;
            bool b = true;
            var x= "abc";
            dynamic d;
            d = 10*5;
            Console.WriteLine(d);
            d = null;
            d = "AAA";
            d = 56.7f;
            d = true;
                          

            Console.Read();
        }

       public int add(int a, int b)  // instance method
        {
            return a + b;
        }

        public void display() // instance function or method
        {
            Console.WriteLine("Hello World");
           
        }

        public static void Msg(string name) // static method
        {
            Console.WriteLine("Hello" + name);
        }

    }

    class Sample
    {
        public int v1;
        public int v2;
    }


    
}
