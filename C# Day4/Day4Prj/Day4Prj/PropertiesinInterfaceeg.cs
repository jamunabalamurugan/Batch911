using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Prj
{
    interface IName
    {
        string Name { get; set; }  // property Name is just Declared
        int Age { get; set; }
    }

    class Employee : IName
    {
        public string Name { get; set; }
        public int Age { get; set; }
       
    }

    class Company :IName
    {
        private string _company { get; set; }
        private int _age { get; set; }
        public string Name
        {
            get { return _company; }
            set { _company = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
    class Client
    {
        static void Main()
        {
            IName e = new Employee();
            e.Name = "Tilak";
            IName c = new Company();
            c.Name = "LTI";
            Console.WriteLine("{0} from {1} is {2} years old ", e.Name,c.Name,c.Age);
           // Client cc = new Client();
            Console.Read();
        }
    }
}
