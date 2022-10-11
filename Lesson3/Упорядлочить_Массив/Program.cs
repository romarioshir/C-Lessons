int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{

    int count = array.Length;

    for (int i = count - 1; i > 0 - 1; i--)
    {
        int minPosition = i;

        for (int j = i - 1; j > 0 - 1; j--)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

Console.Clear();

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);

// В обратном порядке


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{

    int count = array.Length;

    for (int i = 0; i < count - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < count; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

Console.Clear();

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);