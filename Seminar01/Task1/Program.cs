Console.Write("Add Num1: ");
int Num1 = int.Parse(Console.ReadLine());
Console.Write("Add Num2: ");
int Num2 = int.Parse(Console.ReadLine());
Console.Write("Add Num3: ");
int Num3 = int.Parse(Console.ReadLine());
if (Num2 > Num1)
{
    if (Num3 > Num2)
    {
        Console.Write(Num3);
    }
    else
    {
        Console.Write(Num2);
    }
}
else
{
    if (Num1 > Num3)
    {
        Console.Write(Num1);
    }
    else
    {
        Console.Write(Num3);
    }
}
