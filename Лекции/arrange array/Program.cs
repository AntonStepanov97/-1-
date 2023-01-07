

int[] array = {1, 5, 6, 2, 3, 7, 4, 1, 4};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void arrange(int[] array)
{
    for(int i = 0; i < array.Length - 1; i ++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j; // для изменения порядка изменить знак //
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(array);
arrange(array);
PrintArray(array);