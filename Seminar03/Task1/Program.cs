// 1. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве. Программа
//    должна выдать ответ: Да/Нет.
int[] arr = { 1, 3, 4, 8 };
Console.Write("Add N: ");
int N = int.Parse(Console.ReadLine()!);
string answer = "No";
for (int i = 0; i < arr.Length; i++)
{
    if (N == arr[i])
        answer = "Yes";
}
Console.Write(answer);