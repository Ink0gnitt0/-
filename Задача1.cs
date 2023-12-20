using System;

class Program
{
    // Метод для вывода натуральных чисел в промежутке от M до N с использованием рекурсии
    static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write($"{m} ");
            PrintNaturalNumbers(m + 1, n);
        }
    }

    static void Main()
    {
        // Задайте значения M и N
        int M1 = 1, N1 = 5;
        int M2 = 4, N2 = 8;

        Console.WriteLine($"Задача 1: Натуральные числа от {M1} до {N1}:");
        PrintNaturalNumbers(M1, N1);
        Console.WriteLine();

        Console.WriteLine($"Задача 1: Натуральные числа от {M2} до {N2}:");
        PrintNaturalNumbers(M2, N2);
    }
}