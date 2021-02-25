using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mushroom
{
    class Program
    {
        public static int[] A = { 2, 3, 7, 5, 1, 3, 9 };
        public static int k = 4; //starting position
        public static int m = 6; //no. of moves possible

        //function to do prefix sum
        private int[] CountPrefixSum(int[]a)
        {
            int n = a.Length;
            int[] p = new int[n + 1];
            for(int i=1; i<=n;i++)
            {
                p[i] = p[i - 1] + a[i - 1];
            }
            return p;
        }

        //find the total between two positions
        private int CountTotal(int[]p,int x, int y)
        {
            return p[y + 1] - p[x];
        }

        public int mushrooms(int[]a, int k, int m)
        {
            int n = a.Length;
            int result = 0;
            int leftpos = 0;
            int rightpos = 0;

            int[] pref = CountPrefixSum(a);
            Console.WriteLine("M:{0} K:{1}",m,k);

            //There are 2 possible directions that the picker can move from the position k
            //we shall loop to make the moves in the left direction first, and then move towards right.
            //She cannot move beyond the K to 0 position. Hence we might need minimum of both the parameters
            Console.WriteLine("executing 0 to "+(Math.Min(m,k)+1));
            for(int p=0;p<Math.Min(m,k)+1;p++)
            {
                leftpos = k - p;
                Console.WriteLine("LeftPos:" +leftpos);
                rightpos = Math.Min(n - 1, Math.Max(k, k + m - 2 * p)); //as she moves left p pos, and moves right,
                //she has to go through the same position, and hence we are subtracting 2*p from the total(m) moves
                //she cannot move more than n-1(i.e Math.Min), also she is changing the direction hence we are using
                //Math.Max
                Console.WriteLine("RightPos:" +rightpos);
                result = Math.Max(result, CountTotal(pref, leftpos, rightpos));
                Console.WriteLine("Result" + result);
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Executing 0 to "+ Math.Min(m+1,n-k));

            //we shall now loop in the right direction and then change to the left. Exactly opposite to the above 
            for(int p=0; p<Math.Min(m+1,n-k);p++)
            {
                leftpos = k + p;
                Console.WriteLine("LeftPos:" + leftpos);
                rightpos = Math.Max(0, Math.Min(k, k - (m - 2 * p)));
                Console.WriteLine("RightPos:" + rightpos);
                result = Math.Max(result, CountTotal(pref, leftpos, rightpos));
                Console.WriteLine("Result:" + result);

            }
            return result;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.mushrooms(A, k, m);
            Console.Read();
        }
    }
}
