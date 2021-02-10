using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Prj
{
    class ParametersnMethods
    {
        static void Main(string[] args)
        {
           /* int i = 10;
            ParametersnMethods.SimpleValMethod(i); //Method Parameter by Value (calling a function by Value)
            Console.WriteLine(i);
            ParametersnMethods pm = new ParametersnMethods();
            pm.SimpleRefMethod(ref i); //call by Reference
            Console.WriteLine(i);
            int Total = 0;
            int Prod = 0;
            int Diff = 0;
            int div= Calculate(3, 2, out Total, out Prod, out Diff );// Output parameter based function call
           Console.WriteLine("Sum={0}, Product ={1}, Difference={2}, Division={3}",Total,Prod,Diff,div);*/

            int[] num = new int[3];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            ParamsMethod(); //0 arguments or parameters or input 
            ParamsMethod(num); // arraylist with 3 arguments or parameters
            ParamsMethod(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 23);  // comma seperated values
            Console.Read();
        }
        public static void SimpleValMethod(int j)
        {
            j = 100;
            Console.WriteLine(j);
        }

        public void SimpleRefMethod(ref int j)
        {
            Console.WriteLine(j);
            j = 100;
            Console.WriteLine(j);
        }

        public static int Calculate(int a, int b, out int sum, out int product,out int diff)
        {
            
            sum = a + b;
           product = a * b;
             diff = a - b;
            int div = a / b;
            return div;
            
        }

        public static void ParamsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements",numbers.Length);
            foreach(int x in numbers)
            {
                Console.WriteLine(x);
            }

        }

        
    }
}
