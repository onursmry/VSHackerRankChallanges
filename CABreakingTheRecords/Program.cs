using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABreakingTheRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Maria plays college basketball and wants to go pro. Each season she maintains a record of her play.
              She tabulates the number of times she breaks her season record for most points and least points in a game.
              Points scored in the first game establish her record for the season, and she begins counting from there.
            */

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable(""), true);

            //Get the game count from user
            int n = Convert.ToInt32(Console.ReadLine()?.Trim());

            //Get the points scored in each game from user separated by space
            List<int> scores = Console.ReadLine()?.TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            //Initialize the variables to calculate how many time record is broken through played games
            List<int> result = BreakingRecords(scores);

            //Print the result
            Console.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
            Console.ReadLine();
        }

        public static List<int> BreakingRecords(List<int> scores)
        {
            int min = scores[0];
            int max = scores[0];
            int minCount = 0;
            int maxCount = 0;

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                    maxCount++;
                }
                else if (scores[i] < min)
                {
                    min = scores[i];
                    minCount++;
                }
            }

            return new List<int> { maxCount, minCount };
        }

    }
}
