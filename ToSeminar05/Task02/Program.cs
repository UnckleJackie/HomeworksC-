// Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int request = Convert.ToInt32(readInput);
    return request;
}

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

int SumOdds(int[] array)
{
    int sumOdds = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sumOdds = sumOdds + array[i];
    }
    return sumOdds;
}

int SumEvens(int[] array)
{
    int sumEvens = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sumEvens = sumEvens + array[i];
    }
    return sumEvens;
}

int size = Prompt("Input array size: ");
int min = Prompt("Input min value: ");
int max = Prompt("Input max value: ");
int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);

int sumOdds1 = SumOdds(myArray);
System.Console.WriteLine();
System.Console.WriteLine($"Sum of odds positions is: {sumOdds1}"); // На данном этапе задача решена, дальше я развлекаюсь
int sumEvens1 = SumEvens(myArray);
System.Console.WriteLine();
System.Console.WriteLine($"Sum of evens positions is: {sumEvens1}");

int[] ArraySumsBeginAndLasts()
{
    int[] array = new int[size/2]; // объявляем массив
    for (int i = 0; i < size / 2; i++)
    {
        array[i] = myArray[i] + myArray[size - i - 1];
    }
    return array;
}

int[] myArray2 = ArraySumsBeginAndLasts();

PrintArray(myArray2);

