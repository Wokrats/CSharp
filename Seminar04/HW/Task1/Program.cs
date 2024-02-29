//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

//int AddNum(int num)
//{
//    Console.Write("Введите целое число: ");
//    num = int.Parse(Console.ReadLine()!);
//    return num;
//}

int SumDig(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += (num % 10);
        num /= 10;
    }
    return sum;
}
bool CheckNum(int num)
{
    int sum = SumDig(num);
    if (sum % 2 == 0)
    {
        return true;
    }
    else
    {
        if (num == 'q')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

int num = 0;
bool log = false;
while (log == false)
{
   if (CheckNum(num) == false)
   {
    Console.Write("Введите целое число: ");
    num = int.Parse(Console.ReadLine()!);
    log = false;
   }
   else 
   {
    log = true;
   }
}


//Console.Write(SumDig(num));

