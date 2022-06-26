using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMaxMinSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Beş pozitif tam sayı verildiğinde, beş tam sayıdan dördünü toplayarak hesaplanabilecek minimum ve maksimum değerleri bulun. Ardından ilgili minimum ve maksimum değerleri, boşlukla ayrılmış iki uzun tamsayıdan oluşan tek bir satır olarak yazdırın. */

            int[] integerArray = new int[5];  //dizi oluştur

            for (int i = 0; i < integerArray.Length; i++)
            {
                //Kullanıcıdan dizinin elemanlarını al
                Console.Write($"{i+1}. Elemanı giriniz: ");
                while (!int.TryParse(Console.ReadLine(), out integerArray[i]))
                {
                    Console.WriteLine("Lütfen sadece sayısal değer giriniz:");
                }
            }

            List<int> arr = integerArray.ToList();

            MiniMaxSum(arr);

            Console.ReadLine();
        }

        public static void MiniMaxSum(List<int> arr)
        {
            //5 tam sayıdan 4ünü toplayarak bulunabilecek minimum ve maksimum toplam değerlerini bul
            arr.Sort();
            Int64 miniSum =0, maxiSum=0,sum=0;
            foreach (Int64 item in arr)
            {
                sum += item;
            }

            miniSum = sum - arr[arr.Count - 1];
            maxiSum = sum - arr[0];

            //print to console
            Console.WriteLine($"{miniSum}  {maxiSum}");
        }
    }
}
