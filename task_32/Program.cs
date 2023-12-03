// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] array = {-4, -8, 8, 2};
int[] arrayChange = ChangeSingNumbers(array);
int[] ChangeSingNumbers(int[] arr)
  {
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
        Console.Write($" {arr[i]}");
    }
    return arr;
  }

//   // Функция Дмитрия Г., где принимает массив через запятую:
// int x = 6; //Вводить ровно столько чисел, сколько указанно х
// int[] arr =Input($"Введите {x} чисeл через запятую ", x);
// PrintArrey(arr);

//   int[] Input(string abc, int lenght) // Записываем массив из строки по заданной длине
// {
// int[] numbers = new int[lenght];
// Console.Write($"{abc} ");
// string[] input = Console.ReadLine()!.Split(',');
// for (int i = 0; i < numbers.Length; ++i)
// numbers[i] = int.Parse(input[i]);

// return numbers;
// }


// void PrintArrey(int[] array)
//   {
//     for (int i = 0; i < array.Length; i++)
//     {
//       Console.Write($" {array[i]}");
//     }
//   }