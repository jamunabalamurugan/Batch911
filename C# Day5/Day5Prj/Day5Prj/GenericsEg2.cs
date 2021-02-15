using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Prj
{
    class GenericsEg2<T>
    {
        T data; // private generic field /data member

        // let us declare generic property
        public T Prop
        {
            get { return data; }
            set { data = value; }
        }
    }

    class Tester
    {
        static void Main()
        {
            GenericsEg2<string> name = new GenericsEg2<string>(); // instance of string data type
            name.Prop = "Batch 911";
            // instance of float data type

            GenericsEg2<float> version = new GenericsEg2<float>();
            version.Prop = 5.5f;

            //display the contents
            Console.WriteLine(name.Prop);
            Console.WriteLine(version.Prop);

            Console.Read();
        }
    }
}
