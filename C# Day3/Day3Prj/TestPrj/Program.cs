using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day3Prj;

namespace TestPrj
{
    class Program : Phone
    {
        void checkaccess()
        {
           
        }
        static void Main(string[] args)
        {
            Employee e = new Day3Prj.Employee();
           // Student s = new Student();
            Ipod ip = new Ipod();
            ip.Work();
            Console.Read();
        }
    }

    class Ipod: Phone
    {
        void phoneDetails()
        {
            phoneType = "Ipod";
        }

    }
}
