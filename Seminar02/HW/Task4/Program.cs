// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

Console.Write("Add number: ");
int N = int.Parse(Console.ReadLine()!);
string S;
S = "";
while (N > 0)
{
    S = (N % 10) + "," + S;
    N = N / 10;
}
S = S.Substring(0, S.Length - 1);
Console.Write(S);
