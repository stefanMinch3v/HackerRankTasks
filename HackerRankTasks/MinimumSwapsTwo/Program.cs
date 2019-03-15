namespace MinimumSwapsTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        // Solution passed all tests 100/100
        /// <summary>
        /// https://www.hackerrank.com/challenges/minimum-swaps-2/problem
        /// </summary>
        public static void Main()
        {
            //var n = long.Parse(Console.ReadLine());

            //var initialCollection = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            //var desiredCollection = initialCollection.OrderBy(x => x).ToList();

            //var countSwaps = 0;

            //for (int i = 0; i < initialCollection.Count; i++)
            //{
            //    if (initialCollection[i] != desiredCollection[i])
            //    {
            //        for (int j = i + 1; j < initialCollection.Count; j++)
            //        {
            //            if (initialCollection[j] == desiredCollection[i])
            //            {
            //                SwapCollection(initialCollection, initialCollection[i], initialCollection[j]);
            //                countSwaps++;
            //                break;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(countSwaps);

            // must increase the counter only if there isnt any swap at the end otherwise always do the check with the first or zero position
            var n = int.Parse(Console.ReadLine());

            var initialCollection = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var desiredCollection = initialCollection.OrderBy(x => x).ToList();

            var biggestNumber = 0;
            var smallestNumber = 0;
            var countSwaps = 0;
            var isThereSwap = true;
            var counter = 0;
            var equalColl = false;

            while (!equalColl)
            {
                for (int i = 0; i < initialCollection.Count - 1; i++)
                {
                    if (!isThereSwap)
                    {
                        counter++;
                    }

                    var currentNumber = initialCollection[counter];

                    for (int j = counter; j < initialCollection.Count - 1; j++)
                    {
                        var secondNumber = initialCollection[j + 1];

                        if (currentNumber > secondNumber)
                        {
                            smallestNumber = secondNumber;
                            biggestNumber = currentNumber;
                        }
                    }

                    if (biggestNumber > 0 && smallestNumber > 0)
                    {
                        initialCollection = SwapCollection(initialCollection, biggestNumber, smallestNumber);
                        countSwaps++;
                        isThereSwap = true;
                        biggestNumber = 0;
                        smallestNumber = 0;
                    }
                    else
                    {
                        isThereSwap = false;
                    }

                    var result = Enumerable.SequenceEqual(initialCollection, desiredCollection);
                    if (result)
                    {
                        equalColl = true;
                        break;
                    }
                }
            }

            Console.WriteLine(countSwaps);
        }

        private static List<int> SwapCollection(List<int> list, int a, int b)
        {
            var indexA = list.IndexOf(a);
            var indexB = list.IndexOf(b);

            var temp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = temp;

            return list;
        }
    }
}
