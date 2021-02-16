using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class LambdaExp
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 16, 23, 12, 19, 42, 28, 57, 7, 9, 30 };

            //use Lambda expression to calculate square of each number in the collection

            var square = numbers.Select(x => x * x);

            // find all numbers that are divisible by 3

            //foreach(var value in square)
            //{
            //    Console.WriteLine(value);
            //}

            List<Employee> empList = new List<Employee>()
            {
                new Employee{_ID=10,_Name="Ashok"},
                 new Employee{_ID=11,_Name="Malathi"},
                  new Employee{_ID=12,_Name="Bhupesh"}

            };

            var sortedemplist = empList.OrderBy(a => a._Name);

            foreach(var c in sortedemplist)
            {
                Console.WriteLine(c._ID + " " + c._Name);
            }
            Console.Read();
        }
    }

    class Employee
    {
        int ID;
        string Name;

        public int _ID
        {
            get;
            set;
        }

        public string _Name
        {
            get;set;
        }
    }
}
