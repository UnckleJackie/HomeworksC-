// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void ShowCube(int N)
{
    int index = 1;
    while (index <= N)
    {
        System.Console.WriteLine($"{index * index * index}");
        index++;
    }
}

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}
ShowCube(Prompt("Введите число: "));