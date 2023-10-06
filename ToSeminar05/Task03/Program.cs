// Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным
//элементов массива.
//[3 7 22 2 78] -> 76 random.next.Double

double[] CreateArray()
{
    int size = 5;
    double[] array = new double[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().Next(0, 255) + new Random().NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write( array[i] + " ");
    }
    System.Console.WriteLine();
}

double[] myArray = CreateArray();
PrintArray(myArray);

double FindMax(double[] array)
{
    double max = array[0];
    int i = 0;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    int i = 0;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double max = FindMax(myArray);
double min = FindMin(myArray);
double diff = Math.Round((max - min), 2);
System.Console.WriteLine($"Разница между максимумом {max} и минимальным {min} составляет {diff}");

// double DiffMaxMin(double[] array)
// {
//     // Сначала будем искать максимум
//     double max = array[0];
//     double min = array[0];
    
//     int i = 0;
//     for (i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//     }

//     // Теперь поищем минимум
    
//     for (i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min) min = array[i];
//     }
//     double diff = max - min;
//     return diff;
// }



// int size = Prompt("Input array size: ");
// int min = Prompt("Input min value: ");
// int max = Prompt("Input max value: ");
// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);
// double diff = DiffMaxMin(myArray);
// System.Console.WriteLine(diff);



// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
 
// namespace ConsoleApplication1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Double[] aMassiv;
//             Console.WriteLine("Введите количество элементов n=");
//             int n = Convert.ToInt32(Console.ReadLine());
//             aMassiv = new Double[n];
//             Random rnd = new Random();
            
//             for (int i = 0; i < aMassiv.Length; i++)
//                 aMassiv[i] = rnd.Next(-10, 10);
            
//             int p1 = 1;//1
//             foreach (int i in aMassiv)
//                 if (i > 0) p1 *= i;
            
//             Console.WriteLine("Произведение положительных элементов массива = " + p1);
 
//             Double min = aMassiv.Min(); //находим мин элемент
//             int p2 = 0;//2
//             foreach (int i in aMassiv)
//                 if (i != min) p2 += i;
//                 else break;
//             Console.WriteLine("Сумма элементов массива, расположенных до минимального элемента = " + p2);
//             foreach (var i in aMassiv)
//             {
//                 Console.Write(string.Format("{0:f3}\t\t", i )); 
//             }
 
//             Console.ReadKey();
//         }
//     }
// }