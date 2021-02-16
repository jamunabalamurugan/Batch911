using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Prj
{
    class HelloBatch
    {
        //Array of field of a particulat datatype
        private string[] names = new string[3];
        string[] address = new string[3];
        public void accept()
        {
            
        }
        //declare indexers for the field
        public string this[int flag]
        {
            get
            {
                string temp = names[flag];
                return temp; //or  return names[flag];

            }
            set
            {
                names[flag] = value;
            }
        }
            public string this[float flag]
        {
            get
            {
                return address[(int)flag];

            }
            set
            {
                address[(int)flag] = value;
            }
        }
        }
   
    class IndexersEg
    {
        static void Main()
        {
            HelloBatch hb = new HelloBatch();
            hb[0] = "Hello"; // value of the names[0]
            hb[0.0f] = "Batch"; // value at names[1]
            hb[2] = "911"; // values at names[2]
            Console.WriteLine(hb[0] + hb[1] + hb[2]);
            Console.Read();

        }
    }
}
