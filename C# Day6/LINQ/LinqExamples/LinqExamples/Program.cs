using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 99, 45, 53, 35 };

            var s = from n in numbers
                    where n > 50
                    orderby n
                    select n.ToString();

            foreach(var x in s)
            {
                Console.WriteLine(x);
            }
            IEnumerable<string> queryname = from st in Student.GetStudents()
                                            where st.ID==102
                                          //  where st.Name.StartsWith("S")
                                            select st.Name;

            foreach(var i in queryname)
            {
                Console.Write(i + " ");
            }

            Console.Read();
        }
    }

    public class Student
    {
        
        public int ID { get; set; }
        public string Name { get; set ;}
        public string Email { get; set; }
      
        public static List<Student> GetStudents()
        {
            List<Student> studs = new List<Student>();
           // Student ss = new Student(105, "Snithavi", "snithavi@homail.com");
            Student stud1 = new Student { ID = 101, Name = "Shaista", Email = "Shaista@gmail.com" };
            Student stud2 = new Student { ID = 102, Name = "Amit", Email = "Amit@gmail.com" };
            Student stud3 = new Student { ID = 103, Name = "Santosh", Email = "santosh@gmail.com" };
            Student stud4 = new Student { ID = 104, Name = "Rohan", Email = "Rohan@gmail.com" };
            studs.Add(stud1);
            studs.Add(stud2);
            studs.Add(stud3);
            studs.Add(stud4);  // or

           List<Student> stdlist = new List<Student>() {
        new Student() { ID = 1, Name = "Jagadeesh",Email="J@h.com" } ,
        new Student() { ID = 2, Name = "Monika", Email="M@m.com" } ,
        new Student() { ID = 3, Name = "Brijesh", Email="B@b.com" } ,
        new Student() { ID = 4, Name = "Ram" , Email="R@rm.com"} ,
        new Student() { ID = 5, Name = "Roma" ,Email="R@r.com" }
    };

            return studs;

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        }

    }
}
