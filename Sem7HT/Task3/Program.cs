//Задайте произвольный массив. Выведете его элементы, 
//начиная с конца. 
//Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Произвольный массив
        int[] array = { 1, 2, 3, 4, 5 };

        // Вывод элементов массива, начиная с конца
        PrintArrayReverse(array, array.Length - 1);

        Console.ReadLine();
    }

    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReverse(arr, index - 1);
        }
    }
}
