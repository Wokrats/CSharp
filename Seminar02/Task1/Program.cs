Console.WriteLine("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine());
int N1 = N/100*10 + N%10;
Console.Write(N1);
