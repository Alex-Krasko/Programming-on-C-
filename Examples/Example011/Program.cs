int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[]array)
{
    for(int i = 0; i<array.Length-1;i++)
    {
        int minPos = i;

        for(int j = i+1; j<array.Length;j++)
        {
            if(array[j] > array[minPos]) minPos = j;
        }


        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
        }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);