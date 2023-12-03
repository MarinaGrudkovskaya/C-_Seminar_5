// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
int longg = Promt("Введите длину массива: ");
int minnum = Promt("Введите минимальное значение массива: ");
int maxnum = Promt("Введите максимальное значение массива: ");
int[] array = GetArray(longg, minnum, maxnum);
PrintArrey(array);
// Console.WriteLine(); убрала, т.к. добавили "/n" перед "$", "\t"  будет отступ
SummerNumbers(array); 
int Promt(string messeg)
  {
    Console.WriteLine(messeg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
  }
// int[] arrayNew = GetArray(12, -9, 9);//так можем задавать масив с помощью функции описанной ниже
int[] GetArray(int lon, int min, int max) //не все названия переменных можно обьявлять 
   {                                      //может совпадать с встроенными функциями
    int[] arr = new int[lon];
    for (int i = 0; i < arr.Length; i++)//не забывать инициализировать "i" -> "int i"
    {
        arr[i] = new Random().Next(min, max+1);
    }
    return arr;
   }

void PrintArrey(int[] arr)
   {
    Console.Write($"[{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
     Console.Write($", {arr[i]}");   
    }
    Console.Write("]");
   }
void SummerNumbers(int[] arr)
  {
   int plusSum = 0;   
   int menosSum = 0;
   for (int i = 0; i < arr.Length; i++) //не забывать инициализировать "i" -> "int i"
   {
     if (arr[i]< 0)
        menosSum = menosSum + arr[i];
     else
        plusSum = plusSum + arr[i];
   }
   Console.WriteLine($"\nСумма положительных чисел -> {plusSum}, отрицательных -> {menosSum}");
  }
         // решение по суммам с методом Эльвиры с циклом "foreach"
//в переменную "el" записывается значение массива c "0" позиции и в цикле идет по массиву
// цыкл заканчивается, когда возьмет последний элемент
//  Console.WriteLine($"\nСумма положительных чисел -> {plusSum}, отрицательных -> {menosSum}"); (\n - перенос строки)
int[] GetSum(int[] arr) // возвращает 2 элемента
{
// int positiveSum = 0;
// int negativeSum = 0;
// int[] res = new int[2];// создали доп.массив с 2-я элементами
// foreach (int el in array)
// {
//    if (el > 0) positiveSum += el;  
//    if ( el < 0 ) negativeSum +=el; // можно было сделать ветку "else"   
// }
// res[0] = positiveSum;
// res[1] = negativeSum;
// return res;
int[] res = new int[2];
foreach (int el in arr)
{
   if (el > 0) res[0] += el;  
   if ( el < 0 ) res[1] +=el; // можно было сделать ветку "else"   
}
return res;
}
int[] resSum = GetSum(array); //вызываем метод Эльвиры
// печатаем результат
Console.WriteLine($"Сумма положительных чисел -> {resSum[0]}, отрицательных -> {resSum[1]}");



