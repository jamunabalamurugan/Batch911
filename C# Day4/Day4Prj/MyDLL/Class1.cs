using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDLL
{
    public class Class1
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public void DisplayData()
        {
            Console.WriteLine("I am your DLL" );

        }

       
    }
}
