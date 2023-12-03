// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int num = GetNumber("Введите длину массива: ");
int min = GetNumber("Введите max массива: ");
int max = GetNumber("Введите min массива: ");
int[] array1 = GetArray(num, min, max);
SumNumber(array1);

int GetNumber(string messeg)
  {
    Console.WriteLine(messeg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
  }

int[] GetArray(int size, int min, int max)
  {
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
      array[i] = new Random().Next(min, max);
      Console.Write($"{array[i]} ");
    }
    return array;
  }
void SumNumber(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(i % 2 !=0)
    count = count + array[i];
}
Console.WriteLine();
Console.WriteLine(count);
}
