//Задача
//Напишите программу, которая на вход принимает число и выдает, 
//является ли оно четным (делится ли оно на два без остатка)

// Запрашиваю число и конвертирую его в переменную
System.Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

// Я помню, что остаток вычисляется как num%2 и нам необходимо сделать
// IfElse

if(num%2 == 0)
{
    System.Console.WriteLine($"Your number {num} is even!");
}
else
{
    System.Console.WriteLine($"Your number {num} is ODD!");
}
