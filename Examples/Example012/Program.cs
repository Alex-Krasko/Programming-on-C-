int[] array = new int[8];
for (int i=0;i<8;i++)
{
    array[i] = new Random().Next(0,100);
    Console.Write(array[i]+" ");
}
Console.WriteLine();