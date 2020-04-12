namespace sorting
{
    public class BubbleSort : ISort
    {
        public int[] Sort(int[] array)
        {
            int partition = array.Length;
            for (int i = 0; i < partition; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if ((j + 1) < array.Length)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
            return array;
        }
    }
}