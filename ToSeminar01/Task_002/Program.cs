//Задача
//Напишите программу, которая принимает на вход три числа и 
//выдает максимальное из этих чисел

// Запрашиваю три числа и конвертируем их в переменные
System.Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1; //Присваиваю максимум num1, далее начинаем сравнивать

if(num2 > max) max = num2;
if(num3 > max) max = num3;

System.Console.Write($"max = {max}");

