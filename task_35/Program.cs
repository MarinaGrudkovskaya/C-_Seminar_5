// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int[123];
Console.Write("[");
int[] array2 =FillArray(array);
SummerNumber(array2);

int[] FillArray(int[] arr)
  {
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 200);
        Console.Write($" {arr[i]}");
    }
    return arr;
  }

void SummerNumber(int[] array)
  {
   int sum = 0;
   for (int i = 0; i < array.Length; i++)
   {
    if(array[i] > 9 && array[i] < 100)
    sum ++; 
   }
   Console.Write($" ] -> {sum}");
  }