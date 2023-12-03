// // Задача 38: Задайте массив вещественных чисел. Найдите
// // разницу между максимальным и минимальным
// // элементов массива.
// // [3 7 22 2 78] -> 76
// int num = 5;
// int[] array1 = GetArray(num);
// DifferenceNumber(array1);

// int[] GetArray(int number)
//   {
//     int[] array = new int[number];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//         Console.Write($"{array[i]} ");
//     }
//     return array;
//   }
// void DifferenceNumber(int[] array)
// {
//   int max = array[0];
//   int min = array[0];

// for (int i = 1; i < array.Length; i++)
// {
//     if (array[i] < min)
//     {
//        min = array[i]; 
//     }
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"{max} - {min} = {max - min}");
// }
// ==============================================//
// Решение Эльвиры с "double"

Console.Clear();
double[] startArray = GetArray(5);
Console.WriteLine(String.Join("|", startArray)); // "String.Join" строка и присоединение
//в скобках сперва разделитель, потом что нужно вывести. В данном случае "|"
Console.WriteLine($"Разница = {GetDifference(startArray)}");

double[] GetArray(int size) //размер не может быть  double
  {
    double[] res = new double[size];
    for (int i = 0; i < size; i++) // счетчик так же int
    {
      res[i] = new Random().NextDouble()* 10 - 5; // (-5, 5) что бы контролировать диапазон 
      res[i] = Math.Round(res[i], 2); //округление
    }
     return res;
  }

 double GetDifference(double[] array) 
   {
    double min = array[0];
    double max = array[0];
    foreach (double el in array)
    {
      if(min > el) min = el;
      if(max < el) max = el;
    }
    return Math.Round(max - min, 2);
   }