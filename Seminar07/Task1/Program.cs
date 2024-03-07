// 1. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int FindSumNumbers(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return FindSumNumbers(n / 10) + n % 10;
}
Console.Write(FindSumNumbers(n));
