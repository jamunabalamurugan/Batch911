using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Prj
{

   public class Employee
    {
         internal int Empid;  // access specifiers tell us the visibility of any member in the class
         string EmpName;
        float Salary;

       internal void DisplayEmp()
        {
            Console.WriteLine("Emp Id :{0}, EmpName:{1}, Emp salary:{2}",Empid,EmpName,Salary);
           // Console.Read();
        }

    public Employee()
        {
           // Empid = 0;
           // EmpName = "0";
          //  Salary = 0.0f;
            Console.WriteLine("Constructor with zero parameters  called");
        }

        public Employee(int Empid, string EmpName, float s)
        {
            this.Empid = Empid;
            this.EmpName = EmpName;
            Salary = s;

        }

        public Employee(int id, string name)
        {
            Empid = id;
            EmpName = name;
        }
       
        public void acceptEmpDetails()
        {
            Console.WriteLine("Enter Emp id, Name and Salary");
            Empid = Convert.ToInt32(Console.ReadLine());
            EmpName = Console.ReadLine();
            Salary = float.Parse(Console.ReadLine());
        }
        ~Employee()
        {

          Console.WriteLine("Bye from the Destructor");
        }

    }
    class Program
    {
        ~Program()
        {

        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp1 = new Employee(25,"Banurekha",10000.45f);
            //  
            Program p = new Program();
            emp.DisplayEmp();
            // emp.acceptEmpDetails();
            //   emp.DisplayEmp();
            //    emp.Empid = 100;
            //  emp.EmpName = "Saarang";
            //    emp1.acceptEmpDetails();
            //  emp1.DisplayEmp();
            emp = null;
           // emp1 = null;
            GC.Collect();
            Console.Read();
        }
        
    }
}
