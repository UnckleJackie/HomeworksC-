// Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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



System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal Value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal Value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);