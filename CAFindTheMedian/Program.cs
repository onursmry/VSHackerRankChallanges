using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFindTheMedian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Complete the 'findMedian' function below.        
             * The function is expected to return an INTEGER.
             * The function accepts INTEGER_ARRAY arr as parameter.
             */
            int n = Convert.ToInt32(Console.ReadLine()?.TrimEnd());


            List<int> arr = Console.ReadLine()?.TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            FindMedian(arr);
        }

        public static void FindMedian(List<int> arr)
        {
            //O(N) solution
            int result = 0;
            List<int> sorted = arr.OrderBy(x => x).ToList();
            int mid = sorted.Count / 2;
            if (sorted.Count % 2 == 0)
            {
                result = (sorted[mid] + sorted[mid - 1]) / 2;
            }
            else
            {
                result = sorted[mid];
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
