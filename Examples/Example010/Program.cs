int minValue = new Random().Next(-90, 0);
int maxValue = new Random().Next(0, 90);

Console.WriteLine("minValue: "+minValue);
Console.WriteLine("maxValue: "+maxValue);
int[] arrayA = new int[20];

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
            Console.Write(col[position] +" ");
            position++;
    }  
}


for(int j=0; j<arrayA.Length; ++j)   // Заполнение массива случайными числами
{
    Random rnd;
    rnd=new Random();
    arrayA[j] = new Random().Next(minValue,maxValue);
} 
Console.Write("ArrayA: ");
PrintArray(arrayA);
Console.WriteLine();

int[] createArrayB() //Создание массива B на основе массива А с отбрасыванием чисел, нарушающих порядок возрастания
{
    int len = (arrayA.Length)-1;
    int index = 0;
    int index2 = 0;
    int s = 0;
    int currentElement = minValue;
    while (index <= len) 
    {
        if(arrayA[index] > currentElement)
            {
                currentElement = arrayA[index];
                s++;
            }
        index++;
    }
    int[] arrayB = new int[s];
    index = 0;
    currentElement = minValue;
    while (index <= len)
    {
        if(arrayA[index] > currentElement)
            {
                currentElement = arrayA[index];
                arrayB[index2] = currentElement;
                index2++;
            }
        index++;
    }
    return arrayB;
}

int[] arrayB = createArrayB();

Console.Write("ArrayB: ");
PrintArray(arrayB);