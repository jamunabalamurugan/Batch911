using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Prj
{
    class Test
    {
        enum days { Sun,Mon,Tue,Wed,Thur,Fri,Sat};

        static void Main(string[] args)
        {
            int week_start = (int)days.Mon;
            int week_end = (int)days.Fri;
            Console.WriteLine("Monday: {0}",week_start);
            Console.WriteLine("Friday: {0}", week_end);
            Console.ReadKey();
        }
    }
}
