// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] ->  2
int number1 = GetNumber("Задайте длинну массива: ");
int[] array1 = GetArray(number1);
SortNumber(array1);

int GetNumber(string messeg)
  {
    Console.WriteLine(messeg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
  }

int[] GetArray(int size)
  {
    int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
  }
  return array;
  }

void SortNumber(int[] array)
  {
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        count++;
    }
    Console.Write($" - > {count}");
  }
