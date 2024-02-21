// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Add number: ");
int N = int.Parse(Console.ReadLine()!);
if (N % 7 == 0 || N % 23 == 0)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}