namespace SockMerchant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        // Solution passed all tests 100/100
        /// <summary>
        /// https://www.hackerrank.com/challenges/sock-merchant/problem
        /// </summary>
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var result = SockMerchant(n, arr);
            Console.WriteLine(result);
        }

        private static int SockMerchant(int n, int[] arr)
        {
            if (n != arr.Length || n < 1 || n > 100)
            {
                return 0;
            }

            var isValidArray = arr.All(e => e > 0 && e <= 100);
            if (!isValidArray)
            {
                return 0;
            }

            var dictionary = new Dictionary<int, int>();
            var pairSocks = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentEl = arr[i];

                if (!dictionary.ContainsKey(currentEl))
                {
                    dictionary.Add(currentEl, 0);
                }

                dictionary[currentEl]++;
            }

            foreach (var kvp in dictionary)
            {
                var value = kvp.Value;

                if (value > 1 && value % 2 == 1)
                {
                    var pair = (value - 1) / 2;
                    pairSocks += pair;
                }
                else if (value > 1 && value % 2 == 0)
                {
                    var pair = value / 2;
                    pairSocks += pair;
                }
            }

            return pairSocks;
        }
    }
}
