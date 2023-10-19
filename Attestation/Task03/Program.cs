// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

int AkkermanRec(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) 
    {
        return AkkermanRec(m - 1, 1);
    }
    else
    {
        return AkkermanRec(m - 1, AkkermanRec(m, n - 1));
    }
}
System.Console.WriteLine("Данная программа вычислит функцию Аккермана с помощью Рекурсии!");
int m = Prompt("Введи m: ");
int n = Prompt("Введи n: ");
int akkermanRec = AkkermanRec(m, n);
System.Console.WriteLine($"Функция Аккермана при {m} и {n} равна {akkermanRec}");