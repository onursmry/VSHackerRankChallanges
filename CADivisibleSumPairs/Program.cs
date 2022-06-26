using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADivisibleSumPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of integers and a positive integer k, determine the number of (i,j) pairs where i<j and ar[i] + ar[j]  is divisible by k.             
             * Complete the 'divisibleSumPairs' function below.
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER n
             *  2. INTEGER k
             *  3. INTEGER_ARRAY ar     
             */

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine()?.TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine()?.TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = DivisibleSumPairs(n, k, ar);

            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            Console.ReadLine();
        }

        public static int DivisibleSumPairs(int n, int k, List<int> ar)
        {
            //O(N) solution
            int result = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = n - 1; i >= 0; i--)
            {
                int pair = ar[i] % k;
                if (dict.ContainsKey(pair))
                {
                    result += dict[pair];
                }

                if (pair == 0)
                {
                    pair = k;
                }
                if (dict.ContainsKey(k - pair))
                {
                    dict[k - pair]++;
                }
                else
                {
                    dict.Add(k - pair, 1);
                }
            }

            return result;
        }
    }
}
