//Задача
//Напишите программу, которая на вход принимает два числа и выдает,
//какое большее, а какое меньшее

// Программа принимает на вход два числа. Прошу ввести первое и конвертирую его из записанного в переменную
using System.ComponentModel.DataAnnotations;

System.Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input second number: "); //Прошу ввести второе число и конвертирую его в переменную
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2) // если первое больше второго, то выводим на экран
{
    System.Console.WriteLine($"{num1} more than {num2}");
}
else // если второе больше первого, выводим на экран
{
    System.Console.WriteLine($"{num2} more than {num1}");
}
