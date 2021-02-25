using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Maxcounters
    {
        public int[] solution(int N, int[] A)
        {
            int min = 0, max = 0;
            int[] counter = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= 1 && A[i] <= N)
                {
                    if (counter[A[i] - 1] < min)
                    {
                        counter[A[i] - 1] = min;
                    }
                    counter[A[i] - 1]++;
                    if (counter[A[i] - 1] > max)
                    {
                        max = counter[A[i] - 1];
                    }
                    else
                    {
                        min = max;
                    }
                }
            }

                for (int j = 0; j < counter.Length; j++)
                {
                    if (counter[J] < min)
                    {
                        counter[j] = min;
                    }
                }
                return counter;
            }
        }


    }
