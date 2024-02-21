Console.Write("Add first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Add second number: ");
int num2 = int.Parse(Console.ReadLine());
if (num1%num2 == 0)
{
    Console.Write("Yes");
}
else
{
    Console.Write(num1%num2);
}