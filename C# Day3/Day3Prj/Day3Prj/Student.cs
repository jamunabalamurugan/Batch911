using System;



namespace Day3Prj
{
   public class Student
    {
        protected string name;

        internal Student()
        {
            Console.WriteLine("Base class non parametrized constructor invoked");
        }

        internal Student(string nm)
        {
            name = nm;
        }
         void show()
        {
           System.Console.WriteLine(name);
        }
    }

    class DaysScholar : Student
    {
        int room_no;


        public DaysScholar(string name, int room):base(name)
        {
         
            room_no = room;
        }

        public void ShowStudent()
        {
            Console.WriteLine("{0},{1}", name,room_no);
        }
    }

    class TestInheritance
    {
        static void Main()
        {
            DaysScholar ds = new DaysScholar("Ashok", 12);
            ds.ShowStudent();
            Console.Read();

        }
    }
}
