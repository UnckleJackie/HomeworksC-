// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string message)
{
    System.Console.Write(message); 
    string readInput = System.Console.ReadLine(); 
    int result = int.Parse(readInput); 
    return result; 
}

string ShowNumbers(int N)
{
    if (N >= 1)
    {
        return $"{N}, " + ShowNumbers(N - 1);
    }
    else return string.Empty;
}

int N = Prompt("Введите число N:");
string NTo1 = ShowNumbers(N);
System.Console.WriteLine(NTo1);
