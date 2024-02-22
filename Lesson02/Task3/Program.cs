// int N = 10;
int[] arr1 = {2,5,7,4,8,2,23,56,1,98};
int i = 0;
int max = arr1[i];
while (i < arr1.Length)
{
    if (max < arr1[i])
    {
        max = arr1[i];
    }
    i ++;
}
Console.WriteLine(max);

max = arr1[0];
for (int j = 0; j < arr1.Length; j ++)
{
    if (max < arr1[j])
    {
        max = arr1[j];
    }
}
Console.WriteLine(max);

max = arr1[0];
foreach (int e in arr1)
{
    if (max < e)
    {
        max = e;
    }
}
Console.WriteLine(max);