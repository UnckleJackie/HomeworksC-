//Задача
//Напишите программу, которая на вход принимает число и выдает, 
//является ли оно четным (делится ли оно на два без остатка)

// Запрашиваю число и конвертирую его в переменную
System.Console.WriteLine("Дядя Женя, здравствуй, Дорогой");
System.Console.WriteLine("Потестим числа на делимость сейчас");
System.Console.WriteLine("Введи целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Я помню, что остаток вычисляется как num%2 и нам необходимо сделать
// IfElse

if(num%2 == 0)
{
    System.Console.WriteLine($"{num} четное!");
}
else
{
    System.Console.WriteLine($"Число {num} нечетное!");
}

if(num%3 == 0)
{
    System.Console.WriteLine($"А еще твое число делится на 3! Ахуенно же?!");
}
else
{
    System.Console.WriteLine("На 3 не делится");
}
if(num%4 == 0)
{
    System.Console.WriteLine("На 4 делится тоже!");
}
else
{
    System.Console.WriteLine("На 4 не делится");
}
if(num%2 == 0 && num%3 == 0 && num%4 == 0);
{
    System.Console.WriteLine("Прикинь, оно и на 2 и на 3 и на 4 делится! Ниипацца!!!");
}
