using System;

class Program
{
    static void Main()
    {
        // Объявление массивов
        int[] A = new int[5];
        double[,] B = new double[3, 4];

        // Заполнение массива A числами, введенными пользователем
        Console.WriteLine("Введите 5 чисел для массива A:");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = ");
            A[i] = int.Parse(Console.ReadLine());
        }

        // Заполнение массива B случайными числами
        Random rand = new Random();
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                B[i, j] = rand.NextDouble() * 100; // случайное число от 0 до 100
            }
        }

        // Вывод массива A
        Console.WriteLine("Массив A:");
        foreach (int num in A)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Вывод массива B
        Console.WriteLine("Массив B:");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write(B[i, j].ToString("F2") + " ");
            }
            Console.WriteLine();
        }

        // Поиск общего максимального и минимального элементов,
        // общей суммы всех элементов, общего произведения всех элементов,
        // суммы четных элементов массива A, суммы нечетных столбцов массива B.
        double maxElement = double.MinValue;
        double minElement = double.MaxValue;
        double sumAllElements = 0;
        double productAllElements = 1;
        int sumEvenElementsA = 0;
        double sumOddColumnsB = 0;

        foreach (int num in A)
        {
            if (num > maxElement) maxElement = num;
            if (num < minElement) minElement = num;
            sumAllElements += num;
            productAllElements *= num;
            if (num % 2 == 0) sumEvenElementsA += num;
        }

        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > maxElement) maxElement = B[i, j];
                if (B[i, j] < minElement) minElement = B[i, j];
                sumAllElements += B[i, j];
                productAllElements *= B[i, j];
                if (j % 2 != 0) sumOddColumnsB += B[i, j];
            }
        }

        Console.WriteLine($"Общий максимальный элемент: {maxElement}");
        Console.WriteLine($"Общий минимальный элемент: {minElement}");
        Console.WriteLine($"Общая сумма всех элементов: {sumAllElements}");
        Console.WriteLine($"Общее произведение всех элементов: {productAllElements}");
        Console.WriteLine($"Сумма четных элементов массива A: {sumEvenElementsA}");
        Console.WriteLine($"Сумма элементов нечетных столбцов массива B: {sumOddColumnsB}");
    }
}