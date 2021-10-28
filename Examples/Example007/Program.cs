int [] a; // Объявление массива
a=new int[10]; // Создание массива

// Первый способ обнуления массива
int i=0;
while (i<10)
{
    a[i]=0;
    ++i;
}
// Второй способ обнуления массива
for(int j=0; j<10; ++j)
{
    a[j]=0;
}
// Ввод массива с клавиатуры
/*
for(int j=0; j<10; ++j)
{
    string s=Console.ReadLine();
    a[j]=Convert.ToInt32(s);
}
*/

// Заполнение массива случайными числами
for(int j=0; j<10; ++j)
{
    Random rnd;
    rnd=new Random();
    a[j]=rnd.Next(0,101);
}
// Вывод массива в консоль
for(i=0;i<10;++i)
{
    Console.Write(a[i]);
    Console.Write(" ");
}
Console.WriteLine("  Done!");