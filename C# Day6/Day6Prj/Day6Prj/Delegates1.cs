using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Prj
{
    public delegate void EmpHandler(string s); // declaration of a delegate
    delegate int NumberChanger(int a);

    class Employee
    {
        public static void accept(string name)
        {
            Console.WriteLine("Hello:"+" " + name);
        }

        public void display(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }
    }
    class Delegates1
    {
        static void Main()
        {
            //Employee eobj = new Employee();
            //EmpHandler eh1 = new EmpHandler(Employee.accept); // static method accept is being given as a
            //                                                  //  --reference to the delegate object
            //eh1("Radha");
            //EmpHandler eh2 = new EmpHandler(eobj.display); // non -static method
            //eh2("Welcome to Delegates");
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(TestDelegate.AddNum);
            NumberChanger nc2 = new NumberChanger(TestDelegate.MultNum);
            //calling the methods using the delgate objects
            nc1(25);
            Console.WriteLine("Value of Num :{0}", TestDelegate.getNum());
            nc2(5);
            Console.WriteLine("Value of Num :{0}", TestDelegate.getNum());

            Console.ReadKey();

        }
    }
}
