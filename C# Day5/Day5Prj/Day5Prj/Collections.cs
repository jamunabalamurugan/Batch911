using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day5Prj
{
    class Collections
    {
        static void Main()
        {
            // ArrayList al = new ArrayList();
            // al.Add(10);
            // al.Add("Ram");
            // al.Add(456.567f);
            // al.Add(true);
            // al.Add(null);
            // al.Add("collections");
            // al.Insert(5, "new value");
            // Console.WriteLine("-----------");
            // al.RemoveAt(4);
            // al.Remove(34);

            // ArrayList a2 = new ArrayList();
            // a2.Add(2);
            // a2.Add(8);
            // a2.Add(22);
            // a2.Add(0);
            // a2.Sort();
            //// a1.sort(); // can sort collections of same data type only
            // foreach (var x in al)
            // {
            //     Console.WriteLine(x);
            // }

            // foreach (var x in a2)
            // {
            //     Console.WriteLine(x);
            // }

            // //Console.WriteLine(al.Count);
            // //Console.WriteLine(al.Capacity);
            //Hashtable ht = new Hashtable();
            //ht.Add("E001", "Nilesh");
            //ht.Add("E008", "Disha");
            //ht.Add("E003", "Shrishti");
            //ht.Add("E002", "Vamsi");
            //ht.Add("E005","Neeharika");

            //foreach(var item in ht.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine(item);
            //}
            ////in order to give both key and value, we use Dictionary Entry object

            //foreach(DictionaryEntry de in ht)
            //{
            //    Console.Write(de.Key);
            //    Console.Write(de.Value);
            //    Console.WriteLine();
            //}
            //// to search the hashtable with huge records
            //Console.WriteLine("Enter a key to search");
            //string empid = Console.ReadLine();
            //if(ht.ContainsKey(empid))
            //{
            //    Console.WriteLine(empid + "=" + ht[empid]);
            //}
            //else
            //{
            //    Console.WriteLine(empid + "does not exist");
            //}

            Queue q = new Queue();
            q.Enqueue("CS.Net");
            q.Enqueue("VB.Net");
            q.Enqueue("ASP.Net");
            q.Enqueue("Core.Net");

            foreach(var item in q)
            {
                Console.WriteLine(item);
            }

            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
