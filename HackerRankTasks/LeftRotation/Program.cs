namespace LeftRotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        // Solution passed all tests 100/100
        /// <summary>
        /// https://www.hackerrank.com/challenges/array-left-rotation/problem
        /// </summary>
        public static void Main()
        {
            var input = Console.ReadLine().Split(" ");

            var rotations = int.Parse(input[1]);
            var arr = Console.ReadLine()
                .Split(" ")
                .Select(long.Parse)
                .ToArray();

            var result = RotLeft(arr, rotations);
            Console.WriteLine(string.Join(" ", result));
        }

        private static long[] RotLeft(long[] arr, int rotations)
        {
            //for (int i = 0; i < rotations; i++)
            //{
            //    long lastElement = arr[0];
            //    for (int j = 0; j < arr.Length - 1; j++)
            //    {
            //        arr[j] = arr[j + 1];
            //    }

            //    arr[arr.Length - 1] = lastElement;
            //}

            //return arr;

            var queue = new Queue<long>(arr);

            for (int i = 0; i < rotations; i++)
            {
                var element = queue.Dequeue();
                queue.Enqueue(element);
            }

            return queue.ToArray();
        }
    }
}
