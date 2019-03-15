namespace SimpleArraySum
{
    using System;
    using System.Linq;

    public class Program
    {
        // Solution passed all tests 100/100
        /// <summary>
        /// https://www.hackerrank.com/challenges/simple-array-sum/problem
        /// </summary>
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sumArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()
                .Sum();

            Console.WriteLine(sumArr);
        }
    }
}
