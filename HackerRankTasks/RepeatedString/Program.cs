namespace RepeatedString
{
    using System;
    using System.Linq;

    public class Program
    {
        // Solution passed all tests 100/100
        /// <summary>
        /// https://www.hackerrank.com/challenges/repeated-string/problem
        /// </summary>
        public static void Main()
        {
            var str = Console.ReadLine();
            var repeatStr = long.Parse(Console.ReadLine());

            var result = RepeatedString(str, repeatStr);
            Console.WriteLine(result);
        }

        private static long RepeatedString(string str, long repeatStr)
        {
            long countMainString = str.Count(ch => ch == 'a');

            long factorNumber = repeatStr / str.Length;

            long countA = factorNumber * countMainString;

            long shortSize = repeatStr % str.Length;

            for (int i = 0; i < shortSize; i++)
            {
                if (str[i] == 'a')
                {
                    countA++;
                }
            }

            return countA;
        }
    }
}
