//Задайте массив символов (тип char []). Создайте строку из
//символов этого массива. 
// Конструктор строки вида string(char []) не использовать.
char[] chArray = new [] {'2', 'a', '7', 'b', '9', 'c'};

string CreateString(char[] array)
{
    string str = "";
    for (int i = 0; i < array.Length; i++)
    {
        str += array[i];
    }
    return str;
}
Console.Write(CreateString(chArray));
