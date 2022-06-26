using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALonelyInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of integers, where all elements but one occur twice, find the unique element.
             *
             *
             * Complete the 'lonelyinteger' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts INTEGER_ARRAY a as parameter.
             */

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Lonelyinteger(a);

            //textWriter.WriteLine(result);
            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            Console.ReadLine();
        }
        public static int Lonelyinteger(List<int> a)
        {
            int result = 0;
            for (int i = 0; i < a.Count; i++)
            {
                result ^= a[i];
            }
            return result;
        }
    }
}
