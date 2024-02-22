// int N = 10;
int[] arr1 = {1,3,6,23,5,6,7,3,6,10};
int i = 0;
while (i<arr1.Length)
{
    if (arr1[i] % 2 == 0)
    {
        Console.Write($"{arr1[i]} ");
    }
    i ++;
}

