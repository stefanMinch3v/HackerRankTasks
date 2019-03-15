namespace GradingStudents
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        // Solution passed all tests 100/100
        /// <summary>
        /// https://www.hackerrank.com/challenges/grading/problem
        /// </summary>
        public static void Main()
        {
            var numOfGrades = int.Parse(Console.ReadLine());
            var listOfGrades = new List<int>();

            for (int i = 0; i < numOfGrades; i++)
            {
                var grade = int.Parse(Console.ReadLine());

                if (grade < 38)
                {
                    listOfGrades.Add(grade);
                    continue;
                }

                if (grade >= 100)
                {
                    listOfGrades.Add(grade);
                    continue;
                }

                var firstNumberToCompare = int.Parse(grade.ToString().Substring(0, 1));
                var secondNumberToCompare = int.Parse(grade.ToString().Substring(1, 1));

                if (secondNumberToCompare < 5)
                {
                    firstNumberToCompare = firstNumberToCompare * 10 + 5;
                }
                else
                {
                    firstNumberToCompare = firstNumberToCompare * 10 + 10;
                }

                var calculatedGrade = firstNumberToCompare - grade < 3 ? firstNumberToCompare : grade;

                listOfGrades.Add(calculatedGrade);
            }

            Console.WriteLine("=======");
            Console.WriteLine(string.Join(Environment.NewLine, listOfGrades));
        }
    }
}
