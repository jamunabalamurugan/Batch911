using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Prj
{
    public partial class Flower
    {
        string name;
        string color;

        public Flower(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void Display()
        {
            Console.WriteLine(name + " " + " in" + color + " " + "color");
        }
    }

    class FlowerVase
    {
        Flower[] fob = new Flower[5];

        public Flower this[int pos]
        {
            get { return fob[pos]; }
            set { fob[pos] = value; }
        }

        static  void Main()
        {
            FlowerVase fv = new FlowerVase();
            fv[0] = new Flower("Rose", "Red");
            fv[1] = new Flower("Violets", "Blue");
            fv[2] = new Flower("Lily", "white");
            fv[3] = new Flower("Hibiscus", "Pink");
            for (int i =0; i<4; i++)
            {
                fv[i].Display();
            }
           
            Console.Read();
        }
    }
    class Indexers2
    {
    }
}
