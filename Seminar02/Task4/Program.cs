Console.Write("Add number: ");
int N = int.Parse(Console.ReadLine());
if (N/100 > 0)
{
    Console.Write(N/100%10);
}
else
{
    Console.Write("No");
}
