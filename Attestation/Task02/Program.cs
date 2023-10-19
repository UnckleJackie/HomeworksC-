// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

int SumRec(int M, int N)
{
    if (M == N) return N;
    else return M + SumRec(M + 1, N);
}
System.Console.WriteLine("Данная утилитка выведет сумму натуральных чисел между двумя любыми, которые ты загадаешь, братка!");
int M = Prompt("Введи M: ");
int N = Prompt("Введи N: ");
int sumRec = SumRec(M, N);
System.Console.WriteLine($"Сумма чисел от {M} до {N} составляет {sumRec}");