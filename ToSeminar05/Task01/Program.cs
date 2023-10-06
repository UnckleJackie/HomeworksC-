//  Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.
//[345, 897, 568, 234] -> 2

// Запрашиваем данные. Конвертируем их
int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int request = Convert.ToInt32(readInput);
    return request;
}
// Создание массива
int[] CreateArray(int size, int minValue, int maxValue)
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
    System.Console.WriteLine();
}
// Метод, показывающий количество четных чисел в массиве
int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if  (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// Метод, показывающий количество нечетных чисел в массиве
int CountOddNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            count++;
        }
    }
    return count;
}

int size = Prompt("Задай размер массива: "); 
int min = Prompt("Минимальное число диапазона: ");
int max = Prompt("максимальное число диапазона: ");
int[] myArray1 = CreateArray(size, min, max);
System.Console.WriteLine("Печатаю массив чисел: ");
PrintArray(myArray1);
int countEven1 = CountEvenNumbers(myArray1);
System.Console.WriteLine($"Количество четных чисел в массиве 1 составляет: {countEven1}");
System.Console.WriteLine("На этом этапе задача РЕШЕНА");

System.Console.ReadKey();
System.Console.WriteLine();
System.Console.WriteLine("А нечетных?");
System.Console.ReadKey();
int countOdd1 = CountOddNumbers(myArray1);
System.Console.WriteLine($"Количество нечетных чисел в массиве 1 составляет: {countOdd1}");

System.Console.WriteLine();
System.Console.WriteLine("Следующим шагом я распечатаю тебе еще один массив после того, как ты нажмешь любую клавишу");
int[] myArray2 = CreateArray(size, min, max); // Создали второй массив размерностями первого
PrintArray(myArray2);  // Распечатали второй массив
System.Console.WriteLine();
int countEven2 = CountEvenNumbers(myArray2);
System.Console.WriteLine($"Количество четных чисел в массиве 2 составляет: {countEven2}");

int countOdd2 = CountOddNumbers(myArray2);
System.Console.WriteLine($"Количество нечетных чисел в массиве 2 составляет: {countOdd2}");
System.Console.WriteLine();
int[] CreateArrayFrom12() // Создал третий массив, в котором числа зависят от первых двух массивов
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = myArray1[i] + myArray2[i];
    }
    return array;
}
int[] myArray3 = CreateArrayFrom12();
PrintArray(myArray3);

int[] CreateOddArray()
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (myArray1[i] % 2 != 0 && myArray1[i] != 0) 
            array[i] = myArray1[i];
        if (array[i] == 0) i++;
    }
    
    return array;
}

System.Console.WriteLine($"----------------------------");
int[] myArray4 = CreateOddArray();
System.Console.WriteLine();
PrintArray(myArray4);
System.Console.WriteLine();



// int[] createArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write( array[i] + " ");
//     }
// }

// int CountInRange(int[] array) // мы передаем в скобках мин, макс диапазона и САМ МАССИВ для обработки! int minRange, int maxRange, 
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if  (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int size = Prompt("Size of array: ");
// int minValue = Prompt("min value: ");
// int maxValue = Prompt("max value: ");
// //int minRange = Prompt("minimal number of range: ");
// //int maxRange = Prompt("maximum number of range: ");

// int[] myArray = createArray(size, minValue, maxValue);
// PrintArray(myArray);
// System.Console.WriteLine();
// System.Console.Write($"Количество четных чисел составляет: ");
// System.Console.WriteLine(CountInRange(myArray));

// int[] myArray2 = createArray(CountInRange(myArray));
// PrintArray(myArray2);