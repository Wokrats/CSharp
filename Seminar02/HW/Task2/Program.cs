// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

Console.Write("Add X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Add Y: ");
int Y = int.Parse(Console.ReadLine());
if (X == 0 || Y == 0)
{
    Console.Write("Wrong number");
}
else
{
    if (X > 0 && Y > 0)
    {
        Console.Write("I");
    }
    else
    {
        if (X < 0 && Y > 0)
        {
            Console.Write("II");
        }
        else
        {
            if (X < 0 && Y < 0)
            {
                Console.Write("III");
            }
            else
            {
                Console.Write("IV");
            }
        }
    }
}
