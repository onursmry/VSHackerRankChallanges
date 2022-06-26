using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATimeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.*/

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = TimeConversion(s);

            Console.WriteLine(result);


            //textWriter.Flush();
            //textWriter.Close();
            Console.ReadLine();
        }

        public static string TimeConversion(string s)
        {
            string time = s.Substring(0, 8);
            string ampm = s.Substring(8, 2);
            string[] timeArray = time.Split(':');
            int hour = int.Parse(timeArray[0]);
            int minute = int.Parse(timeArray[1]);
            int second = int.Parse(timeArray[2]);
            if (ampm == "PM")
            {
                if (hour != 12)
                {
                    hour += 12;
                }
            }
            else
            {
                if (hour == 12)
                {
                    hour = 0;
                }
            }
            string result = $"{hour:D2}:{minute:D2}:{second:D2}";
            return result;
        }
    }
}
