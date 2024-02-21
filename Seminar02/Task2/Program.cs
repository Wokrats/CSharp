// 2. Напишите программу, которая принимает на вход трёхзначное
//    число и возводит вторую цифру этого числа в степень, равную
//    третьей цифре.
int num1 = int.Parse(Console.ReadLine()!);
int num3 = num1%10;
int num2 = num1/10%10;
Console.WriteLine(Math.Pow(num2,num3));

