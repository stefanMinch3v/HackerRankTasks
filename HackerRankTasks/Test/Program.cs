namespace Test
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var arr = new int[] { 1, 2, 3 };
            Do(arr);
            Console.WriteLine(string.Join(", ", arr));
        }

        private static void Do(int[] arr)
        {
            // arr = new int[1]; in order to work this line is ref keyword to send the reference.
            arr[0] = 100;
        }
    }
}
