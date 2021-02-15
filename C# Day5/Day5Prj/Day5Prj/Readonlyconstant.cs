using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Prj
{
    class Readonlyconstant
    {
        public readonly int var1 =100;
        public readonly int var2;

        public Readonlyconstant(int z)
        {
            var2 = z;
            Console.WriteLine("Value of Var1 {0}, Value of Var2{1}", var1, var2);
            Console.Read();
        }

        //static void Main()
        //{
        //    Readonlyconstant rc = new Readonlyconstant(200);
           
            
        //}

    }

    class Const
    {
        int x;  // non static variable
        static int y =10; // static variable
        const float PI= 3.14f;  // consttant Variable
        readonly bool flag; // readonly variable

        public Const(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
            

        }
        static void Main()
        {
            Console.WriteLine(Const.PI);
            Console.WriteLine(Const.y);
            Const cst = new Const(50, true);
            Console.WriteLine(cst.x + " " + cst.flag);
            Console.WriteLine("Press any Key to Exit");
            Readonlyconstant rc = new Readonlyconstant(200);
            Console.ReadKey();

        }

    }
}
