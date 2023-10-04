//  Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.
//[345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // объявляем массив

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write( array[i] + " ");
    }
}

//System.Console.WriteLine("Input array size: ");
int size = new Random().Next(4, 15); //Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal Value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal Value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);

//Для начала заполнили массив, задали случайную длину и вывели на экран