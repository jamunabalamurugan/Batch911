using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Prj
{

   public class Phone
    {
        protected internal string phoneType;

        public Phone()
        {
            phoneType = "Regular";
            Console.WriteLine("Traditional Phone");
        }
        public Phone(string type)
        {
            phoneType = type;
            Console.WriteLine("Constructor with parameter" + type);
        }

        public void Work()
        {
            Console.WriteLine(phoneType + "Phone is used to make calls");
        }
    }

    class Mobile : Phone
    {
        public void showphone()
        {
            phoneType = "Android"; 
        }

        internal Mobile(string s):base()
        {
            phoneType = s;
        }
    }
   
     class InheritanceEg
    {
        void test()
        {
            Phone testphone = new Phone();
            testphone.phoneType = "Hand Held Device";
        }
        static void Main()
        {
            Mobile m = new Mobile("OS");
            m.Work();
            m.showphone();
            m.Work();
            Console.Read();

        }
    }
}
