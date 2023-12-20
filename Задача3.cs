using System;

class Program
{
    // Метод для вывода элементов массива, начиная с конца, с использованием рекурсии
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write($"{arr[index]} ");
            PrintArrayReverse(arr, index - 1);
        }
    }

    static void Main()
    {
        // Произвольный массив
        int[] myArray = { 1, 2, 5, 0, 10, 34 };

        // Вывести элементы массива, начиная с конца
        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReverse(myArray, myArray.Length - 1);
    }
}