using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAGradingStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *HackerLand University has the following grading policy:
               
               Every student receives a grade in the inclusive range from 0 to 100.
               Any grade less than 40 is a failing grade.
            
               Sam is a professor at the university and likes to round each student's grade according to these rules:
               
               If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5.
               If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.
             *
             *
             * Complete the 'gradingStudents' function below.
             *
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts INTEGER_ARRAY grades as parameter.
             */

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = GradingStudents(grades);

            //textWriter.WriteLine(String.Join("\n", result));
            Console.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
            Console.ReadLine();
        }
        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {
                int grade = grades[i];
                if (grade < 38)
                {
                    result.Add(grade);
                }
                else
                {
                    int nextMultiple = grade + (5 - (grade % 5));
                    if (nextMultiple - grade < 3)
                    {
                        result.Add(nextMultiple);
                    }
                    else
                    {
                        result.Add(grade);
                    }
                }
            }
            return result;
        }
    }
}
