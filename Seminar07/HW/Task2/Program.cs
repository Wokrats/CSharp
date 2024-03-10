//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int EnterNum(string message)
{
    Console.Write(message);
    int Num = Convert.ToInt32(Console.ReadLine()!);
    return Num;
}

int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

int m = EnterNum("Enter number m: ");
int n = EnterNum("Enter number n: ");
Console.Write(AkkermanFunc(m, n));