int max(int a, int b, int c)
{
    int result;
    if (a>b)  result = a; else result = b;
    if (result>c) {} else result=c;
    return result;
}

Console.WriteLine(max(100,80,60));