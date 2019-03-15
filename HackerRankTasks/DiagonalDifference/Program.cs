namespace DiagonalDifference
{
    using System;
    using System.Linq;

    public class Program
    {
        // Solution passed all tests 100/100
        /// <summary>
        /// https://www.hackerrank.com/challenges/diagonal-difference/problem
        /// </summary>
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            }

            var result = DiagonalDifference(matrix);
            Console.WriteLine(result);
        }

        private static int DiagonalDifference(int[][] matrix)
        {
            var leftDiagonalSum = 0;
            var countLeftSteps = 0;

            var rightDiagonalSum = 0;
            var countRightSteps = matrix.Length - 1;

            var length = matrix.Length;

            // left side
            for (int col = 0; col < matrix.Length; col++)
            {
                var row = matrix[col];
                for (int i = 0; i < row.Length; i++)
                {                    
                    var currentNum = row[i];

                    if (i % length == countLeftSteps)
                    {
                        leftDiagonalSum += currentNum;
                        countLeftSteps++;
                        break;
                    }
                }

                // right side
                for (int i = row.Length - 1; i >= 0; i--)
                {
                    var currentNum = row[i];

                    if (i % length == countRightSteps)
                    {
                        rightDiagonalSum += currentNum;
                        countRightSteps--;
                        break;
                    }
                }
            }

            return Math.Abs(leftDiagonalSum - rightDiagonalSum);
        }
    }
}
