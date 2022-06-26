using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFlippingBits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *You will be given a list of 32 bit unsigned integers. Flip all the bits (1 -> 0 and 0 -> 1) and return the result as an unsigned integer.
             *
             * Complete the 'flippingBits' function below.
             *
             * The function is expected to return a LONG_INTEGER.
             * The function accepts LONG_INTEGER n as parameter.
             */

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine().Trim());

                long result = FlippingBits(n);

                //textWriter.WriteLine(result);
                Console.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
            Console.ReadLine();
        }

        public static long FlippingBits(long n)
        {
            //O(N) solution
            long result = 0L;
            for (int i = 0; i < 32; i++)
            {
                long mask = 1;
                mask = mask << i; // shift a bit to the respective position
                if ((n & mask) == 0)
                { // check current bit is zero
                    result = result | mask; // set current bit in result to one
                }
            }

            return result;
        }
    }
}
