// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = {3, 2, 9, 4, 5};
PrintArrey(array);
Console.WriteLine();
void PrintArrey(int[] array)// метод распечатывания, очень красивый
 {
  Console.Write($"[{array[0]}"); //это - чтобы убрать "," в после последнего элемента
  for (int i = 1; i < array.Length; i++)
  {
   Console.Write($", {array[i]}"); //начинаем печатать с "," и далее 2 элесент до конца
  }
  Console.Write("]");// для добавления вконце "]"
 }

int l = array.Length ;
int[] arr = new int[l/2];
int k = 0;
if (l%2==0)
{
    for (int j = 0; j < arr.Length; j++)
    {
        
        arr[j] = array[k]*array[l-1-k];
        Console.WriteLine(arr[j]); 
        k++; 
    }
}
else
{
   for (int j = 0; j < l/2; j++)
    {
        
        arr[j] = array[k]*array[l-1-k];
        Console.WriteLine(arr[j]); 
        k++; 
    }  
    Console.WriteLine(array[l/2]); 
}


