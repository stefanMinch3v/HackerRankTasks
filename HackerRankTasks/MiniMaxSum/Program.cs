namespace MiniMaxSum
{
    using System;
    using System.Linq;

    public class Program
    {
        // Solution passed all tests 100/100
        /// <summary>
        /// https://www.hackerrank.com/challenges/mini-max-sum/problem
        /// </summary>
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            var minSum = input
                .OrderBy(n => n)
                .Take(4)
                .Sum();

            var maxSum = input
                .OrderByDescending(n => n)
                .Take(4)
                .Sum();

            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}
