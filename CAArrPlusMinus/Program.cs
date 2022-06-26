using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAArrPlusMinus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Bir tamsayı dizisi verildiğinde, elemanlarının pozitif, negatif ve sıfır oranlarını hesaplayın.
             * Her kesrin ondalık değerini, ondalıktan sonra 6 basamak olacak şekilde yeni bir satıra yazdırın.
             */
            Console.WriteLine("Dizinizin eleman sayısını giriniz:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Lütfen yalnızca sayı girişi yapınız.");
            }
               
            int[] integerArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                //get array elements with int.TryParse
                Console.WriteLine($"{i+1}. Elemanı giriniz:");
                while (!int.TryParse(Console.ReadLine(), out integerArray[i]))
                {
                    Console.WriteLine("Lütfen yalnızca sayı girişi yapınız:");
                }
            }

           // List<int> arr = Console.ReadLine()?.TrimEnd().Split(' ').ToList().Select(intArray => Convert.ToInt32(intArray)).ToList();

            List<int> arr = integerArray.ToList();

            Result.PlusMinus(arr);
        }

    }

    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void PlusMinus(List<int> arr)
        {
            int n = arr.Count;
            decimal zero = 0, pos = 0, neg = 0;
            foreach (int a in arr)
            {
                if (a > 0)
                {
                    pos += 1;
                }
                else if (a < 0)
                {
                    neg += 1;
                }
                else
                {
                    zero += 1;
                }
            }

            Console.WriteLine($"{pos / n:F6}");
            Console.WriteLine($"{neg / n:F6}");
            Console.WriteLine($"{zero / n:F6}");

            Console.ReadLine();
        }

    }
}


