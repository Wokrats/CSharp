// 2. На основе символов строки (тип string) сформировать массив
//    символов (тип char[]). Вывести массив на экран.

//    Метод строки ToCharArray() не использовать.

Console.Write("Введите строку: ");
string str = Console.ReadLine()!;

char[] CreareCharAr(string str)
{
    int size = str.Length;
    char[] newArr = new char[size];
    
    for (int i = 0; i < size; i++)
    {
        newArr[i] = str[i];
    }
    return newArr;   
}

char[] resultArr = CreareCharAr(str);
foreach (char e in resultArr)
{
    Console.Write($"{e} ");
}
