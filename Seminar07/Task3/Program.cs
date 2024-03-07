// 3. Считать строку с консоли, содержащую латинские буквы.
//    Вывести на экран согласные буквы этой строки.
//    
//    Использовать рекурсию. Не использовать цикл

string vowle = "aeyiou";

void PrintChars(string firstword, int i = 0)
{
    if (i == firstword.Length) return;
    if (vowle.Contains(firstword[i]) == false)
    {
        Console.Write(firstword[i] + " ");
    }
    PrintChars(firstword, i + 1);
}

Console.Write("Введите строку: ");
string word = Console.ReadLine()!;

PrintChars(word);

