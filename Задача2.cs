using System;

class Program
{
    // Метод для вычисления функции Аккермана
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        else if (m > 0 && n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));
        else
            return 0; // Обработка некорректных входных данных
    }

    static void Main()
    {
        // Задайте значения m и n
        int mValue = 2;
        int nValue = 3;

        // Вычислить Аккерманову функцию и вывести результат
        int result = Ackermann(mValue, nValue);
        Console.WriteLine($"A({mValue}, {nValue}) = {result}");
    }
}