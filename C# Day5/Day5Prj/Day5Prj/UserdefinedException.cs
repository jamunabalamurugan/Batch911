using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Day5Prj
{

    class Votingex : ApplicationException
    {
        public Votingex(string msg):base(msg)
        {

        }
    }

    class Vote
    {
        int age;
        public void acceptage()
        {
            Console.WriteLine("Enter Your Age:");
            age = Convert.ToInt32(Console.ReadLine());
            if(age<18)
            {
                throw (new Votingex("Age should be greater than 18 to Vote"));
            }
            else
            {
                Console.WriteLine("Thanks for Voting");
            }


        }
    }
    class UserdefinedException
    {
        static void Main()
        {
            Vote v = new Vote();
            try
            {
                v.acceptage();
            }
            catch(Votingex vx)
            {
                Console.WriteLine(vx.Message);
            }
           ClassLibrary1.Class1 cc= new ClassLibrary1.Class1();
            cc.LibraryFunction1("Trupti B");

            Console.Read();
        }
    }
}
