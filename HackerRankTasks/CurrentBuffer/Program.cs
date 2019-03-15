namespace CurrentBuffer
{
    using System;
    using System.Linq;

    public class Program
    {
        // Solution passed all tests 100/100
        /// <summary>
        /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
        /// </summary>
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var clouds = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var result = JumpingOnClouds(n, clouds);
            Console.WriteLine(result);
        }

        private static int JumpingOnClouds(int n, int[] clouds)
        {
            if (n != clouds.Length)
            {
                return 0;
            }

            var safePath = 0;
            var recordZeros = 0;
            var maxJump = 2;

            for (int i = 0; i < clouds.Length; i++)
            {
                var currentCloud = clouds[i];
                if (currentCloud == 0)
                {
                    recordZeros++;
                    if (recordZeros >= maxJump)
                    {
                        safePath++;
                        recordZeros = 0;
                    }
                }
                else
                {
                    safePath++;
                    recordZeros = 0;
                }
            }

            return safePath;
        }
    }
}
