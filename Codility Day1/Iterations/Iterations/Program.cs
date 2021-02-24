using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int res = sol(num);
            //Console.WriteLine(res);
            int[] A = { 4, 5, 6, 3, 2 };
            int k = 3;
                       
            Console.WriteLine(solution(A,k));
            Console.Read();
        }

        public static int sol(int N)
        {
            bool startpoint = false;
            int len = 0, result = 0;
            if (N == 0)
                return 0;
            for(uint i=1;i<N;i<<=1)
            {
                if((i & N)!=0)
                {
                    if(startpoint)
                    {
                        if(len>result)
                        {
                            result = len;
                        }
                        len = 0;
                    }
                    startpoint = true;
                }
                else
                {
                    if (startpoint == true)
                        len++;
                }
            }
            return result;
        }
        public static int[] solution(int[] A, int K)
        {
            while (K > 0 && A.Length > 0)
            {
                int[] arr1 = A.Take(A.Length - K).ToArray();
                int[] arr2 = A.Skip(A.Length - K).ToArray();
                A = arr2.Concat(arr1).ToArray();
                K -= A.Length;
            }
            return A;
        }
    }
}
