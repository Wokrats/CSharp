int[] CreateNumArray(string firststring)
{
    char[] charArray = firststring.ToCharArray();
    int[] digitArray = new int[charArray.Length];
    int digitCount = 0;
    foreach (char e in charArray)
    {
        if (char.IsDigit(e))
        {
            digitArray[digitCount] = int.Parse(e.ToString());
            digitCount ++;
        }
    }
    return digitArray;
}

Console.Write("Введите строку из цифр и латинских букв: ");
string demo_str = Console.ReadLine()!;
int[] digitArray = CreateNumArray(demo_str);
foreach (int i in digitArray)
{
    Console.Write($"{i}");
}
