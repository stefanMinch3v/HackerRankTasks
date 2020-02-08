namespace TimeConversion
{
    using System;
    using System.Globalization;

    public class Program
    {
        // Solution passed all tests 100/100
        /// <summary>
        /// https://www.hackerrank.com/challenges/time-conversion/problem
        /// </summary>
        public static void Main()
        {
            var input = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
                .ToString("HH:mm:ss");

            Console.WriteLine(input);
        }
    }
}
