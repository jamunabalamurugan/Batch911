using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Prj
{

    class Student 
    {
        private string code = "N.A";
        private string name = "Not Known";
        private int age = 0;

        //declaring properties for the fields/datamembers
        public string Code
        {
            get { return code; } 
            set {code = value; }
        }

        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return "Student Code = " + code +" " +  "Student Name =" + name +" " + "Students Age =" + age;
        }
    }
        class Properties
    {
        static void Main()
        {
            Student s = new Student();
            //set the fields of the student object
            s.Code = "007";
            s._name = "James Bond";
            s.Age = 56;
            Console.WriteLine("Student Info{0}",s.ToString());
            s.Age += 1;
            Console.WriteLine("Student Info{0}", s.ToString());
            Console.Read();

        }
    }
}
