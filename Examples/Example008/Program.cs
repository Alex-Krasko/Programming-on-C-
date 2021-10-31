int[] arrayA = new int[20];
int[] arrayB = new int[10];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
     while (index < length)
     {
         collection[index] = new Random().Next(10, 99);
         index++; 
     }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if(col[position]>0)
        {
            Console.Write(col[position] +" ");
        }
        position++;
        
    }
}

int Avr(int [] A)
{
int len = A.Length;
int a = 0;
int b = 0;
int c = 0;
    for (int i=0; i<len;i++)
    {
        if(A[i]!=0)
        {
            b = b + A[i];
            a++;
        }
    }
    c = b/a;
    return c;
}

int[] createArrayB(int[] arrayB) //Создание массива B на основе массива А с перебором по-возрастанию
{
    int len = (arrayA.Length)-1;
    int index = 0;
    int index2 = 0;
    int currentElement = 0;
    while (index <= len)
    {
        if(arrayA[index]%2==0) {} // Четные отбрасываем по ТЗ
        else
            {
                if(arrayA[index]>Avr(arrayA)) 
                    {
                        
                    }
                else 
                    {
                        if(arrayA[index]>currentElement)
                            {
                                currentElement = arrayA[index];
                                if(arrayA[index]> Avr(arrayA)) {}
                                else 
                                    {
                                        arrayB[index2] = currentElement;
                                        index2++;
                                    }
                            }

                    }
            }
        
        
        index++;
    }
    return arrayB;
}

FillArray(arrayA); // Заполнение массива случайными числами от 10 до 99.
Console.Write("ArrayA: ");
PrintArray(arrayA); // Выведение массива A в консоль.
Console.WriteLine("Average: "+Avr(arrayA)); // Вывод в консоль среднеарифметического значения массива А.
arrayB = createArrayB(arrayB); // Заполнение массива в соответствии с ТЗ.
if(arrayB[0]==0) //Если массив начинается с 0, значит он пуст и отбрасывается.
{
    Console.Write("ArrayB: ");
    Console.WriteLine("Empty array");
}
else {
    Console.Write("ArrayB: ");
    PrintArray(arrayB); // Иначе выводим массив в консоль.
    Console.WriteLine(""); // Для удобочитаемости консоли.
    }