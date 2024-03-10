//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintNaturalNumbers(int firstNum, int secondNum)
{
        if (firstNum <= secondNum)
        {
            Console.Write($"{firstNum} ");
            PrintNaturalNumbers(firstNum + 1, secondNum);
        }
    return;
}




Console.Write("Enter number M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Enter number N: ");
int n = int.Parse(Console.ReadLine()!);

PrintNaturalNumbers(m, n);