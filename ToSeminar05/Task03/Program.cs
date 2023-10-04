// Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным
//элементов массива.
//[3 7 22 2 78] -> 76 random.next.Double

double x = new Random().Next(0, 256);
System.Console.WriteLine(x);
double y = Math.Round(new Random().NextDouble(), 2);
System.Console.WriteLine(y);
double z = (new Random().Next(0, 256) +Math.Round(new Random().NextDouble(), 2));
System.Console.WriteLine(z);

void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = (new Random().Next(0, 256) +Math.Round(new Random().NextDouble(), 2));
System.Console.WriteLine(z); //наполняем массив случайными числами
        index++;
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write( array[i] + " ");
    }
}

double[] array = new double[10];
PrintArray(array);



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