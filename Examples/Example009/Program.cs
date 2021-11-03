string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
string newText = text;

string Replace(char oldValue, char newValue)
{
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(newText[i] == oldValue) newText = newText.Replace(oldValue, newValue);
    }

    return newText;
}
Console.WriteLine("Origin: "+text);
Console.WriteLine(Replace('к', 'К'));
Console.WriteLine(Replace(' ', '*'));