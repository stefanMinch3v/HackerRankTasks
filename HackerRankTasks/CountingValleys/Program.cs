namespace CountingValleys
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        // Solution passed all tests 100/100
        /// <summary>
        /// https://www.hackerrank.com/challenges/counting-valleys/problem
        /// </summary>
        public static void Main()
        {
            var steps = int.Parse(Console.ReadLine());
            var path = Console.ReadLine();

            var result = CountingValleys(steps, path);
            Console.WriteLine(result);
        }

        private static int CountingValleys(int steps, string path)
        {
            const char Down = 'D';
            const char Up = 'U';

            var savedPath = new Stack<int>();
            var stepsInPath = 0;
            var countValleys = 0;

            if (steps != path.Length)
            {
                return 0;
            }

            if (path.Any(ch => ch != Up && ch != Down))
            {
                return 0;
            }

            for (int i = 0; i < path.Length; i++)
            {
                var currentStep = path[i];

                if (currentStep == Down)
                {
                    stepsInPath += 1;
                }
                else
                {
                    stepsInPath -= 1;
                }

                savedPath.Push(stepsInPath);

                if (stepsInPath == 0)
                {
                    var lastElement = savedPath.Skip(1).FirstOrDefault();
                    if (lastElement > 0) // if its positive then shows that the path comes out from valley.
                    {
                        countValleys++;
                    }
                }
            }

            return countValleys;
        }
    }
}
