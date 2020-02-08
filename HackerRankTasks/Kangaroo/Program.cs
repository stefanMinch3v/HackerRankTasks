namespace Kangaroo
{
    using System;
    using System.Linq;

    // Solution passed all tests 100/100
    /// <summary>
    /// https://www.hackerrank.com/challenges/kangaroo/problem
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (input.Length != 4)
            {
                return;
            }

            var kangarooFirstStarts = input[0];
            var kangarooFirstJumps = input[1];

            var kangarooSecondStarts = input[2];
            var kangarooSecondJumps = input[3];

            if (kangarooFirstStarts < 0 ||
                kangarooSecondStarts < kangarooFirstStarts ||
                kangarooSecondStarts > 10000 ||
                kangarooFirstJumps < 1 ||
                kangarooFirstJumps > 10000 ||
                kangarooSecondJumps < 1 ||
                kangarooSecondJumps > 10000)
            {
                Console.WriteLine("NO");
            }

            if ((kangarooFirstStarts > kangarooSecondStarts &&
                kangarooFirstJumps > kangarooSecondJumps) ||
                (kangarooSecondStarts > kangarooFirstStarts &&
                kangarooSecondJumps > kangarooFirstJumps))
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < 10000; i++)
            {
                kangarooFirstStarts += kangarooFirstJumps;
                kangarooSecondStarts += kangarooSecondJumps;

                if (kangarooFirstStarts == kangarooSecondStarts)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }

            Console.WriteLine("NO");
        }
    }
}
