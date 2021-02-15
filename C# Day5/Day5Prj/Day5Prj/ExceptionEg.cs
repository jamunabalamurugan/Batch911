using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Prj
{
    class ExceptionEg
    {
         static int c;
        static void Main()
        {
            
            try
            {
                int a, b;
                Console.WriteLine("Enter 2 nos:");
                a = int.Parse(Console.ReadLine());

                b = int.Parse(Console.ReadLine());
                c = a / b;
                int[] arr1 = { 2, 3, 4, 5 };
                Console.WriteLine(arr1[6]);
                Console.WriteLine(c);
                Console.Read();
            }
            
            /*catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Source +" " +e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Program was trying to access beyound the given Index");
                Console.Read();
            }*/
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                Console.WriteLine(c);
                Console.Read();
            }
        }
    }
}
