using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDLL;

namespace Day4Prj
{
    class DLLeg
    {
        static void Main()
        {
            // MyDLL.Class1 c1 = new MyDLL.Class1();
            Class1 c = new Class1();
            int res = c.Add(5, 6);
            c.DisplayData();
            Console.WriteLine(res);
            Console.Read();


        }
    }
}
