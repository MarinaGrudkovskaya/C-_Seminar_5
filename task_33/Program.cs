// // Задача 33: Задайте массив. Напишите программу, которая
// // определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, 3] -> да

int longA = GetNumbers("Введите длинну массива: ");
int minN = GetNumbers("Введите минимальное значение массива: ");
int maxN = GetNumbers("Введите максимальное массива: ");
Console.Write("Массив - ");
int[] array = GetArray(longA, minN, maxN);
Console.WriteLine();
int number = GetNumbers("Введите число: ");
ComparNumber(array, number);

int GetNumbers(string mesege)
  {
    Console.WriteLine(mesege);
    int vale = int.Parse(Console.ReadLine()!);
    return vale;
  }
int[] GetArray(int longnum, int minnum, int maxnum)
  {
    int[] arr = new int[longnum];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minnum, maxnum+1);
        Console.Write($"{arr[i]} ");
    }
    return arr;
  }

void ComparNumber(int[] array, int num)
  {
    int res = 0;
    int index = 0;
    int n = array.Length;
    while (index < n)
    {
        if (array[index] == num)
        {
         res = 1; 
         break;
        }
        index = index + 1;// тут не нужно писать "else"
        res = -1;  
    }
    if(res == 1)
    Console.WriteLine($"Да, в массиве есть {num} ");
    else 
    Console.WriteLine($"{num} Hет в массиве");
  }

// // решение через bool-евую переменную правда/ложь(true/false) и foreach :
// bool flag = false;
// foreach (var el in array)
// {
//     if (el == number) flag = true;
// }
// if (flag) Console.Write("да");
// else Console.Write("нет");