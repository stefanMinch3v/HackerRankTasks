namespace CompareTheTriplets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        // Solution passed all tests 100/100
        /// <summary>
        /// https://www.hackerrank.com/challenges/compare-the-triplets/problem
        /// </summary>
        public static void Main()
        {
            var aliceInput = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var bobInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var result = CompareTriplets(aliceInput, bobInput);

            Console.WriteLine(string.Join(", ", result));
        }

        private static List<int> CompareTriplets(List<int> aliceInput, List<int> bobInput)
        {
            const string Alice = "Alice";
            const string Bob = "Bob";

            var points = new Dictionary<string, int>();
            points.Add(Alice, 0);
            points.Add(Bob, 0);

            var minCounter = Math.Min(aliceInput.Count, bobInput.Count);
            for (int i = 0; i < minCounter; i++)
            {
                if (aliceInput[i] > bobInput[i])
                {
                    points[Alice]++;
                }
                else if(aliceInput[i] < bobInput[i])
                {
                    points[Bob]++;
                }
            }

            return points.Select(kvp => kvp.Value).ToList();
        }
    }
}
