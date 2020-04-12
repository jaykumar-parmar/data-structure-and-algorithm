using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 5, 6, 8, 10, 3, 4, 1 };

            Console.WriteLine("Bubble Sort");

            BubbleSort bubbleSort = new BubbleSort();
            int[] result = bubbleSort.Sort(array);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }
    }
}
