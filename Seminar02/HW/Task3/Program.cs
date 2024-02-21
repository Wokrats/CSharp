// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Console.Write("Add number: ");
int N = int.Parse(Console.ReadLine()!);
if (N >= 10 && N < 100)
{
    if (N / 10 > N % 10)
    {
        Console.Write(N / 10);
    }
    else
    {
        Console.Write(N % 10);
    }
}
else
{
    Console.Write("Add number [10, 99]");
}

