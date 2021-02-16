using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Prj
{
    class Employee : IComparable
    {
        int Empid;
        String Empname;
        string Company;
        float Sal;

        public int CompareTo(Employee second)
        {
            if(this.Sal==second.Sal)
            {
                return this.Empid.CompareTo(second.Empid);
            }
            return second.Sal.CompareTo(this.Sal);
        }
        public Employee(int id, string name, string co, float sal)
        {
            Empid = id;
            Empname = name;
            Company = co;
            Sal = sal;
        }

        public void Show()
        {
            Console.WriteLine(Empid + "" +"With Name:" + " " + Empname + "Works For" + " " + Company + " " + "and earns Rs:" + Sal);
        }

        public void ShowSal()
        {
            Console.WriteLine(Sal);
        }
    }
    class GenericsEg
    {
        static void Main()
        {
            // List<int> lst = new List<int>();
            // lst.Add(45);
            // lst.Add(15);
            // lst.Add(12);
            // lst.Add(145);

            // lst.Sort();
            // foreach(int i in lst)
            // {
            //     Console.WriteLine(i);
            // }

            // //Hashtable of collections is equal to Dictionary in Gnerics
            // Dictionary<int, string> de = new Dictionary<int, string>();
            // de.Add(4, "Red");
            // de.Add(1, "Black");
            // de.Add(7, "Orange");
            // de.Add(2, "Blue");

            // foreach(int item in de.Keys)
            // {
            //     Console.WriteLine(item);
            // }

            // foreach (string item in de.Values)
            // {
            //     Console.WriteLine(item);
            // }

            // foreach(KeyValuePair<int,string> item in de)
            // {
            //     Console.Write(item.Key);
            //     Console.Write(item.Value);
            //     Console.WriteLine();

            // }
            // //to search the dictionary object
            // Console.WriteLine("Enter the id:");
            //int x= Convert.ToInt32(Console.ReadLine());
            // if(de.ContainsKey(x))
            // {
            //     Console.Write(x + "represents" + " " + de[x]);
            // }
            // else { 
            //     Console.WriteLine("enter a valid id");
            // }

            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee(101, "Ruma", "LTI", 25000));
            emp.Add(new Employee(105, "Ankur", "LTI", 26000));
            emp.Add(new Employee(102, "Falguni", "LTI", 28000));

            foreach(Employee e in emp)
            {
                e.Show();
            }
            emp.Sort();

            foreach(Employee item in emp)
            {
                item.ShowSal();
            }


            Console.Read();
        }
        
        
        
    }
}
