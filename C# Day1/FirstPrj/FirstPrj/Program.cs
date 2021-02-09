using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPrj
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Hello All ! Welcome to C Sharp Programming");
            Console.WriteLine("Please enter your Name:");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter your Age:");
            int age = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Welcome Dear" + " "+ uname); // concatenation
            Console.WriteLine("Welcome Dear {0} {1}",uname,age ); //placeholder outputs
            string s = "AAA";
            object o = s;//implicit 
            o = age;//boxing
            age = (int)o; // unboxing
            /* int i = 100;
             float f1 = i; // implicit conversion
             float f = 123.45f;
             i =(int) f; // explicit conversion by typecasting
                              
             Console.WriteLine(i);*/

            //try Parse
            /* string str = "100ab";
             int result = 0;
             bool status = int.TryParse(str, out result);
             if(status)
             {
                 Console.WriteLine(result);
             }
             else
             {
                 Console.WriteLine("Invalid Data supplied");
             }*/

            //Nullable concepts
            int? Ticketsonsale = 100;
            int AT;
            if(Ticketsonsale==null)
            { 
                AT = 0;
            }
            else
            {
               // AT =(int) Ticketsonsale; // or
               AT = Ticketsonsale.Value;
            }
            Console.WriteLine("Available Tickets = {0}", AT);
            Console.Read();
        }
    }
}
