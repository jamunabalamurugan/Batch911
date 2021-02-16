using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Prj
{

    class GenericMethod
    {
        public void Display<T>(string msg, T value)
        {
            Console.WriteLine("{0} : {1}", msg, value);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            GenericMethod gm = new GenericMethod();
            gm.Display<int>("Integer", 122);
            gm.Display<char>("Character", '3');
            gm.Display<double>("Decimal", 255.67);
            Console.Read();
        }
    }
}
