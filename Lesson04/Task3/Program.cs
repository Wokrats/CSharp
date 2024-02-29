// Считать с консоли строку, состоящую из латинских цифр и букв
// Сформировать новую строку, состоящую из букв исходной строки

string GetLetter(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}


Console.Write("Введите строку из цифр и латинских букв: ");
string demo_s = Console.ReadLine()!;
Console.WriteLine(GetLetter(demo_s));

