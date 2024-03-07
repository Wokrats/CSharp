// 3. Считать строку с консоли, состоящую из латинских
//    букв в нижнем регистре. Выяснить, сколько среди
//    введённых букв гласных.

string vowelchars = "aeiou";
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
int FindNumbersVowels(string FirstString)
{
    int count = 0;
    for (int i = 0; i < FirstString.Length; i++)
    {
        if (vowelchars.Contains(FirstString[i]))
        {
            count++;
        }
    }
    return count;
}
Console.Write(FindNumbersVowels(str));