static int FindMaxValue(int[] array)
{
    if (array == null || array.Length == 0)
    {
        throw new ArgumentException("Array is null or empty.");
    }

    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}