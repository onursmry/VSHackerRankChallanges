using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMatchingStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * There is a collection of input strings and a collection of query strings.
             * For each query string, determine how many times it occurs in the list of input strings.
             * Return an array of the results.
             * Complete the 'matchingStrings' function below.
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts following parameters:
             * 1. STRING_ARRAY strings
             * 2. STRING_ARRAY queries
             */

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> strings = new List<string>();

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings.Add(stringsItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            List<int> res = MatchingStrings(strings, queries);

            //textWriter.WriteLine(String.Join("\n", res));
            
            Console.WriteLine(String.Join("\n", res));

            //textWriter.Flush();
            //textWriter.Close();
            Console.ReadLine();
        }

        public static List<int> MatchingStrings(List<string> strings, List<string> queries)
        {
            List<int> matchCount = new List<int>();
            for (int i = 0, j = 0; i < queries.Count; i++)
            {
                for (int k = 0; k < strings.Count; k++)
                {
                    if (queries[i].Equals(strings[k]))
                        j++;
                }
                matchCount.Add(j);
                j = 0;
            }

            return matchCount;
        }
    }
}
