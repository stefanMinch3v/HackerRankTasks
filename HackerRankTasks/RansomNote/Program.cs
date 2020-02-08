using System;
using System.IO;
using System.Linq;

namespace RansomNote
{
    public class Program
    {
        public static void Main()
        {
            var input = File.ReadAllText("../../../TestCase.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            //var input = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            var magazineElements = int.Parse(input[0]);
            var noteElements = int.Parse(input[1]);

            var result = CheckMagazine(magazineElements, noteElements);
            Console.WriteLine(result);
        }

        private static string CheckMagazine(int magazineElements, int noteElements)
        {
            const string Yes = "Yes";
            const string No = "No";
            const string InvalidData = "Inconsistent data";

            var magazineList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            if (magazineList.Count != magazineElements)
            {
                throw new InvalidOperationException(InvalidData);
            }

            var notesArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (notesArray.Length != noteElements)
            {
                throw new InvalidOperationException(InvalidData);
            }

            foreach (var note in notesArray)
            {
                var success = magazineList.Remove(note);

                if (!success)
                {
                    return No;
                }
            }

            return Yes;
        }
    }
}
