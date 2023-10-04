// Напишите программу, которая задаёт массив из 8 элементов и 
//выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

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

int size = Prompt("Задай размер массива: "); 
int min = Prompt("Минимальное число диапазона: ");
int max = Prompt("максимальное число диапазона: ");
int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);
System.Console.WriteLine();

// Поищем нужное нам число
int[] array = myArray;
int find = Prompt("Какое число хочешь найти, Гражданин?: ");
int index = 0;
while (index < size)
{
    if(array[index] == find)
    {
        System.Console.WriteLine($"стоит на {index} позиции");
        break;
    }
    index++;
}

void FindHonest(int[] array)
{
    int countHonest = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            System. Console.Write($"{array[i]} ");
            countHonest++;
        }
    }        
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество четных чисел составляет:{countHonest}");
}
// FindHonest(myArray);

// int[] array1 = FindHonest(myArray);
// int find1 = Prompt("Что ты теперь хочешь найти, Гражданин?: ");
// int index1 = 0;
// int size1 = array1.Length;
// while (index1 < size1)
// {
//     if(array1[index1] == find1)
//     {
//         System.Console.WriteLine($"стоит на {index1} позиции");
//         break;
//     }
//     index1++;
// }