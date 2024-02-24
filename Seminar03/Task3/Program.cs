// 3. Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
int [] arr = new int [] {5, -6, 8, -3, 10, 5, 2};
int size = arr.Length;
int [] arr2 = new int [size/2 + size % 2];

for (int i = 0; i < size/2; i++)
{
    arr2[i] = arr[i]*arr[size-1-i];
}
if (size%2 == 1)
{
    arr2[arr2.Length-1] = arr[size/2];
}
foreach (var item in arr2)
{
  Console.Write(item + " ");
}