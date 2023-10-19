// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое
// каждого столбца: 4,6; 5,6; 3,6; 3

using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine($"{matrix[i,j]}\t");
            }
            Console.WriteLine();
        }

    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
        int[,] matrix = new int[n,m];
        k = 2;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i,j] = new Random().Next();
            }
        }
        return matrix;
    }
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
        Console.WriteLine("The averages in columns are:");
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write($"{list[i]:f2}\t");
        }

    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
        double average
        for ()
        for (int i = 0; i < list.Length; i++)
        {
            list[i] = 
        }
    return list;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}